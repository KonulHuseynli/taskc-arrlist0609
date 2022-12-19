using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Programt
    {
        static void Main(string[] args)
        {

          

            ArrayList arr = new ArrayList(3);
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
    class ArrayList : IAddRangeable, IRemoveable, IRemoveAtable, ITrimable, IAbles, IEnumerable
    {

        public int Capacity { get; set; }
        public int Count { get; set; }

        public object[] arr;

        public ArrayList(int capacity)
        {
            arr = new object[capacity];

        }

        public void RemoveAt(int index)
        {

            for (int i = index; index < arr.Length - 1; index++)
            {
                arr[index] = arr[index + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);

        }

        public void Remove(object? obj)
        {

            foreach (var item in arr)
            {
                if (obj == item)
                {
                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        arr[i] = arr[i + 1];
                    }
                }
            }
            Array.Resize(ref arr, arr.Length - 1);

        }
        public void Add(object value)
        {



        }

        public void Trim()
        {
            

        }

        public void AddRange(ICollection c)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < c.Count; j++)
                {
                    Array.Resize(ref arr, j);
                    c.CopyTo(arr, i);
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return arr.GetEnumerator();
        }

        

        

        
       
    }
}


