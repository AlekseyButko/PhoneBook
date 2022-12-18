namespace HW_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Employee();
        }
        static void Employee()
        {
            string employeeName;
            string employeeSalary;

            Console.WriteLine("Enetr employees amount");
            int employeeAmount = int.Parse(Console.ReadLine());

            string[][] employeeTable = new string[employeeAmount][];
            for(int i = 0; i < employeeAmount; i++)
            {
                Console.WriteLine("Ente employee name");
                employeeName = Console.ReadLine();

                Console.WriteLine( $"Enter {employeeName}'s salary ");
                double employeeSaalary = double.Parse(Console.ReadLine());
                if (employeeSaalary > 0 && employeeSaalary < 10000000)
                {
                    employeeSalary = Convert.ToString(employeeSaalary);
                    employeeTable[i] = new string[] {employeeName,employeeSalary};
                }
                else
                {
                    Console.WriteLine("Salary amount is incorrect");
                    i--;
                }
            }
            for(int i = 0; i < employeeAmount; i++)
            {
                Console.WriteLine($"{employeeTable[i][0]}: {employeeTable[0][1]}");
            }
        }
    }
}