using System;
using System.Collections;
using System.Threading;
using UniRx;

namespace Worldreaver.UniTween
{
    public static partial class Tweener
    {
        private static IScheduler DefaultScheduler { get; } = new TimeScheduler();
        public const double TIME_DELTA = 0.00001;
        private const double EQUAL_DELTA = 0.02;

        public static IObservable<float> Play(ITween tween)
        {
            return Play(tween, DefaultScheduler);
        }

        public static IObservable<float> Play(ITween tween, IScheduler scheduler)
        {
            return PlayInternal(tween, 1.0f, scheduler);
        }

        private static IObservable<float> PlayInternal(ITween tween, float distance, IScheduler scheduler)
        {
            return Observable
                .Defer(() => Observable.Return(scheduler.Now))
                .ContinueWith(start =>
                    ObservableEx.FromMicroCoroutineWithInitialValue((observer, token) => TweenCoroutine(tween, start, distance, scheduler, observer, token), tween.CalculatePosition(scheduler.Now - start, distance))
                );
        }

        private static IObservable<Unit> SleepInternal(float duration, IScheduler scheduler)
        {
            return Observable
                .Defer(() => Observable.Return(scheduler.Now))
                .ContinueWith(start =>
                    ObservableEx.FromMicroCoroutineWithInitialValue((observer, token) => DelayCoroutine(start, duration, scheduler, observer, token), Unit.Default)
                );
        }

        private static IEnumerator TweenCoroutine(ITween tween, float start, float distance, IScheduler scheduler, IObserver<float> observer, CancellationToken token)
        {
            while (true)
            {
                if (token.IsCancellationRequested)
                {
                    observer.OnCompleted();
                    yield break;
                }

                while (scheduler.Paused)
                {
                    yield return null;
                }

                var now = scheduler.Now - start;
                if (tween.CalculateFinishTime(distance) < now)
                {
                    break;
                }

                observer.OnNext(tween.CalculatePosition(now, distance));
                yield return null;
            }

            observer.OnNext(tween.CalculatePosition(tween.CalculateFinishTime(distance), distance));
            observer.OnCompleted();
        }

        private static IEnumerator DelayCoroutine(float start, float duration, IScheduler scheduler, IObserver<Unit> observer, CancellationToken token)
        {
            while (true)
            {
                if (token.IsCancellationRequested)
                {
                    observer.OnCompleted();
                    yield break;
                }

                while (scheduler.Paused)
                {
                    yield return null;
                }

                var now = scheduler.Now - start;
                if (duration < now)
                {
                    break;
                }

                observer.OnNext(Unit.Default);
                yield return null;
            }

            observer.OnNext(Unit.Default);
            observer.OnCompleted();
        }
    }
}