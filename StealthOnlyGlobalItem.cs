using Terraria;
using Terraria.ModLoader;
using CalamityMod;
using CalamityMod.CalPlayer;

namespace StealthOnly
{
    public class StealthOnlyGlobalItem : GlobalItem
    {
        public override bool CanUseItem(Item item, Player player)
        {
            if (!StealthOnlyConfig.Instance.StealthCon)
                return true;
            //Player doesn't have a stealth strike available
            if (item.CountsAsClass<RogueDamageClass>() && !player.GetModPlayer<CalamityPlayer>().StealthStrikeAvailable() && !StealthOnlyConfig.Instance.FullStealth)
            {
                return false;
            }
            //Player has less than full stealth and the full stealth config
            if (item.CountsAsClass<RogueDamageClass>() && player.GetModPlayer<CalamityPlayer>().rogueStealth < player.GetModPlayer<CalamityPlayer>().rogueStealthMax && StealthOnlyConfig.Instance.FullStealth)
            {
                return false;
            }
            return true;
        }
    }
}