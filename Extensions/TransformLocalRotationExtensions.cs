using System;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Worldreaver.UniTween
{
    public static class TransformLocalRotationExtensions
    {
        public static IDisposable SubscribeToLocalRotation(this IObservable<Vector3> source, Transform transform)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localEulerAngles = x);
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<Vector3> source, Transform transform, Action<Exception, Transform> onError)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localEulerAngles = x, onError);
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<Vector3> source, Transform transform, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localEulerAngles = x, onCompleted);
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<Vector3> source, Transform transform, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localEulerAngles = x, onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<IList<float>> source, Transform transform)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localEulerAngles = new Vector3(x[0], x[1], x[2]));
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<IList<float>> source, Transform transform, Action<Exception, Transform> onError)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localEulerAngles = new Vector3(x[0], x[1], x[2]), onError);
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<IList<float>> source, Transform transform, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localEulerAngles = new Vector3(x[0], x[1], x[2]), onCompleted);
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<IList<float>> source, Transform transform, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localEulerAngles = new Vector3(x[0], x[1], x[2]), onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<List<float>> source, Transform transform)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localEulerAngles = new Vector3(x[0], x[1], x[2]));
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<List<float>> source, Transform transform, Action<Exception, Transform> onError)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localEulerAngles = new Vector3(x[0], x[1], x[2]), onError);
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<List<float>> source, Transform transform, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localEulerAngles = new Vector3(x[0], x[1], x[2]), onCompleted);
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<List<float>> source, Transform transform, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localEulerAngles = new Vector3(x[0], x[1], x[2]), onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<float[]> source, Transform transform)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localEulerAngles = new Vector3(x[0], x[1], x[2]));
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<float[]> source, Transform transform, Action<Exception, Transform> onError)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localEulerAngles = new Vector3(x[0], x[1], x[2]), onError);
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<float[]> source, Transform transform, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localEulerAngles = new Vector3(x[0], x[1], x[2]), onCompleted);
        }

        public static IDisposable SubscribeToLocalRotation(this IObservable<float[]> source, Transform transform, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localEulerAngles = new Vector3(x[0], x[1], x[2]), onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalRotationX(this IObservable<float> source, Transform transform)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localEulerAngles;
                p.x = x;
                t.localEulerAngles = p;
            });
        }

        public static IDisposable SubscribeToLocalRotationX(this IObservable<float> source, Transform transform, Action<Exception, Transform> onError)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localEulerAngles;
                p.x = x;
                t.localEulerAngles = p;
            }, onError);
        }

        public static IDisposable SubscribeToLocalRotationX(this IObservable<float> source, Transform transform, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localEulerAngles;
                p.x = x;
                t.localEulerAngles = p;
            }, onCompleted);
        }

        public static IDisposable SubscribeToLocalRotationX(this IObservable<float> source, Transform transform, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localEulerAngles;
                p.x = x;
                t.localEulerAngles = p;
            }, onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalRotationY(this IObservable<float> source, Transform transform)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localEulerAngles;
                p.y = x;
                t.localEulerAngles = p;
            });
        }

        public static IDisposable SubscribeToLocalRotationY(this IObservable<float> source, Transform transform, Action<Exception, Transform> onError)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localEulerAngles;
                p.y = x;
                t.localEulerAngles = p;
            }, onError);
        }

        public static IDisposable SubscribeToLocalRotationY(this IObservable<float> source, Transform transform, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localEulerAngles;
                p.y = x;
                t.localEulerAngles = p;
            }, onCompleted);
        }

        public static IDisposable SubscribeToLocalRotationY(this IObservable<float> source, Transform transform, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localEulerAngles;
                p.y = x;
                t.localEulerAngles = p;
            }, onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalRotationZ(this IObservable<float> source, Transform transform)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localEulerAngles;
                p.z = x;
                t.localEulerAngles = p;
            });
        }

        public static IDisposable SubscribeToLocalRotationZ(this IObservable<float> source, Transform transform, Action<Exception, Transform> onError)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localEulerAngles;
                p.z = x;
                t.localEulerAngles = p;
            }, onError);
        }

        public static IDisposable SubscribeToLocalRotationZ(this IObservable<float> source, Transform transform, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localEulerAngles;
                p.z = x;
                t.localEulerAngles = p;
            }, onCompleted);
        }

        public static IDisposable SubscribeToLocalRotationZ(this IObservable<float> source, Transform transform, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localEulerAngles;
                p.z = x;
                t.localEulerAngles = p;
            }, onError, onCompleted);
        }

        public static IObservable<Vector3> DoToLocalRotation(this IObservable<Vector3> source, Transform transform)
        {
            return source.Do(x => transform.localEulerAngles = x);
        }

        public static IObservable<Vector3> DoToLocalRotation(this IObservable<Vector3> source, Transform transform, Action<Exception> onError)
        {
            return source.Do(x => transform.localEulerAngles = x, onError);
        }

        public static IObservable<Vector3> DoToLocalRotation(this IObservable<Vector3> source, Transform transform, Action onCompleted)
        {
            return source.Do(x => transform.localEulerAngles = x, onCompleted);
        }

        public static IObservable<Vector3> DoToLocalRotation(this IObservable<Vector3> source, Transform transform, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x => transform.localEulerAngles = x, onError, onCompleted);
        }

        public static IObservable<IList<float>> DoToLocalRotation(this IObservable<IList<float>> source, Transform transform)
        {
            return source.Do(x => transform.localEulerAngles = new Vector3(x[0], x[1], x[2]));
        }

        public static IObservable<IList<float>> DoToLocalRotation(this IObservable<IList<float>> source, Transform transform, Action<Exception> onError)
        {
            return source.Do(x => transform.localEulerAngles = new Vector3(x[0], x[1], x[2]), onError);
        }

        public static IObservable<IList<float>> DoToLocalRotation(this IObservable<IList<float>> source, Transform transform, Action onCompleted)
        {
            return source.Do(x => transform.localEulerAngles = new Vector3(x[0], x[1], x[2]), onCompleted);
        }

        public static IObservable<IList<float>> DoToLocalRotation(this IObservable<IList<float>> source, Transform transform, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x => transform.localEulerAngles = new Vector3(x[0], x[1], x[2]), onError, onCompleted);
        }

        public static IObservable<List<float>> DoToLocalRotation(this IObservable<List<float>> source, Transform transform)
        {
            return source.Do(x => transform.localEulerAngles = new Vector3(x[0], x[1], x[2]));
        }

        public static IObservable<List<float>> DoToLocalRotation(this IObservable<List<float>> source, Transform transform, Action<Exception> onError)
        {
            return source.Do(x => transform.localEulerAngles = new Vector3(x[0], x[1], x[2]), onError);
        }

        public static IObservable<List<float>> DoToLocalRotation(this IObservable<List<float>> source, Transform transform, Action onCompleted)
        {
            return source.Do(x => transform.localEulerAngles = new Vector3(x[0], x[1], x[2]), onCompleted);
        }

        public static IObservable<List<float>> DoToLocalRotation(this IObservable<List<float>> source, Transform transform, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x => transform.localEulerAngles = new Vector3(x[0], x[1], x[2]), onError, onCompleted);
        }

        public static IObservable<float[]> DoToLocalRotation(this IObservable<float[]> source, Transform transform)
        {
            return source.Do(x => transform.localEulerAngles = new Vector3(x[0], x[1], x[2]));
        }

        public static IObservable<float[]> DoToLocalRotation(this IObservable<float[]> source, Transform transform, Action<Exception> onError)
        {
            return source.Do(x => transform.localEulerAngles = new Vector3(x[0], x[1], x[2]), onError);
        }

        public static IObservable<float[]> DoToLocalRotation(this IObservable<float[]> source, Transform transform, Action onCompleted)
        {
            return source.Do(x => transform.localEulerAngles = new Vector3(x[0], x[1], x[2]), onCompleted);
        }

        public static IObservable<float[]> DoToLocalRotation(this IObservable<float[]> source, Transform transform, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x => transform.localEulerAngles = new Vector3(x[0], x[1], x[2]), onError, onCompleted);
        }

        public static IObservable<float> DoToLocalRotationX(this IObservable<float> source, Transform transform)
        {
            return source.Do(x =>
            {
                var p = transform.localEulerAngles;
                p.x = x;
                transform.localEulerAngles = p;
            });
        }

        public static IObservable<float> DoToLocalRotationX(this IObservable<float> source, Transform transform, Action<Exception> onError)
        {
            return source.Do(x =>
            {
                var p = transform.localEulerAngles;
                p.x = x;
                transform.localEulerAngles = p;
            }, onError);
        }

        public static IObservable<float> DoToLocalRotationX(this IObservable<float> source, Transform transform, Action onCompleted)
        {
            return source.Do(x =>
            {
                var p = transform.localEulerAngles;
                p.x = x;
                transform.localEulerAngles = p;
            }, onCompleted);
        }

        public static IObservable<float> DoToLocalRotationX(this IObservable<float> source, Transform transform, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x =>
            {
                var p = transform.localEulerAngles;
                p.x = x;
                transform.localEulerAngles = p;
            }, onError, onCompleted);
        }

        public static IObservable<float> DoToLocalRotationY(this IObservable<float> source, Transform transform)
        {
            return source.Do(x =>
            {
                var p = transform.localEulerAngles;
                p.y = x;
                transform.localEulerAngles = p;
            });
        }

        public static IObservable<float> DoToLocalRotationY(this IObservable<float> source, Transform transform, Action<Exception> onError)
        {
            return source.Do(x =>
            {
                var p = transform.localEulerAngles;
                p.y = x;
                transform.localEulerAngles = p;
            }, onError);
        }

        public static IObservable<float> DoToLocalRotationY(this IObservable<float> source, Transform transform, Action onCompleted)
        {
            return source.Do(x =>
            {
                var p = transform.localEulerAngles;
                p.y = x;
                transform.localEulerAngles = p;
            }, onCompleted);
        }

        public static IObservable<float> DoToLocalRotationY(this IObservable<float> source, Transform transform, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x =>
            {
                var p = transform.localEulerAngles;
                p.y = x;
                transform.localEulerAngles = p;
            }, onError, onCompleted);
        }

        public static IObservable<float> DoToLocalRotationZ(this IObservable<float> source, Transform transform)
        {
            return source.Do(x =>
            {
                var p = transform.localEulerAngles;
                p.z = x;
                transform.localEulerAngles = p;
            });
        }

        public static IObservable<float> DoToLocalRotationZ(this IObservable<float> source, Transform transform, Action<Exception> onError)
        {
            return source.Do(x =>
            {
                var p = transform.localEulerAngles;
                p.z = x;
                transform.localEulerAngles = p;
            }, onError);
        }

        public static IObservable<float> DoToLocalRotationZ(this IObservable<float> source, Transform transform, Action onCompleted)
        {
            return source.Do(x =>
            {
                var p = transform.localEulerAngles;
                p.z = x;
                transform.localEulerAngles = p;
            }, onCompleted);
        }

        public static IObservable<float> DoToLocalRotationZ(this IObservable<float> source, Transform transform, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x =>
            {
                var p = transform.localEulerAngles;
                p.z = x;
                transform.localEulerAngles = p;
            }, onError, onCompleted);
        }
    }
}