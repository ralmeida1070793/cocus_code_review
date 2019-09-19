using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.InheritedClasses
{
    public class MessageB : AbstractMessage, IMessage
    {
        public override void MyCustomMethod()
        {
            Console.WriteLine("MyCustomMethodOnB");
            SomeAdditionalMethodOnB();
        }

        private void SomeAdditionalMethodOnB()
        {
            Console.WriteLine("SomeAdditionalMethodOnB");
        }
    }
}
