using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal abstract class Animal
    {
        public abstract void Sound();
        public abstract void Action();
        
    }

    class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Meow meow!!");
        }
        public override void Action()
        {
            Console.WriteLine("jumpping...");
        }
    }
}


