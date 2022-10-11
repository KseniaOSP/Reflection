// See https://aka.ms/new-console-template for more information


using MyAttribute;
using System;
using System.Reflection;

var q = from t in Assembly.GetExecutingAssembly().GetTypes()
        where t.IsClass && t.Namespace == "MyAttribute"
        select t;

foreach (var type in q)
{
    Console.WriteLine(type.Name);
    // Получаем все атрибуты
    object[] attributes = type.GetCustomAttributes(false);
    foreach (Attribute attr in attributes)
    {
        // если атрибут есть у класса
        if (attr is MyClassAttribute classAttribute)

        {
            foreach (var method in type.GetMethods())
            {
                object[] methodAttrs = method.GetCustomAttributes(false);
                foreach (Attribute methodAttr in methodAttrs)
                {
                    if (methodAttr is MyMethodAttribute) 
                    
                    {
                        method.Invoke(null, new Object[0]);
                    }
                }
            }


        }

    }

}