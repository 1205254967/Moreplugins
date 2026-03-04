using Moreplugins.Assets.Sounds;
using Terraria.Audio;
using Terraria.ModLoader;

namespace Moreplugins.Core.GlobalInstance.Players
{
    public class PluginsPlayer : ModPlayer
    {
        public bool SoundAcc = false;
        public bool SoundAccOld = false;
        public override void ResetEffects()
        {
            SoundAcc = false;
        }

        public override void PostUpdateMiscEffects()
        {
            if (SoundAcc != SoundAccOld)
                SoundEngine.PlaySound(SoundsRegister.DefaultSound, Player.Center);
            SoundAccOld = SoundAcc;
        }
    }
}
