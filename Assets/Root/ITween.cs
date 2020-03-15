namespace Worldreaver.UniTween
{
    public interface ITween
    {
        float CalculateFinishTime(float distance);
        float CalculatePosition(float time, float distance);
    }

    public static class TweenExtensions
    {
        public static Velocity CalculateFinishVelocity(this ITween tween, float distance)
        {
            var finishTime = tween.CalculateFinishTime(distance);
            var pos1 = tween.CalculatePosition(finishTime - (float) Tweener.TIME_DELTA, distance);
            var pos2 = tween.CalculatePosition(finishTime, distance);
            return Velocity.FromPerSecond((pos2 - pos1) * distance / Tweener.TIME_DELTA);
        }

        public static Velocity CalculateStartVelocity(this ITween tween, float distance)
        {
            var pos1 = tween.CalculatePosition(0.0f, distance);
            var pos2 = tween.CalculatePosition((float) Tweener.TIME_DELTA, distance);
            return Velocity.FromPerSecond((pos2 - pos1) * distance / Tweener.TIME_DELTA);
        }
    }
}