using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MethodsLibrary;
namespace GenerativePatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Оберіть метод реалізації:");
            Console.WriteLine("1 - Фабричний метод");
            Console.WriteLine("2 - Абстрактна фабрика");
            Console.WriteLine("3 - Одинак");
            Console.WriteLine("4 - Прототип");
            Console.WriteLine("5 - Будівельник");
            Console.Write("Ваш вибір: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    FactoryMethod();
                    break;
                case "2":
                    AbstractFactory();
                    break;
                case "3":
                    SingletonPattern();
                    break;
                case "4":
                    Prototype();
                    break;
                case "5":
                    Builder();
                    break;
                default:
                    Console.WriteLine("Невірний вибір");
                    break;
            }
        }
        static void FactoryMethod()
        {
            ISubscriptionFactory websiteFactory = new WebSiteFactory();
            ISubscriptionFactory mobileAppFactory = new MobileAppFactory();
            ISubscriptionFactory managerCallFactory = new ManagerCallFactory();

            ISubscription sub1 = websiteFactory.CreateSubscription();
            sub1.ShowDetails();

            ISubscription sub2 = mobileAppFactory.CreateSubscription();
            sub2.ShowDetails();

            ISubscription sub3 = managerCallFactory.CreateSubscription();
            sub3.ShowDetails();
        }
        static void AbstractFactory()
        {
            IDeviceFactory iproneFactory = new IProneFactory();
            IDevice iproneLaptop = iproneFactory.CreateLaptop();
            iproneLaptop.Info("Iprone");

            IDeviceFactory kiaomiFactory = new KiaomiFactory();
            IDevice kiaomiSmartphone = kiaomiFactory.CreateSmartphone();
            kiaomiSmartphone.Info("Kiaomi");

            IDeviceFactory pamsungFactory = new PamsungFactory();
            IDevice pamsungNetbook = pamsungFactory.CreateNetbook();
            pamsungNetbook.Info("Pamsung");

        }
        static void SingletonPattern()
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();
            if (s1 == s2)
            {
                Console.WriteLine("Одинак працює, обидві змінні містять один і той же екземпляр.");
            }
            else
            {
                Console.WriteLine("Одинак не працює, змінні містять різні екземпляри.");
            }
            s1.SomeBusinessLogic();
        }
        static void Prototype()
        {
            var child1 = new Virus("Child Virus 1", 1, 0.1, "Type A", null);
            var child2 = new Virus("Child Virus 1", 1, 0.2, "Type A", null);
            var parent = new Virus("Child Virus 1", 5, 1.0, "Type B", new[] { child1, child2});

            Console.WriteLine("Original Virus:");
            parent.DisplayInfo();

            Virus clonedParent = parent.Clone();

            Console.WriteLine("\nCloned Virus:");
            clonedParent.DisplayInfo();

            Console.WriteLine("\nChecking if children are different instances:");
            Console.WriteLine($"Original Child 1 and Cloned Child 1 are the same: {parent.Children[0] == clonedParent.Children[0]}");
            Console.WriteLine($"Original Child 2 and Cloned Child 2 are the same: {parent.Children[1] == clonedParent.Children[1]}");
        }
        static void Builder()
        {
            ICharacterBuilder heroBuilder = new HeroBuilder();
            CharacterDirector director = new CharacterDirector(heroBuilder);

            Character hero = director.BuildHero();
            hero.DisplayInfo();

            ICharacterBuilder enemyBuilder = new EnemyBuilder();
            director = new CharacterDirector(enemyBuilder);

            Character enemy = director.BuildEnemy();
            enemy.DisplayInfo();
        }
    }
}
