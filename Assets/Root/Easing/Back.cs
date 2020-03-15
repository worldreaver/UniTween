using UnityEngine;

namespace Worldreaver.UniTween
{
    public static partial class Easing
    {
        public static ITween InBack(float duration)
        {
            return new EasingDurationTween(InBackFunction, duration);
        }

        public static ITween OutBack(float duration)
        {
            return new EasingDurationTween(OutBackFunction, duration);
        }

        public static ITween InOutBack(float duration)
        {
            return new EasingDurationTween(InOutBackFunction, duration);
        }

        public static ITween InBack(Velocity velocity)
        {
            return new EasingVelocityTween(InBackFunction, velocity);
        }

        public static ITween OutBack(Velocity velocity)
        {
            return new EasingVelocityTween(OutBackFunction, velocity);
        }

        public static ITween InOutBack(Velocity velocity)
        {
            return new EasingVelocityTween(InOutBackFunction, velocity);
        }

        private static float InBackFunction(float value)
        {
            return value * value * value - value * Mathf.Sin(value * PI);
        }

        private static float OutBackFunction(float value)
        {
            var f = 1f - value;
            return 1f - (f * f * f - f * Mathf.Sin(f * PI));
        }

        private static float InOutBackFunction(float value)
        {
            if (value < 0.5f)
            {
                var f = 2f * value;
                return 0.5f * (f * f * f - f * Mathf.Sin(f * PI));
            }
            else
            {
                var f = (1 - (2 * value - 1));
                return 0.5f * (1f - (f * f * f - f * Mathf.Sin(f * PI))) + 0.5f;
            }
        }
    }
}