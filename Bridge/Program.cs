﻿using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IMessageSender email = new EmailSender();
                IMessageSender queue = new MSMQSender();
                IMessageSender web = new WebServiceSender();

                Message message = new SystemMessage();
                message.Subject = "Test Message";
                message.Body = "Hi, This is a Test Message";

                message.MessageSender = email;
                message.Send();

                message.MessageSender = queue;
                message.Send();

                message.MessageSender = web;
                message.Send();

                UserMessage usermsg = new UserMessage();
                usermsg.Subject = "Test Message";
                usermsg.Body = "Hi, This is a Test Message";
                usermsg.UserComments = "I hope you are well";

                usermsg.MessageSender = email;
                usermsg.Send();
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
