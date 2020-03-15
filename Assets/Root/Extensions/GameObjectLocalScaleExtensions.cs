using System;
using System.Collections.Generic;
using UnityEngine;

namespace Worldreaver.UniTween
{
    public static class GameObjectLocalScaleExtensions
    {
        public static IDisposable SubscribeToLocalScale(this IObservable<Vector3> source, GameObject gameObject)
        {
            return source.SubscribeToLocalScale(gameObject.transform);
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<Vector3> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToLocalScale(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<Vector3> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalScale(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<Vector3> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalScale(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<IList<float>> source, GameObject gameObject)
        {
            return source.SubscribeToLocalScale(gameObject.transform);
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<IList<float>> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToLocalScale(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<IList<float>> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalScale(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<IList<float>> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalScale(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<List<float>> source, GameObject gameObject)
        {
            return source.SubscribeToLocalScale(gameObject.transform);
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<List<float>> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToLocalScale(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<List<float>> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalScale(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<List<float>> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalScale(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<float[]> source, GameObject gameObject)
        {
            return source.SubscribeToLocalScale(gameObject.transform);
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<float[]> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToLocalScale(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<float[]> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalScale(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<float[]> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalScale(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalScaleX(this IObservable<float> source, GameObject gameObject)
        {
            return source.SubscribeToLocalScaleX(gameObject.transform);
        }

        public static IDisposable SubscribeToLocalScaleX(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToLocalScaleX(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToLocalScaleX(this IObservable<float> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalScaleX(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToLocalScaleX(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalScaleX(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalScaleY(this IObservable<float> source, GameObject gameObject)
        {
            return source.SubscribeToLocalScaleY(gameObject.transform);
        }

        public static IDisposable SubscribeToLocalScaleY(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToLocalScaleY(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToLocalScaleY(this IObservable<float> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalScaleY(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToLocalScaleY(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalScaleY(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalScaleZ(this IObservable<float> source, GameObject gameObject)
        {
            return source.SubscribeToLocalScaleZ(gameObject.transform);
        }

        public static IDisposable SubscribeToLocalScaleZ(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToLocalScaleZ(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToLocalScaleZ(this IObservable<float> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalScaleZ(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToLocalScaleZ(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalScaleZ(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<Vector3> DoToLocalScale(this IObservable<Vector3> source, GameObject gameObject)
        {
            return source.DoToLocalScale(gameObject.transform);
        }

        public static IObservable<Vector3> DoToLocalScale(this IObservable<Vector3> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToLocalScale(gameObject.transform, onError);
        }

        public static IObservable<Vector3> DoToLocalScale(this IObservable<Vector3> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToLocalScale(gameObject.transform, onCompleted);
        }

        public static IObservable<Vector3> DoToLocalScale(this IObservable<Vector3> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToLocalScale(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<IList<float>> DoToLocalScale(this IObservable<IList<float>> source, GameObject gameObject)
        {
            return source.DoToLocalScale(gameObject.transform);
        }

        public static IObservable<IList<float>> DoToLocalScale(this IObservable<IList<float>> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToLocalScale(gameObject.transform, onError);
        }

        public static IObservable<IList<float>> DoToLocalScale(this IObservable<IList<float>> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToLocalScale(gameObject.transform, onCompleted);
        }

        public static IObservable<IList<float>> DoToLocalScale(this IObservable<IList<float>> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToLocalScale(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<List<float>> DoToLocalScale(this IObservable<List<float>> source, GameObject gameObject)
        {
            return source.DoToLocalScale(gameObject.transform);
        }

        public static IObservable<List<float>> DoToLocalScale(this IObservable<List<float>> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToLocalScale(gameObject.transform, onError);
        }

        public static IObservable<List<float>> DoToLocalScale(this IObservable<List<float>> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToLocalScale(gameObject.transform, onCompleted);
        }

        public static IObservable<List<float>> DoToLocalScale(this IObservable<List<float>> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToLocalScale(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<float[]> DoToLocalScale(this IObservable<float[]> source, GameObject gameObject)
        {
            return source.DoToLocalScale(gameObject.transform);
        }

        public static IObservable<float[]> DoToLocalScale(this IObservable<float[]> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToLocalScale(gameObject.transform, onError);
        }

        public static IObservable<float[]> DoToLocalScale(this IObservable<float[]> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToLocalScale(gameObject.transform, onCompleted);
        }

        public static IObservable<float[]> DoToLocalScale(this IObservable<float[]> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToLocalScale(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<float> DoToLocalScaleX(this IObservable<float> source, GameObject gameObject)
        {
            return source.DoToLocalScaleX(gameObject.transform);
        }

        public static IObservable<float> DoToLocalScaleX(this IObservable<float> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToLocalScaleX(gameObject.transform, onError);
        }

        public static IObservable<float> DoToLocalScaleX(this IObservable<float> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToLocalScaleX(gameObject.transform, onCompleted);
        }

        public static IObservable<float> DoToLocalScaleX(this IObservable<float> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToLocalScaleX(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<float> DoToLocalScaleY(this IObservable<float> source, GameObject gameObject)
        {
            return source.DoToLocalScaleY(gameObject.transform);
        }

        public static IObservable<float> DoToLocalScaleY(this IObservable<float> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToLocalScaleY(gameObject.transform, onError);
        }

        public static IObservable<float> DoToLocalScaleY(this IObservable<float> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToLocalScaleY(gameObject.transform, onCompleted);
        }

        public static IObservable<float> DoToLocalScaleY(this IObservable<float> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToLocalScaleY(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<float> DoToLocalScaleZ(this IObservable<float> source, GameObject gameObject)
        {
            return source.DoToLocalScaleZ(gameObject.transform);
        }

        public static IObservable<float> DoToLocalScaleZ(this IObservable<float> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToLocalScaleZ(gameObject.transform, onError);
        }

        public static IObservable<float> DoToLocalScaleZ(this IObservable<float> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToLocalScaleZ(gameObject.transform, onCompleted);
        }

        public static IObservable<float> DoToLocalScaleZ(this IObservable<float> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToLocalScaleZ(gameObject.transform, onError, onCompleted);
        }
    }
}