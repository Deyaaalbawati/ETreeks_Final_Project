using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Core.Repository
{
  public  interface ITestmonialRepository
    {
        string createTestmonial(Testmonial testmonial);
        string deleteTestmonial(int id);
        string updateTestmonial(Testmonial testmonial);
        List<Testmonial> getTestmonial();

    }
}
