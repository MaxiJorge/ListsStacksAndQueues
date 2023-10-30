using System.Collections;
using System.Collections.Generic;

namespace Common
{

    public class GenericQueue<T> : IPushPop<T>
    {
        //TODO #1: Declare a List inside this object class to store the objects. Choose the most appropriate object class
        private GenericList<T> queue = new GenericList<T>();

        public string AsString()
        {
            //TODO #2: Return the list as a string. Use the method already implemented in your list
            return queue.ToString();
        }

        public int Count()
        {
            //TODO #3: Return the number of objects
            return queue.Count();
        }

        public void Clear()
        {
            //TODO #4: Remove all objects stored
            queue.Clear();
        }

        public void Push(T value)
        {
            //TODO #5: Add a new object to the list (at the end of it)
            queue.Add(value);
        }

        public T Pop()
        {
            //TODO #6: Remove the first object of the list and return it
            
         T pop = queue.Get(0);
         queue.Remove(0);
         return pop;
        }
    }
}
