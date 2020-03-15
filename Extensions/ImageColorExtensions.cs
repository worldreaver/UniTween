using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Worldreaver.UniTween
{
    public static class ImageColorExtensions
    {
        public static IDisposable SubscribeToColor(this IObservable<Color> source, Image image)
        {
            return source.SubscribeWithState(image, (x, t) => t.color = x);
        }

        public static IDisposable SubscribeToColor(this IObservable<Color> source, Image image, Action<Exception, Image> onError)
        {
            return source.SubscribeWithState(image, (x, t) => t.color = x, onError);
        }

        public static IDisposable SubscribeToColor(this IObservable<Color> source, Image image, Action<Image> onCompleted)
        {
            return source.SubscribeWithState(image, (x, t) => t.color = x, onCompleted);
        }

        public static IDisposable SubscribeToColor(this IObservable<Color> source, Image image, Action<Exception, Image> onError, Action<Image> onCompleted)
        {
            return source.SubscribeWithState(image, (x, t) => t.color = x, onError, onCompleted);
        }

        public static IObservable<Color> DoToColor(this IObservable<Color> source, Image image)
        {
            return source.Do(x => image.color = x);
        }

        public static IObservable<Color> DoToColor(this IObservable<Color> source, Image image, Action<Exception> onError)
        {
            return source.Do(x => image.color = x, onError);
        }

        public static IObservable<Color> DoToColor(this IObservable<Color> source, Image image, Action onCompleted)
        {
            return source.Do(x => image.color = x, onCompleted);
        }

        public static IObservable<Color> DoToColor(this IObservable<Color> source, Image image, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x => image.color = x, onError, onCompleted);
        }
    }
}