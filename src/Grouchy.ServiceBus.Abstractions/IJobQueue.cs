namespace Grouchy.ServiceBus.Abstractions
{
   using System.Threading;
   using System.Threading.Tasks;

   public interface IJobQueue
   {
      void Enqueue(IJob job);

      Task<IJob> DequeueAsync(CancellationToken cancellationToken);
   }
}