

#region Task1

/*
int number1 = 5;
int number2 = 10;
Swap(ref number1, ref number2);

Console.WriteLine(number1);
Console.WriteLine(number2);


void Swap<T>(ref T num1, ref T num2)
{
    T tmp = num1;
    num1 = num2;
    num2 = tmp;
}*/

#endregion

#region Task2

/*
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Channels;


IntCompare intCompare = new IntCompare();
PriorityQueue<int> priorityQueue = new PriorityQueue<int>(intCompare);

priorityQueue.Enqueue(50);
priorityQueue.Enqueue(3);
priorityQueue.Enqueue(390);
priorityQueue.Enqueue(39);


while (priorityQueue.Count > 0)
{
    Console.WriteLine(priorityQueue.Dequeue());
}


    
class PriorityQueue<T>
{
    private List<T> data;
    private IComparer<T> _comparer;
    

    public PriorityQueue(IComparer<T> comparer)
    {
        data = new List<T>();
        _comparer = comparer;
    }

    public void Enqueue(T item)
    {
        data.Add(item);
        int childIndex = data.Count - 1;

        for (int i = 0; i < data.Count(); i++)
        {
            int parentIndex = (childIndex - 1) / 2;
            if (_comparer.Compare(data[childIndex], data[parentIndex]) >= 0)
                break;
            Swap(childIndex, parentIndex);
            childIndex = parentIndex;
        }
    }

    public T Dequeue()
    {
        int lastIndex = data.Count - 1;
        T frontItem = data[0];
        data[0] = data[lastIndex];
        data.RemoveAt(lastIndex);

        lastIndex--;
        int parentIndex = 0;

        while (true)
        {
            int leftChildIndex = parentIndex * 2 + 1;
            if (leftChildIndex > lastIndex)
                break;

            int rightChildIndex = leftChildIndex + 1;
            if (rightChildIndex <= lastIndex && _comparer.Compare(data[leftChildIndex], data[rightChildIndex]) > 0)
                leftChildIndex = rightChildIndex;

            if (_comparer.Compare(data[parentIndex], data[leftChildIndex]) <= 0)
                break;

            Swap(parentIndex, leftChildIndex);
            parentIndex = leftChildIndex;
        }
        return frontItem;
    }

    public int Count
    {
        get { return data.Count; }
    }

    private void Swap(int index1, int index2)
    {
        T temp = data[index1];
        data[index1] = data[index2];
        data[index2] = temp;
    }
}


class IntCompare : IComparer<int>
{
    public int Compare(int x, int y)
    {
        if (x < y)
            return -1;
        if (x > y)
            return 1;
        return 0;
    }
    
    
}
*/


#endregion

#region Task3



/*
using System;

CircularQueue<int> circularQueue = new CircularQueue<int>(3);

circularQueue.Add(30);
circularQueue.Add(10);
circularQueue.Add(7);

circularQueue.Move();


public class CircularQueue<T>
{
    private T[] queue;     
    private int count;    
    private int maxCount;  

    public CircularQueue(int _maxCount)
    {
        maxCount = _maxCount;
        queue = new T[maxCount]; 
        count = 0;              
    }

    public void Clear()
    {
        count = 0;
    }

    public bool IsEmpty()
    {
        return count == 0;
    }

    public int Count()
    {
        return count;
    }

    public bool IsFull()
    {
        return count == maxCount;
    }

    public void Add(T item)
    {
        if (!IsFull()) 
            queue[count++] = item;
    }

    public bool Move()
    {
        if (!IsEmpty()) 
        {
            T item = queue[0];

            for (int i = 1; i < count; i++)
                queue[i - 1] = queue[i];

            queue[count - 1] = item;
            return true;
        }
        else
            return false;
    }
    
    
}
*/





#endregion


#region Task4

/*
using System.Collections;
using System.Text;
using System.Threading.Channels;
using Microsoft.VisualBasic.CompilerServices;

LinkedList<int> linkedList = new LinkedList<int>();
linkedList.Add(10);
linkedList.Add(15);
linkedList.Add(20);



linkedList.Print();
Console.WriteLine();

linkedList.AppendFirst(5);
linkedList.Print();

Console.WriteLine();
Console.WriteLine(linkedList.Lenght());

linkedList.Clear();
linkedList.Add(90);
Console.WriteLine(linkedList.Lenght());


LinkedList<int> list = new LinkedList<int>();

class LinkedList<T>
{
    class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }
    
    private Node<T> Head;
    private Node<T> Tail;
    private int _size;

    public void Add(T data)
    {
        Node<T> newNode = new Node<T>(data);
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail.Next = newNode;
        }
        Tail = newNode; 
        _size++;
    }
    public void Delete(T data)
    {
        Node<T> current = Head;
        Node<T> previous = null;
        while (current != null)
        {
            if (current.Data.Equals(data))
            {
                if (previous != null)
                {
                    previous.Next = current.Next;
                    if (current.Next == null)
                        Tail = previous;
                }
                else
                {
                    Head = Head.Next;
                    if (Head == null)
                        Tail = null;
                }

                _size--;
            }

            previous = current;
            current = current.Next;
        }
    }

    public int Lenght()
    {
        return _size;
    }


    public void Centains(T data)
    {
        Node<T> current = Head;
        while (current!= null)
        {
            if (current.Data.Equals(data))
            {
                Console.WriteLine(current.Data);
                break;
            }

            current = current.Next;
        }
    }

    public void AppendFirst(T data)
    {
        Node<T> newNode = new Node<T>(data);
        Node<T> current = Head;

        
        Head = newNode;
        Head.Next = current;
        _size++;
    }

    public void Clear()
    {
        Head = null;
        Tail = null;
        _size = 0;
    }
    

    public void Print()
    {
        Node<T> current = Head;

        while (current!=null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }
    }
    

}
*/


#endregion

#region Task5

/*
DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
doubleLinkedList.Add(10);
doubleLinkedList.Add(12);
doubleLinkedList.Add(19);
doubleLinkedList.Add(30);

doubleLinkedList.Print();
Console.WriteLine();
doubleLinkedList.Remove(19);
doubleLinkedList.Print();
Console.WriteLine(doubleLinkedList.Size());
Console.WriteLine();
doubleLinkedList.AddFirst(5);
doubleLinkedList.Print();


class Node<T>
{
    public T Data;
    public Node<T> prev;
    public Node<T> next;

    public Node(T data)
    {
        Data = data;
        prev = null;
        next = null;
    }
}

class DoubleLinkedList<T>
{
    private Node<T> Head;
    private Node<T> Tail;
    private int _size;


    public void Add(T data)
    {
        Node<T> newNode = new Node<T>(data);
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail.next = newNode;
            newNode.prev = Tail;
        }

        Tail = newNode;
        _size++;
    }

    public void Remove(T data)
    {
        Node<T> current = Head;
        Node<T> previous = null;

        while (current != null)
        {
            if (current.Data.Equals(data))
            {
                break;
            }

            current = current.next;
        }

        if (current != null)
        {
            if (current.next != null)
            {
                current.next.prev = current.prev;
            }
            else
            {
                Tail = current.prev;
            }

            if (current.prev != null)
            {
                current.prev.next = current.next;
            }
            else
            {
                Head = current.next;
            }

            _size--;
        }
        
        
    }

    public int Size() => _size;
    public void Print()
    {
        Node<T> current = Head;
        while (current != null)
        {
            Console.WriteLine(current.Data);
            current = current.next;
        }
    }

    public void Clear()
    {
        Head = null;
        Tail = null;
        _size = 0;
    }

    public bool Contains(T data)
    {
        Node<T> current = Head;
        while (current != null)
        {
            if (current.Data.Equals(data))
            {
                return true;
            }

            current = current.next;
        }

        return false;
    }

    public void AddFirst(T data)
    {
        Node<T> newNode = new Node<T>(data);
        Node<T> current = Head;

        newNode.next = current;
        Head = newNode;
    }
    
    

}
*/

#endregion
