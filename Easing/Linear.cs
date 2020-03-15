namespace Worldreaver.UniTween
{
    public static partial class Easing
    {
        public static ITween Linear(float duration)
        {
            return new EasingDurationTween(LinearFunction, duration);
        }

        public static ITween Linear(Velocity velocity)
        {
            return new EasingVelocityTween(LinearFunction, velocity);
        }

        private static float LinearFunction(float value)
        {
            return value;
        }
    }
}