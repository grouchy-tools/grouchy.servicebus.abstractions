namespace Grouchy.ServiceBus.Abstractions
{
   using System.Threading;
   using System.Threading.Tasks;

   public interface IMessageHandler<in TMessage>
      where TMessage : class
   {
      Task HandleAsync(TMessage message, CancellationToken cancellationToken);
   }
}