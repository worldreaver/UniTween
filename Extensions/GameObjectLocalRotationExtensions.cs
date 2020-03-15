using System;
using System.Collections.Generic;
using UnityEngine;

namespace Worldreaver.UniTween
{
    public static class GameObjectLocalRotationExtensions
    {
        public static IDisposable SubscribeToLocalRotation(this IObservable<Vector3> source, GameObject gameObject)
        {
            return source.SubscribeToLocalRotation(gameObject.transform);
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<Vector3> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToLocalRotation(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<Vector3> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalRotation(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<Vector3> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalRotation(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<IList<float>> source, GameObject gameObject)
        {
            return source.SubscribeToLocalRotation(gameObject.transform);
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<IList<float>> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToLocalRotation(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<IList<float>> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalRotation(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<IList<float>> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalRotation(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<List<float>> source, GameObject gameObject)
        {
            return source.SubscribeToLocalRotation(gameObject.transform);
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<List<float>> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToLocalRotation(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<List<float>> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalRotation(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<List<float>> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalRotation(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<float[]> source, GameObject gameObject)
        {
            return source.SubscribeToLocalRotation(gameObject.transform);
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<float[]> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToLocalRotation(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<float[]> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalRotation(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<float[]> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalRotation(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalRotationX(this IObservable<float> source, GameObject gameObject)
        {
            return source.SubscribeToLocalRotationX(gameObject.transform);
        }

        public static IDisposable SubscribeToLocalRotationX(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToLocalRotationX(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToLocalRotationX(this IObservable<float> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalRotationX(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToLocalRotationX(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalRotationX(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalRotationY(this IObservable<float> source, GameObject gameObject)
        {
            return source.SubscribeToLocalRotationY(gameObject.transform);
        }

        public static IDisposable SubscribeToLocalRotationY(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToLocalRotationY(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToLocalRotationY(this IObservable<float> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalRotationY(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToLocalRotationY(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalRotationY(gameObject.transform, onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalRotationZ(this IObservable<float> source, GameObject gameObject)
        {
            return source.SubscribeToLocalRotationZ(gameObject.transform);
        }

        public static IDisposable SubscribeToLocalRotationZ(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError)
        {
            return source.SubscribeToLocalRotationZ(gameObject.transform, onError);
        }

        public static IDisposable SubscribeToLocalRotationZ(this IObservable<float> source, GameObject gameObject, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalRotationZ(gameObject.transform, onCompleted);
        }

        public static IDisposable SubscribeToLocalRotationZ(this IObservable<float> source, GameObject gameObject, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeToLocalRotationZ(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<Vector3> DoToLocalRotation(this IObservable<Vector3> source, GameObject gameObject)
        {
            return source.DoToLocalRotation(gameObject.transform);
        }

        public static IObservable<Vector3> DoToLocalRotation(this IObservable<Vector3> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToLocalRotation(gameObject.transform, onError);
        }

        public static IObservable<Vector3> DoToLocalRotation(this IObservable<Vector3> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToLocalRotation(gameObject.transform, onCompleted);
        }

        public static IObservable<Vector3> DoToLocalRotation(this IObservable<Vector3> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToLocalRotation(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<IList<float>> DoToLocalRotation(this IObservable<IList<float>> source, GameObject gameObject)
        {
            return source.DoToLocalRotation(gameObject.transform);
        }

        public static IObservable<IList<float>> DoToLocalRotation(this IObservable<IList<float>> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToLocalRotation(gameObject.transform, onError);
        }

        public static IObservable<IList<float>> DoToLocalRotation(this IObservable<IList<float>> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToLocalRotation(gameObject.transform, onCompleted);
        }

        public static IObservable<IList<float>> DoToLocalRotation(this IObservable<IList<float>> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToLocalRotation(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<List<float>> DoToLocalRotation(this IObservable<List<float>> source, GameObject gameObject)
        {
            return source.DoToLocalRotation(gameObject.transform);
        }

        public static IObservable<List<float>> DoToLocalRotation(this IObservable<List<float>> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToLocalRotation(gameObject.transform, onError);
        }

        public static IObservable<List<float>> DoToLocalRotation(this IObservable<List<float>> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToLocalRotation(gameObject.transform, onCompleted);
        }

        public static IObservable<List<float>> DoToLocalRotation(this IObservable<List<float>> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToLocalRotation(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<float[]> DoToLocalRotation(this IObservable<float[]> source, GameObject gameObject)
        {
            return source.DoToLocalRotation(gameObject.transform);
        }

        public static IObservable<float[]> DoToLocalRotation(this IObservable<float[]> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToLocalRotation(gameObject.transform, onError);
        }

        public static IObservable<float[]> DoToLocalRotation(this IObservable<float[]> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToLocalRotation(gameObject.transform, onCompleted);
        }

        public static IObservable<float[]> DoToLocalRotation(this IObservable<float[]> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToLocalRotation(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<float> DoToLocalRotationX(this IObservable<float> source, GameObject gameObject)
        {
            return source.DoToLocalRotationX(gameObject.transform);
        }

        public static IObservable<float> DoToLocalRotationX(this IObservable<float> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToLocalRotationX(gameObject.transform, onError);
        }

        public static IObservable<float> DoToLocalRotationX(this IObservable<float> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToLocalRotationX(gameObject.transform, onCompleted);
        }

        public static IObservable<float> DoToLocalRotationX(this IObservable<float> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToLocalRotationX(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<float> DoToLocalRotationY(this IObservable<float> source, GameObject gameObject)
        {
            return source.DoToLocalRotationY(gameObject.transform);
        }

        public static IObservable<float> DoToLocalRotationY(this IObservable<float> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToLocalRotationY(gameObject.transform, onError);
        }

        public static IObservable<float> DoToLocalRotationY(this IObservable<float> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToLocalRotationY(gameObject.transform, onCompleted);
        }

        public static IObservable<float> DoToLocalRotationY(this IObservable<float> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToLocalRotationY(gameObject.transform, onError, onCompleted);
        }

        public static IObservable<float> DoToLocalRotationZ(this IObservable<float> source, GameObject gameObject)
        {
            return source.DoToLocalRotationZ(gameObject.transform);
        }

        public static IObservable<float> DoToLocalRotationZ(this IObservable<float> source, GameObject gameObject, Action<Exception> onError)
        {
            return source.DoToLocalRotationZ(gameObject.transform, onError);
        }

        public static IObservable<float> DoToLocalRotationZ(this IObservable<float> source, GameObject gameObject, Action onCompleted)
        {
            return source.DoToLocalRotationZ(gameObject.transform, onCompleted);
        }

        public static IObservable<float> DoToLocalRotationZ(this IObservable<float> source, GameObject gameObject, Action<Exception> onError, Action onCompleted)
        {
            return source.DoToLocalRotationZ(gameObject.transform, onError, onCompleted);
        }
    }
}