using UnityEngine;

namespace Worldreaver.UniTween
{
    public class PausableUnscaledScheduler : IScheduler
    {
        private float? _pauseTime;
        private float _lastResumeTime;

        public float Now => _pauseTime ?? Time.unscaledTime - _lastResumeTime;

        public bool Paused => _pauseTime != null;

        public PausableUnscaledScheduler()
        {
            _lastResumeTime = Time.unscaledTime;
        }

        public void Pause()
        {
            _pauseTime = Time.unscaledTime - _lastResumeTime;
        }

        public void Resume()
        {
            if (_pauseTime == null) return;
            _lastResumeTime = Time.unscaledTime - _pauseTime.Value;
            _pauseTime = null;
        }
    }
}