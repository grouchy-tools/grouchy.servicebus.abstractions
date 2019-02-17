namespace Grouchy.ServiceBus.Abstractions
{
   using System;

   [AttributeUsage(AttributeTargets.Class)]
   public class QueueNameAttribute : Attribute
   {
      public string Name { get; }

      public QueueNameAttribute(string name)
      {
         Name = name;
      }
   }
}
