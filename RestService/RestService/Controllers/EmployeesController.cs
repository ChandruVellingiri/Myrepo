using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EntityDatabaseModel1;

namespace RestService.Controllers
{
    public class EmployeesController : ApiController
    {

        //HTTP Functions
        //CRUD Operations - GET(Retreive), PUT(Update), POST(Create), DELETE(Delete)

        //GET
        public IEnumerable<Employee> Get()
        {
            using (tempdbEntities1 entities = new tempdbEntities1())
            {
                return entities.Employees.ToList();
            }

        }

        //GET/{Parameter}
        public Employee Get(int id)
        {
            using (tempdbEntities1 entities = new tempdbEntities1())
            {
                return entities.Employees.FirstOrDefault(e => e.Id == id);
            }

        }

        //public Department Get(int id)
        //{
        //    using (tempdbEntities entities = new tempdbEntities())
        //    {
        //        return entities.Departments.FirstOrDefault(e => e.Id == id);
        //    }
        //}
    }
}
