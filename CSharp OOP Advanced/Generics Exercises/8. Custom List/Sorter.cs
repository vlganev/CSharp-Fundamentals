using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List
{
    public class Sorter
    {
        public static CustomList<T> Sort<T>(CustomList<T> customList)
            where T : IComparable<T>
        {
            var temp = customList.Elements.OrderBy(x => x);
            return new CustomList<T>(temp);
        } 
    }
}
