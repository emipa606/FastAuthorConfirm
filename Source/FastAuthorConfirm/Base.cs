using Verse;

namespace FastAuthorConfirm
{
    [StaticConstructorOnStartup]
    public static class Initialization
    {
        static Initialization()
        {
            HarmonyPatches.HPatcher.Init();
        }
    }
}
