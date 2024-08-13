namespace demo_c__advanced

{
    internal class prog
    {
        static int sumlist(List<int> num)
        {
            int sum = 0;
            foreach (int item in num)
            {
                sum += item;
            }
            return sum;
        }


        static void Main(string[] args)
        {
            #region generic
            //List<int> num = new List<int>();
            //Console.WriteLine($" count = {num.Count}");
            //Console.WriteLine($"capacity = {num.Capacity}");
            //num.Add(1);
            //num.Add(2);
            //num.Add(3);
            //num.Add(4);
            //num.Add(5);
            //num.Add(4);
            //num.AddRange([1, 2, 3]);
            //num.TrimExcess();
            //Console.WriteLine($" count = {num.Count}");
            //Console.WriteLine($"capacity = {num.Capacity}");
            //foreach(int item in num)
            //{
            //    Console.Write(item);    
            //}
            //Console.WriteLine("=====================");
            //int res= sumlist(num);
            //Console.WriteLine(res);
            //num.Insert(3, 6);
            //foreach (int item in num)
            //{
            //    Console.Write(item);
            //}
            //Console.WriteLine("==========");
            //Console.WriteLine(num.IndexOf(3));
            //num.Remove(3);
            //foreach (int item in num)
            //{
            //    Console.Write(item);
            //}
            //LinkedList<int> linked = new LinkedList<int>();
            //linked.AddFirst(1);
            //linked.AddLast(2);
            //foreach(int item in linked)
            //{
            //    Console.WriteLine(item);
            //}
            //LinkedListNode <int> x = linked.Find(1);
            //linked.AddAfter(x, 10);
            //Console.WriteLine("==================");
            //foreach (int item in linked)
            //{
            //    Console.WriteLine(item);
            //}
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Pop();
            #endregion
        }
    }
}