// See https://aka.ms/new-console-template for more information

using AbstractFactory.ChickenRepublic;
using AbstractFactory.KFC;
namespace AbstractFactory {
    public class Program {
        public static void Main(string[] args)
        {
            var mofeRest = new ChickenRepublicRestaurant();

            var lunch = new LunchTime(mofeRest);

            lunch.GetBurger();

            //var estherRest = new ChickenRepublicRestaurant();
            Console.ReadKey();
        }
       
    }

}

