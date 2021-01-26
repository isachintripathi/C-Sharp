// 0. Abstract classes are in use when we have some common senarios/functionality.
// 1. We can not create an Instace of an abstract class. 
// 2. Abstract classes can't be sealed or static.
// 3. Abstract Class can consist of Abstract and Concrete classes both. 
// 4. Abstract methods are by default overridden.
// 5. We need to add virtual keyword to override non abstract/concrete methods. 
// 6. A concrete class can't inheritate more than 1 abstract class. 
// 7. We can create constructor of an abstract class. 

using System;

namespace ConsoleAbstractClass
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello , Here is the Info1 :");

            Iphone phone = new Iphone5();
            phone.call();
            phone.sms();
            phone.ModelColor();
            phone.ModelNumber();
            phone.RAM();

            Console.WriteLine("Hello , Here is the Info2 :");

            Iphone phone1 = new Iphone7();
            phone1.call();
            phone1.sms();
            phone1.ModelColor();
            phone1.ModelNumber();
            phone1.RAM();
        }
    }

    public abstract class Iphone 
    {
        //default constructor
        public Iphone()
        {

        }

        //concrete method
        public void call()
        {
            Console.WriteLine("This is Iphone Call");
        }

        //concrete method
        public virtual void sms ()
        {
            Console.WriteLine("This is Iphone sms");
        }

        //Abstract Method
        public abstract void ModelNumber();

        public abstract void ModelColor();

        public abstract void RAM();
    }

    public class Iphone5 : Iphone
    {
        public override void ModelNumber()
        {
            Console.WriteLine("This is Model 5 XXXXX");
        }

        public override void ModelColor()
        {
            Console.WriteLine("This is Blue");
        }

        public override void RAM()
        {
            Console.WriteLine("it has 2GB RAM");
        }
    }

    public class Iphone7 : Iphone
    {
        public override void ModelNumber()
        {
            Console.WriteLine("This is Model 7 XXXXX");
        }

        public override void ModelColor()
        {
            Console.WriteLine("This is White");
        }

        public override void RAM()
        {
            Console.WriteLine("it has 8GB RAM");
        }

        public override void sms()
        {
            Console.WriteLine("This is new adv sms");
        }
    }

    public abstract class Android 
    {
        //default constructor
        public Android()
        {

        }

        //concrete method
        public void call()
        {
            Console.WriteLine("This is Call");
        }

        //concrete method
        public virtual void sms()
        {
            Console.WriteLine("This is sms");
        }

        //Abstract Method
        public abstract void ModelNumber();

        public abstract void ModelColor();

        public abstract void RAM();
    }

    // class cannot have multiple base classes. (Iphone10 : Iphone5 , ..) no allowed
    public class Iphone10 : Iphone5
    {

    }
}
