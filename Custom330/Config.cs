using System.Collections.Generic;

using Exiled.API.Interfaces;

using Custom330.API;

using InventorySystem.Items.Usables.Scp330;

namespace Custom330
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        public float MaxCandiesOverride { get; set; } = 2f;

        public Dictionary<CandyKindID, CandyEffect> EffectsOverride { get; set; } = new Dictionary<CandyKindID, CandyEffect>
        {
            [CandyKindID.Blue] = new CandyEffect()
        };
    }
}
