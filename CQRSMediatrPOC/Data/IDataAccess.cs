using CQRSMediatrPOC.Models;
using System.Collections.Generic;

namespace CQRSMediatrPOC.Data
{
    public interface IDataAccess
    {
        List<EmployeeModel> GetEmployees();
        EmployeeModel AddEmployee(string fName , string lName);
    }
}
