using Exiled.API.Enums;

namespace Custom330.API
{
    public class EffectData
    {
        public float Time { get; set; } = 0;
        public float Delay { get; set; } = 0;
        public byte Intensity { get; set; } = 0;

        public EffectType Effect { get; set; } = EffectType.Invigorated;
    }
}
