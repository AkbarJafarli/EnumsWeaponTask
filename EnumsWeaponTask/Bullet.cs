
using static EnumsWeaponTask.Weapon;

namespace EnumsWeaponTask
{
    public class Bullet
    {
        private static int _id = 1;
        public int Id { get; private set; }
        public BulletType Type { get; set; }
        public Bullet(BulletType type)
        {
            Id = _id++;
            Type = type;
        }

    }
}
