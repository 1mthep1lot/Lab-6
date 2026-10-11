namespace Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Employee> employees = new Stack<Employee>();

            Employee employee1 = new Employee(1, "John", "Male", 50000);
            Employee employee2 = new Employee(2, "Lea", "Female", 60000);
            Employee employee3 = new Employee(3, "Ted", "Male", 55000);
            Employee employee4 = new Employee(4, "Anna", "Female", 70000);
            Employee employee5 = new Employee(5, "Nate", "Male", 65000);

            employees.Push(employee1);
            employees.Push(employee2);
            employees.Push(employee3);
            employees.Push(employee4);
            employees.Push(employee5);

            foreach (Employee emp in employees)
            {
                Console.WriteLine($"{emp.Id} - {emp.Name} - {emp.Gender} - {emp.Salary}");
                Console.WriteLine($"Items left in the Stack = {employees.Count}");
            }

        }
    }
}
