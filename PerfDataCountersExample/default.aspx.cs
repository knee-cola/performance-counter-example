using PerfDataCountersExample.Diagnostics.Counters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PerfDataCountersExample
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // inkrementiram brojač `MessagesPerSec`
            Global.myCounterInstances[MyCounterSource.MyCounterObjectsSet.MessagesPerSec].Increment();

            // inkrementiram brojač `MessagesSentTotal`
            Global.myCounterInstances[MyCounterSource.MyCounterObjectsSet.MessagesSentTotal].Increment();

        }
    }
}