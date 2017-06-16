using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    public class MyClass
    {
        private string name = "John";

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            Console.WriteLine("mc.Name : {0}", mc.Name);
            mc.Name = "Bree";
            Console.WriteLine("mc.Name : {0}", mc.Name);
        }
    }
}