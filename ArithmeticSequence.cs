﻿using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            // put your code here
            // throw new NotImplementedException();
            checked
            {
                int result = (count < 0) ? throw new ArgumentException() :
                    number * count + add * ((count - 1) * count / 2);
                return result;
            }
        }
    }
}
