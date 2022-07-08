using Aki.Reflection.Utils;

using BepInEx;
using BepInEx.Configuration;

using Untitled.Reflection;

namespace WeaponMalfunction
{
    [BepInPlugin("com.Untitled.WeaponPatch", "WeaponPatch", "1.0.0")]
    [BepInDependency("com.Untitled.Reflection", BepInDependency.DependencyFlags.HardDependency)]
    public class WeaponPatchPlugin : PatchUnityPlugin
    {
        public static ConfigEntry<bool> Enabled;
        public void Start()
        {
            Enabled = Config.Bind("Config", "Enabled", true, new ConfigDescription("Patch 활성화/비활성화"));
        }
    }
}
