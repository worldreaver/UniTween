# Readme

## What

- Rx Tween Animation Library for Unity

## Requirements
[![Unity 2019.2+](https://img.shields.io/badge/unity-2019.2+-brightgreen.svg?style=flat&logo=unity&cacheSeconds=2592000)](https://unity3d.com/get-unity/download/archive)
[![.Net 2.0 Scripting Runtime](https://img.shields.io/badge/.NET-2.0-blueviolet.svg?style=flat&cacheSeconds=2592000)](https://docs.unity3d.com/2019.1/Documentation/Manual/ScriptingRuntimeUpgrade.html)

## Examples

### Basic

![sample1](https://user-images.githubusercontent.com/961165/35796308-7d0512aa-0a9f-11e8-9c66-c1dceeeafb72.gif)

Move from (-5,0,0) to (5,0,0) at 4m / s.

```csharp
Tweener.Play(new Vector3(-5f, 0f, 0f), new Vector3(5f, 0f, 0f), Motion.Uniform(4f))
    .Subscribe(x => cube.transform.position = x);
    //.SubscribeToPosition(cube);
```

### Method Chain

![sample2](https://user-images.githubusercontent.com/961165/35796309-7d2bbdf6-0a9f-11e8-8fe1-acef944a36c0.gif)

Move from (-5,0,0) to (5,0,0) and then move to (0,3,0) at a constant speed.
When this method is used, the change in value stops for one frame between the first movement and the second movement.
Use the following Path method to move smoothly.

```csharp
var tween = Motion.Uniform(5f);
Tweener.Play(new Vector3(-5f, 0f, 0f), new Vector3(5f, 0f, 0f), tween)
    .Play(new Vector3(0f, 3f, 0f), tween)
    .SubscribeToPosition(cube);
```

### Easing

![sample3](https://user-images.githubusercontent.com/961165/35796312-7d518662-0a9f-11e8-99e4-e5943212d966.gif)

Move in 2 seconds with EaseOutQuad.

```csharp
Tweener.Play(new Vector3(-5f, 0f, 0f), new Vector3(5f, 0f, 0f), Easing.OutQuad(2f))
    .SubscribeToPosition(cube);
```

### Sleep

![sample10](https://user-images.githubusercontent.com/961165/35796321-7e3ff25c-0a9f-11e8-956a-d85aa2a30e48.gif)

After moving, it starts again after 1 second.

```csharp
Tweener.Play(new Vector3(-5f, 0f, 0f), new Vector3(0f, 0f, 0f), Easing.OutExpo(2f))
    .Sleep(1f)
    .Play(new Vector3(5f, 0f, 0f), Easing.OutExpo(2f))
    .SubscribeToPosition(cube);
```

### Path

![sample4](https://user-images.githubusercontent.com/961165/35796313-7d772fc0-0a9f-11e8-91c5-4780b43a5b4f.gif)

Move to the specified position in order.

```csharp
var positions = new[]
{
    new Vector3(-5f, 0f, 0f),
    new Vector3(0f, 3f, 0f),
    new Vector3(5f, 0f, 0f),
    new Vector3(0f, -3f, 0f),
    new Vector3(-5f, 0f, 0f),
};

Tweener.Play(positions, Easing.InOutSine(6f))
    .SubscribeToPosition(cube);
```

### Combine

![sample5](https://user-images.githubusercontent.com/961165/35796315-7d9e024e-0a9f-11e8-908c-f35b4326ee42.gif)

Each x, y, z coordinate is animated separately and synthesized.

```csharp
var x = Tweener.Play(-5f, 5f, Easing.InOutSine(3f));

var y = Tweener.Play(0f, 3f, Easing.InOutSine(1.5f))
    .Play(0f, Easing.InOutSine(1.5f));

var z = Tweener.Stay(0f);

Observable.CombineLatest(x, y, z)
    .SubscribeToPosition(cube);
```

### AnimationCurve

![sample11](https://user-images.githubusercontent.com/961165/35796322-7e6983e2-0a9f-11e8-807c-ff3a2967a2cf.gif)

Move using UnityEngine.AnimationCurve.

```csharp
Tweener.Play(new Vector3(-5f, 0f, 0f), new Vector3(5f, 0f, 0f), Motion.From(curve, 3f))
    .SubscribeToPosition(cube);
```

### Extensions

![sample6](https://user-images.githubusercontent.com/961165/35796317-7dc739de-0a9f-11e8-8aef-599e7e325efc.gif)

Move from cube.transform.position to (3,3,0).

```csharp
cube.transform.position
    .Play(new Vector3(3f, 3f, 0f), Easing.OutBack(2f))
    .SubscribeToPosition(cube);
```

### Circle

![sample8](https://user-images.githubusercontent.com/961165/35796318-7dedcb62-0a9f-11e8-907c-e0ee65298b17.gif)

Convert IObservble <float> to circular motion.

```csharp
Tweener.Play(0f, Mathf.PI * 2f, Easing.OutCubic(3f))
    .Select(x => new Vector3(Mathf.Sin(x), Mathf.Cos(x), 0.0f))
    .Select(x => x * 3f)
    .SubscribeToPosition(cube);
```

### Range / Lerp

![sample17](https://user-images.githubusercontent.com/961165/35954448-0deb1e8e-0ccd-11e8-92ba-1d952a90332e.gif)

Follow along halfway.
Follow only a specific range.

```csharp
var flow = Tweener.Play(Easing.InOutExpo(2.5f))
    .Stop(0.5f)
    .Play(1.0f, 0.0f, Easing.InOutExpo(2.5f));

flow
    .Range(0.0f, 0.5f)
    .Lerp(new Vector3(-5f, 0f, 0f), new Vector3(0f, 0f, 0f))
    .SubscribeToPosition(cube2);

flow
    .Lerp(new Vector3(-5f, -1f, 0f), new Vector3(5f, -1f, 0f))
    .SubscribeToPosition(cube);
```

### PlayIn/PlayOut/PlayInOut

![sample24](https://user-images.githubusercontent.com/961165/36070628-70652970-0f42-11e8-980b-5d2b26d28847.gif)

From animation to constant speed movement.

```csharp
Tweener.PlayIn(-5f, 0f, 5f, Easing.InCubic(1f))
    .SubscribeToPositionX(cube);
```

### Delay

![sample18](https://user-images.githubusercontent.com/961165/36021790-3d5a335a-0dca-11e8-9481-7376cd25a4c0.gif)

Observable.Delay in UniRx

```csharp
var circle = Tweener.Play(0f, Mathf.PI * 2f, Easing.OutCubic(3f))
    .Select(x => new Vector3(Mathf.Sin(x), Mathf.Cos(x), 0.0f))
    .Select(x => x * 3f);

circle
    .SubscribeToPosition(cube);

circle
    .Delay(0.3f)
    .SubscribeToPosition(cube2);

circle
    .Delay(0.55f)
    .SubscribeToPosition(cube3);
```

### Blend

![sample20](https://user-images.githubusercontent.com/961165/36059327-d082cd18-0e79-11e8-9292-c8f035ba4e00.gif)

Add the two moves together.

```csharp
var circle = Tweener
    .Play(Mathf.PI, Mathf.PI * 2f * 3f, Easing.InOutSine(3f))
    .Select(x => new Vector3(Mathf.Sin(x), Mathf.Cos(x), 0f));

var straight = Tweener
    .Play(-3f, 3f, Easing.InOutSine(3f))
    .Select(x => new Vector3(0f, x, 0f));

Observable.CombineLatest(circle, straight)
    .Sum()
    .SubscribeToPosition(cube);
```

### WhenAll

![sample9](https://user-images.githubusercontent.com/961165/35796319-7e1568d4-0a9f-11e8-8e08-28ff53093e8c.gif)

Use WhenAll to synchronize the animation.

```csharp
var leftCube1 = Tweener
    .Play(new Vector3(-5f, 0f, 0f), new Vector3(-0.5f, 0f, 0f), Easing.Linear(2.5f))
    .DoToPosition(cube);

var rightCube1 = Tweener
    .Play(new Vector3(5f, 0f, 0f), new Vector3(0.5f, 0f, 0f), Easing.OutCubic(1f))
    .DoToPosition(cube2);

var leftCube2 = Tweener
    .Play(new Vector3(-0.5f, 0f, 0f), new Vector3(-0.5f, 3f, 0f), Easing.OutCubic(1f))
    .DoToPosition(cube);

var rightCube2 = Tweener
    .Play(new Vector3(0.5f, 0f, 0f), new Vector3(0.5f, 3f, 0f), Easing.OutCubic(1f))
    .DoToPosition(cube2);

Observable.WhenAll(leftCube1, rightCube1)
    .ContinueWith(Observable.WhenAll(leftCube2, rightCube2))
    .Subscribe();
```

### Subscribe onComplete

Tracking Tween complete using DoOnCompleted or override of method ex `SubscribeToPosition`, `DoToPosition` ...

```csharp
        var tween = TweenMotion.Uniform(5f);
        Tweener.Play(new Vector3(-5f, 0f, 0f), new Vector3(5f, 0f, 0f), tween).DoOnCompleted(() => Debug.Log("Complete part 1"))
            .Play(new Vector3(5f, 3f, 0f), tween).DoOnCompleted(() => Debug.Log("Complete part 2"))
            .SubscribeToPosition(cube);
```

```csharp
        var leftCube1 = Tweener
            .Play(new Vector3(-5f, 0f, 0f), new Vector3(-0.5f, 0f, 0f), Easing.Linear(2.5f))
            .DoToPosition(cube, () => Debug.Log("Complete left cube move x to -0.5f")).DoOnCompleted(() => Debug.Log("Do on complete left cube move x to -0.5f"));

        var rightCube1 = Tweener
            .Play(new Vector3(5f, 0f, 0f), new Vector3(0.5f, 0f, 0f), Easing.OutCubic(1f))
            .DoToPosition(cube2, () => Debug.Log("Complete right cube move x to 0.5f"));

        var leftCube2 = Tweener
            .Play(new Vector3(-0.5f, 0f, 0f), new Vector3(-0.5f, 3f, 0f), Easing.OutCubic(1f))
            .DoToPosition(cube);

        var rightCube2 = Tweener
            .Play(new Vector3(0.5f, 0f, 0f), new Vector3(0.5f, 3f, 0f), Easing.OutCubic(1f))
            .DoToPosition(cube2);

        Observable.WhenAll(leftCube1, rightCube1).DoOnCompleted(() => Debug.Log("Compelete both left cube and right cube"))
            .ContinueWith(Observable.WhenAll(leftCube2, rightCube2)).DoOnCompleted(() => Debug.Log("COMPLETE"))
            .Subscribe();
```

## Dependencies

- [![UniRx](https://img.shields.io/badge/UniRx-7.1.0+-brightgreen.svg?style=flat&cacheSeconds=2592000)](https://github.com/worldreaver/UniRx/tree/7.1.1)

- [![MoreLINQ](https://img.shields.io/badge/MoreLINQ-3.3.3+-brightgreen.svg?style=flat&cacheSeconds=2592000)](https://github.com/worldreaver/MoreLINQ/tree/upm)

- [![UniRxEx](https://img.shields.io/badge/UniRxEx-1.1.0+-brightgreen.svg?style=flat&cacheSeconds=2592000)](https://github.com/worldreaver/UniRxEx/tree/upm/v1.1.0)

- [![Utility](https://img.shields.io/badge/Utility-1.2.0+-brightgreen.svg?style=flat&cacheSeconds=2592000)](https://github.com/worldreaver/Utility/tree/upm/v1.2.0)


## License
- Under the MIT license
- Some code is borrowed from @AnimeRx
- Thanks for *kyubuns*