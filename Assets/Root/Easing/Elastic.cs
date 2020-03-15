using UnityEngine;

namespace Worldreaver.UniTween
{
    public static partial class Easing
    {
        public static ITween InElastic(float duration)
        {
            return new EasingDurationTween(InElasticFunction, duration);
        }

        public static ITween OutElastic(float duration)
        {
            return new EasingDurationTween(OutElasticFunction, duration);
        }

        public static ITween InOutElastic(float duration)
        {
            return new EasingDurationTween(InOutElasticFunction, duration);
        }

        public static ITween InElastic(Velocity velocity)
        {
            return new EasingVelocityTween(InElasticFunction, velocity);
        }

        public static ITween OutElastic(Velocity velocity)
        {
            return new EasingVelocityTween(OutElasticFunction, velocity);
        }

        public static ITween InOutElastic(Velocity velocity)
        {
            return new EasingVelocityTween(InOutElasticFunction, velocity);
        }

        private static float InElasticFunction(float value)
        {
            return Mathf.Sin(13 * HALF_PI * value) * Mathf.Pow(2f, 10f * (value - 1f));
        }

        private static float OutElasticFunction(float value)
        {
            return Mathf.Sin(-13 * HALF_PI * (value + 1)) * Mathf.Pow(2f, -10f * value) + 1f;
        }

        private static float InOutElasticFunction(float value)
        {
            if (value < 0.5f)
            {
                return 0.5f * Mathf.Sin(13f * HALF_PI * (2f * value)) * Mathf.Pow(2f, 10f * ((2f * value) - 1f));
            }

            return 0.5f * (Mathf.Sin(-13f * HALF_PI * ((2f * value - 1f) + 1f)) * Mathf.Pow(2f, -10f * (2f * value - 1f)) + 2f);
        }
    }
}