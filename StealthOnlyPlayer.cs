using Terraria.ModLoader;

namespace StealthOnly

{
    public class StealthOnlyPlayer : ModSystem
    {
        public override void ProcessTriggers(TriggersSet triggersSet)
        {
		if (StealthKey.SKey.JustPressed && Main.myPlayer == Player.whoAmI)
		{
			if (StealthOnlyConfig.Instance.StealthCon == true)
			StealthOnlyConfig.Instance.StealthCon = false;
			else
			StealthOnlyConfig.Instance.StealthCon = true;
		}
	}
    }
}