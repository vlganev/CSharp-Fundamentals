using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Scale<T>
    where T : IComparable<T>
{
    private T first;
    private T second;

    public Scale(T first, T second)
    {
        this.first = first;
        this.second = second;
    }

    public T GetHeavier()
    {
        if (this.first.CompareTo(this.second) > 0)
        {
            return this.first;
        }
        else if (this.first.CompareTo(this.second) < 0)
        {
            return this.second;
        }
        return default(T);
    }
}