
namespace ExtensionMethods
{
    public static class ExtendMyData    // Must be declared static
    {
        public static double Average (this MyData md)   // Also must be declared static.
                                                        // The 'this' keyword before the first parameter, which is a instance of the class we want to extend.
        {
            return md.Sum() / 3;
        }
    }
}
