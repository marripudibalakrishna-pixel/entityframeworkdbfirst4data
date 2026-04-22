using entityframeworkdbfirst4data.DTOs;
using entityframeworkdbfirst4data.Interfaces;
using entityframeworkdbfirst4data.Repository;
using entityframeworkdbfirst4data.HotelManagement_Dbconnect;

namespace entityframeworkdbfirst4data.Services
{
    public class Employeeservice : IEmployeeservice
    {
        private readonly Iemployeerepository _employeerepository;
        public Employeeservice(Employeerepository employeerepository)
        {
            _employeerepository = employeerepository;
        }
        public async Task<int> addemployee(EmployeeDto empdto)
        {
            Employee emp = new Employee();
            
                emp.Empid= empdto.Empid;
                emp.Empname = empdto.Empname;
                emp.Empsalary = empdto.Empsalary;
               var res= await _employeerepository.addemployee(emp);
                return res;
            

        }

        public async Task<bool> deletemployee(int id)
        {
            var res =await _employeerepository.deletemployee(id);
            return res;
        }

        public async Task<List<EmployeeDto>> GetAllemployees()
        {
            List<EmployeeDto> employees = new List<EmployeeDto>();

            var res =await _employeerepository.GetAllemployees();
            foreach( Employee item in res) {
                EmployeeDto empdto = new EmployeeDto();
                empdto.Empid = item.Empid;
                empdto.Empname = item.Empname;
                empdto.Empsalary = item.Empsalary;
                employees.Add(empdto);// adding the empdto to the list of employees
            }
            return employees;
        }

        public async Task<EmployeeDto> GetEmployee(int id)
        {
           var res= await _employeerepository.GetEmployee(id);
             EmployeeDto empdto = new EmployeeDto();
            empdto.Empid = res.Empid;
            empdto.Empname = res.Empname;
            empdto.Empsalary = res.Empsalary;
            return empdto;
        }

        public Task<bool> Updateemployee(EmployeeDto emp)
        {
            Employee emp1 = new Employee();
            emp1.Empid = emp.Empid;
            emp1.Empname = emp.Empname;
            emp1.Empsalary = emp.Empsalary;
            var res= _employeerepository.Updateemployee(emp1);
            return res;
        }
    }
}
