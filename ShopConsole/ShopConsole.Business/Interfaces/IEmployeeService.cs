using ShopConsole.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopConsole.Business.Interfaces
{
    public interface IEmployeeService
    {
        void AddEmployee(string surname, int salary, RoleType roleType, string username, string password);
        void RemoveEmployee(string employee, int id);
        void EditEmployee(string employee, int id);
    }
}
