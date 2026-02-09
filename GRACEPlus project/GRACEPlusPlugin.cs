using BepInEx;
using BepInEx.Logging;
using BombRushMP.Plugin;
using HarmonyLib;

namespace GRACEPlus
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    [BepInDependency("BombRushMP.Plugin")]
    public class GRACEPlusPlugin : BaseUnityPlugin
    {
        internal static new ManualLogSource Logger;
        private static Harmony _harmony;

        private void Awake()
        {
            Logger = base.Logger;
            
            _harmony = new Harmony(PluginInfo.PLUGIN_GUID);
            _harmony.PatchAll();
            
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
            Logger.LogInfo("GRACEPlus - GRACE race timer and announcer ready!");
        }

        private void OnDestroy()
        {
            _harmony?.UnpatchSelf();
        }

        public static void ShowNotification(string message)
        {
            ChatUI.Instance?.AddMessage(message);
        }
    }

    public static class PluginInfo
    {
        public const string PLUGIN_GUID = "com.snail.graceplus";
        public const string PLUGIN_NAME = "GRACEPlus";
        public const string PLUGIN_VERSION = "1.0.0";
    }
}