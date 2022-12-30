using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace DoorCutSoundFix
{
    [HarmonyPatch(typeof(LaserCutObject))]
    [HarmonyPatch("OnEnable")]
    class LaserCutObject_OnEnable_Patch
    {
        static void Prefix(LaserCutObject __instance, GameObject ___cutObject)
        {
            if (__instance.isCutOpen)
            {
                FMOD_CustomEmitter doorCutEmitter = ___cutObject.GetComponent<FMOD_CustomEmitter>();
                if (doorCutEmitter != null)
                {
                    doorCutEmitter.playOnAwake = false;
                }
            }
        }
    }
}
