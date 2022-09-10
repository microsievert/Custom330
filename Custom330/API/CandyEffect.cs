using System.Collections.Generic;

using Exiled.API.Enums;

namespace Custom330.API
{
    public class CandyEffect
    {
        public bool IsOverridden { get; set; }
        public float Damage { get; set; } 
        public float Regeneration { get; set; }
        public float AhpShield { get; set; }
        public float NoticeTime { get; set; }
        public string Notice { get; set; } = string.Empty;

        public List<EffectData> ApplyEffects { get; set; } = new List<EffectData>
        {
            new EffectData()
        };

        public List<EffectType> RemoveEffects { get; set; } = new List<EffectType>
        {
            EffectType.Amnesia
        };
    }
}
