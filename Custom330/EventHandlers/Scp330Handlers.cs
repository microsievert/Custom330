using Exiled.Events.EventArgs;
using Exiled.API.Enums;
using Exiled.API.Features;

using MEC;

using Custom330.API;

using InventorySystem.Items.Usables.Scp330;

namespace Custom330.EventHandlers
{
    public class Scp330Handlers
    {
        public void OnEatingScp330(EatingScp330EventArgs ev)
        {
            if (!Custom330.Instance.Config.EffectsOverride.ContainsKey(ev.Candy.Kind))
                return;

            CandyEffect candyEffect = Custom330.Instance.Config.EffectsOverride[ev.Candy.Kind];

            foreach (EffectType targetEffect in candyEffect.RemoveEffects)
                ev.Player.DisableEffect(targetEffect);

            foreach (EffectData targetEffectData in candyEffect.ApplyEffects)
                if (targetEffectData.Delay == 0f)
                    ApplyEffect(ev.Player, targetEffectData);
                else
                    Timing.CallDelayed(targetEffectData.Delay, () => ApplyEffect(ev.Player, targetEffectData));

            if (candyEffect.Damage != 0f)
                ev.Player.Hurt(candyEffect.Damage);

            if (candyEffect.Regeneration != 0f)
                ev.Player.Health += candyEffect.Regeneration;

            if (candyEffect.AhpShield != 0f)
                ev.Player.AddAhp(candyEffect.AhpShield);

            if (!candyEffect.Notice.Equals(string.Empty))
                ev.Player.ShowHint(candyEffect.Notice, candyEffect.NoticeTime);

            if (candyEffect.IsOverridden)
            {
                if (ev.Player.CurrentItem.Base is Scp330Bag bagObject)
                {
                    bagObject.Candies.Remove(ev.Candy.Kind);
                    bagObject.ServerRefreshBag();
                }

                ev.IsAllowed = false;
            }
        }

        private void ApplyEffect(Player player, EffectData effect)
        {
            for (int i = 0; i < effect.Intensity; i++)
                player.EnableEffect(effect.Effect, effect.Time);
        }
    }
}
