using BepInEx;
using HarmonyLib;

namespace NoBaseRaids
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        public static BepInEx.Logging.ManualLogSource MyLogger { get; private set; }

        private readonly Harmony _harmony = new(PluginInfo.PLUGIN_GUID);
        private void Awake()
        {
            MyLogger = Logger;
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");


            _harmony.PatchAll();
        }

        private void OnDestroy()
        {
            _harmony.UnpatchSelf();
        }

    }
}
