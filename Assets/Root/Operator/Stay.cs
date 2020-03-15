using System;
using UniRx;

namespace Worldreaver.UniTween
{
    public static partial class Tweener
    {
        public static IObservable<T> Stay<T>(T value)
        {
            return Observable.Return(value);
        }

        public static IObservable<T> Stay<T>(this IObservable<T> self, T value)
        {
            return self.Concat(Stay(value));
        }
    }
}