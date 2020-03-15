using UnityEngine;

namespace Worldreaver.UniTween
{
    public static partial class Easing
    {
        public static ITween InSine(float duration)
        {
            return new EasingDurationTween(InSineFunction, duration);
        }

        public static ITween OutSine(float duration)
        {
            return new EasingDurationTween(OutSineFunction, duration);
        }

        public static ITween InOutSine(float duration)
        {
            return new EasingDurationTween(InOutSineFunction, duration);
        }

        public static ITween InSine(Velocity velocity)
        {
            return new EasingVelocityTween(InSineFunction, velocity);
        }

        public static ITween OutSine(Velocity velocity)
        {
            return new EasingVelocityTween(OutSineFunction, velocity);
        }

        public static ITween InOutSine(Velocity velocity)
        {
            return new EasingVelocityTween(InOutSineFunction, velocity);
        }

        private static float InSineFunction(float value)
        {
            return Mathf.Sin((value - 1f) * HALF_PI) + 1f;
        }

        private static float OutSineFunction(float value)
        {
            return Mathf.Sin(value * HALF_PI);
        }

        private static float InOutSineFunction(float value)
        {
            return 0.5f * (1f - Mathf.Cos(value * PI));
        }
    }
}