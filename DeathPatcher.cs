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
    public class DeathPatcher
    {

        [HarmonyPrefix]
        [HarmonyPatch(typeof(Player), "CreateTombStone")]
        static bool CreateTombStoneHook()
        {
            return false;
        }
    }
}
