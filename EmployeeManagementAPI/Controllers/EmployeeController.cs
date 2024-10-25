using EmployeeManagementAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class EmployeeController : ControllerBase
  {
    private readonly List<Employee> employees;
    private readonly List<Department> departments;
    public EmployeeController()
    {
      employees = new List<Employee>()
    {
        new Employee{ id = 234, name = "sravan kumar",
                      dept_id = 1},
        new Employee{ id = 244, name = "Monika",
                      dept_id = 2},
        new Employee{ id = 734, name = "harsha",
                      dept_id = 1},
        new Employee{ id = 533, name = "komal",
                      dept_id = 4},
    };

      departments = new List<Department>()
    {
        new Department{ dept_id = 1, dept_name = "CSE" },
        new Department{ dept_id = 2, dept_name = "CSE" },
        new Department{ dept_id = 3, dept_name = "IT " },
    };
    }

    [HttpGet]
    [Route("employees")]
    public IActionResult GetEmployees()
    {
      return Ok(employees);
    }


    [HttpGet]
    [Route("departments")]
    public IActionResult GetDepartments()
    {
      return Ok(departments);
    }
  }
}
