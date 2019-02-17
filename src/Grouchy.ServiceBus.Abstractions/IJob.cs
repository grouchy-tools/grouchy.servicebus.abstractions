namespace Grouchy.ServiceBus.Abstractions
{
   using System.Threading;
   using System.Threading.Tasks;

   public interface IJob
   {
      Task RunAsync(CancellationToken cancellationToken);
   }
}