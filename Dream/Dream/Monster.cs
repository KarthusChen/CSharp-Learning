using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dream
{
    public class Monster
    {
        public double MaxHP { get; set; }
        public double CurrentHP { get; set; }
        public double Stength { get; set; }
        public int MyProperty { get; set; }

        public virtual void DisplayMonster() { }

    }

    public class Goblin:Monster
    {
        public Goblin()
        {
            MaxHP = 10;
            CurrentHP = MaxHP;
            Stength = 1;

        }

        public override void DisplayMonster()
        {
            
        }

    }

}
