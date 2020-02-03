using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoorCutSoundFix
{
    [HarmonyPatch(typeof(LaserCutObject))]
    [HarmonyPatch("Awake")]
    internal class LaserCutObject_Awake_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(LaserCutObject __instance)
        {
            if (__instance.isCutOpen)
            {
                FMOD_CustomEmitter doorCutEmitter = __instance.cutObject.GetComponent<FMOD_CustomEmitter>();
                if (doorCutEmitter != null)
                {
                    doorCutEmitter.playOnAwake = false;
                }
            }
        }

    }
}
