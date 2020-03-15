using System;
using UniRx;
using UnityEngine;

namespace Worldreaver.UniTween
{
    public static class CanvasGroupFadeExtensions
    {
        public static IDisposable SubscribeToFade(this IObservable<float> source, CanvasGroup canvasGroup)
        {
            return source.SubscribeWithState(canvasGroup, (x, t) => t.alpha = x);
        }

        public static IDisposable SubscribeToFade(this IObservable<float> source, CanvasGroup canvasGroup, Action<Exception, CanvasGroup> onError)
        {
            return source.SubscribeWithState(canvasGroup, (x, t) => t.alpha = x, onError);
        }

        public static IDisposable SubscribeToFade(this IObservable<float> source, CanvasGroup canvasGroup, Action<CanvasGroup> onCompleted)
        {
            return source.SubscribeWithState(canvasGroup, (x, t) => t.alpha = x, onCompleted);
        }

        public static IDisposable SubscribeToFade(this IObservable<float> source, CanvasGroup canvasGroup, Action<Exception, CanvasGroup> onError, Action<CanvasGroup> onCompleted)
        {
            return source.SubscribeWithState(canvasGroup, (x, t) => t.alpha = x, onError, onCompleted);
        }

        public static IObservable<float> DoToFade(this IObservable<float> source, CanvasGroup canvasGroup)
        {
            return source.Do(x => canvasGroup.alpha = x);
        }

        public static IObservable<float> DoToFade(this IObservable<float> source, CanvasGroup canvasGroup, Action<Exception> onError)
        {
            return source.Do(x => canvasGroup.alpha = x, onError);
        }

        public static IObservable<float> DoToFade(this IObservable<float> source, CanvasGroup canvasGroup, Action onCompleted)
        {
            return source.Do(x => canvasGroup.alpha = x, onCompleted);
        }

        public static IObservable<float> DoToFade(this IObservable<float> source, CanvasGroup canvasGroup, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x => canvasGroup.alpha = x, onError, onCompleted);
        }
    }
}