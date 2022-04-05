using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Core.Service
{
  public  interface IAccountService 
    {
        string createAccount(Account account);
        string deleteAccount(int id);
        string updateAccount(Account account);
        List<Account> getAccount();
        List<Account> searchTeacher(string TeacherName);
        List<Account> getTeacher();
        List<Account> getStudent();
        List<Account> getAccountId(string Email);

    }
}
