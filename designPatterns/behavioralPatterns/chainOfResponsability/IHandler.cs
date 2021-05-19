using System;

namespace ChainOfResponsability
{
    interface IHandler
    {
        public IHandler SetNextHandler(IHandler handler);
        public object Handle(object request);
    }
}
