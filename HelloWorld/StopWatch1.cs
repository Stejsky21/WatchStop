using System;

namespace StopWatch_Ex

{
    public class StopWatch

    {

        private DateTime _timeAtStart = new DateTime();

        private DateTime _timeAtEnd = new DateTime();

        private TimeSpan _timeElapsed = new TimeSpan();



        public DateTime StartTheWatch()

        {

            _timeAtStart = DateTime.Now;

            return _timeAtStart;

        }



        public DateTime StopTheWatch()

        {

            _timeAtEnd = DateTime.Now;

            return _timeAtEnd;

        }



        public TimeSpan ResultOfEntry()

        {

            _timeElapsed = _timeAtEnd.Subtract(_timeAtStart);

            return _timeElapsed;

        }

    }

}