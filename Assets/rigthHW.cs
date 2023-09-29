using OpenCover.Framework.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static rigthHW;

public class rigthHW : MonoBehaviour
{
    public class MyList
    {
        private int[] m_array;
        public int Count { get; private set; }

        public int Capacity
        {
            get { return m_array.Length; }
            set
            {
                if (value > m_array.Length)
                {
                    System.Array.Resize(ref m_array, value);
                }
            }
        }

        public MyList()
        {
            m_array = new int[4];
        }

        public MyList(int capacity)
        {
            m_array = new int[capacity];
        }

        public int this[int index]
        {
            get
            {
                CheckIndexRange(index);
                return m_array[index];
            }
            set
            {
                CheckIndexRange(index);
                m_array[index] = value;
            }
        }

        private bool CheckIndexRange(int index)
        {
            if (index < 0 || index >= Count)
                throw new ArgumentOutOfRangeException();

            return true;
        }

        private void IncreaseCapacityIfNeed()
        {
            if (Count == Capacity)
            {
                Capacity *= 2;
            }
        }

        public void Add(int item)
        {
            IncreaseCapacityIfNeed();

            m_array[Count] = item;
            Count++;
        }

        public void Insert(int index, int item)
        {
            if (index < 0 || index > Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            IncreaseCapacityIfNeed();

            if (index < Count)
            {
                System.Array.Copy(m_array, index, m_array, index + 1, Count - index);
            }

            Count++;
            m_array[index] = item;
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (m_array[i] == item)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool Remove(int item)
        {
            int index = IndexOf(item);
            if (index >= 0)
            {
                RemoveAt(index);
                return true;
            }

            return false;
        }

        public void RemoveAt(int index)
        {
            CheckIndexRange(index);
            Count--;
            if (index < Count)
            {
                System.Array.Copy(m_array, index + 1, m_array, index, Count - index);
            }
        }

        public bool Contains(int item)
        {
            return IndexOf(item) >= 0;
        }

        public void Clear()
        {
            System.Array.Clear(m_array, 0, m_array.Length);
            Count = 0;
        }


    }
    public class MyListG<T>
    {
        private T[] m_array;
        public int Count { get; private set; }

        public int Capacity
        {
            get { return m_array.Length; }
            set
            {
                if (value > m_array.Length)
                {
                    System.Array.Resize(ref m_array, value);
                }
            }
        }

        public MyListG()
        {
            m_array = new T[4];
        }

        public MyListG(int capacity)
        {
            m_array = new T[capacity];
        }

        public T this[int index]
        {
            get
            {
                CheckIndexRange(index);
                return m_array[index];
            }
            set
            {
                CheckIndexRange(index);
                m_array[index] = value;
            }
        }

        private bool CheckIndexRange(int index)
        {
            if (index < 0 || index >= Count)
                throw new ArgumentOutOfRangeException();

            return true;
        }

        private void IncreaseCapacityIfNeed()
        {
            if (Count == Capacity)
            {
                Capacity *= 2;
            }
        }

        public void Add(T item)
        {
            IncreaseCapacityIfNeed();

            m_array[Count] = item;
            Count++;
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index > Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            IncreaseCapacityIfNeed();

            if (index < Count)
            {
                System.Array.Copy(m_array, index, m_array, index + 1, Count - index);
            }

            Count++;
            m_array[index] = item;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (m_array[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index >= 0)
            {
                RemoveAt(index);
                return true;
            }

            return false;
        }

        public void RemoveAt(int index)
        {
            CheckIndexRange(index);
            Count--;
            if (index < Count)
            {
                System.Array.Copy(m_array, index + 1, m_array, index, Count - index);
            }
        }

        public bool Contains(T item)
        {
            return IndexOf(item) >= 0;
        }

        public void Clear()
        {
            System.Array.Clear(m_array, 0, m_array.Length);
            Count = 0;
        }
    }
    private void Start()
    {
        System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();

        MyList MyListG = new MyList();

        for (int i = 0; i<10000000; ++i)
        {
            MyListG.Add(i);
        }
        Debug.Log($"Generic List time {sw.ElapsedMilliseconds}");

        sw = System.Diagnostics.Stopwatch.StartNew();

        MyList MyList = new MyList();

        for (int i = 0; i < 10000000; ++i)
        {
            MyList.Add(i);
        }
        Debug.Log($"List time {sw.ElapsedMilliseconds}");

    }

}
