using entityframeworkdbfirst4data.DTOs;

namespace entityframeworkdbfirst4data.Interfaces
{
    public interface IEmployeeservice
    {
        public Task<int> addemployee(EmployeeDto emp);
        public Task<EmployeeDto> GetEmployee(int id);
        public Task<List<EmployeeDto>> GetAllemployees();

        public Task<bool> deletemployee(int id);
        public Task<bool> Updateemployee(EmployeeDto emp);
    }
}
