namespace Grouchy.ServiceBus.Abstractions
{
   using System;

   [AttributeUsage(AttributeTargets.Class)]
   public class MessageNameAttribute : Attribute
   {
      public string Name { get; }

      public MessageNameAttribute(string name)
      {
         Name = name;
      }
   }
}
