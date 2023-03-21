using System;
using System.Collections.Generic;

namespace ElevatorChallenge
{
    public class Passenger
    {
        static int nextId;
        public int PassengerID {get; private set;}
        public int StartFloor {get; set;}
        public int EndFloor {get; set;}
        public int Weight {get; set;}
        public string StartDirection {get; set;}

        public Passenger(int SFloor, string SDirection)
        {
            PassengerID = Interlocked.Increment(ref nextId);
            StartFloor = SFloor;
            EndFloor = EFloor;
            Weight = Math.floor(Math.random() * (200 - 50 + 1) + 50 );  //setting a random weight for each instance of person between 50 and 200
            StartDirection = SDirection;
        }

        public Direction Direction
        {
            //Set the direction of the elevator based on whether the passenger selected up or down from the outside or selected a specific floor from the inside
            get
            {
                //This can apply to the inside selection
                if (StartFloor < EndFloor) return Direction.Up;
                else return Direction.Down;
            }
        }
    }
}