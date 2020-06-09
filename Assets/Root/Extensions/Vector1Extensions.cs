using System;
using System.Collections.Generic;
using System.Linq;
using UniRx;

namespace Worldreaver.UniTween
{
    public static class Vector1Extensions
    {
        public static IObservable<float> Play(this float source, float to, ITween tween)
        {
            return Tweener.Play(source, to, tween);
        }

        public static IObservable<float> Play(this float source, float to, ITween tween, IScheduler scheduler)
        {
            return Tweener.Play(source, to, tween, scheduler);
        }

        public static IObservable<float> Play(this float source, float[] path, ITween tween)
        {
            var merged = new float[path.Length + 1];
            merged[0] = source;
            Array.Copy(path, 0, merged, 1, path.Length);
            return Tweener.Play(merged, tween);
        }

        public static IObservable<float> Play(this float source, float[] path, ITween tween, IScheduler scheduler)
        {
            var merged = new float[path.Length + 1];
            merged[0] = source;
            Array.Copy(path, 0, merged, 1, path.Length);
            return Tweener.Play(merged, tween, scheduler);
        }

        public static IObservable<float> PlayRelative(this float source, float relative, ITween tween)
        {
            return Tweener.PlayRelative(source, relative, tween);
        }

        public static IObservable<float> PlayRelative(this float source, float relative, ITween tween, IScheduler scheduler)
        {
            return Tweener.PlayRelative(source, relative, tween, scheduler);
        }

        public static IObservable<float> Sum(this IObservable<IList<float>> source)
        {
            return source.Select(x => { return x.Aggregate(0.0f, (current, xx) => current + xx); });
        }

        public static IObservable<float> Sum(this IObservable<List<float>> source)
        {
            return source.Select(x => { return x.Aggregate(0.0f, (current, xx) => current + xx); });
        }

        public static IObservable<float> Sum(this IObservable<float[]> source)
        {
            return source.Select(x => { return x.Aggregate(0.0f, (current, xx) => current + xx); });
        }
    }
}