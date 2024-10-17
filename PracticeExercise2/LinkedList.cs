using System;
namespace PracticeExercise2
{

    public class LinkedListNode<T>
    {
        public T Data { get; set; }
        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode(T data = default(T), LinkedListNode<T> next = null)
        {
            Data = data;
            Next = next;
        }

        public override string ToString()
        {
            return Data.ToString();
        }

    }


	public class LinkedList<T> : IList<T>
	{
       
        public LinkedList()
		{

		}

        // TODO
        /// <summary>
        /// Returns first element in list, null if empty.
        /// </summary>
        public T? First;

        // TODO
        /// <summary>
        /// Returns last element in list, null if empty.
        /// </summary>
        public T? Last;

        // TODO
        /// <summary>
        /// Returns true if list is has no elements; false otherwise.
        /// </summary>
        public bool IsEmpty;

        /// <summary>
        /// Number of elements in list.
        /// </summary>
        public int Length
        {
            get;
            private set;
        }


        // TODO 
        /// <summary>
        /// Adds given item to end of list.
        /// </summary>
        /// <param name="item">item to add to the list</param>
        public void Append(T item)
        {
           
        }

        /// <summary>
        /// Remove all elements from list
        /// </summary>
        public void Clear()
        {
           
        }

        /// <summary>
        /// Checks if the list contains the given value.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>true if item is in list; false otherwise</returns>
        public bool Contains(T item)
        {
            return false;
        }

        // TODO
        /// <summary>
        /// Find index of first element with matching value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Index of first element with value; -1 if element is not found</returns>
        public int FirstIndexOf(T item)
        {
            
        }

        /// <summary>
        /// Return the element at the given index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>The element at the given index.</returns>
        public T Get(int index)
        {
            return default;
        }

        // TODO
        /// <summary>
        /// Insert new value after first instance of existing value.
        /// If existingValue is not in list, then add new value to end of list.
        /// </summary>
        /// <param name="newValue"></param>
        /// <param name="existingValue"></param>
        public void InsertAfter(T newItem, T existingItem)
        {
        }

        // TODO
        /// <summary>
        /// Insert value at given index 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="index"></param>
        public void InsertAt(T item, int index)
        {
        }

        // TODO
        /// <summary>
        /// Add value to beginning of list
        /// </summary>
        /// <param name="value"></param>
        public void Prepend(T item)
        {
        }

        // TODO
        /// <summary>
        /// Remove first item with given value
        /// </summary>
        /// <param name="value">value of item to be removed</param>
        public void Remove(T item)
        {

        }

        // TODO
        /// <summary>
        /// Remove item at specififed index.
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
        }

        // TODO
        /// <summary>
        /// Return a new copy of list in reverse order
        /// </summary>
        /// <returns></returns>
        public IList<T> Reverse()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string str = "[ ";

            var currentNode = Head;

            while(currentNode != null)
            {
                str += currentNode.Data.ToString();

                if (currentNode != Tail)
                {
                    str += ", ";
                }

                currentNode = currentNode.Next;
            }

            str += "]";

            return str;
        }
    }
}

