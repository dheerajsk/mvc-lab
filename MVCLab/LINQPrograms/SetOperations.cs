using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQPrograms
{
    class SetOperations
    {
        static string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Feb", "June", "Jan" };

        public static void DoDistinct()
        {
            var result = months.Distinct();

            foreach (var month in result)
            {
                Console.WriteLine(month);
            }
        }

        public static void DoExcept()
        {
            string[] months2 = { "Sept", "Oct", "Apr", "June", "Dec" };

            var result = months.Except(months2);

            foreach (var month in result)
            {
                Console.WriteLine(month);
            }
        }

        public static void DoIntersect()
        {
            string[] months2 = { "Sept", "Oct", "Apr", "June", "Dec" };

            var result = months.Intersect(months2);

            foreach (var month in result)
            {
                Console.WriteLine(month);
            }
        }

        public static void DoUnion()
        {
            string[] months2 = { "Sept", "Oct", "Apr", "June", "Dec" };

            var result = months.Union(months2);

            foreach (var month in result)
            {
                Console.WriteLine(month);
            }
        }

        public static void DoUnionAll ()
        {
            string[] months2 = { "Sept", "Oct", "Apr", "June", "Dec" };

            var result = months.Concat(months2);

            foreach (var month in result)
            {
                Console.WriteLine(month);
            }
        }
    }
}
