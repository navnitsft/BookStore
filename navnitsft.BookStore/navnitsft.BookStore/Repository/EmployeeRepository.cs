using navnitsft.BookStore.Models;

namespace navnitsft.BookStore.Repository
{
    public class EmployeeRepository
    {
        public List<EmployeeModel> GetAllEmployee()
        {
            return DataSource();
        }
        public List<EmployeeModel> GetEmployeeById(int id)
        {
            return DataSource().Where(x => x.EmpId == id).ToList();
        }
        public List<EmployeeModel> SearchEmployee(string name, string email)
        {
            return DataSource().Where(x => x.EmpName == name && x.EmpEmail==email ).ToList();
        }

        public List<EmployeeModel> DataSource() 
        {
            return new List<EmployeeModel>()
            {
                new EmployeeModel() {EmpId=1, EmpName="Sita", EmpEmail="sita@gmail.com", EmpPhone="8147988001"},
                new EmployeeModel() {EmpId=2, EmpName="Gita", EmpEmail="gita@gmail.com", EmpPhone="8147988001"},
                new EmployeeModel() {EmpId=3, EmpName="Rahul", EmpEmail="rahul@gmail.com", EmpPhone="8147988001"},
                new EmployeeModel() {EmpId=4, EmpName="Sunny", EmpEmail="sunny@gmail.com", EmpPhone="8147988001"},
                new EmployeeModel() {EmpId=5, EmpName="Ram", EmpEmail="ram@gmail.com", EmpPhone="8147988001"},
                new EmployeeModel() {EmpId=6, EmpName="Mohan", EmpEmail="mohan@gmail.com", EmpPhone="8147988001"}
            };       
        }

    }
}
