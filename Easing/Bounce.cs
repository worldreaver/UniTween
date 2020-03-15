namespace Worldreaver.UniTween
{
    public static partial class Easing
    {
        public static ITween InBounce(float duration)
        {
            return new EasingDurationTween(InBounceFunction, duration);
        }

        public static ITween OutBounce(float duration)
        {
            return new EasingDurationTween(OutBounceFunction, duration);
        }

        public static ITween InOutBounce(float duration)
        {
            return new EasingDurationTween(InOutBounceFunction, duration);
        }

        public static ITween InBounce(Velocity velocity)
        {
            return new EasingVelocityTween(InBounceFunction, velocity);
        }

        public static ITween OutBounce(Velocity velocity)
        {
            return new EasingVelocityTween(OutBounceFunction, velocity);
        }

        public static ITween InOutBounce(Velocity velocity)
        {
            return new EasingVelocityTween(InOutBounceFunction, velocity);
        }

        private static float InBounceFunction(float value)
        {
            return 1 - OutBounceFunction(1 - value);
        }

        private static float OutBounceFunction(float value)
        {
            if (value < 4f / 11.0f)
            {
                return 121f * value * value / 16.0f;
            }

            if (value < 8f / 11.0f)
            {
                return 363f / 40.0f * value * value - 99f / 10.0f * value + 17f / 5.0f;
            }

            if (value < 9f / 10.0f)
            {
                return 4356f / 361.0f * value * value - 35442f / 1805.0f * value + 16061f / 1805.0f;
            }

            return 54f / 5.0f * value * value - 513f / 25.0f * value + 268f / 25.0f;
        }

        private static float InOutBounceFunction(float value)
        {
            if (value < 0.5f)
            {
                return 0.5f * InBounceFunction(value * 2f);
            }

            return 0.5f * OutBounceFunction(value * 2f - 1f) + 0.5f;
        }
    }
}