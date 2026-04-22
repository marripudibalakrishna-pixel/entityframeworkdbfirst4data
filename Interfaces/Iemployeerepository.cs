using entityframeworkdbfirst4data.HotelManagement_Dbconnect;

namespace entityframeworkdbfirst4data.Interfaces
{
    public interface Iemployeerepository
    {
        public Task<int> addemployee(Employee emp);
        public Task<Employee> GetEmployee(int id);
        public Task<List<Employee>> GetAllemployees();

        public Task<bool> deletemployee(int id);
            public Task<bool> Updateemployee(Employee emp);
  }
}
