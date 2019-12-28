using ToolkitPatchLib;
using Verse;

namespace ToolkitRimOfMagicPatch
{
    public class ToolkitRimOfMagicPatch : Mod
    {
        public ToolkitRimOfMagicPatch(ModContentPack content) : base(content)
        {
            Logger.LOGGERNAME = "TROM";
        }

        public override string SettingsCategory() => "Toolkit RimOfMagic Patch";
    }
}
