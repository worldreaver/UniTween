using System;
using System.Collections.Generic;
using UnityEngine;

namespace Worldreaver.UniTween
{
    public static class GameObjectRotationExtensions
    {
        public static IDisposable SubscribeToRotation(this IObservable<Vector3> source, GameObject gameObject)
        {
            return source.SubscribeToRotation(gameObject.transform);
        }

        public static IDisposable SubscribeToRotation(this IObservable<Vector3> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToRotation(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToRotation(this IObservable<Vector3> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToRotation(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToRotation(this IObservable<Vector3> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToRotation(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToRotation(this IObservable<IList<float>> source, GameObject gameObject)
        {
            return source.SubscribeToRotation(gameObject.transform);
        }

        public static IDisposable SubscribeToRotation(this IObservable<IList<float>> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToRotation(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToRotation(this IObservable<IList<float>> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToRotation(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToRotation(this IObservable<IList<float>> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToRotation(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToRotation(this IObservable<List<float>> source, GameObject gameObject)
        {
            return source.SubscribeToRotation(gameObject.transform);
        }

        public static IDisposable SubscribeToRotation(this IObservable<List<float>> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToRotation(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToRotation(this IObservable<List<float>> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToRotation(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToRotation(this IObservable<List<float>> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToRotation(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToRotation(this IObservable<float[]> source, GameObject gameObject)
        {
            return source.SubscribeToRotation(gameObject.transform);
        }

        public static IDisposable SubscribeToRotation(this IObservable<float[]> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToRotation(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToRotation(this IObservable<float[]> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToRotation(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToRotation(this IObservable<float[]> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToRotation(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToRotationX(this IObservable<float> source, GameObject gameObject)
        {
            return source.SubscribeToRotationX(gameObject.transform);
        }

        public static IDisposable SubscribeToRotationX(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToRotationX(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToRotationX(this IObservable<float> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToRotationX(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToRotationX(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToRotationX(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToRotationY(this IObservable<float> source, GameObject gameObject)
        {
            return source.SubscribeToRotationY(gameObject.transform);
        }

        public static IDisposable SubscribeToRotationY(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToRotationY(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToRotationY(this IObservable<float> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToRotationY(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToRotationY(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToRotationY(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToRotationZ(this IObservable<float> source, GameObject gameObject)
        {
            return source.SubscribeToRotationZ(gameObject.transform);
        }

        public static IDisposable SubscribeToRotationZ(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToRotationZ(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToRotationZ(this IObservable<float> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToRotationZ(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToRotationZ(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToRotationZ(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<Vector3> DoToRotation(this IObservable<Vector3> source, GameObject gameObject)
        {
            return source.DoToRotation(gameObject.transform);
        }

        public static IObservable<Vector3> DoToRotation(this IObservable<Vector3> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToRotation(gameObject.transform, onError);
        }

        public static IObservable<Vector3> DoToRotation(this IObservable<Vector3> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToRotation(gameObject.transform, onCompleted);
        }

        public static IObservable<Vector3> DoToRotation(this IObservable<Vector3> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToRotation(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<IList<float>> DoToRotation(this IObservable<IList<float>> source, GameObject gameObject)
        {
            return source.DoToRotation(gameObject.transform);
        }

        public static IObservable<IList<float>> DoToRotation(this IObservable<IList<float>> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToRotation(gameObject.transform, onError);
        }

        public static IObservable<IList<float>> DoToRotation(this IObservable<IList<float>> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToRotation(gameObject.transform, onCompleted);
        }

        public static IObservable<IList<float>> DoToRotation(this IObservable<IList<float>> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToRotation(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<List<float>> DoToRotation(this IObservable<List<float>> source, GameObject gameObject)
        {
            return source.DoToRotation(gameObject.transform);
        }

        public static IObservable<List<float>> DoToRotation(this IObservable<List<float>> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToRotation(gameObject.transform, onError);
        }

        public static IObservable<List<float>> DoToRotation(this IObservable<List<float>> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToRotation(gameObject.transform, onCompleted);
        }

        public static IObservable<List<float>> DoToRotation(this IObservable<List<float>> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToRotation(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<float[]> DoToRotation(this IObservable<float[]> source, GameObject gameObject)
        {
            return source.DoToRotation(gameObject.transform);
        }

        public static IObservable<float[]> DoToRotation(this IObservable<float[]> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToRotation(gameObject.transform, onError);
        }

        public static IObservable<float[]> DoToRotation(this IObservable<float[]> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToRotation(gameObject.transform, onCompleted);
        }

        public static IObservable<float[]> DoToRotation(this IObservable<float[]> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToRotation(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<float> DoToRotationX(this IObservable<float> source, GameObject gameObject)
        {
            return source.DoToRotationX(gameObject.transform);
        }

        public static IObservable<float> DoToRotationX(this IObservable<float> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToRotationX(gameObject.transform, onError);
        }

        public static IObservable<float> DoToRotationX(this IObservable<float> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToRotationX(gameObject.transform, onCompleted);
        }

        public static IObservable<float> DoToRotationX(this IObservable<float> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToRotationX(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<float> DoToRotationY(this IObservable<float> source, GameObject gameObject)
        {
            return source.DoToRotationY(gameObject.transform);
        }

        public static IObservable<float> DoToRotationY(this IObservable<float> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToRotationY(gameObject.transform, onError);
        }

        public static IObservable<float> DoToRotationY(this IObservable<float> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToRotationY(gameObject.transform, onCompleted);
        }

        public static IObservable<float> DoToRotationY(this IObservable<float> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToRotationY(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<float> DoToRotationZ(this IObservable<float> source, GameObject gameObject)
        {
            return source.DoToRotationZ(gameObject.transform);
        }

        public static IObservable<float> DoToRotationZ(this IObservable<float> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToRotationZ(gameObject.transform, onError);
        }

        public static IObservable<float> DoToRotationZ(this IObservable<float> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToRotationZ(gameObject.transform, onCompleted);
        }

        public static IObservable<float> DoToRotationZ(this IObservable<float> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToRotationZ(gameObject.transform, onError, onCompleted);
        }
    }
}