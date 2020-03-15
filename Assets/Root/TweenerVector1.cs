using System;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Worldreaver.UniTween
{
    public static partial class Tweener
    {
        public static IObservable<float> Play(float from, float to, ITween tween)
        {
            return Play(from, to, tween, DefaultScheduler);
        }

        public static IObservable<float> Play(float from, float to, ITween tween, IScheduler scheduler)
        {
            return PlayInternal(tween, Mathf.Abs(from - to), scheduler)
                .Select(x => Mathf.LerpUnclamped(from, to, x));
        }

        public static IObservable<float> PlayIn(float from, float inEnd, float to, ITween inTween)
        {
            return PlayIn(from, inEnd, to, inTween, DefaultScheduler);
        }

        public static IObservable<float> PlayIn(float from, float inEnd, float to, ITween inTween, IScheduler scheduler)
        {
            var velocity = inTween.CalculateFinishVelocity(Mathf.Abs(inEnd - from));
            var linear = Easing.Linear(velocity);
            var compositeTween = new CompositeTween(new[]
            {
                Tuple.Create(inTween, Mathf.Abs(inEnd - from)),
                Tuple.Create(linear, Mathf.Abs(to - inEnd)),
            });
            return Play(new[] {from, inEnd, to}, compositeTween, scheduler);
        }

        public static IObservable<float> PlayOut(float from, float outStart, float to, ITween outTween)
        {
            return PlayOut(from, outStart, to, outTween, DefaultScheduler);
        }

        public static IObservable<float> PlayOut(float from, float outStart, float to, ITween outTween, IScheduler scheduler)
        {
            var velocity = outTween.CalculateStartVelocity(Mathf.Abs(to - outStart));
            var linear = Easing.Linear(velocity);
            var compositeTween = new CompositeTween(new[]
            {
                Tuple.Create(linear, Mathf.Abs(outStart - from)),
                Tuple.Create(outTween, Mathf.Abs(to - outStart)),
            });
            return Play(new[] {from, outStart, to}, compositeTween, scheduler);
        }

        public static IObservable<float> PlayInOut(float from, float inEnd, float outStart, float to, ITween inTween, ITween outTween)
        {
            return PlayInOut(from, inEnd, outStart, to, inTween, outTween, DefaultScheduler);
        }

        public static IObservable<float> PlayInOut(float from, float inEnd, float outStart, float to, ITween inTween, ITween outTween, IScheduler scheduler)
        {
            var inVelocity = inTween.CalculateFinishVelocity(Mathf.Abs(inEnd - from)).PerSecond;
            var outVelocity = outTween.CalculateStartVelocity(Mathf.Abs(to - outStart)).PerSecond;
            ITween linearTween;

            if (Math.Abs(inVelocity - outVelocity) < EQUAL_DELTA)
            {
                linearTween = TweenMotion.Uniform((float) ((inVelocity + outVelocity) / 2.0));
            }
            else
            {
                var accel = (outVelocity * outVelocity - inVelocity * inVelocity) / (2.0f * Mathf.Abs(outStart - inEnd));
                linearTween = TweenMotion.Acceleration((float) accel, (float) inVelocity);
            }

            var compositeTween = new CompositeTween(new[]
            {
                Tuple.Create(inTween, Mathf.Abs(inEnd - from)),
                Tuple.Create(linearTween, Mathf.Abs(outStart - inEnd)),
                Tuple.Create(outTween, Mathf.Abs(to - outStart)),
            });
            return Play(new[] {from, inEnd, outStart, to}, compositeTween, scheduler);
        }

        public static IObservable<float> Play(float[] path, ITween tween)
        {
            return Play(path, tween, DefaultScheduler);
        }

        public static IObservable<float> Play(float[] path, ITween tween, IScheduler scheduler)
        {
            var distance = new List<float>();
            var sum = 0.0f;
            for (var i = 0; i < path.Length - 1; ++i)
            {
                var d = Mathf.Abs(path[i] - path[i + 1]);
                distance.Add(sum + d);
                sum += d;
            }

            return PlayInternal(tween, sum, scheduler)
                .Select(x =>
                {
                    var a = x * sum;
                    var i = 0;
                    for (; i < distance.Count - 1; i++)
                    {
                        if (distance[i] > a) break;
                    }

                    var b = i == 0 ? 0 : distance[i - 1];
                    return Mathf.LerpUnclamped(path[i], path[i + 1], (a - b) / (distance[i] - b));
                });
        }

        public static IObservable<float> Play(this IObservable<float> self, float from, float to, ITween tween)
        {
            return Play(self, from, to, tween, DefaultScheduler);
        }

        public static IObservable<float> Play(this IObservable<float> self, float from, float to, ITween tween, IScheduler scheduler)
        {
            return self.Concat(Play(from, to, tween, scheduler));
        }

        public static IObservable<float> Play(this IObservable<float> self, float from, float[] path, ITween tween)
        {
            return Play(self, from, path, tween, DefaultScheduler);
        }

        public static IObservable<float> Play(this IObservable<float> self, float from, float[] path, ITween tween, IScheduler scheduler)
        {
            var merged = new float[path.Length + 1];
            merged[0] = from;
            Array.Copy(path, 0, merged, 1, path.Length);
            return self.Concat(Play(merged, tween, scheduler));
        }

        public static IObservable<float> Play(this IObservable<float> self, float to, ITween tween)
        {
            return Play(self, to, tween, DefaultScheduler);
        }

        public static IObservable<float> Play(this IObservable<float> self, float to, ITween tween, IScheduler scheduler)
        {
            var hot = self.Publish().RefCount();
            return hot.Merge(hot.ContinueWith(x => Play(x, to, tween, scheduler)));
        }

        public static IObservable<float> Play(this IObservable<float> self, float[] path, ITween tween)
        {
            return Play(self, path, tween, DefaultScheduler);
        }

        public static IObservable<float> Play(this IObservable<float> self, float[] path, ITween tween, IScheduler scheduler)
        {
            return self.Select(x =>
            {
                var merged = new float[path.Length + 1];
                merged[0] = x;
                Array.Copy(path, 0, merged, 1, path.Length);
                return Observable.Return(x).Concat(Play(merged, tween, scheduler));
            }).Switch();
        }

        public static IObservable<float> PlayRelative(float from, float relative, ITween tween)
        {
            return PlayRelative(from, relative, tween, DefaultScheduler);
        }

        public static IObservable<float> PlayRelative(float from, float relative, ITween tween, IScheduler scheduler)
        {
            return Play(from, from + relative, tween, scheduler);
        }

        public static IObservable<float> PlayRelative(this IObservable<float> self, float from, float relative, ITween tween)
        {
            return PlayRelative(self, from, relative, tween, DefaultScheduler);
        }

        public static IObservable<float> PlayRelative(this IObservable<float> self, float from, float relative, ITween tween, IScheduler scheduler)
        {
            return self.Concat(Play(from, from + relative, tween, scheduler));
        }

        public static IObservable<float> PlayRelative(this IObservable<float> self, float relative, ITween tween)
        {
            return PlayRelative(self, relative, tween, DefaultScheduler);
        }

        public static IObservable<float> PlayRelative(this IObservable<float> self, float relative, ITween tween, IScheduler scheduler)
        {
            var hot = self.Publish().RefCount();
            return hot.Merge(hot.ContinueWith(x => Play(x, x + relative, tween, scheduler)));
        }

        public static IObservable<float> Lerp(this IObservable<float> self, float from, float to)
        {
            return self.Select(x => Mathf.LerpUnclamped(from, to, x));
        }
    }
}