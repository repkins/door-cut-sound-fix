using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEngine;

namespace DoorCutSoundFix
{
    public class MainPatcher
    {
        public static void Patch()
        {
            var harmony = HarmonyInstance.Create("subnautica.mod.doorcutsoundfix");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
