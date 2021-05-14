using System;
using System.Collections.Generic;


namespace ChainOfResponsability
{
    class Client
    {

        public static void ClientCode(AbstractHandler handler)
        {
            List<string> ipList = new List<string> { "IPv4/192.168.1.1/Up", "ipv6/fe80::1/Down", "ipv6/fe80::2/Up", "ipv4/172.16.1.1/Up", "ipv5/undefined/Down" };

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
