using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;

namespace ElevatorChallenge
{
    public class ElevatorControl
    {
        public Elevator elevator {get; set;}
        public List<Passenger> WaitingPassengers {get; set;}
        public List<Passenger> DonePassengers {get; set;}

        public ElevatorControl()
        {
            elevator = new Elevator();
            WaitingPassengers = new List<Passenger>();
            DonePassengers = new List<Passenger>();
        }

        //Next is to accept incoming passengers based on outer input of origin floor and direction

        //From there start the process of moving to the selected destination of the passenger in queue
        public void MoveElevatorUp()
        {
                if (elevator.CurrentFloor != elevator.SelectedFloor)
                {
                    FindHighestEndFloor();
                    // Move up to the next floor
                    Console.WriteLine("The current floor is: " + elevator.CurrentFloor + ". The elevator is moving: " + elevator.Direction );
                    FloorToFloor();
                    elevator.CurrentFloor++;
                }
                else
                {

                }
        }

        public void MoveElevatorDown()
        {

        }

        //Find the lowest floor based on passengers for the elevator to currently move to
        public void FindLowestEndFloor()
        {
            foreach (Passenger passenger in elevator.Passengers)
            {
                elevator.SelectedFloor = Math.Min(elevator.SelectedFloor, passenger.EndFloor);
            }
        }

        //Find the highest Floor based on passengers for the elevator to currently move to
        public void FindHighestEndFloor()
        {
            foreach (Passenger passenger in elevator.Passengers)
            {
                elevator.SelectedFloor = Math.Max(elevator.SelectedFloor, passenger.EndFloor);
            }
        }

        async Task FloorToFloor()
        {
            await Task.Delay(3000);
        }

        async Task WaitAtFloor()
        {
            await Task.Delay(1000);
        }
    }
}