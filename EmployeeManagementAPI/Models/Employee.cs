namespace EmployeeManagementAPI.Models
{
  // Variables for Employee list 
  public class Employee
  {
    public int id { get; set; }
    public string name { get; set; }
    public int dept_id { get; set; }
    public int add_id { get; set; }
  }

  // Variables for Department list 
  public class Department
  {
    public int dept_id { get; set; }
    public string dept_name { get; set; }
  }
}
