using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Alt
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList cars = new ArrayList();
            cars.Add(new Car("Tesla", "Model S", 2018, 67_999.99));
            cars.Add(new Car("Ford", "Flex ", 2018, 33_905.99));
            cars.Add(new Car("Chevrolet", "Equinox", 2018, 29_495.99));
            cars.Add(new Car("Honda", "Civic", 2018, 19_615.00));
            cars.Add(new UsedCar("Toyota", "Prius", 2014, 15_723.99, 43_321));
            cars.Add(new UsedCar("Hyundai", "Sonata", 2010, 7_522.99, 71_043));
            cars.Add(new UsedCar("Dodge", "Charger", 2010, 12_450.99, 63_128));
            cars.Add(new UsedCar("Nissan", "Leaf", 2014, 8_998.99, 24_517));
            cars.Add(new Car("Quit", "", 0, 0));

            bool buyagain = true;
            while (buyagain)
            {
                Console.WriteLine("Welcome to Dave's Used Cars!\n");
                Console.WriteLine("Make           Model      Year  Price             Mileage");
                Console.WriteLine("=========================================================");
                int count = 0;
                foreach (Car c in cars)
                {
                        Console.WriteLine($"{count + 1} {c}");
                    count++;
                }

                Console.Write("Which car would you like to purchase? ");
                string order1 = Console.ReadLine().Trim();
                int.TryParse(order1, out int order);

                if (order == cars.Count || order > cars.Count || order <= 0)
                {
                    buyagain = false;
                    break;
                }
                
                
                int menuchoice = order -1;

                Car choice = (Car)(cars[menuchoice]);
                Console.WriteLine($"You chose {choice.GetMake()} {choice.GetModel()} {choice.GetYear()} for ${choice.GetPrice()}.");

                buyagain = Validator.ValidatePurchase("Is this the car you want? (Y or N)");
                cars.RemoveAt(menuchoice);
            }
            Console.WriteLine("Have a great day!");
            Console.ReadKey();
        }
    }
}
