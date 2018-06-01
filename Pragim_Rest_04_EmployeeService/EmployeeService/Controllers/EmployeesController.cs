using EmployeeDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeService.Controllers
{
  public class EmployeesController : ApiController
  {
    public IEnumerable<Employees> Get()
    {
      using (Entities entities = new Entities())
      {
        return entities.Employees.ToList();
      }
    }

    public Employees Get(int id)
    {
      using (Entities entities = new Entities())
      {
        return entities.Employees.FirstOrDefault(e => e.ID == id);
      }
    }
  }
}
