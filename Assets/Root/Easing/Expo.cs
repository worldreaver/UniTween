using UnityEngine;

namespace Worldreaver.UniTween
{
    public static partial class Easing
    {
        public static ITween InExpo(float duration)
        {
            return new EasingDurationTween(InExpoFunction, duration);
        }

        public static ITween OutExpo(float duration)
        {
            return new EasingDurationTween(OutExpoFunction, duration);
        }

        public static ITween InOutExpo(float duration)
        {
            return new EasingDurationTween(InOutExpoFunction, duration);
        }

        public static ITween InExpo(Velocity velocity)
        {
            return new EasingVelocityTween(InExpoFunction, velocity);
        }

        public static ITween OutExpo(Velocity velocity)
        {
            return new EasingVelocityTween(OutExpoFunction, velocity);
        }

        public static ITween InOutExpo(Velocity velocity)
        {
            return new EasingVelocityTween(InOutExpoFunction, velocity);
        }

        private static float InExpoFunction(float value)
        {
            return Mathf.Approximately(0.0f, value) ? value : Mathf.Pow(2f, 10f * (value - 1f));
        }

        private static float OutExpoFunction(float value)
        {
            return Mathf.Approximately(1.0f, value) ? value : 1f - Mathf.Pow(2f, -10f * value);
        }

        private static float InOutExpoFunction(float value)
        {
            if (Mathf.Approximately(0.0f, value) || Mathf.Approximately(1.0f, value)) return value;

            if (value < 0.5f)
            {
                return 0.5f * Mathf.Pow(2f, (20f * value) - 10f);
            }

            return -0.5f * Mathf.Pow(2f, (-20f * value) + 10f) + 1f;
        }
    }
}