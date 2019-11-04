using System;

namespace BlazorAnimate
{
    public class AnimateOptions
    {
        public IAnimation Animation { get; set; }
        public IEasing Easing { get; set; }
        public TimeSpan Duration { get; set; }
        public TimeSpan Delay { get; set; }
        public bool Mirror { get; set; }
        public bool Once { get; set; }
    }
}
