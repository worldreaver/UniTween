using System;
using System.Collections.Generic;
using System.Linq;
using UniRx;
using UnityEngine;

namespace Worldreaver.UniTween
{
    public static class Vector4Extensions
    {
        public static IObservable<Vector4> Play(this Vector4 source, Vector4 to, ITween tween)
        {
            return Tweener.Play(source, to, tween);
        }

        public static IObservable<Vector4> Play(this Vector4 source, Vector4 to, ITween tween, IScheduler scheduler)
        {
            return Tweener.Play(source, to, tween, scheduler);
        }

        public static IObservable<Vector4> Play(this Vector4 source, Vector4[] path, ITween tween)
        {
            var merged = new Vector4[path.Length + 1];
            merged[0] = source;
            Array.Copy(path, 0, merged, 1, path.Length);
            return Tweener.Play(merged, tween);
        }

        public static IObservable<Vector4> Play(this Vector4 source, Vector4[] path, ITween tween, IScheduler scheduler)
        {
            var merged = new Vector4[path.Length + 1];
            merged[0] = source;
            Array.Copy(path, 0, merged, 1, path.Length);
            return Tweener.Play(merged, tween, scheduler);
        }

        public static IObservable<Vector4> PlayRelative(this Vector4 source, Vector4 relative, ITween tween)
        {
            return Tweener.PlayRelative(source, relative, tween);
        }

        public static IObservable<Vector4> PlayRelative(this Vector4 source, Vector4 relative, ITween tween, IScheduler scheduler)
        {
            return Tweener.PlayRelative(source, relative, tween, scheduler);
        }

        public static IObservable<Vector4> Sum(this IObservable<IList<Vector4>> source)
        {
            return source.Select(x => { return x.Aggregate(new Vector4(), (current, xx) => current + xx); });
        }
        
        public static IObservable<Vector4> Sum(this IObservable<List<Vector4>> source)
        {
            return source.Select(x => { return x.Aggregate(new Vector4(), (current, xx) => current + xx); });
        }

        public static IObservable<Vector4> Sum(this IObservable<Vector4[]> source)
        {
            return source.Select(x => { return x.Aggregate(new Vector4(), (current, xx) => current + xx); });
        }
    }
}