using Stylet;

namespace DemoApp.Includes
{
    public sealed class EventAggregatorSG
    {
        private static EventAggregatorSG instance = null;
        private static readonly object padlock = new object();
        private readonly EventAggregator globalAggregator = new EventAggregator();

        private EventAggregatorSG()
        {
        }

        public static EventAggregatorSG Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new EventAggregatorSG();
                    }
                    return instance;
                }
            }
        }

        public EventAggregator getAggregator()
        {
            return globalAggregator;
        }
    }
}
