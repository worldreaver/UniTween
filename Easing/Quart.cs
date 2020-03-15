namespace Worldreaver.UniTween
{
    public static partial class Easing
    {
        public static ITween InQuart(float duration)
        {
            return new EasingDurationTween(InQuartFunction, duration);
        }

        public static ITween OutQuart(float duration)
        {
            return new EasingDurationTween(OutQuartFunction, duration);
        }

        public static ITween InOutQuart(float duration)
        {
            return new EasingDurationTween(InOutQuartFunction, duration);
        }

        public static ITween InQuart(Velocity velocity)
        {
            return new EasingVelocityTween(InQuartFunction, velocity);
        }

        public static ITween OutQuart(Velocity velocity)
        {
            return new EasingVelocityTween(OutQuartFunction, velocity);
        }

        public static ITween InOutQuart(Velocity velocity)
        {
            return new EasingVelocityTween(InOutQuartFunction, velocity);
        }

        private static float InQuartFunction(float value)
        {
            return value * value * value * value;
        }

        private static float OutQuartFunction(float value)
        {
            var f = (value - 1f);
            return f * f * f * (1f - value) + 1f;
        }

        private static float InOutQuartFunction(float value)
        {
            if (value < 0.5f)
            {
                return 8f * value * value * value * value;
            }

            var f = 2f * value - 2f;
            return 0.5f * f * f * f * f + 1f;
        }
    }
}