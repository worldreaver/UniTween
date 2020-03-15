using UnityEngine;

namespace Worldreaver.UniTween
{
    public static partial class TweenMotion
    {
        public static ITween Uniform(float velocity)
        {
            return new UniformTween(velocity);
        }

        private class UniformTween : ITween
        {
            private readonly float _velocity;

            public UniformTween(float velocity)
            {
                _velocity = velocity;
            }

            public float CalculateFinishTime(float distance)
            {
                return distance / _velocity;
            }

            public float CalculatePosition(float time, float distance)
            {
                return Mathf.Clamp01(time / CalculateFinishTime(distance));
            }
        }
    }
}