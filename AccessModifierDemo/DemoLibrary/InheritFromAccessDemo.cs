namespace DemoLibrary
{
    class InheritFromAccessDemo : AccessDemo
    {
        public void Test()
        {
            ProtectedDemo();
            InternalDemo();
            PrivateProtectedDemo();
        }
    }
}
