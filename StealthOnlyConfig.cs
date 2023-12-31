﻿using Microsoft.Xna.Framework;
using System;
using System.ComponentModel;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader.Config;

namespace StealthOnly
{
    [BackgroundColor(49, 32, 36, 216)]
    public class StealthOnlyConfig : ModConfig
    {
        public static StealthOnlyConfig Instance;
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [Header("$Mods.StealthOnly.StealthOnlyConfig.Headers.StealthOnlyHeader")]
        [Label("$Mods.StealthOnly.StealthOnlyConfig.StealthCon.Label")]
        [BackgroundColor(192, 54, 64, 192)]
        [DefaultValue(true)]
        [Tooltip("Causes you to become unable to attack unless you have enough stealth to perform a stealth strike. Accounts for Coin of Deceit and its upgrades")]
        public bool StealthCon { get; set; }

        [Label("$Mods.StealthOnly.StealthOnlyConfig.FullStealth.Label")]
        [BackgroundColor(192, 54, 64, 192)]
        [DefaultValue(false)]
        [Tooltip("Requires you to have full stealth to attack, ignoring Coin of Deceit and its upgrades. Requires the above config to be enabled.")]
        public bool FullStealth { get; set; }
    }
}