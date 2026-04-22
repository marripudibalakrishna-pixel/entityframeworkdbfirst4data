using entityframeworkdbfirst4data.HotelManagement_Dbconnect;
using entityframeworkdbfirst4data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace entityframeworkdbfirst4data.Repository
{
    public class Employeerepository : Iemployeerepository
    {
        private readonly HotelmanagementContext _HotelmanagementContext;
        public  Employeerepository(HotelmanagementContext HotelmanagementContext)
        {
            _HotelmanagementContext = HotelmanagementContext;
        }
        public async Task<int> addemployee(Employee emp)
        {
            await _HotelmanagementContext.Employees.AddAsync(emp);
             _HotelmanagementContext.SaveChangesAsync();
            return 1;
        }

        public async  Task<bool> deletemployee(int id)
        {
          var res=  await _HotelmanagementContext.Employees.Where(x => x.Empid == id).FirstOrDefaultAsync();
         if (res != null)
            {
                _HotelmanagementContext.Employees.Remove(res);
                 _HotelmanagementContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<Employee>> GetAllemployees()
        {
           var res = await _HotelmanagementContext.Employees.ToListAsync();
            if (res.Count==0)
            {
                return res;
            }
            else 
                return null;
        }

        public async Task<Employee> GetEmployee(int id)
        {
            var res =await _HotelmanagementContext.Employees.Where(x => x.Empid == id).FirstOrDefaultAsync();
        if (res != null)
            {
                return res;
            }
            return null;
        }

        public async Task<bool> Updateemployee(Employee emp)
        {
            _HotelmanagementContext.Employees.Update(emp);
            return true;


        }
    }
}
