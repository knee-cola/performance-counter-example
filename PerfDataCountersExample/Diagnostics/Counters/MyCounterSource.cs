using System.Diagnostics;
using System.Threading;
using DevUtils.ETWIMBA.Diagnostics.Counters;

namespace PerfDataCountersExample.Diagnostics.Counters
{
	[CounterSource(Guid = "{ab8e1320-965a-4cf9-9c07-fe25378c2a23}")]
	public sealed class MyCounterSource
	{
        [CounterSet(CounterSetInstances.Multiple, Name = "NGIT_Counter_Demo", Description = "counteri kreirani za potrebe testiranja kreiranja counter-a")]
        public enum MyCounterObjectsSet
        {
            [Counter(CounterType.PerfCounterLargeRawcount,
                Name = "Total messages sent",
                Description = "total number of messages sent since the application was started")]
            MessagesSentTotal = 1,
            [Counter(CounterType.PerfCounterLargeRawcount,
                Name = "Messages Per Sec",
                Description = "number of messages sent per second")]
            MessagesPerSec
        }
	}
}