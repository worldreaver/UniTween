using UnityEngine;

namespace Worldreaver.UniTween
{
    public class UnscaledTimeScheduler : IScheduler
    {
        #region Implementation of IScheduler

        public float Now => Time.unscaledTime;
        public bool Paused => false;

        #endregion
    }
}