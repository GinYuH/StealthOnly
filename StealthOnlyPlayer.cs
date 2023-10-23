﻿using Terraria.GameInput;
using Terraria.ModLoader;
using Terraria;

namespace StealthOnly

{
    public class StealthOnlyPlayer : ModPlayer
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