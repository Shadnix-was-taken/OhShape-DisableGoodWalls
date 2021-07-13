using MelonLoader;
using System.Reflection;

namespace DisableGoodWalls
{
    public static class BuildInfo
    {
        public const string Name = "Disable Good Walls";        // Name of the Mod.  (MUST BE SET)
        public const string ShortName = "DisableGoodWalls";
        public const string Description = "Disables the 'good wall' sfx effect when correctly passing through a wall."; // Description for the Mod.  (Set as null if none)
        public const string Author = "Shadnix";                 // Author of the Mod.  (Set as null if none)
        public const string Company = null;                     // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0";                  // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null;                // Download Link for the Mod.  (Set as null if none)
    }

    public class Mod : MelonMod
    {
        internal static bool HarmonyPatchesLoaded = false;
        internal static string HarmonyInstanceID = "com.shadnix.OhShape.DisableGoodWalls";
        internal static HarmonyLib.Harmony ModHarmonyInstance = new HarmonyLib.Harmony(HarmonyInstanceID);

        // Initialize mod on startup
        public override void OnApplicationStart()
        {
            MelonLogger.Msg("OnApplicationStart called. Initializing " + BuildInfo.Name + "...");
            Load();
        }

        public override void OnApplicationQuit()
        {
            MelonLogger.Msg("OnApplicationQuit called.");
            Unload();
        }

        private void Load()
        {
            if (!HarmonyPatchesLoaded)
            {
                ModHarmonyInstance.PatchAll(Assembly.GetExecutingAssembly());
                MelonLogger.Msg("Loaded Harmony patches.");
            }
            HarmonyPatchesLoaded = true;
        }

        private void Unload()
        {
            if (HarmonyPatchesLoaded)
            {
                ModHarmonyInstance.UnpatchAll(HarmonyInstanceID);
                MelonLogger.Msg("Unloaded Harmony patches.");
            }
            HarmonyPatchesLoaded = false;
        }
    }

}
