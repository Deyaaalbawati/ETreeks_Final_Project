using ETreeks.Core.DTO;
using ETreeks.Core.Repository;
using ETreeks.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Infra.Service
{
    public class TestmonialService : ITestmonialService
    {

        private readonly ITestmonialRepository _testmonialRepository;
        public TestmonialService(ITestmonialRepository itestmonialRepository)
        {
            _testmonialRepository = itestmonialRepository;
        }

        public string createTestmonial(Testmonial testmonial)
        {
            return _testmonialRepository.createTestmonial(testmonial);
        }

        public string deleteTestmonial(int id)
        {
            return _testmonialRepository.deleteTestmonial(id);
        }

        public List<Testmonial> getTestmonial()
        {
            return _testmonialRepository.getTestmonial();
        }

        public List<TestmonialAccount> getTestmonialAccount()
        {
            return _testmonialRepository.getTestmonialAccount();
        }

        public string updateTestmonial(Testmonial testmonial)
        {
            return _testmonialRepository.updateTestmonial(testmonial);
        }
    }
}
