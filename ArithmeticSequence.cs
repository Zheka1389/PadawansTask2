using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            // put your code here
            // throw new NotImplementedException();
            int result = (add < 0 || count < 0) ? throw new ArgumentException() :
                number * count + add * ((count - 1) * count / 2);
            return result;
        }
    }
}
