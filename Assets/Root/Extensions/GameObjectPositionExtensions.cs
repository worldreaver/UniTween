using System;
using System.Collections.Generic;
using UnityEngine;

namespace Worldreaver.UniTween
{
    public static class GameObjectPositionExtensions
    {
        public static IDisposable SubscribeToPosition(this IObservable<Vector3> source, GameObject gameObject)
        {
            return source.SubscribeToPosition(gameObject.transform);
        }

        public static IDisposable SubscribeToPosition(this IObservable<Vector3> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToPosition(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToPosition(this IObservable<Vector3> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToPosition(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToPosition(this IObservable<Vector3> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToPosition(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToPosition(this IObservable<IList<float>> source, GameObject gameObject)
        {
            return source.SubscribeToPosition(gameObject.transform);
        }

        public static IDisposable SubscribeToPosition(this IObservable<IList<float>> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToPosition(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToPosition(this IObservable<IList<float>> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToPosition(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToPosition(this IObservable<IList<float>> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToPosition(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToPosition(this IObservable<List<float>> source, GameObject gameObject)
        {
            return source.SubscribeToPosition(gameObject.transform);
        }

        public static IDisposable SubscribeToPosition(this IObservable<List<float>> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToPosition(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToPosition(this IObservable<List<float>> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToPosition(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToPosition(this IObservable<List<float>> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToPosition(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToPosition(this IObservable<float[]> source, GameObject gameObject)
        {
            return source.SubscribeToPosition(gameObject.transform);
        }

        public static IDisposable SubscribeToPosition(this IObservable<float[]> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToPosition(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToPosition(this IObservable<float[]> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToPosition(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToPosition(this IObservable<float[]> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToPosition(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToPositionX(this IObservable<float> source, GameObject gameObject)
        {
            return source.SubscribeToPositionX(gameObject.transform);
        }

        public static IDisposable SubscribeToPositionX(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToPositionX(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToPositionX(this IObservable<float> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToPositionX(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToPositionX(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToPositionX(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToPositionY(this IObservable<float> source, GameObject gameObject)
        {
            return source.SubscribeToPositionY(gameObject.transform);
        }

        public static IDisposable SubscribeToPositionY(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToPositionY(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToPositionY(this IObservable<float> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToPositionY(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToPositionY(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToPositionY(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToPositionZ(this IObservable<float> source, GameObject gameObject)
        {
            return source.SubscribeToPositionZ(gameObject.transform);
        }

        public static IDisposable SubscribeToPositionZ(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToPositionZ(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToPositionZ(this IObservable<float> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToPositionZ(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToPositionZ(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToPositionZ(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<Vector3> DoToPosition(this IObservable<Vector3> source, GameObject gameObject)
        {
            return source.DoToPosition(gameObject.transform);
        }

        public static IObservable<Vector3> DoToPosition(this IObservable<Vector3> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToPosition(gameObject.transform, onError);
        }

        public static IObservable<Vector3> DoToPosition(this IObservable<Vector3> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToPosition(gameObject.transform, onCompleted);
        }

        public static IObservable<Vector3> DoToPosition(this IObservable<Vector3> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToPosition(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<IList<float>> DoToPosition(this IObservable<IList<float>> source, GameObject gameObject)
        {
            return source.DoToPosition(gameObject.transform);
        }

        public static IObservable<IList<float>> DoToPosition(this IObservable<IList<float>> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToPosition(gameObject.transform, onError);
        }

        public static IObservable<IList<float>> DoToPosition(this IObservable<IList<float>> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToPosition(gameObject.transform, onCompleted);
        }

        public static IObservable<IList<float>> DoToPosition(this IObservable<IList<float>> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToPosition(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<List<float>> DoToPosition(this IObservable<List<float>> source, GameObject gameObject)
        {
            return source.DoToPosition(gameObject.transform);
        }

        public static IObservable<List<float>> DoToPosition(this IObservable<List<float>> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToPosition(gameObject.transform, onError);
        }

        public static IObservable<List<float>> DoToPosition(this IObservable<List<float>> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToPosition(gameObject.transform, onCompleted);
        }

        public static IObservable<List<float>> DoToPosition(this IObservable<List<float>> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToPosition(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<float[]> DoToPosition(this IObservable<float[]> source, GameObject gameObject)
        {
            return source.DoToPosition(gameObject.transform);
        }

        public static IObservable<float[]> DoToPosition(this IObservable<float[]> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToPosition(gameObject.transform, onError);
        }

        public static IObservable<float[]> DoToPosition(this IObservable<float[]> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToPosition(gameObject.transform, onCompleted);
        }

        public static IObservable<float[]> DoToPosition(this IObservable<float[]> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToPosition(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<float> DoToPositionX(this IObservable<float> source, GameObject gameObject)
        {
            return source.DoToPositionX(gameObject.transform);
        }

        public static IObservable<float> DoToPositionX(this IObservable<float> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToPositionX(gameObject.transform, onError);
        }

        public static IObservable<float> DoToPositionX(this IObservable<float> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToPositionX(gameObject.transform, onCompleted);
        }

        public static IObservable<float> DoToPositionX(this IObservable<float> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToPositionX(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<float> DoToPositionY(this IObservable<float> source, GameObject gameObject)
        {
            return source.DoToPositionY(gameObject.transform);
        }

        public static IObservable<float> DoToPositionY(this IObservable<float> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToPositionY(gameObject.transform, onError);
        }

        public static IObservable<float> DoToPositionY(this IObservable<float> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToPositionY(gameObject.transform, onCompleted);
        }

        public static IObservable<float> DoToPositionY(this IObservable<float> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToPositionY(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<float> DoToPositionZ(this IObservable<float> source, GameObject gameObject)
        {
            return source.DoToPositionZ(gameObject.transform);
        }

        public static IObservable<float> DoToPositionZ(this IObservable<float> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToPositionZ(gameObject.transform, onError);
        }

        public static IObservable<float> DoToPositionZ(this IObservable<float> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToPositionZ(gameObject.transform, onCompleted);
        }

        public static IObservable<float> DoToPositionZ(this IObservable<float> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToPositionZ(gameObject.transform, onError, onCompleted);
        }
    }
}