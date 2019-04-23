using System;
using DesignPatterns.StartegyDesign.Interfaces;

namespace DesignPatterns.StartegyDesign
{


    
    public class Duck
    {

        private IQuackBehaviour qb;

        public Duck(IQuackBehaviour qb)
        {
            this.qb = qb;
        }

        public void Quack()
        {
            this.qb.Quack();
        }


    }
}
