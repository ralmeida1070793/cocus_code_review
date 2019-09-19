using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.InheritedClasses
{
    public class MessageA : AbstractMessage, IMessage
    {
        public override void MyCustomMethod()
        {
            Console.WriteLine("MyCustomMethodOnA");
        }
    }
}
