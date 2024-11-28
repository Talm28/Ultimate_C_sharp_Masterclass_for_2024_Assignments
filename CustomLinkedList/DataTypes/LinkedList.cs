using System.Collections;
using CustomLimkedList.Interfaces;

namespace CustomLimkedList.DataTypes
{
    public class LinkedList<T> : ILinkedList<T?>
    {
        private int _count;
        private Node? _head;

        public LinkedList()
        {
            _count = 0;
            _head = null;
        }

        public int Count => _count;

        public bool IsReadOnly => false;

        public void Add(T? item)
        {
            AddToEnd(item);
        }

        public void AddToEnd(T? item)
        {
            if(_head == null) // The list is empty
            {
                _head = new Node(item);
            }
            else
            {
                Node pointer = _head;
                while(pointer.next != null)
                    pointer = pointer.next;
                pointer.next = new Node(item);
            }
            _count++;
            
        }

        public void AddToFront(T? item)
        {
            Node newHead = new Node(item);
            newHead.next = _head;
            _head = newHead;
            _count++;
        }

        public void Clear()
        {
            // Clear all "next" property of the nodes
            Node? pointer = _head;
            while(pointer != null)
            {
                Node? tmp = pointer.next;
                pointer.next = null;
                pointer = tmp;
            }

            _count = 0;
            _head = null;
        }

        public bool Contains(T? item)
        { 
            Node? pointer = _head;
            while(pointer != null)
            {
                if(item == null && pointer.value == null) return true;
                if(pointer.value != null && pointer.value.Equals(item))
                    return true;
                pointer = pointer.next;
            }
            return false;
        }

        public void CopyTo(T?[] array, int arrayIndex)
        {
            if(array == null || array.Length < _count || arrayIndex >= array.Length || arrayIndex + _count > array.Length)
                throw new ArgumentException("The array cannot be null or there is not enough elements to fit the list.");
            Node? pointer = _head;
            while(pointer != null)
            {
                array[arrayIndex++] = pointer.value;
                pointer = pointer.next;
            }
        }

        public bool Remove(T? item)
        {
            Node? pointer = _head;
            if(pointer == null) return false;
            if((pointer.value == null && item == null) ||
               (pointer.value != null && pointer.value.Equals(item))) // If the item at the start.
            {
                _head = _head.next;
                _count--;
                return true;
            }
            while(pointer.next != null) // Search the list for the item.
            {
                if((pointer.next.value == null && item == null) || 
                   (pointer.next.value != null && pointer.next.value.Equals(item)))
                {
                    pointer.next = pointer.next.next;
                    _count--;
                    return true;
                }
            }
            return false;       
        }

        public IEnumerator<T?> GetEnumerator()
        {
            Node? pointer = _head;
            while( pointer != null)
            {
                yield return pointer.value;
                pointer = pointer.next;
            }
                
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class Node
        {
            public T? value;
            public Node? next;

            public Node(T? value)
            {
                this.value = value;
                next = null;
            }

        }
    }
}