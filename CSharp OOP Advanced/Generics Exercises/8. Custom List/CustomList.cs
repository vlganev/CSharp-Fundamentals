using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List
{
    public class CustomList<T> : ICustomList<T>, IEnumerable<T>
        where T : IComparable<T>
    {
        private readonly IList<T> elements;

        public IList<T> Elements { get => elements; }
        public CustomList() 
            : this(Enumerable.Empty<T>())
        {
        }

        public CustomList(IEnumerable<T> collection)
        {
            this.elements = new List<T>(collection);
        }

        public void Add(T element) => this.elements.Add(element);
        public T Remove(int index)
        {
            T temp = this.elements[index];
            this.elements.RemoveAt(index);
            return temp;
        }

        public bool Contains(T element)
        {
            return this.elements.Contains(element);
        }

        public void Swap(int index1, int index2)
        {
            T temp = this.elements[index1];
            this.elements[index1] = this.elements[index2];
            this.elements[index2] = temp;
        }

        public int CountGreaterThan(T element)
        {
            int count = 0;
            for (int i = 0; i < this.elements.Count; i++)
            {
                if (this.elements[i].CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }

        public T Max()
        {
            return this.elements.Max();
        }

        public T Min()
        {
            return this.elements.Min();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var element in this.elements)
            {
                sb.AppendLine(element.ToString());
            }
            return sb.ToString().Trim();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
