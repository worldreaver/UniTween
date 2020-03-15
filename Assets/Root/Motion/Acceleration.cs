using UnityEngine;


namespace Worldreaver.UniTween
{
    public static partial class TweenMotion
    {
        public static ITween Acceleration(float acceleration, float velocityStart = 0.0f)
        {
            return new AccelerationTween(acceleration, velocityStart);
        }

        private class AccelerationTween : ITween
        {
            private readonly float _acceleration;
            private readonly float _velocityStart;

            public AccelerationTween(float acceleration, float velocityStart)
            {
                _acceleration = acceleration;
                _velocityStart = velocityStart;
            }

            public float CalculateFinishTime(float distance)
            {
                var d = Mathf.Sqrt(_velocityStart * _velocityStart + 2f * _acceleration * distance);
                return (-_velocityStart + d) / _acceleration;
            }

            public float CalculatePosition(float time, float distance)
            {
                return Mathf.Clamp01((_velocityStart * time + 0.5f * _acceleration * time * time) / distance);
            }
        }
    }
}