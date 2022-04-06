using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Core.Repository
{
  public interface IAccountRepository
    {
        string createAccount(Account account);
        string deleteAccount(int id);
        string updateAccount(Account account);
        List<Account> getAccount();
        //List<Account> searchTeacher(string TeacherName);
        List<Account> getTeacher();
        List<Account> searchTeacher(Account account);
        List<Account> getStudent();

        List<Account> getAccountId(string Email);

        List<Account> getTeacherById(int TeacherId);




        int getNumberStudent();
        int getNumberTeacher();


    }
}
