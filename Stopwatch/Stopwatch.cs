using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        private DateTime _startTime=new DateTime();
        private bool _isRunning = false;
        public void Start()
        {
            if (!_isRunning)
            {
                _startTime = DateTime.Now;
                _isRunning = true;
            }
            else
            {
                throw new InvalidOperationException("Stopwatch already running");
            }

        }

        public TimeSpan Stop()
        {
            _isRunning = false;
            return DateTime.Now - _startTime;

        }
    }
}
