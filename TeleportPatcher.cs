using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using BepInEx;

namespace NoBaseRaids
{
    [HarmonyPatch]
    public class TeleportPatcher
    {
        [HarmonyPrefix]
        [HarmonyPatch(typeof(Inventory), "IsTeleportable")]
        static bool IsTeleportableHook(ref bool __result)
        {
            __result = true;
            return false;
        }
    }
}
