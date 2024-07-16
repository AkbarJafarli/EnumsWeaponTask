using EnumsWeaponTask;
using System.Collections.Concurrent;
using static EnumsWeaponTask.Weapon;

Weapon weapon = null;
while (true)
{
    Console.WriteLine("===============================");
    Console.WriteLine("1.Create a new weapon");
    Console.WriteLine("2.Fill the weapon with bullets");
    Console.WriteLine("3.Fire bullets");
    Console.WriteLine("4.Display next bullet to fire");
    Console.WriteLine("5.Put the weapon away");
    Console.WriteLine("===============================");
    Console.Write("Choose:");


    int choice;
    if (!int.TryParse(Console.ReadLine(), out choice))
    {
        Console.WriteLine("Invalid input,Please enter a number.");
        continue;
    }

    switch (choice)
    {
        case 1:
            Console.Write("Enter capacity for the weapon:");
            int capacity;
            if (!int.TryParse(Console.ReadLine(), out capacity))
            {
                Console.WriteLine("Invalit input,Please enter a number.");
                break;
            }
            weapon = new Weapon(capacity);
            Console.WriteLine($"Created a new weapon with capacity {capacity}.");
            break;

        case 2:
            if (weapon == null)
            {
                Console.WriteLine("Create a weapon first before filling it with bullets.");
                break;
            }
            weapon.Fill();
            break;
        case 3:
            if (weapon == null)
            {
                Console.WriteLine("Create a weapon first before firing bullets.");
                break;
            }
            Console.WriteLine("Bullet types:");
            Console.WriteLine("0.Frangible");
            Console.WriteLine("1.Fmj");
            Console.WriteLine("2.Jhp");
            Console.Write("Choose bullet type:");
            int bulletTypeInt;
            if (!int.TryParse(Console.ReadLine(), out bulletTypeInt))
            {
                Console.WriteLine("Invalid bullet type,please enter 0,1 or 2.");
                break;
            }
            BulletType bulletType = (BulletType)bulletTypeInt;
            Console.Write("Enter number of bullets to fire:");
            int numberOfBullets;
            if (!int.TryParse(Console.ReadLine(), out numberOfBullets))
            {
                Console.WriteLine("Invalid input,Please enter a number");
                break;
            }
            weapon.Fire(bulletType, numberOfBullets);
            break;

        case 4:
            if (weapon == null)
            {
                Console.WriteLine("Create a weapon first to display the next bullet to fire.");
                break;
            }
            weapon.PullTrigger();
            break;

        case 5:
            Console.WriteLine("I put the weapon aside");
            return;

        default:
            Console.WriteLine("Invalid choice. Please choose a number from the menu.");
            break;


    }
}

