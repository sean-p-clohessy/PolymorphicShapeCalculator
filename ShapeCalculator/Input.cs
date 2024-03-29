﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculator
{
    class Input
    { 
        public string RawInput { get; set; }
        public string TypeError { get; } = "TypeError. Plase enter a valid value";

        //validation of shape choice input by user
        public int GetInputAndTypeValidate(int intChoice)
        {
            
            bool isValid = false;
            do
            {
                isValid = int.TryParse(Console.ReadLine(), out intChoice);
                if (!isValid)
                {
                    Console.WriteLine(TypeError);
                }
            } while (!isValid);
            return intChoice;
        }

        //validation of shape messurement inputs by user
        public double GetInputAndTypeValidate (double value)
        {
            
            bool isValid = false;
            do
            {
                isValid = double.TryParse(Console.ReadLine(), out value);
                if (!isValid)
                {
                    Console.WriteLine(TypeError);
                }
            } while (!isValid);
            return value;
        }

    }
}
