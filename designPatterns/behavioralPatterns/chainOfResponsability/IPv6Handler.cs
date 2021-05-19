using System;

namespace ChainOfResponsability
{
    class IPv6Handler : AbstractHandler
    {

        public override object Handle(object request)
        {
            if ((request.ToString()).Substring(0, 4) == "ipv6")
            {
                return $"IPv6: {request.ToString().Split('/')[1]} status:{request.ToString().Split('/')[2]}";
            }
            else
            {
                return base.Handle(request);
            }
        }

    }
}
