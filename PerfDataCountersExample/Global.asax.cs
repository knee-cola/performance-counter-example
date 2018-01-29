using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using DevUtils.ETWIMBA.Diagnostics.Counters;
using PerfDataCountersExample.Diagnostics.Counters;

namespace PerfDataCountersExample
{
    public class Global : System.Web.HttpApplication
    {
        public static CounterSet<MyCounterSource.MyCounterObjectsSet> myCounterSet;
        public static CounterSetInstance<MyCounterSource.MyCounterObjectsSet> myCounterInstances;
        
        protected void Application_Start(object sender, EventArgs e)
        {
            // Creating an unique name from the name of the process, which will be assigned to counter instance
            // We need to "sanitize" the process name by removing some characters from the string (ie. back slash).
            // For example "/lm/w3svc/2/root/jsonproxy-3-13119983125367734"
            // Will become "_lm_w3svc_2_root_jsonprox_-3-13119983125367734"
            string instanceName = AppDomain.CurrentDomain.FriendlyName.Replace('/', '_');

            // creating the counter set
            Global.myCounterSet = new CounterSet<MyCounterSource.MyCounterObjectsSet>();
            // creating coutner instances
            Global.myCounterInstances = myCounterSet.CreateInstance(instanceName);
        }
    }
}