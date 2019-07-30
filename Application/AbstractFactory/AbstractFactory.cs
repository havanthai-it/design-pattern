using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AbstractFactory
{
    abstract class AbstractFactory
    {
        private static readonly BlackPet _blackPet = new BlackPet();
        private static readonly WhitePet _whitePet = new WhitePet();

        public static AbstractFactory GetFactory(PetColor color)
        {
            AbstractFactory factory = null;

            switch(color)
            {
                case PetColor.BLACK:
                    factory = _blackPet;
                    break;
                case PetColor.WHITE:
                    factory = _whitePet;
                    break;
            }

            return factory;
        }

        public abstract Cat BuyCat();

        public abstract Dog BuyDog();
    }

    enum PetColor
    {
        BLACK, WHITE
    }

    class BlackPet : AbstractFactory
    {
        public override Cat BuyCat()
        {
            Console.WriteLine("Bought a black cat");
            return new BlackCat();
        }

        public override Dog BuyDog()
        {
            Console.WriteLine("Bought a black dog");
            return new BlackDog();
        }
    }

    class WhitePet : AbstractFactory
    {
        public override Cat BuyCat()
        {
            Console.WriteLine("Bought a white cat");
            return new WhiteCat();
        }

        public override Dog BuyDog()
        {
            Console.WriteLine("Bought a white cat");
            return new WhiteDog();
        }
    }
}
