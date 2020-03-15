namespace Worldreaver.UniTween
{
    /// <summary>
    /// used for tween callbacks
    /// </summary>
    public delegate void TweenCallback();

    /// <summary>
    /// used for tween callbacks
    /// </summary>
    public delegate void TweenCallback<in T>(T value);

    /// <summary>
    /// used for easing
    /// </summary>
    /// <param name="value">[0..1]</param>
    public delegate float EasingFunction(float value);
}