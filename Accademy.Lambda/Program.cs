using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Lambda
{
    public delegate bool FilterInt(int i);
    public delegate bool MyDelegate(int i, string s);
    public delegate bool NewDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>() {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            FilterInt filterOdd = new FilterInt(IsOdd);
            List<int> result1 = FilterInts(lst, filterOdd);
            List<int> result2 = FilterInts(lst, IsEven);

            MyDelegate lamda = (i, s) =>
            {
                if (i > s.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            NewDelegate newLambda = () => { return true; };

            //List<int> result = FilterInts(lst, i => (i % 2) == 1);

            List<int> result = FilterInts(lst, i => (i & 1) == 1);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        public static bool IsOdd(int x)
        {
            return (x % 2) == 1;
        }
        public static bool IsEven(int x)
        {
            return (x % 2) == 0;
        }

        public static List<int> FilterInts(List<int> inputList, FilterInt filter)
        {
            List<int> resultList = new List<int>();
            foreach (var item in inputList)
            {
                if (filter(item))
                    resultList.Add(item);
            }
            return resultList;
        }
    }

    
}
