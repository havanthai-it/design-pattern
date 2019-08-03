using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CreationalDesignPatterns.Builder
{
    class BuilderProgram
    {
        public static void Run()
        {
            BedRoomBuilder bedRoomBuilder = new BedRoomBuilder();
            BathRoomBuilder bathRoomBuilder = new BathRoomBuilder();

            Mason mason = new Mason();

            mason.SetRoomBuilder(bedRoomBuilder);
            Room bedRoom = mason.Build();

            mason.SetRoomBuilder(bathRoomBuilder);
            Room bathRoom = mason.Build();
        }
    }
}
