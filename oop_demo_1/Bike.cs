using System;

namespace oop_inclass_demo
{
    public class Bike<T> // T is a place holder for generic type
    {
        private int currentGear = 1; // should not make public as value can be invalid
        public int GetCurrentGear()
        {
            return this.currentGear; // need to return int, same type as declared
        }
        public void SetCurrentGear(T gear) // T stands for generic argument
        {
            int gear_int = Convert.ToInt32(gear);
            if (gear_int > 5 || gear_int < 1)
            {
                return; // don't return anything when the input value is invalid
            }
            this.currentGear = gear_int;
        }
    }
}