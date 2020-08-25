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
        public int Seats {
            get {
                return this.seats;
            }
            set {
                if (this.Seats == -1 && value > 0)
                {
                    this.Seats = value; // "value" is always assumed name
                }
            } 
        }
        
        private string engine;
        public void SetEngine(string value)
        {
            if (this.engine == null)
            {
                this.engine = value; // to set value only once
            }
        }
    }
}