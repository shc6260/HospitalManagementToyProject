using System;

namespace ToyProject.Core.Helper
{
    public class EventBus
    {
        private static readonly EventBus _instance = new EventBus();
        public static EventBus Instance => _instance;

        private EventBus() { }

        private event EventHandler<EventArgs> Published;

        public void Publish(EventArgs args)
        {
            Published?.Invoke(this, args);
        }

        public void Subscribe(EventHandler<EventArgs> handler)
        {
            Published += handler;
        }

        public void Unsubscribe(EventHandler<EventArgs> handler)
        {
            Published -= handler;
        }
    }
}
