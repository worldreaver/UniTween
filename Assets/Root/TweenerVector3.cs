using System;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Worldreaver.UniTween
{
    public static partial class Tweener
    {
        public static IObservable<Vector3> Play(Vector3 from, Vector3 to, ITween tween)
        {
            return Play(from, to, tween, DefaultScheduler);
        }

        public static IObservable<Vector3> Play(Vector3 from, Vector3 to, ITween tween, IScheduler scheduler)
        {
            return PlayInternal(tween, Vector3.Distance(from, to), scheduler)
                .Select(x => Vector3.LerpUnclamped(from, to, x));
        }

        public static IObservable<Vector3> PlayIn(Vector3 from, Vector3 inEnd, Vector3 to, ITween inTween)
        {
            return PlayIn(from, inEnd, to, inTween, DefaultScheduler);
        }

        public static IObservable<Vector3> PlayIn(Vector3 from, Vector3 inEnd, Vector3 to, ITween inTween, IScheduler scheduler)
        {
            var velocity = inTween.CalculateFinishVelocity(Vector3.Distance(inEnd, from));
            var linear = Easing.Linear(velocity);
            var compositeTween = new CompositeTween(new[]
            {
                Tuple.Create(inTween, Vector3.Distance(inEnd, from)),
                Tuple.Create(linear, Vector3.Distance(to, inEnd)),
            });
            return Play(new[] {from, inEnd, to}, compositeTween, scheduler);
        }

        public static IObservable<Vector3> PlayOut(Vector3 from, Vector3 outStart, Vector3 to, ITween outTween)
        {
            return PlayOut(from, outStart, to, outTween, DefaultScheduler);
        }

        public static IObservable<Vector3> PlayOut(Vector3 from, Vector3 outStart, Vector3 to, ITween outTween, IScheduler scheduler)
        {
            var velocity = outTween.CalculateStartVelocity(Vector3.Distance(to, outStart));
            var linear = Easing.Linear(velocity);
            var compositeTween = new CompositeTween(new[]
            {
                Tuple.Create(linear, Vector3.Distance(outStart, from)),
                Tuple.Create(outTween, Vector3.Distance(to, outStart)),
            });
            return Play(new[] {from, outStart, to}, compositeTween, scheduler);
        }

        public static IObservable<Vector3> PlayInOut(Vector3 from, Vector3 inEnd, Vector3 outStart, Vector3 to, ITween inTween, ITween outTween)
        {
            return PlayInOut(from, inEnd, outStart, to, inTween, outTween, DefaultScheduler);
        }

        public static IObservable<Vector3> PlayInOut(Vector3 from, Vector3 inEnd, Vector3 outStart, Vector3 to, ITween inTween, ITween outTween, IScheduler scheduler)
        {
            var inVelocity = inTween.CalculateFinishVelocity(Vector3.Distance(inEnd, from)).PerSecond;
            var outVelocity = outTween.CalculateStartVelocity(Vector3.Distance(to, outStart)).PerSecond;
            ITween linearTween;

            if (Math.Abs(inVelocity - outVelocity) < EQUAL_DELTA)
            {
                linearTween = TweenMotion.Uniform((float) ((inVelocity + outVelocity) / 2.0));
            }
            else
            {
                var accel = (outVelocity * outVelocity - inVelocity * inVelocity) / (2.0f * Vector3.Distance(outStart, inEnd));
                linearTween = TweenMotion.Acceleration((float) accel, (float) inVelocity);
            }

            var compositeTween = new CompositeTween(new[]
            {
                Tuple.Create(inTween, Vector3.Distance(inEnd, from)),
                Tuple.Create(linearTween, Vector3.Distance(outStart, inEnd)),
                Tuple.Create(outTween, Vector3.Distance(to, outStart)),
            });
            return Play(new[] {from, inEnd, outStart, to}, compositeTween, scheduler);
        }

        public static IObservable<Vector3> Play(Vector3[] path, ITween tween)
        {
            return Play(path, tween, DefaultScheduler);
        }

        public static IObservable<Vector3> Play(Vector3[] path, ITween tween, IScheduler scheduler)
        {
            var distance = new List<float>();
            var sum = 0.0f;
            for (var i = 0; i < path.Length - 1; ++i)
            {
                var d = Vector3.Distance(path[i], path[i + 1]);
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
                    return Vector3.LerpUnclamped(path[i], path[i + 1], (a - b) / (distance[i] - b));
                });
        }

        public static IObservable<Vector3> Play(this IObservable<Vector3> self, Vector3 from, Vector3 to, ITween tween)
        {
            return Play(self, from, to, tween, DefaultScheduler);
        }

        public static IObservable<Vector3> Play(this IObservable<Vector3> self, Vector3 from, Vector3 to, ITween tween, IScheduler scheduler)
        {
            return self.Concat(Play(from, to, tween, scheduler));
        }

        public static IObservable<Vector3> Play(this IObservable<Vector3> self, Vector3 from, Vector3[] path, ITween tween)
        {
            return Play(self, from, path, tween, DefaultScheduler);
        }

        public static IObservable<Vector3> Play(this IObservable<Vector3> self, Vector3 from, Vector3[] path, ITween tween, IScheduler scheduler)
        {
            var merged = new Vector3[path.Length + 1];
            merged[0] = from;
            Array.Copy(path, 0, merged, 1, path.Length);
            return self.Concat(Play(merged, tween, scheduler));
        }

        public static IObservable<Vector3> Play(this IObservable<Vector3> self, Vector3 to, ITween tween)
        {
            return Play(self, to, tween, DefaultScheduler);
        }

        public static IObservable<Vector3> Play(this IObservable<Vector3> self, Vector3 to, ITween tween, IScheduler scheduler)
        {
            var hot = self.Publish().RefCount();
            return hot.Merge(hot.ContinueWith(x => Play(x, to, tween, scheduler)));
        }
        
        public static IObservable<Vector3> Play(this IObservable<Vector3> self, Vector3[] path, ITween tween)
        {
            return Play(self, path, tween, DefaultScheduler);
        }

        public static IObservable<Vector3> Play(this IObservable<Vector3> self, Vector3[] path, ITween tween, IScheduler scheduler)
        {
            return self.Select(x =>
            {
                var merged = new Vector3[path.Length + 1];
                merged[0] = x;
                Array.Copy(path, 0, merged, 1, path.Length);
                return Observable.Return(x).Concat(Play(merged, tween, scheduler));
            }).Switch();
        }

        public static IObservable<Vector3> PlayRelative(Vector3 from, Vector3 relative, ITween tween)
        {
            return PlayRelative(from, relative, tween, DefaultScheduler);
        }

        public static IObservable<Vector3> PlayRelative(Vector3 from, Vector3 relative, ITween tween, IScheduler scheduler)
        {
            return Play(from, from + relative, tween, scheduler);
        }

        public static IObservable<Vector3> PlayRelative(this IObservable<Vector3> self, Vector3 from, Vector3 relative, ITween tween)
        {
            return PlayRelative(self, from, relative, tween, DefaultScheduler);
        }

        public static IObservable<Vector3> PlayRelative(this IObservable<Vector3> self, Vector3 from, Vector3 relative, ITween tween, IScheduler scheduler)
        {
            return self.Concat(Play(from, from + relative, tween, scheduler));
        }

        public static IObservable<Vector3> PlayRelative(this IObservable<Vector3> self, Vector3 relative, ITween tween)
        {
            return PlayRelative(self, relative, tween, DefaultScheduler);
        }

        public static IObservable<Vector3> PlayRelative(this IObservable<Vector3> self, Vector3 relative, ITween tween, IScheduler scheduler)
        {
            var hot = self.Publish().RefCount();
            return hot.Merge(hot.ContinueWith(x => Play(x, x + relative, tween, scheduler)));
        }

        public static IObservable<Vector3> Lerp(this IObservable<float> self, Vector3 from, Vector3 to)
        {
            return self.Select(x => Vector3.LerpUnclamped(from, to, x));
        }
    }
}