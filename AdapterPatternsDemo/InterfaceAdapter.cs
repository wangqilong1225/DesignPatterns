using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternsDemo
{
    public class InterfaceAdapter : VGA
    {
        HDMI hdmi = new HDMI();
        public override void RequireConnectDisplay()
        {
            hdmi.BaseConnectDisplay();
        }
    }
}
