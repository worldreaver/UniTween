using UnityEngine;

namespace Worldreaver.UniTween
{
    public static partial class Easing
    {
        public static ITween InCirc(float duration)
        {
            return new EasingDurationTween(InCircFunction, duration);
        }

        public static ITween OutCirc(float duration)
        {
            return new EasingDurationTween(OutCircFunction, duration);
        }

        public static ITween InOutCirc(float duration)
        {
            return new EasingDurationTween(InOutCircFunction, duration);
        }

        public static ITween InCirc(Velocity velocity)
        {
            return new EasingVelocityTween(InCircFunction, velocity);
        }

        public static ITween OutCirc(Velocity velocity)
        {
            return new EasingVelocityTween(OutCircFunction, velocity);
        }

        public static ITween InOutCirc(Velocity velocity)
        {
            return new EasingVelocityTween(InOutCircFunction, velocity);
        }

        private static float InCircFunction(float value)
        {
            return 1f - Mathf.Sqrt(1f - value * value);
        }

        private static float OutCircFunction(float value)
        {
            return Mathf.Sqrt((2f - value) * value);
        }

        private static float InOutCircFunction(float value)
        {
            if (value < 0.5f)
            {
                return 0.5f * (1 - Mathf.Sqrt(1f - 4f * (value * value)));
            }

            return 0.5f * (Mathf.Sqrt(-(2f * value - 3f) * (2f * value - 1f)) + 1f);
        }
    }
}