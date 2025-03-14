using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsLibrary
{
    public interface ISubscription
    {
        void ShowDetails();
    }

    public abstract class Subscription : ISubscription
    {
        protected double monthlyFee;
        protected int minPeriod;
        protected string[] channels;
        public abstract void ShowDetails();
    }
    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription()
        {
            this.monthlyFee = 12.99;
            this.minPeriod = 3;
            this.channels = new string[] { "BBC", "CNN", "Discovery" };
        }
        public override void ShowDetails()
        {
            Console.WriteLine($"Домашня підписка: ${monthlyFee}/міс, мінімум {minPeriod} міс.");
        }
    }
    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription()
        {
            this.monthlyFee = 5.00;
            this.minPeriod = 2;
            this.channels = new string[] { "Discovery", "Science", "Hitory" };
        }
        public override void ShowDetails()
        {
            Console.WriteLine($"Освітня підписка: ${monthlyFee}/міс, мінімум {minPeriod} міс.");
        }
    }
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription()
        {
            this.monthlyFee = 15.97;
            this.minPeriod = 4;
            this.channels = new string[] { "All channels", "Exclusive Content", "4K Streaming" };
        }
        public override void ShowDetails()
        {
            Console.WriteLine($"Преміум підписка: ${monthlyFee}/міс, мінімум {minPeriod} міс.");
        }
    }

    public interface ISubscriptionFactory
    {
        ISubscription CreateSubscription();
    }

    public class WebSiteFactory : ISubscriptionFactory
    {
        public ISubscription CreateSubscription()
        {
            Console.WriteLine("Купівля через вебсайт...");
            return new DomesticSubscription();
        }
    }
    public class MobileAppFactory : ISubscriptionFactory
    {
        public ISubscription CreateSubscription()
        {
            Console.WriteLine("Купівля через мобільний додаток...");
            return new EducationalSubscription();
        }
    }
    public class ManagerCallFactory : ISubscriptionFactory
    {
        public ISubscription CreateSubscription()
        {
            Console.WriteLine("Купівля через менеджера...");
            return new PremiumSubscription();
        }
    }
}
