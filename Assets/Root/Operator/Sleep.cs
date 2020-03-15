﻿using System;
using UniRx;

namespace Worldreaver.UniTween
{
    public static partial class Tweener
    {
        public static IObservable<Unit> Sleep(float duration)
        {
            return Sleep(duration, DefaultScheduler);
        }

        public static IObservable<Unit> Sleep(float duration, IScheduler scheduler)
        {
            return SleepInternal(duration, scheduler);
        }

        public static IObservable<T> Sleep<T>(float duration, T value)
        {
            return Sleep(duration, value, DefaultScheduler);
        }

        public static IObservable<T> Sleep<T>(float duration, T value, IScheduler scheduler)
        {
            return SleepInternal(duration, scheduler).Select(_ => value);
        }

        public static IObservable<T> Sleep<T>(this IObservable<T> self, float duration)
        {
            return self.Sleep(duration, DefaultScheduler);
        }

        public static IObservable<T> Sleep<T>(this IObservable<T> self, float duration, IScheduler scheduler)
        {
            var hot = self.Publish().RefCount();
            return hot.Merge(hot.ContinueWith(_ => Sleep(duration, _, scheduler)));
        }

        public static IObservable<T> Sleep<T>(this IObservable<T> self, float duration, T value)
        {
            return self.Concat(Sleep(duration, value));
        }

        public static IObservable<T> Sleep<T>(this IObservable<T> self, float duration, T value, IScheduler scheduler)
        {
            return self.Concat(Sleep(duration, value, scheduler));
        }
    }
}