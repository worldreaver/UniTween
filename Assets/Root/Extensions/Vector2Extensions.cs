using System;
using System.Collections.Generic;
using System.Linq;
using UniRx;
using UnityEngine;

namespace Worldreaver.UniTween
{
    public static class Vector2Extensions
    {
        public static IObservable<Vector2> Play(this Vector2 source, Vector2 to, ITween tween)
        {
            return Tweener.Play(source, to, tween);
        }

        public static IObservable<Vector2> Play(this Vector2 source, Vector2 to, ITween tween, IScheduler scheduler)
        {
            return Tweener.Play(source, to, tween, scheduler);
        }

        public static IObservable<Vector2> Play(this Vector2 source, Vector2[] path, ITween tween)
        {
            var merged = new Vector2[path.Length + 1];
            merged[0] = source;
            Array.Copy(path, 0, merged, 1, path.Length);
            return Tweener.Play(merged, tween);
        }

        public static IObservable<Vector2> Play(this Vector2 source, Vector2[] path, ITween tween, IScheduler scheduler)
        {
            var merged = new Vector2[path.Length + 1];
            merged[0] = source;
            Array.Copy(path, 0, merged, 1, path.Length);
            return Tweener.Play(merged, tween, scheduler);
        }

        public static IObservable<Vector2> PlayRelative(this Vector2 source, Vector2 relative, ITween tween)
        {
            return Tweener.PlayRelative(source, relative, tween);
        }

        public static IObservable<Vector2> PlayRelative(this Vector2 source, Vector2 relative, ITween tween, IScheduler scheduler)
        {
            return Tweener.PlayRelative(source, relative, tween, scheduler);
        }

        public static IObservable<Vector2> Sum(this IObservable<IList<Vector2>> source)
        {
            return source.Select(x => { return x.Aggregate(new Vector2(), (current, xx) => current + xx); });
        }
        
        public static IObservable<Vector2> Sum(this IObservable<List<Vector2>> source)
        {
            return source.Select(x => { return x.Aggregate(new Vector2(), (current, xx) => current + xx); });
        }
        
        public static IObservable<Vector2> Sum(this IObservable<Vector2[]> source)
        {
            return source.Select(x => { return x.Aggregate(new Vector2(), (current, xx) => current + xx); });
        }
    }
}