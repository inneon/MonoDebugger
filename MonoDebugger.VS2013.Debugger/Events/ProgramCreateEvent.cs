﻿using Microsoft.VisualStudio.Debugger.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoDebugger.VS2013.Debugger.Events
{
    class ProgramCreateEvent : AsynchronousEvent, IDebugProgramCreateEvent2
    {
        public const string IID = "96CD11EE-ECD4-4E89-957E-B5D496FC4139";
    }
}
