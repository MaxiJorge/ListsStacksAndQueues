
namespace Common
{
    public class GenericStack<T> : IPushPop<T>
    {
        //TODO #1: Declare a List inside this object class to store the objects. Choose the most appropriate object class
        GenericList<T> Stack = new GenericList<T>();
        public string AsString()
        {
            //TODO #2: Return the list as a string. Use the method already implemented in your list
            return Stack.ToString();
        }

        public int Count()
        {
            //TODO #3: Return the number of objects
            return Stack.Count();
        }

        public void Clear()
        {
            //TODO #4: Remove all objects stored
            Stack.Clear();
        }

        public void Push(T value)
        {
            //TODO #5: Add a new object to the list (at the end of it)
            Stack.Add(value);
        }

        public T Pop()
        {
            //TODO #6: Remove the last object of the list and return it
            T pop = Stack.Get(Stack.Count() - 1);
            Stack.Remove(Stack.Count() - 1);

            return pop;
        }
    }
}
