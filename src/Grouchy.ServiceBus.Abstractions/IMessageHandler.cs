namespace Grouchy.ServiceBus.Abstractions
{
   using System.Threading.Tasks;

   public interface IMessageHandler<in TMessage>
      where TMessage : class
   {
      Task Handle(TMessage message);
   }
}