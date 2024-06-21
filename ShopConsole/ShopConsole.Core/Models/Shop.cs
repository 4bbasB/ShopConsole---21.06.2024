namespace ShopConsole.Core.Models;

public class Shop : Base
{
    public int MinSalary { get; set; }
    public int Budget { get; set; }
    List<Employee> Employees = new List<Employee>();
    List<Product> Products = new List<Product>();
}
