namespace Worldreaver.UniTween
{
    public struct Velocity
    {
        public double PerSecond { get; }

        private Velocity(double perSecond)
        {
            PerSecond = perSecond;
        }

        public static Velocity FromPerSecond(double value)
        {
            return new Velocity(value);
        }
    }
}