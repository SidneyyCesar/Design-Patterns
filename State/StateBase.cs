using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public interface StateBase
    {
        void Change(Context context);
    }
}
