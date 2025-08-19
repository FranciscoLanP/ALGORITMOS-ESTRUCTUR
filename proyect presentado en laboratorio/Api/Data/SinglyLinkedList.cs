using System;
using System.Collections.Generic;

namespace Api.Data
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T>? Next { get; set; }
        public Node(T value) { Value = value; Next = null; }
    }

    public class SinglyLinkedList<T>
    {
        private Node<T>? head;

        public void Add(T value)
        {
            var newNode = new Node<T>(value);
            if (head == null) head = newNode;
            else
            {
                var curr = head;
                while (curr.Next != null) curr = curr.Next;
                curr.Next = newNode;
            }
        }

        public bool Remove(Predicate<T> match)
        {
            Node<T>? curr = head, prev = null;
            while (curr != null)
            {
                if (match(curr.Value))
                {
                    if (prev == null) head = curr.Next;
                    else prev.Next = curr.Next;
                    return true;
                }
                prev = curr;
                curr = curr.Next;
            }
            return false;
        }

        public T? Find(Predicate<T> match)
        {
            var curr = head;
            while (curr != null)
            {
                if (match(curr.Value)) return curr.Value;
                curr = curr.Next;
            }
            return default;
        }

        public List<T> ToList()
        {
            var list = new List<T>();
            var curr = head;
            while (curr != null)
            {
                list.Add(curr.Value);
                curr = curr.Next;
            }
            return list;
        }
    }
}
