namespace Worldreaver.UniTween
{
    public partial class Easing
    {
        public enum Type
        {
            InBack,
            OutBack,
            InOutBack,

            InBounce,
            OutBounce,
            InOutBounce,

            InCirc,
            OutCirc,
            InOutCirc,

            InCubic,
            OutCubic,
            InOutCubic,

            InElastic,
            OutElastic,
            InOutElastic,

            InExpo,
            OutExpo,
            InOutExpo,

            Linear,

            InQuad,
            OutQuad,
            InOutQuad,

            InQuart,
            OutQuart,
            InOutQuart,

            InQuint,
            OutQuint,
            InOutQuint,

            InSine,
            OutSine,
            InOutSine
        }

        public static ITween Interpolate(Type type, float duration)
        {
            switch (type)
            {
                case Type.InBack: return InBack(duration);
                case Type.OutBack: return OutBack(duration);
                case Type.InOutBack: return InOutBack(duration);
                case Type.InBounce: return InBounce(duration);
                case Type.OutBounce: return OutBounce(duration);
                case Type.InOutBounce: return InOutBounce(duration);
                case Type.InCirc: return InCirc(duration);
                case Type.OutCirc: return OutCirc(duration);
                case Type.InOutCirc: return InOutCirc(duration);
                case Type.InCubic: return InCubic(duration);
                case Type.OutCubic: return OutCubic(duration);
                case Type.InOutCubic: return InOutCubic(duration);
                case Type.InElastic: return InElastic(duration);
                case Type.OutElastic: return OutElastic(duration);
                case Type.InOutElastic: return InOutElastic(duration);
                case Type.InExpo: return InExpo(duration);
                case Type.OutExpo: return OutExpo(duration);
                case Type.InOutExpo: return InOutExpo(duration);
                case Type.Linear: return Linear(duration);
                case Type.InQuad: return InQuad(duration);
                case Type.OutQuad: return OutQuad(duration);
                case Type.InOutQuad: return InOutQuad(duration);
                case Type.InQuart: return InQuart(duration);
                case Type.OutQuart: return OutQuart(duration);
                case Type.InOutQuart: return InOutQuart(duration);
                case Type.InQuint: return InQuint(duration);
                case Type.OutQuint: return OutQuint(duration);
                case Type.InOutQuint: return InOutQuint(duration);
                case Type.InSine: return InSine(duration);
                case Type.OutSine: return OutSine(duration);
                case Type.InOutSine: return InOutSine(duration);
                default:
                    return Linear(duration);
            }
        }

        public static ITween Interpolate(Type type, Velocity velocity)
        {
            switch (type)
            {
                case Type.InBack: return InBack(velocity);
                case Type.OutBack: return OutBack(velocity);
                case Type.InOutBack: return InOutBack(velocity);
                case Type.InBounce: return InBounce(velocity);
                case Type.OutBounce: return OutBounce(velocity);
                case Type.InOutBounce: return InOutBounce(velocity);
                case Type.InCirc: return InCirc(velocity);
                case Type.OutCirc: return OutCirc(velocity);
                case Type.InOutCirc: return InOutCirc(velocity);
                case Type.InCubic: return InCubic(velocity);
                case Type.OutCubic: return OutCubic(velocity);
                case Type.InOutCubic: return InOutCubic(velocity);
                case Type.InElastic: return InElastic(velocity);
                case Type.OutElastic: return OutElastic(velocity);
                case Type.InOutElastic: return InOutElastic(velocity);
                case Type.InExpo: return InExpo(velocity);
                case Type.OutExpo: return OutExpo(velocity);
                case Type.InOutExpo: return InOutExpo(velocity);
                case Type.Linear: return Linear(velocity);
                case Type.InQuad: return InQuad(velocity);
                case Type.OutQuad: return OutQuad(velocity);
                case Type.InOutQuad: return InOutQuad(velocity);
                case Type.InQuart: return InQuart(velocity);
                case Type.OutQuart: return OutQuart(velocity);
                case Type.InOutQuart: return InOutQuart(velocity);
                case Type.InQuint: return InQuint(velocity);
                case Type.OutQuint: return OutQuint(velocity);
                case Type.InOutQuint: return InOutQuint(velocity);
                case Type.InSine: return InSine(velocity);
                case Type.OutSine: return OutSine(velocity);
                case Type.InOutSine: return InOutSine(velocity);
                default:
                    return Linear(velocity);
            }
        }
    }
}