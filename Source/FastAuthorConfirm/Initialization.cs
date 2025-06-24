using System.Reflection;
using HarmonyLib;
using Verse;

namespace FastAuthorConfirm;

[StaticConstructorOnStartup]
public static class Initialization
{
    static Initialization()
    {
        new Harmony("Harmony_FastAuthorConfirm").PatchAll(Assembly.GetExecutingAssembly());
    }
}