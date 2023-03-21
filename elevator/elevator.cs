using System;   
using System.Collections.Generic;



namespace ElevatorChallenge
{
    public class Elevator
    {
        public int CurrentFloor {get; set;}
        public int CurrentWeight {get; set;}
        public int WeightLimit {get; set;}
        public int SelectedFloor {get; set;}
        public List<bool> FloorQueue {get;set;}
        public List<Passenger> Passengers {get; set;}

        //create the instance of the elevator
        public Elevator()
        {
            Passengers = new List<Passenger>();
            FloorQueue = new List<bool>();
            CurrentFloor = 0;  //might adjust this to be 1st/ground floor, might change if basement is involved
            CurrentWeight = 0;
            WeightLimit = 1200; //setting a weight limit, might adjust this


        }

        public Direction Direction
        {
            get
            {
                if (CurrentFloor == 0 || CurrentFloor < SelectedFloor)
                {
                    return Direction.Up;
                }
                else if(CurrentFloor == 9 || CurrentFloor > SelectedFloor)
                {
                    return Direction.Down;
                }
                else
                {
                    return Direction.Neutral;
                }
            }
        }
    }
}