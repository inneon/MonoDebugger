﻿using Microsoft.VisualStudio.Debugger.Interop;
using MonoDebugger.VS2013.Debugger.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoDebugger.VS2013.Debugger.VisualStudio
{
    class ThreadCreateEvent : AsynchronousEvent, IDebugThreadCreateEvent2
    {
        public const string IID = "2090CCFC-70C5-491D-A5E8-BAD2DD9EE3EA";
    }
}
