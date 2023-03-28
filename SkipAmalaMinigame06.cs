using MelonLoader;
using HarmonyLib;
using Il2Cpp;
using skip_amala_minigame_06;

[assembly: MelonInfo(typeof(SkipAmalaMinigame06), "Skip Amala minigame (0.6 ver.)", "1.0.0", "Matthiew Purple")]
[assembly: MelonGame("アトラス", "smt3hd")]

namespace skip_amala_minigame_06;
public class SkipAmalaMinigame06 : MelonMod
{
    [HarmonyPatch(typeof(pipeSection), nameof(pipeSection.pipeLoadSection))]
    private class Patch
    {
        public static void Postfix()
        {
            dds3SequenceList.ExitPipe(); // Immediately exit the "pipe" after loading it
        }
    }
}
