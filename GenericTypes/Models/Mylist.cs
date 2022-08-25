using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTypes.Models
{      
    class Mylist<T>
    {

        private int _count=0;
        private int _capacity=1;
        T[] arr;
        public int Count { get { return _count; } }
        public int Capacity { get { return _capacity; }
            set
            {
                if (value>0)
                {
                    _capacity = value;
                    return;
                }
                throw new IndexOutOfRangeException();
            
            } }
        public Mylist(int capacity)
        {
            Capacity = capacity;
            arr = new T[capacity];

        }

        public T this[int index]
        {
            get
            {
                if (index < arr.Length)
                {
                    return arr[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index < arr.Length)
                {
                    arr[index] = value;
                    return;
                }
                throw new IndexOutOfRangeException();
            }
        }

        public void Add(T value)
        {

            if (_count==arr.Length)
            {
                Array.Resize<T>(ref arr, arr.Length + Capacity);
             

            }
            _count++;
            arr[Count - 1] = value;
            

        }
     


        public int Indexof(T value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (object.Equals(arr[i],value))
                {
                    return i;

                }
            }
            return -1;
             }
        public   int LastIndexof(T value)
        {
            int count = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (object.Equals(value,arr[i]))
                {
                    count = i;
                }
            }
            return count;
        }
        public bool Exist(T value)
        {
            bool exist=false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (object.Equals(value,arr[i]))
                {
                    exist = true;
                }
            }
            return exist;
           
        }
        public void reverse()
        {

            for (int i = 0; i < Count; i++)
            {
                if (i<Count)
                {
                    T temp;
                    T startValue = arr[i];
                    T EndValue = arr[arr.Length - 1 - i];
                    temp = startValue;
                    startValue = EndValue;
                    EndValue = temp;
                }

            }
           

        }
        public void Clear()
        {
            arr = new T[0];
        }
        public void Remove(T value)
        {

            for (int i = Indexof(value); i < arr.Length-1; i++)
            {
                arr[i] = arr[i + 1];

            }
            Array.Resize(ref arr, arr.Length - 1);
            _count--;


        }


    }
}
