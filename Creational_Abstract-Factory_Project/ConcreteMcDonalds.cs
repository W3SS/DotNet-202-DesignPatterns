﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Abstract_Factory_Project
{
    class ConcreteMcDonalds : AbstractFactoryFastFood
    {
        public override AbstractMcDonalds CreateFoodA()
        {
            return new McDonaldsA();
        }

        public override AbstractBurgerKing CreateFoodB()
        {
            return new BurgerKingA();
        }
    }
}
