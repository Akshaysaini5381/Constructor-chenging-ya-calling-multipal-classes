using System;

namespace Constructor_chenging_ya_calling_multipal_classes
{
    class grant
    {
        public grant(int age)      //:base()  is opstinal 
        {
            Console.WriteLine("grant age "+age);
        }
    }
    class father : grant
    {
        public father(int age):base(60)
        {
            Console.WriteLine("father age "+age);
        }
    }

    class child:father
{
        public child(int age):base(40)
        {
            Console.WriteLine("child age "+age);
        }
        static void Main(string[] args)
        {
            grant obj = new child(20);
        }
    }
}
