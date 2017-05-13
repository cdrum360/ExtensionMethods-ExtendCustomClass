using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            MyData md = new MyData(3, 4, 5);
            
            Console.WriteLine("Sum:      {0}", md.Sum());

            Console.WriteLine("Average:  {0}", md.Average());   // Instance invocation; can be used when ...
                                                                // The keyword 'this' is used before the type name in the parameter declaration of the extension method.
            #region Alternate Syntax
            
            //Console.WriteLine("Average:  {0}", ExtendMyData.Average(md));   // Static invocation
            
            #endregion
            
            Console.ReadLine();
        }
    }
}
