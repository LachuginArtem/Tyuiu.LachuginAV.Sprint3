using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.LachuginAV.Sprint3.Task6.V11.Lib
{
    public class DataService : ISprint3Task6V11
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int res = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                List<int> array = new List<int>();
                for (int k = 1; k <= i; k++)
                {
                    if (i % k == 0)
                    {
                        array.Add(k);
                    }
                }
                foreach (char number in array)
                {
                    if (number > 10)
                    {
                        res += 1;
                    }
                }
            }
            return res;
        }
    }
}