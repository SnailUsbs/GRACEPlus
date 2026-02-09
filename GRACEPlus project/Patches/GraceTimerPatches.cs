using BombRushMP.Common.Networking;
using BombRushMP.Common.Packets;
using BombRushMP.Common;
using BombRushMP.Plugin;
using BombRushMP.Plugin.Gamemodes;
using HarmonyLib;
using System;

namespace GRACEPlus.Patches
{
    [HarmonyPatch(typeof(GraffitiRace), nameof(GraffitiRace.OnPacketReceived_InGame))]
    class GraffitiRaceTimerPatch
    {
        private static DateTime raceStartTime;
        private static bool isRaceActive = false;

        static void Postfix(GraffitiRace __instance, Packets packetId, Packet packet)
        {
            try
            {
                if (packetId == Packets.ServerGamemodeBegin && !isRaceActive)
                {
                    raceStartTime = DateTime.Now;
                    isRaceActive = true;
                    GRACEPlusPlugin.Logger.LogInfo("GRACEPlus: Graffiti Race started - Timer began");
                }
            }
            catch (System.Exception ex)
            {
                GRACEPlusPlugin.Logger.LogError($"ERROR in GRACEPlus timer: {ex.Message}\n{ex.StackTrace}");
            }
        }

        [HarmonyPostfix]
        [HarmonyPatch(typeof(GraffitiRace), nameof(GraffitiRace.OnEnd))]
        static void OnEnd_Postfix()
        {
            if (isRaceActive)
            {
                var endTime = DateTime.Now;
                var duration = endTime - raceStartTime;
                var totalSeconds = Math.Round(duration.TotalSeconds, 1);
                
                isRaceActive = false;
                
                GRACEPlusPlugin.Logger.LogInfo($"GRACEPlus: Graffiti Race ended - Duration: {totalSeconds} seconds");
                GRACEPlusPlugin.ShowNotification($"<color=green>GRACE Ended IN {totalSeconds} Seconds!</color>");
            }
        }
    }

    [HarmonyPatch(typeof(TeamGraffitiRace), nameof(TeamGraffitiRace.OnPacketReceived_InGame))]
    class TeamGraffitiRaceTimerPatch
    {
        private static DateTime raceStartTime;
        private static bool isRaceActive = false;

        static void Postfix(TeamGraffitiRace __instance, Packets packetId, Packet packet)
        {
            try
            {
                if (packetId == Packets.ServerGamemodeBegin && !isRaceActive)
                {
                    raceStartTime = DateTime.Now;
                    isRaceActive = true;
                    GRACEPlusPlugin.Logger.LogInfo("GRACEPlus: Team Graffiti Race started - Timer began");
                }
            }
            catch (System.Exception ex)
            {
                GRACEPlusPlugin.Logger.LogError($"ERROR in GRACEPlus team timer: {ex.Message}\n{ex.StackTrace}");
            }
        }

        [HarmonyPostfix]
        [HarmonyPatch(typeof(TeamGraffitiRace), nameof(TeamGraffitiRace.OnEnd))]
        static void OnEnd_Postfix()
        {
            if (isRaceActive)
            {
                var endTime = DateTime.Now;
                var duration = endTime - raceStartTime;
                var totalSeconds = Math.Round(duration.TotalSeconds, 1);
                
                isRaceActive = false;
                
                GRACEPlusPlugin.Logger.LogInfo($"GRACEPlus: Team Graffiti Race ended - Duration: {totalSeconds} seconds");
                GRACEPlusPlugin.ShowNotification($"<color=green>Team GRACE Ended IN {totalSeconds} Seconds!</color>");
            }
        }
    }
}