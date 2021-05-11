using System;

namespace ChainOfResponsability
{
    class IPv6Handler : AbstractHandler
    {

        public override object Handle(object request)
        {
            if ((request.ToString()).Substring(0, 4) == "ipv6")
            {
                return $"IPv6: {request.ToString().Substring(5)}";
            }
            else
            {
                return base.Handle(request);
            }
        }

    }
}
