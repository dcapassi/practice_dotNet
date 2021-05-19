using System;

namespace ChainOfResponsability
{
    class LowerCaseHandler : AbstractHandler
    {

        public override object Handle(object request)
        {
            return base.Handle(request.ToString().ToLower());
        }

    }
}
