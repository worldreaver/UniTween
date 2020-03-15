using System;
using UniRx;
using UnityEngine.UI;

namespace Worldreaver.UniTween
{
    public static class ImageFillAmountExtensions
    {
        public static IDisposable SubscribeToFillAmount(this IObservable<float> source, Image image)
        {
            return source.SubscribeWithState(image, (x, t) => t.fillAmount = x);
        }

        public static IDisposable SubscribeToFillAmount(this IObservable<float> source, Image image, Action<Exception, Image> onError)
        {
            return source.SubscribeWithState(image, (x, t) => t.fillAmount = x, onError);
        }

        public static IDisposable SubscribeToFillAmount(this IObservable<float> source, Image image, Action<Image> onCompleted)
        {
            return source.SubscribeWithState(image, (x, t) => t.fillAmount = x, onCompleted);
        }

        public static IDisposable SubscribeToFillAmount(this IObservable<float> source, Image image, Action<Exception, Image> onError, Action<Image> onCompleted)
        {
            return source.SubscribeWithState(image, (x, t) => t.fillAmount = x, onError, onCompleted);
        }

        public static IObservable<float> DoToFillAmount(this IObservable<float> source, Image image)
        {
            return source.Do(x => image.fillAmount = x);
        }

        public static IObservable<float> DoToFillAmount(this IObservable<float> source, Image image, Action<Exception> onError)
        {
            return source.Do(x => image.fillAmount = x, onError);
        }

        public static IObservable<float> DoToFillAmount(this IObservable<float> source, Image image, Action onCompleted)
        {
            return source.Do(x => image.fillAmount = x, onCompleted);
        }

        public static IObservable<float> DoToFillAmount(this IObservable<float> source, Image image, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x => image.fillAmount = x, onError, onCompleted);
        }
    }
}