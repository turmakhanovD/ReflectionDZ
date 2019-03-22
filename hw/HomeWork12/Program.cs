using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace HomeWork12
{
    class Program
    {
        static void Main(string[] args)
        {
            Type console = typeof(Console); 
            MethodInfo[] methods = console.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.Write( method.ReturnType.Name + "\t" + method.Name +"(");
                ParameterInfo[] parameter = method.GetParameters();
                for (int i = 0; i < parameter.Length; i++)
                {
                    Console.Write(parameter[i].ParameterType.Name + " " + parameter[i].Name + " ");
                }
                Console.Write(")\n");
            }

            Console.ReadLine();
        }
    }
}