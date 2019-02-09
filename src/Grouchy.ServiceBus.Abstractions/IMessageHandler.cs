using System.Threading.Tasks;

namespace Grouchy.ServiceBus.Abstractions
{
   public interface IMessageHandler<in TMessage>
      where TMessage : class
   {
      Task Handle(TMessage message);
   }
}