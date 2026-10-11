namespace Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Create a geneeric stack that can only hold Employee objects.
            Stack<Employee> employees = new Stack<Employee>();

            //Create 5 Employee objects with different values.

            Employee employee1 = new Employee(1, "John", "Male", 50000);
            Employee employee2 = new Employee(2, "Lea", "Female", 60000);
            Employee employee3 = new Employee(3, "Ted", "Male", 55000);
            Employee employee4 = new Employee(4, "Anna", "Female", 70000);
            Employee employee5 = new Employee(5, "Nate", "Male", 65000);

            //Push adds each object on top of the stack.

            employees.Push(employee1);
            employees.Push(employee2);
            employees.Push(employee3);
            employees.Push(employee4);
            employees.Push(employee5);

            //foreach prints every item from top to bottom without removing anything, so count stays at 5.
            foreach (Employee emp in employees)
            {
                Console.WriteLine($"{emp.Id} - {emp.Name} - {emp.Gender} - {emp.Salary}");
                Console.WriteLine($"Items left in the Stack = {employees.Count}");
            }


            Console.WriteLine("----------------------------");
            Console.WriteLine("Retrieve Using Pop Method");

            //Pop removes and returns the top item from the stack, so count decreases by 1 each time. The loop runs until the stack is empty.

            while (employees.Count > 0)
            {
                Employee emp = employees.Pop();

                Console.WriteLine($"{emp.Id} - {emp.Name} - {emp.Gender} - {emp.Salary}");

                Console.WriteLine($"Items left in the Stack = {employees.Count}");
            }

            //The stack is empty after the Pop, so push all the objects back.

            employees.Push(employee1);
            employees.Push(employee2);
            employees.Push(employee3);
            employees.Push(employee4);
            employees.Push(employee5);


            Console.WriteLine("----------------------------");
            Console.WriteLine("Retrieve Using Peek Method");

            //Peek looks at the top item without removing it, so both rounds show the same employee and Count stays at 5.

            for (int i = 0; i < 2; i++)
            {
                Employee emp = employees.Peek();

                Console.WriteLine($"{emp.Id} - {emp.Name} - {emp.Gender} - {emp.Salary}");

                Console.WriteLine($"Items left in the Stack = {employees.Count}");

            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("Check if Employee3 is in the Stack");

            //Contains returns true if this exact object is in the stack.
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
            //Create a generic list that can only hold Employee objects.

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
