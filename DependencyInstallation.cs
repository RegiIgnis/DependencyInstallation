using Sons.Weapon;
using SonsSdk;
using static RedLoader.RLog;

namespace DependencyInstallation;

public class DependencyInstallation : SonsMod
{
    public DependencyInstallation()
    {

        // Uncomment any of these if you need a method to run on a specific update loop.
        //OnUpdateCallback = MyUpdateMethod;
        //OnLateUpdateCallback = MyLateUpdateMethod;
        //OnFixedUpdateCallback = MyFixedUpdateMethod;
        //OnGUICallback = MyGUIMethod;

        // Uncomment this to automatically apply harmony patches in your assembly.
        //HarmonyPatchAll = true;
    }

    protected override void OnInitializeMod()
    {
        // Do your early mod initialization which doesn't involve game or sdk references here
        Config.Init();
    }

    protected override void OnSdkInitialized()
    {
        // Do your mod initialization which involves game or sdk references here
        // This is for stuff like UI creation, event registration etc.
        DependencyInstallationUi.Create();
    }

    protected override void OnGameStart()
    {
        ChainsawWeaponController Chains = new ChainsawWeaponController();
        Chains._chainSpeed = 100;
        // This is called once the player spawns in the world and gains control.
    }
}