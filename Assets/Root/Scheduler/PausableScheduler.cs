using UnityEngine;

namespace Worldreaver.UniTween
{
    public class PausableScheduler : IScheduler
    {
        private float? _pauseTime;
        private float _lastResumeTime;
        
        public float Now => _pauseTime ?? Time.time - _lastResumeTime;
        
        public bool Paused => _pauseTime != null;
        
        public PausableScheduler()
        {
            _lastResumeTime = Time.time;
        }
        
        public void Pause()
        {
            _pauseTime = Time.time - _lastResumeTime;
        }

        public void Resume()
        {
            if (_pauseTime == null) return;
            _lastResumeTime = Time.time - _pauseTime.Value;
            _pauseTime = null;
        }
    }
}