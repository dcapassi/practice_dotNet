using System;

namespace ChainOfResponsability
{
    class AbstractHandler : IHandler
    {

        private IHandler nextHandler;

        public IHandler SetNextHandler(IHandler handler)
        {
            nextHandler = handler;
            return handler;
        }

        public virtual object Handle(object request)
        {
            if (nextHandler != null)
            {
                return nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }

    }
}
