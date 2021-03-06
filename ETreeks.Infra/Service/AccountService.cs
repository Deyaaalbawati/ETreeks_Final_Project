using ETreeks.Core.DTO;
using ETreeks.Core.Repository;
using ETreeks.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Infra.Service
{
    public class AccountService : IAccountService
    {

        private readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository iaccountRepository)
        {
            _accountRepository = iaccountRepository;
        }

        public string addLocation(AddLocation addLocation)
        {
            return _accountRepository.addLocation(addLocation);
        }

        public string createAccount(Account account)
        {
          return _accountRepository.createAccount(account);
        }

        public string deleteAccount(int id)
        {
            return _accountRepository.deleteAccount(id);
        }

        public List<Account> getAccount()
        {
            return _accountRepository.getAccount();
        }

        public List<Account> getAccountId(string Email)
        {
            return _accountRepository.getAccountId(Email);
        }

        public int getNumberStudent()
        {
            return _accountRepository.getNumberStudent();
        }

        public int getNumberTeacher()
        {
            return _accountRepository.getNumberTeacher();
        }

        public List<Account> getStudent()
        {
            return _accountRepository.getStudent();
        }

        public List<Account> getTeacher()
        {
            return _accountRepository.getTeacher();
        }

        public List<Account> searchTeacher(string TeacherName)
        {
            return _accountRepository.searchTeacher(TeacherName);
        }

        public string updateAccount(Account account)
        {
            return _accountRepository.updateAccount(account);
        }

        List<Account> IAccountService.getTeacherById(int TeacherId)
        {
            return _accountRepository.getTeacherById(TeacherId);

        }
    }
}
