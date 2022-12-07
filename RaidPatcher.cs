using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HarmonyLib;
using BepInEx;

namespace NoBaseRaids
{
    [HarmonyPatch]
    public class RaidPatcher
    {

        [HarmonyPrefix]
        [HarmonyPatch(typeof(RandEventSystem), "UpdateRandomEvent")]
        static bool UpdateRandomEventHook()
        {
            return false;
        }

        [HarmonyPrefix]
        [HarmonyPatch(typeof(RandEventSystem), "UpdateForcedEvents")]
        static bool UpdateForcedEventHook()
        {
            return false;
        }
    }
}
