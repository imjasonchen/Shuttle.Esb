using System;

namespace Shuttle.Esb
{
    public class QueueFactoryNotFoundException : Exception
    {
        public QueueFactoryNotFoundException(string scheme)
            : base(string.Format(ESBResources.QueueFactoryNotFoundException, scheme))
        {
        }
    }
}