using System;

using Exiled.API.Features;

using Custom330.EventHandlers;

namespace Custom330
{
    public class Custom330 : Plugin<Config>
    {
        public static Custom330 Instance;

        public override string Name => "Custom330";
        public override string Author => "microsievert";
        public override Version Version { get; } = new Version(1, 0, 1);

        private Scp330Handlers _scp330Handlers;

        public override void OnEnabled()
        {
            Instance = this;

            RegisterEvents();

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Instance = null;

            UnregisterEvents();

            base.OnDisabled();
        }

        private void RegisterEvents()
        {
            _scp330Handlers = new Scp330Handlers();

            Exiled.Events.Handlers.Scp330.EatingScp330 += _scp330Handlers.OnEatingScp330;
        }

        private void UnregisterEvents()
        {
            Exiled.Events.Handlers.Scp330.EatingScp330 -= _scp330Handlers.OnEatingScp330;

            _scp330Handlers = null;
        }
    }
}
