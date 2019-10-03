using System;

namespace enums01
{
    public enum ShippingMethod
    {
        Regular = 1,
        FirstClass = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;

          

            Console.WriteLine((int) method);

            //casting
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";

            //Parsing
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof (ShippingMethod), methodName);

            Console.WriteLine("\n\n" + shippingMethod);

         
        }
    }
}
