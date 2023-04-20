using System;
using System.Reflection;

namespace ReflectionExample
{
    class Person
    {
        public string Name;
        public int Age;
        private string City;
        protected bool IsStudent;
        internal double Height;

        public Person(string name, int age, string city, bool isStudent, double height)
        {
            Name = name;
            Age = age;
            City = city;
            IsStudent = isStudent;
            Height = height;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello, my name is {Name} from {City} and I'm {Age} years old, my height is {Height}. Am I a student? {IsStudent}");

        }

        public int AddNumbers(int a, int b)
        {
            return a + b;
        }

        private void SetCity(string city)
        {
            city = city;
        }

        public string Student(bool IsStudent)
        {
            
            if (IsStudent == true)
            {
                Console.WriteLine("Yes I am!");
            }
            else
            {
                Console.WriteLine("Nope");
            }
            
            return $"Am I a student? {IsStudent}";
        }

        static void Main(string[] args)
        {
            Person person = new Person("John", 25, "New York", true, 1.8);
            person.SayHello();

            Type type = typeof(Person);
            Console.WriteLine($"Type Name: {type.Name}");
            Console.WriteLine($"Full Name: {type.FullName}");
            Console.WriteLine($"Namespace: {type.Namespace}");

            TypeInfo typeInfo = type.GetTypeInfo();
            Console.WriteLine($"Is Abstract: {typeInfo.IsAbstract}");
            Console.WriteLine($"Is Class: {typeInfo.IsClass}");
            Console.WriteLine($"Is Public: {typeInfo.IsPublic}");

            MemberInfo[] members = type.GetMembers(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            Console.WriteLine("Members:");
            foreach (MemberInfo member in members)
            {
                Console.WriteLine($"{member.MemberType} - {member.Name}");
            }

            FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            Console.WriteLine("Fields:");
            foreach (FieldInfo field in fields)
            {
                Console.WriteLine($"{field.Name} - {field.FieldType}");
            }

            MethodInfo method = type.GetMethod("AddNumbers");
            object[] parameters = new object[] { 5, 7 };
            int result = (int)method.Invoke(person, parameters);
            Console.WriteLine($"AddNumbers method result: {result}");
        }
    }
}
