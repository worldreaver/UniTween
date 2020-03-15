namespace Worldreaver.UniTween
{
    public static partial class Easing
    {
        public static ITween InCubic(float duration)
        {
            return new EasingDurationTween(InCubicFunction, duration);
        }

        public static ITween OutCubic(float duration)
        {
            return new EasingDurationTween(OutCubicFunction, duration);
        }

        public static ITween InOutCubic(float duration)
        {
            return new EasingDurationTween(InOutCubicFunction, duration);
        }

        public static ITween InCubic(Velocity velocity)
        {
            return new EasingVelocityTween(InCubicFunction, velocity);
        }

        public static ITween OutCubic(Velocity velocity)
        {
            return new EasingVelocityTween(OutCubicFunction, velocity);
        }

        public static ITween InOutCubic(Velocity velocity)
        {
            return new EasingVelocityTween(InOutCubicFunction, velocity);
        }

        private static float InCubicFunction(float value)
        {
            return value * value * value;
        }

        private static float OutCubicFunction(float value)
        {
            var f = value - 1f;
            return f * f * f + 1f;
        }

        private static float InOutCubicFunction(float value)
        {
            if (value < 0.5f)
            {
                return 4f * value * value * value;
            }

            var f = 2f * value - 2f;
            return 0.5f * f * f * f + 1f;
        }
    }
}