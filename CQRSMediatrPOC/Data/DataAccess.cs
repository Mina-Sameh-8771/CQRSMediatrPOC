using CQRSMediatrPOC.Models;
using System.Collections.Generic;
using System.Linq;

namespace CQRSMediatrPOC.Data
{
    public class DataAccess : IDataAccess
    {
        private List<EmployeeModel> _emolyees = new();

        public DataAccess()
        {
            _emolyees.Add(new EmployeeModel { FirstName = "Mina" , LastName = "Sameh" , Id = 1});
            _emolyees.Add(new EmployeeModel { FirstName = "Youssef" , LastName = "Sameh" , Id = 2});
        }

        public EmployeeModel AddEmployee(string fName, string lName)
        {
            EmployeeModel employee = new EmployeeModel();
            employee.FirstName = fName;
            employee.LastName = lName;
            employee.Id = _emolyees.Max(x => x.Id) + 1;
            _emolyees.Add(employee);

            return employee;
        }

        public List<EmployeeModel> GetEmployees()
        {
            return _emolyees;
        }
    }
}
