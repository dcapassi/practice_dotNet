using System;
using System.Collections.Generic;


namespace ChainOfResponsability
{
    class Client
    {

        public static void ClientCode(AbstractHandler handler)
        {
            List<string> ipList = new List<string> { "ipv4/192.168.1.1", "ipv6/fe80::1", "ipv6/fe80::2", "ipv4/172.16.1.1", "ipv5/undefined" };

            foreach (var ip in ipList)
            {

                var result = handler.Handle(ip);

                if (result != null)
                {
                    Console.WriteLine($"{result}");
                }
                else
                {
                    Console.WriteLine($"{ip} was left untouched.");
                }

            }



        }


    }
}
