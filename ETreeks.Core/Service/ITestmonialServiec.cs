using ETreeks.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Core.Service
{
   public interface ITestmonialService
    {
        string createTestmonial(Testmonial testmonial);
        string deleteTestmonial(int id);
        string updateTestmonial(Testmonial testmonial);
        List<Testmonial> getTestmonial();
        public List<TestmonialAccount> getTestmonialAccount();

    }
}
