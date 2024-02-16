using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApp11
{
    abstract class Hero
    {
        public int Level { get; set; }
        public abstract string Attack();
    }
    class Knight : Hero
    {
        public override string Attack()
        {
            return Attack();
        }
    }
    class DarkKnight : Knight
    {
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DarkKnight bob = new DarkKnight();
            Console.WriteLine(bob.Attack());
        }
    }
}
