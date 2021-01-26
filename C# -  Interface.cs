// 0. Interface are in use when we do not know future Implementation or functionalities which are not common.
// 1. Interface consists of public and abstract methods by default.
// 2. Interface methods can't be private.
// 3. Interface can extend multiple Interface. 
// 4. Class can Implement multiple Interface.
// 5. A class has to implement Interface members of implemented Interface.
// 6. Interface members doesn't have implementation.
// 7. They can't be sealed or static.
// 8. Interface is by default public and abstract.
using System;

namespace ConsoleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IPhone iphone = new IPhone();
            Android android = new Android();

            Console.WriteLine("IPhone Details!");

            iphone.OperatingSystem();
            iphone.Memory();
            iphone.AppStore();
            iphone.Camera();

            Console.WriteLine(" ");
            Console.WriteLine("Android Details!");

            android.OperatingSystem();
            android.Memory();
            android.AppStore();

        }
    }

    public interface ISmartPhones
    {
        void OperatingSystem();

        void AppStore();

        void Memory();

    }

    public interface  ICamera : ISmartPhones
    {
        void Camera();
    }

    public class Android : ISmartPhones
    {
        public void OperatingSystem()
        {
            Console.WriteLine("This is android OS");
        }

        public void AppStore()
        {
            Console.WriteLine("This is android AppStore");
        }

        public void Memory()
        {
            Console.WriteLine("This is android Memory");
        }
    }

    public class IPhone : ICamera
    {
        public void OperatingSystem()
        {
            Console.WriteLine("This is IPhone OS");
        }

        public void AppStore()
        {
            Console.WriteLine("This is IPhone AppStore");
        }

        public void Memory()
        {
            Console.WriteLine("This is IPhone Memory");
        }

        public void Camera()
        {
            Console.WriteLine("IPhone has Camera");
        }
    }
}
