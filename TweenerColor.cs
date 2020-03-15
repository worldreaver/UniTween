using System;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Worldreaver.UniTween
{
    public static partial class Tweener
    {
        public static IObservable<Color> Play(Color from, Color to, ITween tween)
        {
            return Play(from, to, tween, DefaultScheduler);
        }

        public static IObservable<Color> Play(Color from, Color to, ITween tween, IScheduler scheduler)
        {
            return PlayInternal(tween, Vector4.Distance(from, to), scheduler)
                .Select(x => Color.LerpUnclamped(from, to, x));
        }

        public static IObservable<Color> PlayIn(Color from, Color inEnd, Color to, ITween inTween)
        {
            return PlayIn(from, inEnd, to, inTween, DefaultScheduler);
        }

        public static IObservable<Color> PlayIn(Color from, Color inEnd, Color to, ITween inTween, IScheduler scheduler)
        {
            var velocity = inTween.CalculateFinishVelocity(Vector4.Distance(inEnd, from));
            var linear = Easing.Linear(velocity);
            var compositeTween = new CompositeTween(new[]
            {
                Tuple.Create(inTween, Vector4.Distance(inEnd, from)),
                Tuple.Create(linear, Vector4.Distance(to, inEnd)),
            });
            return Play(new[] {from, inEnd, to}, compositeTween, scheduler);
        }

        public static IObservable<Color> PlayOut(Color from, Color outStart, Color to, ITween outTween)
        {
            return PlayOut(from, outStart, to, outTween, DefaultScheduler);
        }

        public static IObservable<Color> PlayOut(Color from, Color outStart, Color to, ITween outTween, IScheduler scheduler)
        {
            var velocity = outTween.CalculateStartVelocity(Vector4.Distance(to, outStart));
            var linear = Easing.Linear(velocity);
            var compositeTween = new CompositeTween(new[]
            {
                Tuple.Create(linear, Vector4.Distance(outStart, from)),
                Tuple.Create(outTween, Vector4.Distance(to, outStart)),
            });
            return Play(new[] {from, outStart, to}, compositeTween, scheduler);
        }

        public static IObservable<Color> PlayInOut(Color from, Color inEnd, Color outStart, Color to, ITween inTween, ITween outTween)
        {
            return PlayInOut(from, inEnd, outStart, to, inTween, outTween, DefaultScheduler);
        }

        public static IObservable<Color> PlayInOut(Color from, Color inEnd, Color outStart, Color to, ITween inTween, ITween outTween, IScheduler scheduler)
        {
            var inVelocity = inTween.CalculateFinishVelocity(Vector4.Distance(inEnd, from)).PerSecond;
            var outVelocity = outTween.CalculateStartVelocity(Vector4.Distance(to, outStart)).PerSecond;
            ITween linearTween;

            if (Math.Abs(inVelocity - outVelocity) < EQUAL_DELTA)
            {
                linearTween = TweenMotion.Uniform((float) ((inVelocity + outVelocity) / 2.0));
            }
            else
            {
                var accel = (outVelocity * outVelocity - inVelocity * inVelocity) / (2.0f * Vector4.Distance(outStart, inEnd));
                linearTween = TweenMotion.Acceleration((float) accel, (float) inVelocity);
            }

            var compositeTween = new CompositeTween(new[]
            {
                Tuple.Create(inTween, Vector4.Distance(inEnd, from)),
                Tuple.Create(linearTween, Vector4.Distance(outStart, inEnd)),
                Tuple.Create(outTween, Vector4.Distance(to, outStart)),
            });
            return Play(new[] {from, inEnd, outStart, to}, compositeTween, scheduler);
        }

        public static IObservable<Color> Play(Color[] path, ITween tween)
        {
            return Play(path, tween, DefaultScheduler);
        }

        public static IObservable<Color> Play(Color[] path, ITween tween, IScheduler scheduler)
        {
            var distance = new List<float>();
            var sum = 0.0f;
            for (var i = 0; i < path.Length - 1; ++i)
            {
                var d = Vector4.Distance(path[i], path[i + 1]);
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
                    return Color.LerpUnclamped(path[i], path[i + 1], (a - b) / (distance[i] - b));
                });
        }

        public static IObservable<Color> Play(this IObservable<Color> self, Color from, Color to, ITween tween)
        {
            return Play(self, from, to, tween, DefaultScheduler);
        }

        public static IObservable<Color> Play(this IObservable<Color> self, Color from, Color to, ITween tween, IScheduler scheduler)
        {
            return self.Concat(Play(from, to, tween, scheduler));
        }

        public static IObservable<Color> Play(this IObservable<Color> self, Color from, Color[] path, ITween tween)
        {
            return Play(self, from, path, tween, DefaultScheduler);
        }

        public static IObservable<Color> Play(this IObservable<Color> self, Color from, Color[] path, ITween tween, IScheduler scheduler)
        {
            var merged = new Color[path.Length + 1];
            merged[0] = from;
            Array.Copy(path, 0, merged, 1, path.Length);
            return self.Concat(Play(merged, tween, scheduler));
        }

        public static IObservable<Color> Play(this IObservable<Color> self, Color to, ITween tween)
        {
            return Play(self, to, tween, DefaultScheduler);
        }

        public static IObservable<Color> Play(this IObservable<Color> self, Color to, ITween tween, IScheduler scheduler)
        {
            var hot = self.Publish().RefCount();
            return hot.Merge(hot.ContinueWith(x => Play(x, to, tween, scheduler)));
        }

        public static IObservable<Color> Play(this IObservable<Color> self, Color[] path, ITween tween)
        {
            return Play(self, path, tween, DefaultScheduler);
        }

        public static IObservable<Color> Play(this IObservable<Color> self, Color[] path, ITween tween, IScheduler scheduler)
        {
            return self.Select(x =>
            {
                var merged = new Color[path.Length + 1];
                merged[0] = x;
                Array.Copy(path, 0, merged, 1, path.Length);
                return Observable.Return(x).Concat(Play(merged, tween, scheduler));
            }).Switch();
        }

        public static IObservable<Color> PlayRelative(Color from, Color relative, ITween tween)
        {
            return PlayRelative(from, relative, tween, DefaultScheduler);
        }

        public static IObservable<Color> PlayRelative(Color from, Color relative, ITween tween, IScheduler scheduler)
        {
            return Play(from, from + relative, tween, scheduler);
        }

        public static IObservable<Color> PlayRelative(this IObservable<Color> self, Color from, Color relative, ITween tween)
        {
            return PlayRelative(self, from, relative, tween, DefaultScheduler);
        }

        public static IObservable<Color> PlayRelative(this IObservable<Color> self, Color from, Color relative, ITween tween, IScheduler scheduler)
        {
            return self.Concat(Play(from, from + relative, tween, scheduler));
        }

        public static IObservable<Color> PlayRelative(this IObservable<Color> self, Color relative, ITween tween)
        {
            return PlayRelative(self, relative, tween, DefaultScheduler);
        }

        public static IObservable<Color> PlayRelative(this IObservable<Color> self, Color relative, ITween tween, IScheduler scheduler)
        {
            var hot = self.Publish().RefCount();
            return hot.Merge(hot.ContinueWith(x => Play(x, x + relative, tween, scheduler)));
        }

        public static IObservable<Color> Lerp(this IObservable<float> self, Color from, Color to)
        {
            return self.Select(x => Color.LerpUnclamped(from, to, x));
        }
    }
}