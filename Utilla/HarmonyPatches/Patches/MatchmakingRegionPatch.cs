﻿/*
using System;
using System.Linq;
using HarmonyLib;

namespace Utilla.HarmonyPatches.Patches
{
    [HarmonyPatch(typeof(NetworkSystemPUN), "get_lowestPingRegionIndex"), HarmonyWrapSafe]
    internal class MatchmakingRegionPatch
    {
        public static bool Prefix(ref int __result, NetworkRegionInfo[] ___regionData)
        {
            var playerCount = ___regionData.Select(a => a.playersInRegion);
            var desiredCount = playerCount.Max();
            var regionIndex = Array.IndexOf(___regionData, Array.Find(___regionData, region => region.playersInRegion == desiredCount));

            __result = regionIndex;
            return false;
        }
    }
}
*/