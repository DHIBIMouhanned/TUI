﻿using System;

namespace TUI.Test2
{
    public class Program
    {
        static void Main(string[] args)
        {
            object message = new MessageA();
            if (message.GetType() == typeof(MessageA))
            {
                var messageA = message as MessageA;
                messageA?.MyCustomMethodOnA();
            }
            else if (message.GetType() == typeof(MessageB))
            {
                var messageB = message as MessageB;
                messageB?.MyCustomMethodOnB();
                messageB?.SomeAdditionalMethodOnB();
            }
            else if (message.GetType() == typeof(MessageB))
            {
                var messageC = message as MessageC;
                messageC?.MyCustomMethodOnC();
            }
            Console.ReadLine();
        }

        //static void Main(string[] args)
        //{
        //    var sCoord = new GeoCoordinate(48.750000, 2.4);
        //    var eCoord = new GeoCoordinate(36.8, 10.16);

        //    var test= sCoord.GetDistanceTo(eCoord);

        //    object message = new MessageA();
        //    Console.WriteLine("Start");
        //    if (message is MessageA)
        //    {
        //        var messageA = message as MessageA;
        //        messageA = null;
        //        messageA?.MyCustomMethodOnA();
        //    }
        //    else if (message is MessageB)
        //    {
        //        var messageB = message as MessageB;
        //        messageB?.MyCustomMethodOnB();
        //        messageB?.SomeAdditionalMethodOnB();
        //    }
        //    else if (message is MessageC)
        //    {
        //        var messageC = message as MessageC;
        //        messageC?.MyCustomMethodOnC();
        //    }
        //    Console.ReadLine();
        //}

    }
}
