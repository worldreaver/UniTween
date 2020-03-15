using System;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Worldreaver.UniTween
{
    public static class TransformRotationExtensions
    {
        public static IDisposable SubscribeToRotation(this IObservable<Vector3> source, Transform transform)
        {
            return source.SubscribeWithState(transform, (x, t) => t.eulerAngles = x);
        }

        public static IDisposable SubscribeToRotation(this IObservable<Vector3> source, Transform transform, Action<Exception, Transform> onError)
        {
            return source.SubscribeWithState(transform, (x, t) => t.eulerAngles = x, onError);
        }

        public static IDisposable SubscribeToRotation(this IObservable<Vector3> source, Transform transform, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.eulerAngles = x, onCompleted);
        }

        public static IDisposable SubscribeToRotation(this IObservable<Vector3> source, Transform transform, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.eulerAngles = x, onError, onCompleted);
        }

        public static IDisposable SubscribeToRotation(this IObservable<IList<float>> source, Transform transform)
        {
            return source.SubscribeWithState(transform, (x, t) => t.eulerAngles = new Vector3(x[0], x[1], x[2]));
        }

        public static IDisposable SubscribeToRotation(this IObservable<IList<float>> source, Transform transform, Action<Exception, Transform> onError)
        {
            return source.SubscribeWithState(transform, (x, t) => t.eulerAngles = new Vector3(x[0], x[1], x[2]), onError);
        }

        public static IDisposable SubscribeToRotation(this IObservable<IList<float>> source, Transform transform, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.eulerAngles = new Vector3(x[0], x[1], x[2]), onCompleted);
        }

        public static IDisposable SubscribeToRotation(this IObservable<IList<float>> source, Transform transform, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.eulerAngles = new Vector3(x[0], x[1], x[2]), onError, onCompleted);
        }

        public static IDisposable SubscribeToRotation(this IObservable<List<float>> source, Transform transform)
        {
            return source.SubscribeWithState(transform, (x, t) => t.eulerAngles = new Vector3(x[0], x[1], x[2]));
        }

        public static IDisposable SubscribeToRotation(this IObservable<List<float>> source, Transform transform, Action<Exception, Transform> onError)
        {
            return source.SubscribeWithState(transform, (x, t) => t.eulerAngles = new Vector3(x[0], x[1], x[2]), onError);
        }

        public static IDisposable SubscribeToRotation(this IObservable<List<float>> source, Transform transform, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.eulerAngles = new Vector3(x[0], x[1], x[2]), onCompleted);
        }

        public static IDisposable SubscribeToRotation(this IObservable<List<float>> source, Transform transform, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.eulerAngles = new Vector3(x[0], x[1], x[2]), onError, onCompleted);
        }

        public static IDisposable SubscribeToRotation(this IObservable<float[]> source, Transform transform)
        {
            return source.SubscribeWithState(transform, (x, t) => t.eulerAngles = new Vector3(x[0], x[1], x[2]));
        }

        public static IDisposable SubscribeToRotation(this IObservable<float[]> source, Transform transform, Action<Exception, Transform> onError)
        {
            return source.SubscribeWithState(transform, (x, t) => t.eulerAngles = new Vector3(x[0], x[1], x[2]), onError);
        }

        public static IDisposable SubscribeToRotation(this IObservable<float[]> source, Transform transform, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.eulerAngles = new Vector3(x[0], x[1], x[2]), onCompleted);
        }

        public static IDisposable SubscribeToRotation(this IObservable<float[]> source, Transform transform, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.eulerAngles = new Vector3(x[0], x[1], x[2]), onError, onCompleted);
        }

        public static IDisposable SubscribeToRotationX(this IObservable<float> source, Transform transform)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.eulerAngles;
                p.x = x;
                t.eulerAngles = p;
            });
        }

        public static IDisposable SubscribeToRotationX(this IObservable<float> source, Transform transform, Action<Exception, Transform> onError)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.eulerAngles;
                p.x = x;
                t.eulerAngles = p;
            }, onError);
        }

        public static IDisposable SubscribeToRotationX(this IObservable<float> source, Transform transform, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.eulerAngles;
                p.x = x;
                t.eulerAngles = p;
            }, onCompleted);
        }

        public static IDisposable SubscribeToRotationX(this IObservable<float> source, Transform transform, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.eulerAngles;
                p.x = x;
                t.eulerAngles = p;
            }, onError, onCompleted);
        }

        public static IDisposable SubscribeToRotationY(this IObservable<float> source, Transform transform)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.eulerAngles;
                p.y = x;
                t.eulerAngles = p;
            });
        }

        public static IDisposable SubscribeToRotationY(this IObservable<float> source, Transform transform, Action<Exception, Transform> onError)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.eulerAngles;
                p.y = x;
                t.eulerAngles = p;
            }, onError);
        }

        public static IDisposable SubscribeToRotationY(this IObservable<float> source, Transform transform, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.eulerAngles;
                p.y = x;
                t.eulerAngles = p;
            }, onCompleted);
        }

        public static IDisposable SubscribeToRotationY(this IObservable<float> source, Transform transform, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.eulerAngles;
                p.y = x;
                t.eulerAngles = p;
            }, onError, onCompleted);
        }

        public static IDisposable SubscribeToRotationZ(this IObservable<float> source, Transform transform)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.eulerAngles;
                p.z = x;
                t.eulerAngles = p;
            });
        }

        public static IDisposable SubscribeToRotationZ(this IObservable<float> source, Transform transform, Action<Exception, Transform> onError)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.eulerAngles;
                p.z = x;
                t.eulerAngles = p;
            }, onError);
        }

        public static IDisposable SubscribeToRotationZ(this IObservable<float> source, Transform transform, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.eulerAngles;
                p.z = x;
                t.eulerAngles = p;
            }, onCompleted);
        }

        public static IDisposable SubscribeToRotationZ(this IObservable<float> source, Transform transform, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.eulerAngles;
                p.z = x;
                t.eulerAngles = p;
            }, onError, onCompleted);
        }

        public static IObservable<Vector3> DoToRotation(this IObservable<Vector3> source, Transform transform)
        {
            return source.Do(x => transform.eulerAngles = x);
        }

        public static IObservable<Vector3> DoToRotation(this IObservable<Vector3> source, Transform transform, Action<Exception> onError)
        {
            return source.Do(x => transform.eulerAngles = x, onError);
        }

        public static IObservable<Vector3> DoToRotation(this IObservable<Vector3> source, Transform transform, Action onCompleted)
        {
            return source.Do(x => transform.eulerAngles = x, onCompleted);
        }

        public static IObservable<Vector3> DoToRotation(this IObservable<Vector3> source, Transform transform, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x => transform.eulerAngles = x, onError, onCompleted);
        }

        public static IObservable<IList<float>> DoToRotation(this IObservable<IList<float>> source, Transform transform)
        {
            return source.Do(x => transform.eulerAngles = new Vector3(x[0], x[1], x[2]));
        }

        public static IObservable<IList<float>> DoToRotation(this IObservable<IList<float>> source, Transform transform, Action<Exception> onError)
        {
            return source.Do(x => transform.eulerAngles = new Vector3(x[0], x[1], x[2]), onError);
        }

        public static IObservable<IList<float>> DoToRotation(this IObservable<IList<float>> source, Transform transform, Action onCompleted)
        {
            return source.Do(x => transform.eulerAngles = new Vector3(x[0], x[1], x[2]), onCompleted);
        }

        public static IObservable<IList<float>> DoToRotation(this IObservable<IList<float>> source, Transform transform, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x => transform.eulerAngles = new Vector3(x[0], x[1], x[2]), onError, onCompleted);
        }

        public static IObservable<List<float>> DoToRotation(this IObservable<List<float>> source, Transform transform)
        {
            return source.Do(x => transform.eulerAngles = new Vector3(x[0], x[1], x[2]));
        }

        public static IObservable<List<float>> DoToRotation(this IObservable<List<float>> source, Transform transform, Action<Exception> onError)
        {
            return source.Do(x => transform.eulerAngles = new Vector3(x[0], x[1], x[2]), onError);
        }

        public static IObservable<List<float>> DoToRotation(this IObservable<List<float>> source, Transform transform, Action onCompleted)
        {
            return source.Do(x => transform.eulerAngles = new Vector3(x[0], x[1], x[2]), onCompleted);
        }

        public static IObservable<List<float>> DoToRotation(this IObservable<List<float>> source, Transform transform, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x => transform.eulerAngles = new Vector3(x[0], x[1], x[2]), onError, onCompleted);
        }

        public static IObservable<float[]> DoToRotation(this IObservable<float[]> source, Transform transform)
        {
            return source.Do(x => transform.eulerAngles = new Vector3(x[0], x[1], x[2]));
        }

        public static IObservable<float[]> DoToRotation(this IObservable<float[]> source, Transform transform, Action<Exception> onError)
        {
            return source.Do(x => transform.eulerAngles = new Vector3(x[0], x[1], x[2]), onError);
        }

        public static IObservable<float[]> DoToRotation(this IObservable<float[]> source, Transform transform, Action onCompleted)
        {
            return source.Do(x => transform.eulerAngles = new Vector3(x[0], x[1], x[2]), onCompleted);
        }

        public static IObservable<float[]> DoToRotation(this IObservable<float[]> source, Transform transform, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x => transform.eulerAngles = new Vector3(x[0], x[1], x[2]), onError, onCompleted);
        }

        public static IObservable<float> DoToRotationX(this IObservable<float> source, Transform transform)
        {
            return source.Do(x =>
            {
                var p = transform.eulerAngles;
                p.x = x;
                transform.eulerAngles = p;
            });
        }

        public static IObservable<float> DoToRotationX(this IObservable<float> source, Transform transform, Action<Exception> onError)
        {
            return source.Do(x =>
            {
                var p = transform.eulerAngles;
                p.x = x;
                transform.eulerAngles = p;
            }, onError);
        }

        public static IObservable<float> DoToRotationX(this IObservable<float> source, Transform transform, Action onCompleted)
        {
            return source.Do(x =>
            {
                var p = transform.eulerAngles;
                p.x = x;
                transform.eulerAngles = p;
            }, onCompleted);
        }

        public static IObservable<float> DoToRotationX(this IObservable<float> source, Transform transform, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x =>
            {
                var p = transform.eulerAngles;
                p.x = x;
                transform.eulerAngles = p;
            }, onError, onCompleted);
        }

        public static IObservable<float> DoToRotationY(this IObservable<float> source, Transform transform)
        {
            return source.Do(x =>
            {
                var p = transform.eulerAngles;
                p.y = x;
                transform.eulerAngles = p;
            });
        }

        public static IObservable<float> DoToRotationY(this IObservable<float> source, Transform transform, Action<Exception> onError)
        {
            return source.Do(x =>
            {
                var p = transform.eulerAngles;
                p.y = x;
                transform.eulerAngles = p;
            }, onError);
        }

        public static IObservable<float> DoToRotationY(this IObservable<float> source, Transform transform, Action onCompleted)
        {
            return source.Do(x =>
            {
                var p = transform.eulerAngles;
                p.y = x;
                transform.eulerAngles = p;
            }, onCompleted);
        }

        public static IObservable<float> DoToRotationY(this IObservable<float> source, Transform transform, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x =>
            {
                var p = transform.eulerAngles;
                p.y = x;
                transform.eulerAngles = p;
            }, onError, onCompleted);
        }

        public static IObservable<float> DoToRotationZ(this IObservable<float> source, Transform transform)
        {
            return source.Do(x =>
            {
                var p = transform.eulerAngles;
                p.z = x;
                transform.eulerAngles = p;
            });
        }

        public static IObservable<float> DoToRotationZ(this IObservable<float> source, Transform transform, Action<Exception> onError)
        {
            return source.Do(x =>
            {
                var p = transform.eulerAngles;
                p.z = x;
                transform.eulerAngles = p;
            }, onError);
        }

        public static IObservable<float> DoToRotationZ(this IObservable<float> source, Transform transform, Action onCompleted)
        {
            return source.Do(x =>
            {
                var p = transform.eulerAngles;
                p.z = x;
                transform.eulerAngles = p;
            }, onCompleted);
        }

        public static IObservable<float> DoToRotationZ(this IObservable<float> source, Transform transform, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x =>
            {
                var p = transform.eulerAngles;
                p.z = x;
                transform.eulerAngles = p;
            }, onError, onCompleted);
        }
    }
}