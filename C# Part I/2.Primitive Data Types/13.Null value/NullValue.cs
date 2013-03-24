using System;

namespace _13.Null_value
{
    class NullValue
    {
        static void Main()
        {
            int? nint= null;
            //nint = 0; //add some value in nint
            Console.WriteLine( "Integer with Null value:{0}",nint);
            double? ndouble = null;
            //ndouble = 0.001; //add samo value in ndouble
            Console.WriteLine("Double with Null value:{0}",ndouble);
        }
    }
}
