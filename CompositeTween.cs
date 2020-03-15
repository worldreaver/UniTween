using System;

namespace Worldreaver.UniTween
{
    public class CompositeTween : ITween
    {
        private readonly Tuple<ITween, float>[] _tweens;
        private readonly float[] _times;
        private readonly float _totalDistance;

        public CompositeTween(Tuple<ITween, float>[] tweens)
        {
            _tweens = tweens;

            _times = new float[tweens.Length];
            for (var i = 0; i < tweens.Length; ++i)
            {
                _totalDistance += tweens[i].Item2;
                _times[i] = tweens[i].Item1.CalculateFinishTime(tweens[i].Item2);
            }
        }

        public float CalculateFinishTime(float distance)
        {
            var total = 0.0f;
            for (var i = 0; i < _tweens.Length; ++i)
            {
                total += _times[i];
            }

            return total;
        }

        public float CalculatePosition(float time, float distance)
        {
            var i = 0;
            var calcedDistance = 0.0f;
            for (; i < _tweens.Length - 1; ++i)
            {
                if (_times[i] < time)
                {
                    time -= _times[i];
                    calcedDistance += _tweens[i].Item2;
                    continue;
                }

                break;
            }

            return (_tweens[i].Item1.CalculatePosition(time, _tweens[i].Item2) * _tweens[i].Item2 + calcedDistance) / _totalDistance;
        }
    }
}