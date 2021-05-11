using System;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {

            var myIpv4Handler = new IPv4Handler();
            var myIpv6Handler = new IPv6Handler();

            myIpv4Handler.SetNextHandler(myIpv6Handler);
            Client.ClientCode(myIpv4Handler);
        }
    }
}
