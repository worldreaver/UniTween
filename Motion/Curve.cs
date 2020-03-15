using UnityEngine;

namespace Worldreaver.UniTween
{
    public static partial class TweenMotion
    {
        public static ITween From(AnimationCurve curve, float duration)
        {
            return new CurveTimeTween(curve, duration);
        }

        private class CurveVelocityTween : ITween
        {
            private readonly AnimationCurve _curve;
            private readonly float _velocity;

            public CurveVelocityTween(AnimationCurve curve, float velocity)
            {
                _curve = curve;
                _velocity = velocity;
            }

            public float CalculateFinishTime(float distance)
            {
                return _curve.keys[_curve.keys.Length - 1].time / _velocity;
            }

            public float CalculatePosition(float time, float distance)
            {
                return _curve.Evaluate(time / CalculateFinishTime(distance));
            }
        }

        private class CurveTimeTween : ITween
        {
            private readonly AnimationCurve _curve;
            private readonly float _duration;

            public CurveTimeTween(AnimationCurve curve, float duration)
            {
                _curve = curve;
                _duration = duration;
            }

            public float CalculateFinishTime(float distance)
            {
                return _duration;
            }

            public float CalculatePosition(float time, float distance)
            {
                return _curve.Evaluate(time / _duration);
            }
        }
    }
}