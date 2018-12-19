using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public abstract class Colleague
    {
        protected IMediator _mediator;

        public Colleague(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
