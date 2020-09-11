# Blazor.Animate 

Easily add fade, slide and zoom-effects into your Blazor applications. Blazor.Animate is powered by the excellent [AOS-library](https://michalsnik.github.io/aos/).

![Blazor.Animate animation](blazoranimate.gif)

Blazor.Animate is an animation component for Blazor. With Blazor.Animate you can animate how other components are brought to the view. You can easily add fade, slide and zoom-effects and even add easing to the animations.

[![NuGet](https://img.shields.io/nuget/v/BlazorAnimate.svg)](https://www.nuget.org/packages/BlazorAnimate/)

## Quick Start

To animate a component, wrap it inside Animate-component and use the Animation-parameter to define the animation:

```
    <Animate Animation="Animations.ZoomIn" Duration="TimeSpan.FromSeconds(0.5)" >
        <Counter></Counter>
    </Animate>
```

## Getting Started

Few steps are required in order to use the library.

#### Add NuGet

```csharp
Install-Package BlazorAnimate
```

#### Configure _Imports.razor

```
...
@using BlazorAnimate
```

#### Add JS interop into _Host.cshtml

```
    <script src="_content/BlazorAnimate/blazorAnimateInterop.js"></script>
```

#### Use the Animate-component

```
    <Animate Animation="Animations.ZoomIn" Duration="TimeSpan.FromSeconds(0.5)" Delay="TimeSpan.FromSeconds(1)">
        <Counter></Counter>
    </Animate>
```

## Sample

For a sample, please view http://animateblazorsamplessvc.azurewebsites.net/

The sample's source code is available from GitHub: https://github.com/mikoskinen/Blazor.Animate/tree/master/samples/BlazorAnimate.Sample

## Running animation manually

It's possible to run the animation manually. Please note that the animated component will be hidden until the animation is manually executed.

To animate component manually, first set the IsManual to true and also capture the reference to the component:

```
	<Animate Animation="Animations.ZoomIn" Duration="TimeSpan.FromSeconds(0.5)" @ref="myAnim" IsManual="true">
		<Counter></Counter>
	</Animate>
```

Then in code-behind, call Run-method to animate the component:

```
	@code {

		private Animate myAnim;

		private void RunAnimation()
		{
			myAnim.Run();
		}
	}
```

The Manual.razor page in the sample illustrates this functionality.

## Animations

To define an animation, use the Animation-property of the Animate-component. The built-in animations are available from BlazorAnimate.Animations:

* Fade
* FadeIn
* FadeUp
* FadeDown
* FadeLeft
* FadeRight
* FadeUpRight
* FadeUpLeft
* FadeDownRight
* FadeDownLeft
* FlipUp
* FlipDown
* FlipLeft
* FlipRight
* SlideUp
* SlideDown
* SlideLeft
* SlideRight
* ZoomIn
* ZoomInUp
* ZoomInDown
* ZoomInLeft
* ZoomInRight
* ZoomOut
* ZoomOutUp
* ZoomOutDown
* ZoomOutLeft
* ZoomOutRight

Use Duration (TimeSpan) or DurationMs -property to define the duration of an animation.

Use Delay (TimeSpan) or DelayMs -property to define how long the animation is delayed before it is started.

## Available easings

To define an easing for the animation, use the Easing-property of the Animate-component. The built-in easings are available from BlazorAnimate.Easings:

* Linear
* Ease
* EaseIn
* EaseOut
* EaseInOut
* EaseInBack
* EaseOutBack
* EaseInOutBack
* EaseInSine
* EaseOutSine
* EaseInOutSine
* EaseInQuad
* EaseOutQuad
* EaseInOutQuad
* EaseInCubic
* EaseOutCubic 
* EaseInOutCubic
* EaseInQuart
* EaseOutQuart
* EaseInOutQuart

## Configuring the defaults

ASP.NET Core's options can be used to define the default animation settings:

```
            services.Configure<AnimateOptions>(options =>
            {
                options.Animation = Animations.FadeDown;
                options.Duration = TimeSpan.FromMilliseconds(100);
            });
```

If no animation parameters is defined on the Animate-component, the defaults are used:

```
<Animate>
    <h1>Hello, world!</h1>
</Animate>
```

## Named configurations

Blazor.Animate supports named animation settings through the ASP.NET Core's named options. Here's an example where two configurations are provided, one without a name (the defaults) and one with a name:

```
            services.Configure<AnimateOptions>("my", options =>
            {
                options.Animation = Animations.FadeDown;
                options.Duration = TimeSpan.FromSeconds(2);
            });

            services.Configure<AnimateOptions>(options =>
            {
                options.Animation = Animations.FadeDown;
                options.Duration = TimeSpan.FromMilliseconds(100);
            });
```

To use a named configuration, provide the OptionsName-parameter:

```
<Animate OptionsName="my">
    <h1>Hello, world!</h1>
</Animate>
```
## Authors

Blazor.Animate is created by [Mikael Koskinen](https://mikaelkoskinen.net).

Contributions are welcome!

## License

Blazor.Animate is MIT licensed. The library uses the following other libraries:

* [AOS](https://michalsnik.github.io/aos/): MIT-license
