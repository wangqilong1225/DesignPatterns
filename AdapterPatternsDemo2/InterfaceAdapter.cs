using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternsDemo2
{
    public class InterfaceAdapter : HDMI, VGA
    {
        public void RequireConnectDisplay()
        {
            this.BaseConnectDisplay();
        }
    }
}
