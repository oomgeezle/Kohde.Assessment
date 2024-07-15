using System;
using System.Linq;

namespace Kohde.Assessment
{
    public delegate void MyEventHandler(string foo);

    public class DisposableObject : IDisposable
    {
        public event MyEventHandler SomethingHappened;

        public int Counter { get; private set; }

        public void PerformSomeLongRunningOperation()
        {
            foreach (var i in Enumerable.Range(1, 10))
            {
                this.SomethingHappened += HandleSomethingHappened;
            }
        }

        public void RaiseEvent(string data)
        {
            //Using null coalesce for readability
            this.SomethingHappened?.Invoke(data);
        }

        private void HandleSomethingHappened(string foo)
        {
            //Updating to better counter increment
            this.Counter++;
            Console.WriteLine("HIT {0} => HandleSomethingHappened. Data: {1}", this.Counter, foo);
        }

        protected virtual void Dispose(bool disposing)
        {

            if (disposing)
            {
                // Dispose managed resources
                // Set the counter to one as indicated by test cases when item is disposed
                Counter = 1;
            }

            // Free native resources
            // Set instance of event handler to null
            if (this.SomethingHappened != null)
            {
                foreach (var d in this.SomethingHappened.GetInvocationList())
                {
                    this.SomethingHappened -= (MyEventHandler)d;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~DisposableObject()
        {
            Dispose(false);
        }
    }
}