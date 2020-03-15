using UnityEngine;
using Worldreaver.Utility;

namespace Worldreaver.UniTween
{
    public static partial class TweenMotion
    {
        public static ITween Random(float duration, float min, float max)
        {
            return new RandomDurationTween(duration, min, max);
        }

        private class RandomDurationTween : ITween
        {
            private readonly float _duration;
            private readonly float _min;
            private readonly float _max;

            public RandomDurationTween(float duration, float min, float max)
            {
                _duration = duration;
                _min = min;
                _max = max;
            }

            public float CalculateFinishTime(float distance)
            {
                return _duration;
            }

            public float CalculatePosition(float time, float distance)
            {
                if (Mathf.Approximately(time, _duration))
                {
                    return 0.0f;
                }

                return (float) RandomInstance.This.NextDouble() * (_max - _min) + _min;
            }
        }
    }
}