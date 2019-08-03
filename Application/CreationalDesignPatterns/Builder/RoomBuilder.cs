using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CreationalDesignPatterns.Builder
{
    // Abstract builder
    abstract class RoomBuilder
    {
        protected Room Room { get; set; }

        public RoomBuilder()
        {
            Room = new Room();
        }

        public Room GetRoom()
        {
            return Room;
        }

        public abstract void BuildWindow();

        public abstract void BuildAC();
    }

    // Concrete builder
    class BedRoomBuilder : RoomBuilder
    {
        public override void BuildAC()
        {
            Room.HasAC = true;
        }

        public override void BuildWindow()
        {
            Room.NumberOfWindow = 2;
        }
    }

    // Concrete builder
    class BathRoomBuilder : RoomBuilder
    {
        public override void BuildAC()
        {
            Room.HasAC = false;
        }

        public override void BuildWindow()
        {
            Room.NumberOfWindow = 1;
        }
    }

    // Director
    class Mason
    {
        private RoomBuilder _builder;

        public Mason()
        {
        }

        public void SetRoomBuilder(RoomBuilder builder)
        {
            _builder = builder;
        }

        public Room Build()
        {
            _builder.BuildAC();
            _builder.BuildWindow();
            return _builder.GetRoom();
        }
    }

    // Product
    class Room
    {
        public int NumberOfWindow { get; set; }

        public bool HasAC { get; set; }
    }
}
