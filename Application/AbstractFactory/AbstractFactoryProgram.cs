using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AbstractFactory
{
    class AbstractFactoryProgram
    {
        public static void Run()
        {
            AbstractFactory blackPetFactory = AbstractFactory.GetFactory(PetColor.BLACK);
            AbstractFactory whitePetFactory = AbstractFactory.GetFactory(PetColor.WHITE);

            Cat blackCat = blackPetFactory.BuyCat();
            Cat whiteCat = whitePetFactory.BuyCat();
            Dog blackDog = blackPetFactory.BuyDog();
            Dog whiteDog = whitePetFactory.BuyDog();
        }
    }
}
