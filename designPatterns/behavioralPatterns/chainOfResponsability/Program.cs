using System;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            var myLowerCaseHandler = new LowerCaseHandler();
            var myIpv4Handler = new IPv4Handler();
            var myIpv6Handler = new IPv6Handler();

            myLowerCaseHandler.SetNextHandler(myIpv4Handler).SetNextHandler(myIpv6Handler);
            Client.ClientCode(myLowerCaseHandler);
        }
    }
}
