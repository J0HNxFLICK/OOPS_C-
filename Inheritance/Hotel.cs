namespace Inheritance
{
    internal class Hotel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to abc hotel.\nEnter 1 to order Chicken.\nEnter 2 to order Noodles." +
                "\nEnter 3 to order Fried Rice.\nEnter 4 to order Biriyani.\nEnter 5 to order french fries.\nEnter 6 to order Ratatouille.");

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
                    chef.MakeBiriyani();
                    break;

                case 5:
                    italianChef.MakeFrenchFries();
                    break;

                case 6:
                    italianChef.MakeRatatouille();
                    break;

                default:
                    Console.WriteLine("Out of menu request.");
                    break;
            }


        }
    }
}