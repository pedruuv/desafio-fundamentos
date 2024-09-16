using ChallengeFundamentos.Models;

Console.WriteLine("Welcome to the Parking System");
Console.WriteLine("Type the initial price: ");
decimal initialPrice = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Now, type the price per hour: ");
decimal priceHour = Convert.ToDecimal(Console.ReadLine());

Parking parking = new(initialPrice, priceHour);

int option = 0;
bool showMenu = true;

while (showMenu)
{
    Menu();
    option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            parking.AddVehicle();
            break;
        case 2:
            parking.RemoveVehicle();
            break;
        case 3:
            parking.ListVehicles();
            break;
        case 4:
            showMenu = false;
            break;
        default:
            Console.WriteLine("Invalid option");
            break;
    }
    Console.WriteLine("Type any key to return: ");
    Console.ReadKey();
    Console.Clear();

}
Console.WriteLine("The application ended.");

void Menu()
{
    Console.Clear();
    Console.WriteLine("Type an option: ");
    Console.WriteLine("1- Register Vehicle");
    Console.WriteLine("2- Remove Vehicle");
    Console.WriteLine("3- List Vehicles");
    Console.WriteLine("4- Exit");
}