namespace Grouchy.ServiceBus.Abstractions
{
   using System;
   using System.Threading.Tasks;

   public interface IServiceBus : IDisposable
   {
      Task Publish<TMessage>(TMessage message) where TMessage : class;

      IMessageSubscription Subscribe<TMessage>(IMessageHandler<TMessage> messageHandler)
         where TMessage : class;
   }
}