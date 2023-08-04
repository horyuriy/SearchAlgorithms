using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SequentialSearch
{
    public static class ArrayExt
    {
        private static void CheckArray<T>(T[] a)
        {
            if (a == null)
            {
                throw new ArgumentNullException("The array cannot be null");
            }
            if (a.Length == 0)
            {
                throw new ArgumentException("The length of the array must be greater than zero");
            }
        }
        public static int LinearSearch<T>(this T[] array, T key) where T: struct, IEquatable<T>
        {
            CheckArray(array);
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i].Equals(key)) return i;
            }
            return -1;
        }
        public static T MinValue<T>(this T[] array) where T: struct, IComparable<T>
        {
            CheckArray(array);
            T min = array[0];
            for(int i =1; i< array.Length; ++i)
            {
                if (array[i].CompareTo(min) <0)
                { 
                    min = array[i];
                }
            }
            return min;
        }
        public static T MaxValue<T>(this T[] array) where T : struct, IComparable<T>
        {
            CheckArray(array);
            T max = array[0];
            for (int i = 1; i < array.Length; ++i)
            {
                if (array[i].CompareTo(max) > 0)
                {
                    max = array[i];
                }
            }
            return max;
        }
        public static int IndexOfMax<T>(this T[] array ) where T: struct, IComparable<T>
        {
            CheckArray(array);
            int indexOfMax = 0;
            T max = array[0];
            for (int i = 1; i < array.Length; ++i)
            {
                if (array[i].CompareTo(max) > 0)
                {

                    max = array[i];
                    indexOfMax = i;
                }
            }
            return indexOfMax;
        }
        public static int IndexOfMin<T>(this T[] array) where T : struct, IComparable<T>
        {
            CheckArray(array);
            int indexOfMax = 0;
            T min = array[0];
            for (int i = 1; i < array.Length; ++i)
            {
                if (array[i].CompareTo(min) < 0)
                {

                    min = array[i];
                    indexOfMax = i;
                }
            }
            return indexOfMax;
        }


    }
}
