using System;
using System.Collections.Generic;
using TrackBudgetApp.Entities.Concrete;

namespace TrackBudgetApp.Business.Abstract
{
    public interface IUserService
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);
        List<User> GetAllUsers();

        string Login(User user);
        string SignUp(User user);
        List<Transaction> GetAllTransactionsByUserId(int userId);

        string CurrentBudgetShowByTime(DateTime dateTime);

        void SubmitTransaction(Transaction transaction);
    }
}