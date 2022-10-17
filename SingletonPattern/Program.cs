using System;

namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args) {
            var mySingleton = Singleton.Instance;

            mySingleton.print();
        }
    }
}
