using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ManagerEmployee.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManagerEmployee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : Controller
    {

        /// <summary>
        /// Initialization List Employees, Departments, Positions, EmpDeps
        /// </summary>

        List<Employee> Employees = new List<Employee>();
        List<Department> Departments = new List<Department>();
        List<Position> Positions = new List<Position>();
        List<EmpDep> EmpDeps = new List<EmpDep>();
        List<UserLogin> UserLogins = new List<UserLogin>();

        /// <summary>
        /// Contructor
        /// Initialization Managercontext
        /// Get data table Employees, Departments, Positions, EmpDeps
        /// </summary>
        public ManagerController()
        {
            ManagerEmployeeContext managercontext = new ManagerEmployeeContext();
            //Employees = managercontext.Employee.ToList();
            //Departments = managercontext.Department.ToList();
            //Positions = managercontext.Position.ToList();
            //EmpDeps = managercontext.EmpDep.ToList();
            UserLogins = managercontext.UserLogin.ToList();
        }

        /// <summary>
        /// api/Manager/GetAllUserLogin
        /// Get all data table UserLogins
        /// </summary>

        [HttpGet]
        [Route("GetAllUserLogin")]
        public async Task<List<UserLogin>> GetAllUserLogin()
        {
            return await Task.FromResult(UserLogins);
        }

        /// <summary>
        /// api/Manager/GetAllEmployee
        /// Get all information Employeee
        /// </summary>


        [HttpGet]
        [Route("GetAllEmployee")]
        public async Task<List<Employee>> GetAllEmployee()
        {
            return await Task.FromResult(Employees);
        }
        /// <summary>
        /// api/Manager/GetAllDepartment
        /// Get all information Department
        /// </summary>

        [HttpGet]
        [Route("GetAllDepartment")]
        public async Task<List<Department>> GetAllDepartment()
        {
            return await Task.FromResult(Departments);
        }

        /// <summary>
        /// api/Manager/GetAllPosition
        /// Get all information Position
        /// </summary>
        [HttpGet]
        [Route("GetAllPosition")]
        public async Task<List<Position>> GetAllPosition()
        {
            return await Task.FromResult(Positions);
        }


        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
