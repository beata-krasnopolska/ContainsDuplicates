using System;
using System.Collections.Generic;

namespace FindDuplicate
{
    class IsDuplicate : Interface1
    {
        public bool containsDuplicates(int[] a)
        {
            var length = a.Length;

            HashSet<int> hSet = new HashSet<int>(a);
            var hashLength = hSet.Count;

            if (length == hashLength)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
