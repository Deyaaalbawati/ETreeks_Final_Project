﻿using ETreeks.Core.Repository;
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

        public string updateAccount(Account account)
        {
            return _accountRepository.updateAccount(account);
        }
    }
}