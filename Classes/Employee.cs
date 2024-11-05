namespace AccessModifiers
{
    internal class Employee
    {
        public int Id { get; set; }
        internal string Name { get; set; }
        protected int Age { get; set; }

        public Department Department { get; set; }
    }
}
