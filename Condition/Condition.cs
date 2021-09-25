using System;

namespace Condition
{
    public static class Condition
    {
        /// <summary>
        /// Implement code according to description of  task 1
        /// </summary>        
        public static int Task1(int n)
        {
            if (n>0) return n*n;
            else if (n<0) return Math.Abs(n);
            else return 0;
        }

        /// <summary>
        /// Implement code according to description of  task 2
        /// </summary>  
        public static int Task2(int n)
        {
            int[] count = new int[10];
            String str = n.ToString();
            for (int i = 0; i < str.Length; i++)
                count[str[i] - '0']++;
            int result = 0, multiplier = 1;
            for (int i = 0; i <= 9; i++)
            {
                while (count[i] > 0)
                {
                    result = result + (i * multiplier);
                    count[i]--;
                    multiplier = multiplier * 10;
                }
            }
            return result;
        }
    }
}
