using System;

namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
            int num = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    num++;
            }
            int[] pidar = new int[num];
            int had = 0;
            for(int j = 0; j < numbers.Length; j++)
            {
                if(numbers[j] % 2 == 0)
                {
                    pidar[had] = numbers[j];
                    had++;
                }
            }
            return pidar;
        }
    }
}
