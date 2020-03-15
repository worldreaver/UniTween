using System;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Worldreaver.UniTween
{
    public static class TransformLocalScaleExtensions
    {
        public static IDisposable SubscribeToLocalScale(this IObservable<Vector3> source, Transform transform)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localScale = x);
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<Vector3> source, Transform transform, Action<Exception, Transform> onError)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localScale = x, onError);
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<Vector3> source, Transform transform, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localScale = x, onCompleted);
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<Vector3> source, Transform transform, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localScale = x, onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<IList<float>> source, Transform transform)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localScale = new Vector3(x[0], x[1], x[2]));
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<IList<float>> source, Transform transform, Action<Exception, Transform> onError)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localScale = new Vector3(x[0], x[1], x[2]), onError);
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<IList<float>> source, Transform transform, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localScale = new Vector3(x[0], x[1], x[2]), onCompleted);
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<IList<float>> source, Transform transform, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localScale = new Vector3(x[0], x[1], x[2]), onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<List<float>> source, Transform transform)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localScale = new Vector3(x[0], x[1], x[2]));
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<List<float>> source, Transform transform, Action<Exception, Transform> onError)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localScale = new Vector3(x[0], x[1], x[2]), onError);
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<List<float>> source, Transform transform, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localScale = new Vector3(x[0], x[1], x[2]), onCompleted);
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<List<float>> source, Transform transform, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localScale = new Vector3(x[0], x[1], x[2]), onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<float[]> source, Transform transform)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localScale = new Vector3(x[0], x[1], x[2]));
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<float[]> source, Transform transform, Action<Exception, Transform> onError)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localScale = new Vector3(x[0], x[1], x[2]), onError);
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<float[]> source, Transform transform, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localScale = new Vector3(x[0], x[1], x[2]), onCompleted);
        }

        public static IDisposable SubscribeToLocalScale(this IObservable<float[]> source, Transform transform, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) => t.localScale = new Vector3(x[0], x[1], x[2]), onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalScaleX(this IObservable<float> source, Transform transform)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localScale;
                p.x = x;
                t.localScale = p;
            });
        }

        public static IDisposable SubscribeToLocalScaleX(this IObservable<float> source, Transform transform, Action<Exception, Transform> onError)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localScale;
                p.x = x;
                t.localScale = p;
            }, onError);
        }

        public static IDisposable SubscribeToLocalScaleX(this IObservable<float> source, Transform transform, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localScale;
                p.x = x;
                t.localScale = p;
            }, onCompleted);
        }

        public static IDisposable SubscribeToLocalScaleX(this IObservable<float> source, Transform transform, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localScale;
                p.x = x;
                t.localScale = p;
            }, onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalScaleY(this IObservable<float> source, Transform transform)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localScale;
                p.y = x;
                t.localScale = p;
            });
        }

        public static IDisposable SubscribeToLocalScaleY(this IObservable<float> source, Transform transform, Action<Exception, Transform> onError)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localScale;
                p.y = x;
                t.localScale = p;
            }, onError);
        }

        public static IDisposable SubscribeToLocalScaleY(this IObservable<float> source, Transform transform, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localScale;
                p.y = x;
                t.localScale = p;
            }, onCompleted);
        }

        public static IDisposable SubscribeToLocalScaleY(this IObservable<float> source, Transform transform, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localScale;
                p.y = x;
                t.localScale = p;
            }, onError, onCompleted);
        }

        public static IDisposable SubscribeToLocalScaleZ(this IObservable<float> source, Transform transform)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localScale;
                p.z = x;
                t.localScale = p;
            });
        }

        public static IDisposable SubscribeToLocalScaleZ(this IObservable<float> source, Transform transform, Action<Exception, Transform> onError)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localScale;
                p.z = x;
                t.localScale = p;
            }, onError);
        }

        public static IDisposable SubscribeToLocalScaleZ(this IObservable<float> source, Transform transform, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localScale;
                p.z = x;
                t.localScale = p;
            }, onCompleted);
        }

        public static IDisposable SubscribeToLocalScaleZ(this IObservable<float> source, Transform transform, Action<Exception, Transform> onError, Action<Transform> onCompleted)
        {
            return source.SubscribeWithState(transform, (x, t) =>
            {
                var p = t.localScale;
                p.z = x;
                t.localScale = p;
            }, onError, onCompleted);
        }

        public static IObservable<Vector3> DoToLocalScale(this IObservable<Vector3> source, Transform transform)
        {
            return source.Do(x => transform.localScale = x);
        }

        public static IObservable<Vector3> DoToLocalScale(this IObservable<Vector3> source, Transform transform, Action<Exception> onError)
        {
            return source.Do(x => transform.localScale = x, onError);
        }

        public static IObservable<Vector3> DoToLocalScale(this IObservable<Vector3> source, Transform transform, Action onCompleted)
        {
            return source.Do(x => transform.localScale = x, onCompleted);
        }

        public static IObservable<Vector3> DoToLocalScale(this IObservable<Vector3> source, Transform transform, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x => transform.localScale = x, onError, onCompleted);
        }

        public static IObservable<IList<float>> DoToLocalScale(this IObservable<IList<float>> source, Transform transform)
        {
            return source.Do(x => transform.localScale = new Vector3(x[0], x[1], x[2]));
        }

        public static IObservable<IList<float>> DoToLocalScale(this IObservable<IList<float>> source, Transform transform, Action<Exception> onError)
        {
            return source.Do(x => transform.localScale = new Vector3(x[0], x[1], x[2]), onError);
        }

        public static IObservable<IList<float>> DoToLocalScale(this IObservable<IList<float>> source, Transform transform, Action onCompleted)
        {
            return source.Do(x => transform.localScale = new Vector3(x[0], x[1], x[2]), onCompleted);
        }

        public static IObservable<IList<float>> DoToLocalScale(this IObservable<IList<float>> source, Transform transform, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x => transform.localScale = new Vector3(x[0], x[1], x[2]), onError, onCompleted);
        }

        public static IObservable<List<float>> DoToLocalScale(this IObservable<List<float>> source, Transform transform)
        {
            return source.Do(x => transform.localScale = new Vector3(x[0], x[1], x[2]));
        }

        public static IObservable<List<float>> DoToLocalScale(this IObservable<List<float>> source, Transform transform, Action<Exception> onError)
        {
            return source.Do(x => transform.localScale = new Vector3(x[0], x[1], x[2]), onError);
        }

        public static IObservable<List<float>> DoToLocalScale(this IObservable<List<float>> source, Transform transform, Action onCompleted)
        {
            return source.Do(x => transform.localScale = new Vector3(x[0], x[1], x[2]), onCompleted);
        }

        public static IObservable<List<float>> DoToLocalScale(this IObservable<List<float>> source, Transform transform, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x => transform.localScale = new Vector3(x[0], x[1], x[2]), onError, onCompleted);
        }

        public static IObservable<float[]> DoToLocalScale(this IObservable<float[]> source, Transform transform)
        {
            return source.Do(x => transform.localScale = new Vector3(x[0], x[1], x[2]));
        }

        public static IObservable<float[]> DoToLocalScale(this IObservable<float[]> source, Transform transform, Action<Exception> onError)
        {
            return source.Do(x => transform.localScale = new Vector3(x[0], x[1], x[2]), onError);
        }

        public static IObservable<float[]> DoToLocalScale(this IObservable<float[]> source, Transform transform, Action onCompleted)
        {
            return source.Do(x => transform.localScale = new Vector3(x[0], x[1], x[2]), onCompleted);
        }

        public static IObservable<float[]> DoToLocalScale(this IObservable<float[]> source, Transform transform, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x => transform.localScale = new Vector3(x[0], x[1], x[2]), onError, onCompleted);
        }

        public static IObservable<float> DoToLocalScaleX(this IObservable<float> source, Transform transform)
        {
            return source.Do(x =>
            {
                var p = transform.localScale;
                p.x = x;
                transform.localScale = p;
            });
        }

        public static IObservable<float> DoToLocalScaleX(this IObservable<float> source, Transform transform, Action<Exception> onError)
        {
            return source.Do(x =>
            {
                var p = transform.localScale;
                p.x = x;
                transform.localScale = p;
            }, onError);
        }

        public static IObservable<float> DoToLocalScaleX(this IObservable<float> source, Transform transform, Action onCompleted)
        {
            return source.Do(x =>
            {
                var p = transform.localScale;
                p.x = x;
                transform.localScale = p;
            }, onCompleted);
        }

        public static IObservable<float> DoToLocalScaleX(this IObservable<float> source, Transform transform, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x =>
            {
                var p = transform.localScale;
                p.x = x;
                transform.localScale = p;
            }, onError, onCompleted);
        }

        public static IObservable<float> DoToLocalScaleY(this IObservable<float> source, Transform transform)
        {
            return source.Do(x =>
            {
                var p = transform.localScale;
                p.y = x;
                transform.localScale = p;
            });
        }

        public static IObservable<float> DoToLocalScaleY(this IObservable<float> source, Transform transform, Action<Exception> onError)
        {
            return source.Do(x =>
            {
                var p = transform.localScale;
                p.y = x;
                transform.localScale = p;
            }, onError);
        }

        public static IObservable<float> DoToLocalScaleY(this IObservable<float> source, Transform transform, Action onCompleted)
        {
            return source.Do(x =>
            {
                var p = transform.localScale;
                p.y = x;
                transform.localScale = p;
            }, onCompleted);
        }

        public static IObservable<float> DoToLocalScaleY(this IObservable<float> source, Transform transform, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x =>
            {
                var p = transform.localScale;
                p.y = x;
                transform.localScale = p;
            }, onError, onCompleted);
        }

        public static IObservable<float> DoToLocalScaleZ(this IObservable<float> source, Transform transform)
        {
            return source.Do(x =>
            {
                var p = transform.localScale;
                p.z = x;
                transform.localScale = p;
            });
        }

        public static IObservable<float> DoToLocalScaleZ(this IObservable<float> source, Transform transform, Action<Exception> onError)
        {
            return source.Do(x =>
            {
                var p = transform.localScale;
                p.z = x;
                transform.localScale = p;
            }, onError);
        }

        public static IObservable<float> DoToLocalScaleZ(this IObservable<float> source, Transform transform, Action onCompleted)
        {
            return source.Do(x =>
            {
                var p = transform.localScale;
                p.z = x;
                transform.localScale = p;
            }, onCompleted);
        }

        public static IObservable<float> DoToLocalScaleZ(this IObservable<float> source, Transform transform, Action<Exception> onError, Action onCompleted)
        {
            return source.Do(x =>
            {
                var p = transform.localScale;
                p.z = x;
                transform.localScale = p;
            }, onError, onCompleted);
        }
    }
}