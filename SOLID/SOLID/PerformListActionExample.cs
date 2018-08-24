using System;
using System.Collections.Generic;

namespace SOLID
{
    public static class PerformListActionExample
    {
        public static void DoAction(int[] list)
        {
            foreach (var item in list) Console.WriteLine(item);
        }

        public static void DoAction<T>(List<T> list)
        {
            foreach (var item in list) Console.WriteLine(item);
        }

        public static void DoAction<T>(IList<T> list)
        {
            foreach (var item in list) Console.WriteLine(item);
        }

        public static void DoAction<T>(IList<T> list, Action<T> action)
        {
            foreach (var item in list) action(item);
        }
    }
}