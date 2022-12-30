using BepInEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoorCutSoundFix
{
    [BepInPlugin("subnautica.repkins.door-cut-sound-fix", "Door Cut Sound Fix", "1.0.1.0")]
    public class Plugin : BaseUnityPlugin
    {
        public void Awake()
        {
            MainPatcher.Patch();
        }
    }
}
