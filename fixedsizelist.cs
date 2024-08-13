using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSI_2_C__ADVANCED
{
    internal class fixedsizelist <T>
    {

        

        public fixedsizelist(int capacity)
        {
            this.capacity = capacity;
            list = new List<T>(capacity);
        }
       public int capacity {  get; set; }
       public List<T> list { get; set; }
        public void add(T item)
        {
            if (list.Count >= capacity) {
                throw new Exception(" list is full");
            }
            else
            {

            list.Add(item); 
            }
        }
        public void get(int index)
        {
            try
        {
                Console.WriteLine($"{list[index]}");
        }
            catch { throw new Exception("invalid"); }
        }
    }
}
