namespace Worldreaver.UniTween
{
    public static partial class Easing
    {
        public static ITween InQuad(float duration)
        {
            return new EasingDurationTween(InQuadFunction, duration);
        }

        public static ITween OutQuad(float duration)
        {
            return new EasingDurationTween(OutQuadFunction, duration);
        }

        public static ITween InOutQuad(float duration)
        {
            return new EasingDurationTween(InOutQuadFunction, duration);
        }

        public static ITween InQuad(Velocity velocity)
        {
            return new EasingVelocityTween(InQuadFunction, velocity);
        }

        public static ITween OutQuad(Velocity velocity)
        {
            return new EasingVelocityTween(OutQuadFunction, velocity);
        }

        public static ITween InOutQuad(Velocity velocity)
        {
            return new EasingVelocityTween(InOutQuadFunction, velocity);
        }

        private static float InQuadFunction(float value)
        {
            return value * value;
        }

        private static float OutQuadFunction(float value)
        {
            return -(value * (value - 2f));
        }

        private static float InOutQuadFunction(float value)
        {
            if (value < 0.5f)
            {
                return 2f * value * value;
            }

            return -2f * value * value + 4f * value - 1f;
        }
    }
}