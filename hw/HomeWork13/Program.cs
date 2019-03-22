using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace HomeWork13
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank tank = new Tank()
            {
                Name = "tank",
                Ammination = 78,
                Armor = 100,
                Movement = 57
            };
            Type type = typeof(Tank);

            Console.WriteLine("Type is: {0}", type.Name);
            PropertyInfo[] props = type.GetProperties();

            Console.WriteLine("There are {0} properties: ",
                              props.Length);

            foreach (var property in props)
                if (property.GetIndexParameters().Length == 0)
                    Console.WriteLine("   {0} ({1}): {2}", property.Name,
                                      property.PropertyType.Name,
                                      property.GetValue(tank, null));

            Console.ReadLine();
        }
    }
}
