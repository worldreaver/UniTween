using System;
using System.Collections.Generic;
using UnityEngine;

namespace Worldreaver.UniTween
{
    public static class GameObjectLocalPositionExtensions
    {
        public static IDisposable SubscribeToLocalPosition(this IObservable<Vector3> source, GameObject gameObject)
        {
            return source.SubscribeToLocalPosition(gameObject.transform);
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<Vector3> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToLocalPosition(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<Vector3> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalPosition(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<Vector3> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalPosition(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<IList<float>> source, GameObject gameObject)
        {
            return source.SubscribeToLocalPosition(gameObject.transform);
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<IList<float>> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToLocalPosition(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<IList<float>> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalPosition(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<IList<float>> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalPosition(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<List<float>> source, GameObject gameObject)
        {
            return source.SubscribeToLocalPosition(gameObject.transform);
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<List<float>> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToLocalPosition(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<List<float>> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalPosition(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<List<float>> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalPosition(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<float[]> source, GameObject gameObject)
        {
            return source.SubscribeToLocalPosition(gameObject.transform);
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<float[]> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToLocalPosition(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<float[]> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalPosition(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<float[]> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalPosition(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalPositionX(this IObservable<float> source, GameObject gameObject)
        {
            return source.SubscribeToLocalPositionX(gameObject.transform);
        }

        public static IDisposable SubscribeToLocalPositionX(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToLocalPositionX(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToLocalPositionX(this IObservable<float> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalPositionX(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToLocalPositionX(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalPositionX(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalPositionY(this IObservable<float> source, GameObject gameObject)
        {
            return source.SubscribeToLocalPositionY(gameObject.transform);
        }

        public static IDisposable SubscribeToLocalPositionY(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToLocalPositionY(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToLocalPositionY(this IObservable<float> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalPositionY(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToLocalPositionY(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalPositionY(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalPositionZ(this IObservable<float> source, GameObject gameObject)
        {
            return source.SubscribeToLocalPositionZ(gameObject.transform);
        }

        public static IDisposable SubscribeToLocalPositionZ(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToLocalPositionZ(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToLocalPositionZ(this IObservable<float> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalPositionZ(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToLocalPositionZ(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalPositionZ(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<Vector3> DoToLocalPosition(this IObservable<Vector3> source, GameObject gameObject)
        {
            return source.DoToLocalPosition(gameObject.transform);
        }

        public static IObservable<Vector3> DoToLocalPosition(this IObservable<Vector3> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToLocalPosition(gameObject.transform, onError);
        }

        public static IObservable<Vector3> DoToLocalPosition(this IObservable<Vector3> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToLocalPosition(gameObject.transform, onCompleted);
        }

        public static IObservable<Vector3> DoToLocalPosition(this IObservable<Vector3> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToLocalPosition(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<IList<float>> DoToLocalPosition(this IObservable<IList<float>> source, GameObject gameObject)
        {
            return source.DoToLocalPosition(gameObject.transform);
        }

        public static IObservable<IList<float>> DoToLocalPosition(this IObservable<IList<float>> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToLocalPosition(gameObject.transform, onError);
        }

        public static IObservable<IList<float>> DoToLocalPosition(this IObservable<IList<float>> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToLocalPosition(gameObject.transform, onCompleted);
        }

        public static IObservable<IList<float>> DoToLocalPosition(this IObservable<IList<float>> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToLocalPosition(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<List<float>> DoToLocalPosition(this IObservable<List<float>> source, GameObject gameObject)
        {
            return source.DoToLocalPosition(gameObject.transform);
        }

        public static IObservable<List<float>> DoToLocalPosition(this IObservable<List<float>> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToLocalPosition(gameObject.transform, onError);
        }

        public static IObservable<List<float>> DoToLocalPosition(this IObservable<List<float>> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToLocalPosition(gameObject.transform, onCompleted);
        }

        public static IObservable<List<float>> DoToLocalPosition(this IObservable<List<float>> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToLocalPosition(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<float[]> DoToLocalPosition(this IObservable<float[]> source, GameObject gameObject)
        {
            return source.DoToLocalPosition(gameObject.transform);
        }

        public static IObservable<float[]> DoToLocalPosition(this IObservable<float[]> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToLocalPosition(gameObject.transform, onError);
        }

        public static IObservable<float[]> DoToLocalPosition(this IObservable<float[]> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToLocalPosition(gameObject.transform, onCompleted);
        }

        public static IObservable<float[]> DoToLocalPosition(this IObservable<float[]> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToLocalPosition(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<float> DoToLocalPositionX(this IObservable<float> source, GameObject gameObject)
        {
            return source.DoToLocalPositionX(gameObject.transform);
        }

        public static IObservable<float> DoToLocalPositionX(this IObservable<float> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToLocalPositionX(gameObject.transform, onError);
        }

        public static IObservable<float> DoToLocalPositionX(this IObservable<float> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToLocalPositionX(gameObject.transform, onCompleted);
        }

        public static IObservable<float> DoToLocalPositionX(this IObservable<float> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToLocalPositionX(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<float> DoToLocalPositionY(this IObservable<float> source, GameObject gameObject)
        {
            return source.DoToLocalPositionY(gameObject.transform);
        }

        public static IObservable<float> DoToLocalPositionY(this IObservable<float> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToLocalPositionY(gameObject.transform, onError);
        }

        public static IObservable<float> DoToLocalPositionY(this IObservable<float> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToLocalPositionY(gameObject.transform, onCompleted);
        }

        public static IObservable<float> DoToLocalPositionY(this IObservable<float> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToLocalPositionY(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<float> DoToLocalPositionZ(this IObservable<float> source, GameObject gameObject)
        {
            return source.DoToLocalPositionZ(gameObject.transform);
        }

        public static IObservable<float> DoToLocalPositionZ(this IObservable<float> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToLocalPositionZ(gameObject.transform, onError);
        }

        public static IObservable<float> DoToLocalPositionZ(this IObservable<float> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToLocalPositionZ(gameObject.transform, onCompleted);
        }

        public static IObservable<float> DoToLocalPositionZ(this IObservable<float> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToLocalPositionZ(gameObject.transform, onError, onCompleted);
        }
    }
}