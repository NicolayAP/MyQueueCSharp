using System;
    public class MyQueue<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public void Enqueue(T item)
        {
            Node<T> node = new Node<T>(item);
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.setNext(node);
                tail = node;
            }
               
        }


        public T Dequeue()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            T data = head.getData();
            head = head.getNext();

            if (head == null)
            {
                tail = null;
            }
            return data;
        }

        public T Peek()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            return head.getData();
        }

        public bool IsEmpty()
        {
            return head == null;
        }
    }
