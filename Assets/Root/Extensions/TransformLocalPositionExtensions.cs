using System;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Worldreaver.UniTween
{
    public static class TransformLocalPositionExtensions
    {
        public static IDisposable SubscribeToLocalPosition(this IObservable<Vector3> source, Transform transform)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localPosition = x);
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<Vector3> source, Transform transform, Action<Exception, Transform> onError)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localPosition = x, onError);
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<Vector3> source, Transform transform, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localPosition = x, onCompleted);
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<Vector3> source, Transform transform, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localPosition = x, onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<IList<float>> source, Transform transform)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localPosition = new Vector3(x[0], x[1], x[2]));
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<IList<float>> source, Transform transform, Action<Exception, Transform> onError)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localPosition = new Vector3(x[0], x[1], x[2]), onError);
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<IList<float>> source, Transform transform, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localPosition = new Vector3(x[0], x[1], x[2]), onCompleted);
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<IList<float>> source, Transform transform, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localPosition = new Vector3(x[0], x[1], x[2]), onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<List<float>> source, Transform transform)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localPosition = new Vector3(x[0], x[1], x[2]));
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<List<float>> source, Transform transform, Action<Exception, Transform> onError)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localPosition = new Vector3(x[0], x[1], x[2]), onError);
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<List<float>> source, Transform transform, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localPosition = new Vector3(x[0], x[1], x[2]), onCompleted);
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<List<float>> source, Transform transform, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localPosition = new Vector3(x[0], x[1], x[2]), onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<float[]> source, Transform transform)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localPosition = new Vector3(x[0], x[1], x[2]));
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<float[]> source, Transform transform, Action<Exception, Transform> onError)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localPosition = new Vector3(x[0], x[1], x[2]), onError);
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<float[]> source, Transform transform, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localPosition = new Vector3(x[0], x[1], x[2]), onCompleted);
        }

        public static IDisposable SubscribeToLocalPosition(this IObservable<float[]> source, Transform transform, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localPosition = new Vector3(x[0], x[1], x[2]), onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalPositionX(this IObservable<float> source, Transform transform)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localPosition;
                p.x = x;
                t.localPosition = p;
            });
        }

        public static IDisposable SubscribeToLocalPositionX(this IObservable<float> source, Transform transform, Action<Exception, Transform> onError)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localPosition;
                p.x = x;
                t.localPosition = p;
            }, onError);
        }

        public static IDisposable SubscribeToLocalPositionX(this IObservable<float> source, Transform transform, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localPosition;
                p.x = x;
                t.localPosition = p;
            }, onCompleted);
        }

        public static IDisposable SubscribeToLocalPositionX(this IObservable<float> source, Transform transform, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localPosition;
                p.x = x;
                t.localPosition = p;
            }, onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalPositionY(this IObservable<float> source, Transform transform)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localPosition;
                p.y = x;
                t.localPosition = p;
            });
        }

        public static IDisposable SubscribeToLocalPositionY(this IObservable<float> source, Transform transform, Action<Exception, Transform> onError)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localPosition;
                p.y = x;
                t.localPosition = p;
            }, onError);
        }

        public static IDisposable SubscribeToLocalPositionY(this IObservable<float> source, Transform transform, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localPosition;
                p.y = x;
                t.localPosition = p;
            }, onCompleted);
        }

        public static IDisposable SubscribeToLocalPositionY(this IObservable<float> source, Transform transform, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localPosition;
                p.y = x;
                t.localPosition = p;
            }, onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalPositionZ(this IObservable<float> source, Transform transform)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localPosition;
                p.z = x;
                t.localPosition = p;
            });
        }

        public static IDisposable SubscribeToLocalPositionZ(this IObservable<float> source, Transform transform, Action<Exception, Transform> onError)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localPosition;
                p.z = x;
                t.localPosition = p;
            }, onError);
        }

        public static IDisposable SubscribeToLocalPositionZ(this IObservable<float> source, Transform transform, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localPosition;
                p.z = x;
                t.localPosition = p;
            }, onCompleted);
        }

        public static IDisposable SubscribeToLocalPositionZ(this IObservable<float> source, Transform transform, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localPosition;
                p.z = x;
                t.localPosition = p;
            }, onError, onCompleted);
        }

        public static IObservable<Vector3> DoToLocalPosition(this IObservable<Vector3> source, Transform transform)
        {
            return source.Do(x => transform.localPosition = x);
        }

        public static IObservable<Vector3> DoToLocalPosition(this IObservable<Vector3> source, Transform transform, Action<Exception> onError)
        {
            return source.Do(x => transform.localPosition = x, onError);
        }

        public static IObservable<Vector3> DoToLocalPosition(this IObservable<Vector3> source, Transform transform, Action onCompleted)
        {
            return source.Do(x => transform.localPosition = x, onCompleted);
        }

        public static IObservable<Vector3> DoToLocalPosition(this IObservable<Vector3> source, Transform transform, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x => transform.localPosition = x, onError, onCompleted);
        }

        public static IObservable<IList<float>> DoToLocalPosition(this IObservable<IList<float>> source, Transform transform)
        {
            return source.Do(x => transform.localPosition = new Vector3(x[0], x[1], x[2]));
        }

        public static IObservable<IList<float>> DoToLocalPosition(this IObservable<IList<float>> source, Transform transform, Action<Exception> onError)
        {
            return source.Do(x => transform.localPosition = new Vector3(x[0], x[1], x[2]), onError);
        }

        public static IObservable<IList<float>> DoToLocalPosition(this IObservable<IList<float>> source, Transform transform, Action onCompleted)
        {
            return source.Do(x => transform.localPosition = new Vector3(x[0], x[1], x[2]), onCompleted);
        }

        public static IObservable<IList<float>> DoToLocalPosition(this IObservable<IList<float>> source, Transform transform, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x => transform.localPosition = new Vector3(x[0], x[1], x[2]), onError, onCompleted);
        }

        public static IObservable<List<float>> DoToLocalPosition(this IObservable<List<float>> source, Transform transform)
        {
            return source.Do(x => transform.localPosition = new Vector3(x[0], x[1], x[2]));
        }

        public static IObservable<List<float>> DoToLocalPosition(this IObservable<List<float>> source, Transform transform, Action<Exception> onError)
        {
            return source.Do(x => transform.localPosition = new Vector3(x[0], x[1], x[2]), onError);
        }

        public static IObservable<List<float>> DoToLocalPosition(this IObservable<List<float>> source, Transform transform, Action onCompleted)
        {
            return source.Do(x => transform.localPosition = new Vector3(x[0], x[1], x[2]), onCompleted);
        }

        public static IObservable<List<float>> DoToLocalPosition(this IObservable<List<float>> source, Transform transform, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x => transform.localPosition = new Vector3(x[0], x[1], x[2]), onError, onCompleted);
        }

        public static IObservable<float[]> DoToLocalPosition(this IObservable<float[]> source, Transform transform)
        {
            return source.Do(x => transform.localPosition = new Vector3(x[0], x[1], x[2]));
        }

        public static IObservable<float[]> DoToLocalPosition(this IObservable<float[]> source, Transform transform, Action<Exception> onError)
        {
            return source.Do(x => transform.localPosition = new Vector3(x[0], x[1], x[2]), onError);
        }

        public static IObservable<float[]> DoToLocalPosition(this IObservable<float[]> source, Transform transform, Action onCompleted)
        {
            return source.Do(x => transform.localPosition = new Vector3(x[0], x[1], x[2]), onCompleted);
        }

        public static IObservable<float[]> DoToLocalPosition(this IObservable<float[]> source, Transform transform, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x => transform.localPosition = new Vector3(x[0], x[1], x[2]), onError, onCompleted);
        }

        public static IObservable<float> DoToLocalPositionX(this IObservable<float> source, Transform transform)
        {
            return source.Do(x =>
            {
                var p = transform.localPosition;
                p.x = x;
                transform.localPosition = p;
            });
        }

        public static IObservable<float> DoToLocalPositionX(this IObservable<float> source, Transform transform, Action<Exception> onError)
        {
            return source.Do(x =>
            {
                var p = transform.localPosition;
                p.x = x;
                transform.localPosition = p;
            }, onError);
        }

        public static IObservable<float> DoToLocalPositionX(this IObservable<float> source, Transform transform, Action onCompleted)
        {
            return source.Do(x =>
            {
                var p = transform.localPosition;
                p.x = x;
                transform.localPosition = p;
            }, onCompleted);
        }

        public static IObservable<float> DoToLocalPositionX(this IObservable<float> source, Transform transform, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x =>
            {
                var p = transform.localPosition;
                p.x = x;
                transform.localPosition = p;
            }, onError, onCompleted);
        }

        public static IObservable<float> DoToLocalPositionY(this IObservable<float> source, Transform transform)
        {
            return source.Do(x =>
            {
                var p = transform.localPosition;
                p.y = x;
                transform.localPosition = p;
            });
        }

        public static IObservable<float> DoToLocalPositionY(this IObservable<float> source, Transform transform, Action<Exception> onError)
        {
            return source.Do(x =>
            {
                var p = transform.localPosition;
                p.y = x;
                transform.localPosition = p;
            }, onError);
        }

        public static IObservable<float> DoToLocalPositionY(this IObservable<float> source, Transform transform, Action onCompleted)
        {
            return source.Do(x =>
            {
                var p = transform.localPosition;
                p.y = x;
                transform.localPosition = p;
            }, onCompleted);
        }

        public static IObservable<float> DoToLocalPositionY(this IObservable<float> source, Transform transform, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x =>
            {
                var p = transform.localPosition;
                p.y = x;
                transform.localPosition = p;
            }, onError, onCompleted);
        }

        public static IObservable<float> DoToLocalPositionZ(this IObservable<float> source, Transform transform)
        {
            return source.Do(x =>
            {
                var p = transform.localPosition;
                p.z = x;
                transform.localPosition = p;
            });
        }

        public static IObservable<float> DoToLocalPositionZ(this IObservable<float> source, Transform transform, Action<Exception> onError)
        {
            return source.Do(x =>
            {
                var p = transform.localPosition;
                p.z = x;
                transform.localPosition = p;
            }, onError);
        }

        public static IObservable<float> DoToLocalPositionZ(this IObservable<float> source, Transform transform, Action onCompleted)
        {
            return source.Do(x =>
            {
                var p = transform.localPosition;
                p.z = x;
                transform.localPosition = p;
            }, onCompleted);
        }

        public static IObservable<float> DoToLocalPositionZ(this IObservable<float> source, Transform transform, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x =>
            {
                var p = transform.localPosition;
                p.z = x;
                transform.localPosition = p;
            }, onError, onCompleted);
        }
    }
}