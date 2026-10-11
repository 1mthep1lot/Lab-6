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


            Console.WriteLine("----------------------------");
            Console.WriteLine("Retrieve Using Pop Method");

            while (employees.Count > 0)
            {
                Employee emp = employees.Pop();

                Console.WriteLine($"{emp.Id} - {emp.Name} - {emp.Gender} - {emp.Salary}");

                Console.WriteLine($"Items left in the Stack = {employees.Count}");
            }

            employees.Push(employee1);
            employees.Push(employee2);
            employees.Push(employee3);
            employees.Push(employee4);
            employees.Push(employee5);


            Console.WriteLine("----------------------------");
            Console.WriteLine("Retrieve Using Peek Method");

            for (int i = 0; i < 2; i++)
            {
                Employee emp = employees.Peek();

                Console.WriteLine($"{emp.Id} - {emp.Name} - {emp.Gender} - {emp.Salary}");

                Console.WriteLine($"Items left in the Stack = {employees.Count}");

            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("Check if Employee3 is in the Stack");
            if (employees.Contains(employee3))
            {
                Console.WriteLine($"Emp3: {employee3.Name} is in the stack.");
            }
            else
            {
                Console.WriteLine($"Emp3: {employee3.Name} is not in the stack.");   
            }
             

            Console.WriteLine();

            Console.WriteLine("----------------------------");
            Console.WriteLine("Part 2 - List");

            List<Employee> employee = new List<Employee>();

            employee.Add(employee1);
            employee.Add(employee2);
            employee.Add(employee3);
            employee.Add(employee4);
            employee.Add(employee5);


            if (employee.Contains(employee2))
            {
                Console.WriteLine($"Emp2: {employee2.Name} is in the list.");
            }
            else
            {
                Console.WriteLine($"Emp2: {employee2.Name} is not in the list.");
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("Find - first Male");

            Employee? FirstMale = employee.Find(e => e.Gender == "Male");
            Console.WriteLine($"{FirstMale.Id} - {FirstMale.Name} - {FirstMale.Gender} - {FirstMale.Salary}");

            Console.WriteLine();

            Console.WriteLine("----------------------------");
            Console.WriteLine("Find all Males");


            List<Employee> allMales = employee.FindAll(a => a.Gender == "Male");  
            
            foreach (Employee emp in allMales)
            {
                Console.WriteLine($"{emp.Id} - {emp.Name} - {emp.Gender} - {emp.Salary}");

            }




        }
    }
}
