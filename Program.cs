using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> things = new List<object>();

            things.Add(7);
            things.Add(28);
            things.Add(-1);
            things.Add(true);
            things.Add("chair");
            foreach(object item in things)
            {
                System.Console.WriteLine(item);
            }

            int sum = 0;
            foreach(object item in things)
            {
                if(item is int) {
                    int add = (int)item;
                    sum += add;
                }
            }
            System.Console.WriteLine(sum);
        }
    }
}
