using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class MotivationGenericMethodsTests
    {
        public class ObjectStack
        {
            int position;
            object[] data = new object[10];
            public void Push(object obj) => data[position++] = obj;
            public object Pop() => data[--position];
        }

        //Converting the above code to generic ( type T )
        public class Stack<T>
        {
            int position;
            T[] data = new T[10];
            public void Push(T obj)
            {
                data[position++] = obj;
            }

            public T Pop()
            {
                return data[--position];
            }
        }

        [TestMethod]
        [ExpectedException(typeof(System.InvalidCastException))]
        public void InvalidCastExceptionTest()
        {
            // Now suppose we want a stack that stores just integers:
            ObjectStack stack = new ObjectStack();

            // It's easy to make mistakes:
            stack.Push("s");          // Wrong type, but no error!
            int i = (int)stack.Pop();  // Downcast - runtime error!
        }

        [TestMethod]
        public void StackTest()
        {
            // Now suppose we want a stack that stores just integers:
            var stack = new Stack<int>();

            // It's easy to make mistakes:
            stack.Push(1);          // Wrong type, but no error!
            var i = (int)stack.Pop();  // Downcast - runtime error!

            Assert.AreEqual(1, 1);
        }
    }
}
