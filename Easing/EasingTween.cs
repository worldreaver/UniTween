using UnityEngine;

namespace Worldreaver.UniTween
{
    public static partial class Easing
    {
        private class EasingDurationTween : ITween
        {
            private readonly float _duration;
            private readonly EasingFunction _easing;

            public EasingDurationTween(EasingFunction easing, float duration)
            {
                _duration = Mathf.Max(duration, Mathf.Epsilon);
                _easing = easing;
            }

            public float CalculateFinishTime(float distance)
            {
                return _duration;
            }

            public float CalculatePosition(float time, float distance)
            {
                return _easing.Invoke(Mathf.Clamp01(time / _duration));
            }
        }

        private class EasingVelocityTween : ITween
        {
            private readonly float _velocity;
            private readonly EasingFunction _easing;

            public EasingVelocityTween(EasingFunction easing, Velocity velocity)
            {
                _velocity = (float) velocity.PerSecond;
                _easing = easing;
            }

            public float CalculateFinishTime(float distance)
            {
                return distance / _velocity;
            }

            public float CalculatePosition(float time, float distance)
            {
                return _easing.Invoke(Mathf.Clamp01(time / CalculateFinishTime(distance)));
            }
        }
    }
}