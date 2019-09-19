using ConsoleApp1.IndependentClasses;
using ConsoleApp1.InheritedClasses;
using System;

namespace ConsoleApp1
{
    class Program
    {
        private static void executeIndependants(object message)
        {
            if (message is IndependentClasses.MessageA)
            {
                var messageA = message as IndependentClasses.MessageA;
                messageA?.MyCustomMethodOnA();
            }
            else if (message is IndependentClasses.MessageB)
            {
                var messageB = message as IndependentClasses.MessageB;
                messageB?.MyCustomMethodOnB();
                messageB?.SomeAdditionalMethodOnB();
            }
            else if (message is IndependentClasses.MessageC)
            {
                var messageC = message as IndependentClasses.MessageC;
                messageC?.MyCustomMethodOnC();
            }
        }

        private static void executeInherited(IMessage message)
        {
            message.MyCustomMethod();
        }
        static void Main(string[] args)
        {
            executeIndependants(new IndependentClasses.MessageA());
            executeInherited(new InheritedClasses.MessageA());

            executeIndependants(new IndependentClasses.MessageB());
            executeInherited(new InheritedClasses.MessageB());

            executeIndependants(new IndependentClasses.MessageC());
            executeInherited(new InheritedClasses.MessageC());

            Console.Write("Press any key to close...");
            Console.ReadKey();
        }
    }
}
