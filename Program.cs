
using ASSI_2_C__ADVANCED;
using System.Collections;

internal class prog
    {
    static void Main(string[] args)
    {
        #region part 1

        // non generic colliction => array list (Heterogeneous) : have (hashcode,lists) , count , capacity , 
        // generic collection => list (dynamic size , Homogeneous) : have (hashcode,lists) , fast to retrive
        // => linkedlist (dynamic size , Homogeneous) : have nodes , fast to add
        // queue : first in first out
        //stack : last in first out
        #endregion

        #region part 2
        #region q1
     static void rev( ArrayList arrayList)
    {
        object temp;
        int end = arrayList.Count;
        for (int i = 0; i < arrayList.Count / 2; i++)
        {
            temp = arrayList[i];
            arrayList[i] = arrayList[end - 1];
            arrayList[end - 1] = temp;
            end--;
        }
    }
      
        ArrayList arr1 = new ArrayList();
        arr1.AddRange(new int [] {1, 2, 3});
        foreach (int item in arr1)
        {
        Console.WriteLine(item);
        }
        rev(arr1);
        Console.WriteLine("after reverse");
        foreach (int item in arr1)
        {
            Console.WriteLine(item);
        }
        #endregion
        #region q2
        Console.WriteLine("=======================");
        static List<int> even_num(List<int> l1)
        {
            int counter = 0;
            List<int> l2 = new List<int>() ;
            while (counter < l1.Count)
            {
                if (l1[counter] %2 ==0)
                {
                    l2.Add ( l1[counter]);
                }
                counter++;
            }
            return l2;
        }
        List <int> list = new List<int>() { 1,2 ,3,4,5,6,7,8,9,10,11,12};
        List<int> l = even_num(list); 
        foreach (int item in l)
        {
            Console.WriteLine(item);
        }

        #region q3
        fixedsizelist<int> list1 = new fixedsizelist<int>(5);
        list1.add(1);
        list1.add (2);
        list1.add(3);
        list1.add(4);
        list1.add(5);
        list1.get(0);
        list1.get(5);
        #endregion

        #endregion

        #endregion


    }
}
