using LINQ.Examples;
using System;
using System.Collections;

namespace LinQ.Examples
{
    internal class Program
    {
        static void Main(string[] args) {
            LINQObjects.DataLoad();

            // Search into an Object
            var googleEmployees = LINQObjects.GetGoogleEmployees();
            LINQObjects.print(googleEmployees);

        }
    }
}
