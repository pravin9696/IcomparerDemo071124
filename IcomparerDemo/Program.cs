namespace IcomparerDemo
{
    class compareBySalary:IComparer<employee>
    {
        public int Compare(employee x, employee y)
        {
            if (x.salary>y.salary)
            {
                return 1;
            }
            else if (x.salary<y.salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    class employee:IEquatable<employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }

        public bool Equals(employee other)
        {
            if (Id==other.Id && Name==other.Name)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void show()
        {
            Console.WriteLine($"Id:{Id} Name:{Name} Salary:{salary}");
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            List<employee> empList = new List<employee>();//accept only ojects of employee class 

            employee e1 = new employee() { Id = 1, Name = "rajesh", salary = 10000 };
            employee e2 = new employee() { Id = 4, Name = "rajesh", salary = 12000 };
            employee e3 = new employee() { Id = 2, Name = "dinesh", salary = 9000 };
            employee e4 = new employee() { Id = 3, Name = "anand", salary = 15000 };

            empList.Add(e1);
            empList.Add(e2);
            empList.Add(e3);
            empList.Add(e4);
            Console.WriteLine("Before sort");

            foreach (employee e in empList)
            {
                e.show();
            }

            compareBySalary cbs = new compareBySalary();
            empList.Sort(cbs);//sort by salary

            Console.WriteLine("\nAfter sort");

            foreach (employee e in empList)
            {
                e.show();
            }

            employee tempEmp = new employee() { Id = 77, Name = "dinesh", salary = 9000 };
            var newResult = empList.Contains(tempEmp);

            var result3 = empList.Find(x => x.Id == 44);
        
            List<string> strList = new List<string>();
            strList.Add("aa");
            strList.Add("bb");
            strList.Add("cc");
            strList.Add("dd");

            var result = strList.Contains("aa");


            Dictionary<int, string> d1 = new Dictionary<int, string>();
            d1.Add(12, "pune");
            d1.Add(13, "solapur");


        }
    }
}
