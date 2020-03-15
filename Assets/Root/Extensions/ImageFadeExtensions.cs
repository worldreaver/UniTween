using System;
using UniRx;
using UnityEngine.UI;

namespace Worldreaver.UniTween
{
    public static class ImageFadeExtensions
    {
        public static IDisposable SubscribeToFade(this IObservable<float> source, Image image)
        {
            return source.SubscribeWithState(image, (x, t) =>
            {
                var current = t.color;
                current.a = x;
                t.color = current;
            });
        }

        public static IDisposable SubscribeToFade(this IObservable<float> source, Image image, Action<Exception, Image> onError)
        {
            return source.SubscribeWithState(image, (x, t) =>
            {
                var current = t.color;
                current.a = x;
                t.color = current;
            }, onError);
        }

        public static IDisposable SubscribeToFade(this IObservable<float> source, Image image, Action<Image> onCompleted)
        {
            return source.SubscribeWithState(image, (x, t) =>
            {
                var current = t.color;
                current.a = x;
                t.color = current;
            }, onCompleted);
        }

        public static IDisposable SubscribeToFade(this IObservable<float> source, Image image, Action<Exception, Image> onError, Action<Image> onCompleted)
        {
            return source.SubscribeWithState(image, (x, t) =>
            {
                var current = t.color;
                current.a = x;
                t.color = current;
            }, onError, onCompleted);
        }

        public static IObservable<float> DoToFade(this IObservable<float> source, Image image)
        {
            return source.Do(x =>
            {
                var current = image.color;
                current.a = x;
                image.color = current;
            });
        }

        public static IObservable<float> DoToFade(this IObservable<float> source, Image image, Action<Exception> onError)
        {
            return source.Do(x =>
            {
                var current = image.color;
                current.a = x;
                image.color = current;
            }, onError);
        }

        public static IObservable<float> DoToFade(this IObservable<float> source, Image image, Action onCompleted)
        {
            return source.Do(x =>
            {
                var current = image.color;
                current.a = x;
                image.color = current;
            }, onCompleted);
        }

        public static IObservable<float> DoToFade(this IObservable<float> source, Image image, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x =>
            {
                var current = image.color;
                current.a = x;
                image.color = current;
            }, onError, onCompleted);
        }
    }
}