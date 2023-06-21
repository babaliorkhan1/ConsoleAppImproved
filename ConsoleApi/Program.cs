using ConsoleApi.Core.Models;
using ConsoleApi.Service.Services.Implemantations;

DepartmentService departmentService = new DepartmentService();
EmployeeService employeeService= new EmployeeService();
CompanyService company= new CompanyService();   

 void Show()
{

    Console.WriteLine("1:Create department");
    Console.WriteLine("2:Delete department");
    Console.WriteLine("3:Show department");
    Console.WriteLine("4:ShowAll department");
    Console.WriteLine("5:Create Employee");
    Console.WriteLine("6:Delete Employee");
    Console.WriteLine("7:Show Employee");
    Console.WriteLine("8:Show All Employees");
    Console.WriteLine("9:GetDepartment by id Employees");
    Console.WriteLine("10:Update department");
    Console.WriteLine("11:Create company");
    Console.WriteLine("12:ShowDepartments ByCompany");
    Console.WriteLine("13:ShowCompanies");

}

Show();

int.TryParse(Console.ReadLine(), out int result);

while (result!=0)
{
    switch (result)
    {
        case 1:
            departmentService.Create();
            break;
         case 2:
            departmentService.Delete();
            break;
        case 3:
            departmentService.Get();
        
            break;
        case 4:
            departmentService.GetAll();
             
            break;
        case 5:
            employeeService.Create();
            break;
        case 6:
            employeeService.Delete();  
            break;
        case 7:
            employeeService.Get();
            break;
        case 8:
            employeeService.GetAll();  
            break;
        case 9:
            employeeService.GetDepartmentId();
            break;
            case 10:
                departmentService.Update();
            break;
        case 11:
            company.Create();
            break;
            case 12:
                company.ShowDepartments();
            break;
            case 13:
            company.GetAllCompanies1();
            break;  

        default:
            Console.WriteLine("Duzgun deyer daxil edin");
            break;
    }
    Show();
    int.TryParse(Console.ReadLine(), out result);
}