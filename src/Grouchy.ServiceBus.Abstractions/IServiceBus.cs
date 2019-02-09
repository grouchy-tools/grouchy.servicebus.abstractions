using System;
using System.Threading.Tasks;

namespace Grouchy.ServiceBus.Abstractions
{
   public interface IServiceBus : IDisposable
   {
      Task Publish<TMessage>(TMessage message) where TMessage : class;

      IMessageSubscription Subscribe<TMessage, TMessageHandler>(TMessageHandler messageHandler)
         where TMessage : class
         where TMessageHandler : class, IMessageHandler<TMessage>;
   }
}