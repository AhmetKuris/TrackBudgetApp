using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using DevFramework.Core.Aspects.Postsharp.ValidationAspects;
using TrackBudgetApp.Business.Abstract;
using TrackBudgetApp.Business.Properties;
using TrackBudgetApp.Business.ValidationRules.FluentValidation;
using TrackBudgetApp.Entities.Concrete;
using TrackBudgetApp.DataAccess.Abstract;
namespace TrackBudgetApp.Business.Concrete
{
    public class UserManager:IUserService
    {
        #region Fields

        private IUserDal _userDal;
        private ITransactionDal _transactionDal;
        private string _loggedInUserEmail;
        private int _loggedInUserId;

        #endregion
        
        public UserManager(IUserDal userDal, ITransactionDal transactionDal)
        {
            _userDal = userDal;
            _transactionDal = transactionDal;
            _loggedInUserEmail = Settings.Default.LoggedInUserEmail;

            _loggedInUserId = GenerateUserIdFromEmail();
        }


        #region Essentials CRUD

        // Essential Trio. Add, Delete, Update --- Private olabilirler.
        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }

        #endregion


        #region GETS

        public List<User> GetAllUsers()
        {
            return _userDal.GetList().Select(p => new User
            {
                Id = p.Id,
                FirstName = p.FirstName,
                LastName = p.LastName,
                Email = p.Email,
                UserNo = p.UserNo
                
            }).ToList();
        }

        public User GetUserByEmail(string email)
        {
            return _userDal.Get(u => u.Email == email);
            
        }

        public List<Transaction> GetAllTransactionsByUserId(int userId)
        {
            return _transactionDal.GetList(t=>t.UserId==userId).Select(t => new Transaction
            {
                Id = t.Id,
                UserId = t.UserId,
                CategoryId = t.CategoryId,
                TypeId = t.TypeId,
                Name = t.Name,
                Amount = t.Amount,
                IssuedTime = t.IssuedTime,
                EffectiveTime = t.EffectiveTime,
                RepetitionAfterXDay = t.RepetitionAfterXDay,
                Description = t.Description

            }).ToList();
        }

        #endregion


        #region Authentication Section
        ///Authentication Seciton
        [FluentValidationAspect(typeof(UserValidator))]
        public string Login(User user)
        {
            User dbQueryUser = _userDal.Get(u => u.Email == user.Email);

            if (dbQueryUser != null)
            {
                if (dbQueryUser.Password == user.Password)
                {
                    //IN the future make this part a unique timed id which expires over time
                    //Just like in the cookie authentication implementation
                    Settings.Default["LoggedInUserEmail"] = dbQueryUser.Email;
                    Settings.Default.Save();

                    return "True";
                }
                else
                {
                    return "FalsePassword";
                }
            }
            else
            {
                return "FalseUser";
            }
        }
        [FluentValidationAspect(typeof(UserValidator))]
        public string SignUp(User user)
        {
            User dboQueryUser = _userDal.Get(u => u.Email == user.Email);

            if (dboQueryUser is null)
            {
                User newUser = new User();
                newUser.FirstName = user.FirstName;
                newUser.LastName = user.LastName;
                newUser.Email = user.Email;
                newUser.Password = user.Password;
                newUser.UserNo = UserNoGenerator();
                Add(newUser);
                return "Added";
            }
            else
            {
                return "AlreadyExists";
            }
        }
        #endregion


        #region UI END-POINTS

        //UI END-POINTS
        public void SubmitTransaction(Transaction transaction)
        {
            _transactionDal.Add(new Transaction
            {
                UserId = _loggedInUserId,
                CategoryId = transaction.CategoryId,
                TypeId = transaction.TypeId,
                Name = transaction.Name,
                Amount = transaction.Amount,
                IssuedTime = transaction.IssuedTime,
                EffectiveTime = transaction.EffectiveTime,
                RepetitionAfterXDay = transaction.RepetitionAfterXDay,
                Description = transaction.Description
            });

        }
        public string CurrentBudgetShowByTime(DateTime dateTime)
        {
         return CalculateBudgetDependingOnTimeAndUser(dateTime,_loggedInUserEmail).ToString();
        }

        #endregion


        #region Budget Calculation

        //Budget Calculation
        private decimal CalculateBudgetDependingOnTimeAndUser(DateTime dateTime, string userEmail)
        {
            User user = _userDal.Get(u => u.Email == userEmail);
            List<Transaction> userTransactionsList = GetAllTransactionsByUserId(user.Id);

            List<Transaction> afterEffectiveTime = new List<Transaction>();

            decimal resultBudget = new decimal();

            foreach (var transaction in userTransactionsList)
            {
                if (dateTime.ToUniversalTime() > transaction.EffectiveTime.ToUniversalTime())
                {
                    afterEffectiveTime.Add(transaction);
                }
            }

            foreach (var transaction in afterEffectiveTime)
            {

                switch (transaction.TypeId)
                {
                    case 1:
                        resultBudget = resultBudget + transaction.Amount;
                        break;
                    case 2:
                        resultBudget = resultBudget - transaction.Amount;
                        break;
                    case 3:
                        resultBudget = resultBudget - transaction.Amount;
                        break;
                    case 4:
                        resultBudget = resultBudget + transaction.Amount;
                        break;
                }
            }

            return resultBudget;

        }
        #endregion


        #region Private Parts

        //Private Parts

        //Geçiçi Çözüm - sonradan kişiye özel bir mantık belirle.
        private string UserNoGenerator()
        {
            Random randomNumber=new Random();
            for (int i = 0; i < int.MaxValue; i++)
            {
               string randomUserNo= LongRandom(10000000000, 99999999999, randomNumber);
               User tempUser = _userDal.Get(u => u.UserNo ==randomUserNo);

               if (tempUser is null)
               {
                   return randomUserNo;
               }
            }
            Exception exception=new SystemException();
            throw exception ;
            return "Erorr";
        }

        private string LongRandom(long min, long max, Random rand)
        {
            byte[] buf = new byte[8];
            rand.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);

            return (Math.Abs(longRand % (max - min)) + min).ToString();
        }


        private void ClearLoggedInUserEmail()
        {
            Settings.Default.LoggedInUserEmail = "";
        }
        private int GenerateUserIdFromEmail()
        {
             User user= _userDal.Get(u => u.Email == _loggedInUserEmail);

             return user.Id;
        }
       
        #endregion
        
    }
}