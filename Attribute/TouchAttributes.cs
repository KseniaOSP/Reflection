using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAttribute
{
    [MyClass]
    public class TouchAttributes
    {
        public static void Method1()
        {
            Console.WriteLine("Метод1");
        }

        public static void Method2()
        {
            Console.WriteLine("Метод2");
        }

    }

    [MyClass]
    public class TouchAttribute2
    {
        [MyMethod]
        public static void Method3()
        {
            Console.WriteLine("Метод3");
        }

    }

    [MyClass]
    public class TouchAttribute3
    {
        public static void Method4()
        {
            Console.WriteLine("Метод4");
        }
    }

    [MyClass]
    public class TouchAttribute4
    {
        [MyMethod]
        public static void Method5()
        {
            Console.WriteLine("Метод5");
        }
    }

    public class TouchAttribute5
    {
        [MyMethod]
        public static void Method6()
        {
            Console.WriteLine("Метод6");
        }
    }

    public class TouchAttribute6
    {
        [MyMethod]
        public static void Method7()
        {
            Console.WriteLine("Метод7");
        }
    }
    [MyClass]
    public class TouchAttribute7
    {
        [MyMethod]
        public static void Method8()
        {
            Console.WriteLine("Метод8");
        }
    }
    public class TouchAttribute8
    {
       
        public static void Method9()
        {
            Console.WriteLine("Метод9");
        }
    }

    class MyClassAttribute : Attribute { }

    class MyMethodAttribute : Attribute { }
}
