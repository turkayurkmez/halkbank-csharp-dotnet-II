using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Weapon
    {
        public int Damage { get; set; }
        public double Price { get; set; }
        public int Weight { get; set; }
        public Weapon(int damage)
        {
            Damage = damage;
        }
        public void Attack()
        {
            Console.WriteLine($"{this.GetType().Name} ile saldırıldı. Hasar {Damage}");
        }

        public virtual void ChangePosition()
        {
            Console.WriteLine("Bıçak dik konuma getirildi!");
        }
    }

    public class Knife : Weapon
    {
        public Knife() : base(10)
        {

        }

    }

    public class Gun : Weapon
    {
        public Gun() : base(25)
        {

        }
        public int MaxBulletCount { get; set; }
        public int MaxCharger { get; set; }


        public override void ChangePosition()
        {
            Console.WriteLine($"{GetType().Name} göz gez arpacık moduna getirildi");
        }
    }

    public class Baretta : Gun
    {
        public Baretta()
        {
            Damage = 30;
        }
        public int GunCount { get; set; } = 2;
    }

    public class Rifle : Gun
    {
        public bool IsZooming { get; set; }
        public override void ChangePosition()
        {
            Console.WriteLine("Dürbün ile bakılıyor");
        }
    }

    public class SG1 : Rifle
    {
        public SG1()
        {
            Damage = 100;
        }
        public bool IsStaticPosition { get; set; }
    }


}
