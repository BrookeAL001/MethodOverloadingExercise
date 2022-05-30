using System;

namespace MethodOverloadingExercise
{
    class Program
    {
    public static int Add(int a, int b)
        {
            return a + b;
        }
    public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
    public static string Add(int x, int y, bool isTrue)

        {
            var sum = x + y;
            
            if(isTrue == true && sum >1)
            {
                return $"{sum} dollars";
            }

            else if(isTrue == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isTrue == true && sum <1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
    }
}
