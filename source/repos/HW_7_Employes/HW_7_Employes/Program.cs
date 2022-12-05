namespace HW_7_Employes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeSalary();
        }
        static void EmployeeSalary()
        {
            string employeeName;
            string employeeSalary;

            Console.WriteLine("Enter employes amount");
            int employeeAmount = int.Parse(Console.ReadLine());

            string[][] employeeTable = new string[employeeAmount][];
            for(int i = 0; i < employeeAmount; i++)
            {
                Console.WriteLine("Enter emplyee name: ");
                employeeName = Console.ReadLine();

                Console.WriteLine($"Enter {employeeName}'s salary : ");
                int employeeSalaryy = int.Parse(Console.ReadLine());
                if (employeeSalaryy > 0 && employeeSalaryy < 10000)
                {
                    employeeSalary = Convert.ToString(employeeSalaryy);
                    employeeTable[i] = new string[] { employeeName, employeeSalary };
                }
                else
                {
                    Console.WriteLine("Salary amount is incorrect");
                    i--;
                }
            }
            for(int i = 0; i < employeeAmount; i++)
            {
                Console.WriteLine($"{employeeTable[i][0]} : {employeeTable[i][1]}");
            }
           
        }
    }
}