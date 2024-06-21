using ShopConsole.Core.Enums;
namespace ShopConsole.Core.Models;

public class Employee : Base
{
    public string Surname { get; set; }
    public int Salary { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}
