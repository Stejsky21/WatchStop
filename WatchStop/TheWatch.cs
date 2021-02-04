using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchStop
{
    public class TheWatch
    {
        private DateTime timeAtStart = new DateTime();
        private DateTime timeAtEnd = new DateTime();
        private TimeSpan timeElapsed = new TimeSpan();
        private bool watchIsRunning;

        public DateTime StartTheWatch()
        {
            if (watchIsRunning)
            {
                throw new InvalidOperationException("Watch is running!");
            }

            watchIsRunning = true;
            timeAtStart = DateTime.Now;
            return timeAtStart;
        }

        public DateTime EndTheWatch()
        {
            watchIsRunning = false;
            timeAtEnd = DateTime.Now;
            return timeAtEnd;
        }

        public TimeSpan Result()
        {
            timeElapsed = timeAtEnd - timeAtStart;
            return timeElapsed;
        }
    }
}
