using System;
using System.Reflection;

namespace ReflectionDemo
{
    public class mainClass
    {
        public static void Main()
        {
            Type T = Type.GetType("ReflectionDemo.StudentInfo");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType + " " + method.Name);
            }
            PropertyInfo[] properties = T.GetProperties();

            Console.WriteLine("\nProperties");
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType + " " + property.Name);
            }

            Console.WriteLine("\nConstructors");
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }

        }

    }
    class StudentInfo
    {
        int id { get; set; }
        int age { get; set; }
        String name { get; set; }
        public StudentInfo()
        {
            id = 1;
            age = 1;
            name = "Twinkle";
        }
        public StudentInfo(int id, int age, String name)
        {
            this.id = id;
            this.age = age;
            this.name = name;
        }
        public void showId()
        {
            Console.WriteLine("ID is: {0}", this.id);
        }
        public void showName()
        {
            Console.WriteLine("NAME is: {0}", this.name);
        }
        public void showAge()
        {
            Console.WriteLine("AGE is: {0}", this.age);
        }

    }

}
