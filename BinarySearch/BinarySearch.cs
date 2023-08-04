using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public static class BinarySearch
    {
        public static int SearchBinary(int[] array, int searchedValue, int first, int last)
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
                    return SearchBinary(array, searchedValue, first, middle-1);
                }
                else
                {
                    return SearchBinary(array, searchedValue, middle + 1, last);
                }
            }
        }
    }
}
