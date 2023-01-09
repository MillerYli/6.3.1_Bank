using System;
using System.Collections.Generic;
using System.Threading.Tasks;


class Company
{
    public string Type;
    public string Name;
}

class Department
{
    public Company company = new Company();
    public City city = new City();
}

class City
{
    public string Name;
}

class Program
{
    static void Main(string[] args)
    {
        var department = GetCurrentDepartment();
        if (department?.company?.Type == "Банк" && department?.city?.Name == "Санкт-Петербург")
        {
            Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.company?.Name ?? "Неизвестная компания");
        }
    }

    static Department GetCurrentDepartment()
    {
        Department depart = new Department();
        depart.company.Type = "Банк";
        depart.company.Name = "Alfa";
        depart.city.Name = "Санкт-Петербург";

        return depart;
    }
}

