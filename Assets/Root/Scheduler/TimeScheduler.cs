using UnityEngine;

namespace Worldreaver.UniTween
{
    public class TimeScheduler : IScheduler
    {
        #region Implementation of IScheduler

        public float Now => Time.time;
        public bool Paused => false;

        #endregion
    }
}