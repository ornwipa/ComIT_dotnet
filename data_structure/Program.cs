using System;
using System.Collections.Generic; // namespace for using List class !!!

namespace data_structure
{
    class Program
    {
        static void learnArray()
        {
            bool[] stuff = new bool[5]; // default to false            
            for (int i = 0; i < 5; i++){
                Console.WriteLine("The element at index {0} is {1}.", i, stuff[i]);
            }

            const int numberOfGrades = 5;

            float[] grades;
            grades = new float[numberOfGrades];
            // List<float> grades;
            // grades = new List<float>();

            float grades_sum = 0;

            for (int i = 0; i < grades.Length; i++){ // List doesn't have Length attribute; but .Count
                
                while(true){
                    string input = Console.ReadLine();
                    // float grade = (float)Convert.ToDouble(input); // (float) is explicit conversion
                    float grade = float.Parse(input); // both ways work.

                    if (grade <= 100 && grade >= 0){
                        grades[i] = grade;
                        grades_sum = grades_sum + grades[i];
                        break;                        
                    }
                    Console.WriteLine("Invalid Grade");
                }                
            }
            float average = grades_sum / 5;
            Console.WriteLine("The average grade is {0}.", average);
        }
        static void learnMatrix()
        {
            int[,] matrix;
            matrix = new int[4,3];
            // matrix.Length returns 4*3 (total number of all elements)

            for (int i = 0; i < matrix.GetLength(0); i++){
                // for (int j = 0; j < matrix.GetLength(1); j++){
                for (int j = 0; j < i; j++){
                    Console.WriteLine("The value at {0} and {1} is {2}", i, j, matrix[i,j]);
                }
            }
        }
        static void Main(string[] args)
        {
            // learnArray();
            // learnMatrix();

            int number = 0; // primitive type that stores data, 64 bits
            number.GetType();

            int[] number_array; // not just data, but instance of a class, so has its own properties
            number_array = new int[5] {1, 2, 3, 4, 5};
            number_array.GetValue(0);

            float f = 2.8530f; // need to specify precision of the decimal point number
            int i = (int) f; // number gets cut-off to 2 (not rounded), following rule of binary number

            char a = 'a'; // char stores 16 bits, less than integer that stores 32 bits
            int number_a = a; // stores as 97, there is a giant table ... ascii or utf-8 formating

            char result = (char)(a + 1); // char is 98 'b'

            string string_a = "97";
            int int_a = Int32.Parse(string_a);

            char b = 'b';
            string res = a > b ? "a > b" : "a < b"; // shorthand if-else statement that return the value
            Console.WriteLine(res);
        }
    }
}