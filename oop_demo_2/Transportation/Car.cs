using System;
using System.Collections.Generic;

namespace Transportation // only for organizing code
{
    class Car
    {
        private int seats;
        // public int GetSeats(){
        //     return this.seats;
        // }
        // public void SetSeats(int value)
        // {
        //     // LOGIC to protect invalid vale
        //     this.seats = value;
        // }
        
        // public int Seats { get; } // properties
        
        // LOGIC inside getter and setter
        // public int Seats {
        //     get {
        //         return this.seats;
        //     }
        //     set {
        //         if (this.Seats == -1 && value > 0)
        //         {
        //             this.Seats = value; // "value" is always assumed name
        //         }
        //     } 
        // }
        
        private string engine;
        public void SetEngine(string value)
        {
            if (this.engine == null)
            {
                this.engine = value; // to set value only once
            }
        }

        /// <summary>
        /// Creates a new instance of the car class
        /// </summary>
        /// <param name="seats"></param> the number of seats in a car
        /// <param name="acceleration"></param> the initial acceleration
        public Car(int seats, int acceleration)
        {
            this.Seats = seats;
            this.Acceleration = acceleration;
        }
        public int Seats { get; private set; }
        public int Acceleration { get; private set; }
        public int CurrentSpeed { get; set; }
        /// <summary>
        /// Increases the car's current speed using acceleration property
        /// </summary>
        public void Accerate() {
            this.CurrentSpeed += this.Acceleration;
        }
        /// <summary>
        /// Creates a string representation of the car instance
        /// </summary>
        /// <returns>string of a car type and current speed</returns>
        public override string ToString()
        {
            return "Type: " + base.ToString() + "\n" + "Current speed: " + this.CurrentSpeed;
        }
    }
}