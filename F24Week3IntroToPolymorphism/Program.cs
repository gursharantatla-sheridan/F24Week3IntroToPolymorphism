namespace F24Week3IntroToPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BaseClass objBase = new BaseClass();
            //objBase.Show();

            //DerivedClass objDerived = new DerivedClass();
            //objDerived.Show();


            //objBase = new DerivedClass();
            //objBase.Show();



            // without polymorphism

            SalariedEmployee salEmp = new SalariedEmployee(101, "John", 1500);
            Console.WriteLine(salEmp);
            Console.WriteLine($"Earnings = {salEmp.Earnings():C}\n\n");

            HourlyEmployee hrEmp = new HourlyEmployee(102, "Anne", 50, 20);
            Console.WriteLine(hrEmp);
            Console.WriteLine($"Earnings = {hrEmp.Earnings():C}\n\n");

            CommissionEmployee commEmp = new CommissionEmployee(103, "Mark", 10000, 0.20);
            Console.WriteLine(commEmp);
            Console.WriteLine($"Earnings = {commEmp.Earnings():C}\n\n");


            Console.WriteLine("\n\n\n");


            // with polymorphism

            Employee emp;

            emp = new SalariedEmployee(101, "John", 1500);
            Console.WriteLine(emp);
            Console.WriteLine($"Earnings = {emp.Earnings():C}\n\n");

            emp = new HourlyEmployee(102, "Anne", 50, 20);
            Console.WriteLine(emp);
            Console.WriteLine($"Earnings = {emp.Earnings():C}\n\n");

            emp = new CommissionEmployee(103, "Mark", 10000, 0.20);
            Console.WriteLine(emp);
            Console.WriteLine($"Earnings = {emp.Earnings():C}\n\n");



            Console.WriteLine("\n\n\n");



            // more realistic example of polymorphism

            Employee[] employees = new Employee[3];

            employees[0] = new SalariedEmployee(101, "John", 1500);
            employees[1] = new HourlyEmployee(102, "Anne", 50, 20);
            employees[2] = new CommissionEmployee(103, "Mark", 10000, 0.20);

            foreach (Employee e in employees)
            {
                Console.WriteLine(e);
                Console.WriteLine($"Earnings = {e.Earnings():C}\n\n");
            }
        }
    }
}
