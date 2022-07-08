using BepInEx;
using BepInEx.Configuration;

namespace WeaponMalfunction
{
    [BepInPlugin("com.Untitled.WeaponPatch", "WeaponPatch", "1.0.0")]
    [BepInDependency("com.Untitled.Reflection", BepInDependency.DependencyFlags.HardDependency)]
    public class WeaponPatchPlugin : BaseUnityPlugin
    {
        public static ConfigEntry<bool> Enabled;
        public void Start()
        {
            new WeaponMalfunctionPatch().Enable();
            new RemoveDurabilityBurnPatch().Enable();

            Enabled = Config.Bind("Config", "Enabled", true, new ConfigDescription("Patch 활성화/비활성화"));
        }
    }
}
