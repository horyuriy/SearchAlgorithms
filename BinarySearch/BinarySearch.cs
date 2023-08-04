using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public static class BinarySearch
    {
        public static int SearchBinaryRecursive(int[] array, int searchedValue, int first, int last)
        {
            if (first > last)
            {
                return -1;
            }
            var middle = (first + last) / 2;
            var middleValue = array[middle];
            if(middleValue == searchedValue)
            {
                return array[middleValue];
            }
            else
            {
                if( middleValue >searchedValue)
                {
                    return SearchBinaryRecursive(array, searchedValue, first, middle-1);
                }
                else
                {
                    return SearchBinaryRecursive(array, searchedValue, middle + 1, last);
                }
            }
        }
        public static int SearchBinaryItetative(int[] array, int searchedValue, int left, int right)
        {
            while(left<=right)
            {
                var middle = (left + right) / 2;
                if(searchedValue == array[middle])
                {
                    return middle;
                }
                else if( searchedValue < array[middle])
                {
                    right = middle -1 ;

                }
                else
                {
                    left = middle + 1 ;
                }
            }
            return -1;
        }
    }
}
