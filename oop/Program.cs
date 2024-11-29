//using System;
//namespace MyOpp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Person person1 = new Person("Juan");
//            Person person2 = new Person("Sara");
//            Person person3 = new Person("Carlos");

//            Console.WriteLine(person1.ToString());
//            Console.WriteLine(person2.ToString());
//            Console.WriteLine(person3.ToString());

//        }
//    }

//    class Base
//    {
//        public virtual string Hello()
//        {
//            Console.WriteLine("hello");
//            return "hello";
//        }
//    }
//    class Person : Base
//    {
//        public String name;
        
//        public Person(String name)
//        {
//            this.name = name;
//        }

//        public override string ToString()
//        {
//            return "Hello! My name is" + " " + name;
//        }

//    }

//}