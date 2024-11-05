namespace AccessModifiers
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    public class EmployeeASD
    {
        public int Id { get; set; }
        internal string Name { get; set; }
        protected int Age { get; set; }

        public Department Department { get; set; }
    }
}


