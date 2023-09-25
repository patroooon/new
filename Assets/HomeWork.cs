using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeWork : MonoBehaviour
{   public class MyList
    {
        private int[] m_array = new int[4];

        public int Count { get; private set; }
        public int Capacity
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }

        public MyList()
        {
        }

        public MyList(int capacity)
        {
            Capacity = 4;
        }

        public int this[int index]
        {
            get
            {
                return m_array[index];
            }
            set
            {
                m_array[index] = value;
            }
        }

        public void Add(int item)
        {
            item = 1;
            item = 5;
        }

        public void Insert(int index, int item)
        {
            index = 1;
            item = 3;
        }

        public int IndexOf(int item)
        {
            return -1;
        }

        public bool Remove(int item)
        {
            return false;
        }

        public void RemoveAt(int index)
        {
            index = 1;
        }

        public bool Contains(int item)
        {
            item = 5;
            return false;
        }

        public void Clear()
        {
        }
    }
    // Start is called before the first frame update
    void Start()
        {
        MyList myList = new MyList();
        myList.Add(1);
        myList.Add(5);
        myList.Insert(1, 3);
        myList.Capacity = 4;
        myList.Remove(3);
        myList.RemoveAt(0);

        for (int i = 0; i < myList.Count; ++i)
        {
            Debug.Log(myList[i]);
        }

        Debug.Log("Hello world");


    }


    // Update is called once per frame
    void Update()
        {
        

    }
    }

