using HarmonyLib;

namespace DisableGoodWalls.HarmonyPatches
{
    [HarmonyPatch(typeof(WallPassedListener))]
    [HarmonyPatch("SpawnGoodWall")]
    class SpawnGoodWallPatch
    {
        static bool Prefix()
        {
            return false;
        }
    }
}
