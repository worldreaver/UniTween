namespace Worldreaver.UniTween
{
    public static partial class Easing
    {
        public static ITween InQuint(float duration)
        {
            return new EasingDurationTween(InQuintFunction, duration);
        }

        public static ITween OutQuint(float duration)
        {
            return new EasingDurationTween(OutQuintFunction, duration);
        }

        public static ITween InOutQuint(float duration)
        {
            return new EasingDurationTween(InOutQuintFunction, duration);
        }

        public static ITween InQuint(Velocity velocity)
        {
            return new EasingVelocityTween(InQuintFunction, velocity);
        }

        public static ITween OutQuint(Velocity velocity)
        {
            return new EasingVelocityTween(OutQuintFunction, velocity);
        }

        public static ITween InOutQuint(Velocity velocity)
        {
            return new EasingVelocityTween(InOutQuintFunction, velocity);
        }

        private static float InQuintFunction(float value)
        {
            return value * value * value * value * value;
        }

        private static float OutQuintFunction(float value)
        {
            var f = value - 1f;
            return f * f * f * f * f + 1f;
        }

        private static float InOutQuintFunction(float value)
        {
            if (value < 0.5f)
            {
                return 16 * value * value * value * value * value;
            }

            var f = 2f * value - 2f;
            return 0.5f * f * f * f * f * f + 1;
        }
    }
}