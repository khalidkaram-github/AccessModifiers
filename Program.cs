using ProjectTwo.Classes;
namespace AccessModifiers
{
    internal class Program
    {
        //************AccessModifiers******//
        //----------public-----------------//
        //----------private----------------//
        //----------protected--------------//
        //----------internal---------------//
        //----------protected internal-----//
        //----------file-------------------//
        static void Main(string[] args)
        {
            var customer = new Customer();
            //customer.name
        }
    }

    class X : Customer
    {
        public X()
        {
            name = "";
            //id
        }
    }



}
