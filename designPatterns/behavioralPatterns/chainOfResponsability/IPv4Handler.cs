using System;

namespace ChainOfResponsability
{
    class IPv4Handler : AbstractHandler
    {

        public override object Handle(object request)
        {
            if ((request.ToString()).Substring(0, 4) == "ipv4")
            {
                return $"IPv4: {request.ToString().Split('/')[1]} status:{request.ToString().Split('/')[2]}";
            }
            else
            {
                return base.Handle(request);
            }
        }

    }
}
