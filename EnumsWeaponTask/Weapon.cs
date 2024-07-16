namespace EnumsWeaponTask
{
    public class Weapon
    {
        public enum BulletType
        {
            Frangible,
            Fmj,
            Jhp
        }

        private static int _id = 1;
        public int Id { get; private set; }
        public List<Bullet> Bullets { get; private set; }
        public int Capacity { get; private set; }
        public Weapon(int capacity)
        {
            Id = _id++;
            Capacity = capacity;
            Bullets = new List<Bullet>();
        }
        public void Fire(BulletType type, int numberOfBullets)
        {
            Console.WriteLine($"Firing {numberOfBullets} {type.ToString()} bullets from Weapon {Id}");

            for (int i = 0; i < numberOfBullets; i++)
            {
                if (Bullets.Count > 0)
                {
                    Bullets.RemoveAt(0);
                }
                else
                {
                    Console.WriteLine("Out of Bullets!");
                    break;
                }
            }
        }
        public void Fill()
        {
            for (int i = 0; i < Capacity; i++)
            {
                Bullets.Add(new Bullet(BulletType.Frangible));
            }
            Console.WriteLine($"Filled Weapon {Id} with {Capacity} bullets.");
        }

        public void PullTrigger()
        {
            if (Bullets.Count > 0)
            {
                Console.WriteLine($"Next bullet to fire from Weapon {Id}: Type: {Bullets[0].Type}, Id: {Bullets[0].Id}");
            }
            else
            {
                Console.WriteLine("Weapon is empty,Cannot fire.");
            }
        }
    }
}
