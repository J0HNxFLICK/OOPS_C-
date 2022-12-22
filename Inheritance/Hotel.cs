namespace Inheritance
{
    internal class Hotel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to abc hotel.\nEnter 1 to order Chicken.\nEnter 2 to order Noodles." +
                "\nEnter 3 to order Fried Rice.\nEnter 4 to order Special Dish of chef.\nEnter 5 to order french fries.\nEnter 6 to order Italian Chef special dish.");

            int userChoice = Convert.ToInt32(Console.ReadLine());

            Chef chef= new Chef();
            ItalianChef italianChef= new ItalianChef();

            switch (userChoice)
            {
                case 1:
                    chef.MakeChicken();
                    break;

                case 2:
                    italianChef.MakeNoodles();
                    break;

                case 3:
                    chef.MakeFriedRice();
                    break;

                case 4:
                    chef.MakeSpecialDish();
                    break;

                case 5:
                    italianChef.MakeFrenchFries();
                    break;

                case 6:
                    italianChef.MakeSpecialDish();
                    break;

                default:
                    Console.WriteLine("Out of menu request.");
                    break;
            }


        }
    }
}