using RimWorld;
using TorannMagic;
using TorannMagic.Conditions;
using ToolkitPatchLib;
using Verse;

namespace ToolkitRimOfMagicPatch
{

    public class IncidentHelper_ArcaneEnemyRaid : WagerIncidentHelper<IncidentWorker_ArcaneEnemyRaid>
    {
        public IncidentHelper_ArcaneEnemyRaid() : base(IncidentCategoryDefOf.ThreatBig, IncidentDef.Named("ArcaneEnemyRaid")) { }
    }

    public class VoteHelper_ArcaneEnemyRaid : WagerIncidentHelper<IncidentWorker_ArcaneEnemyRaid>
    {
        public VoteHelper_ArcaneEnemyRaid() : base(IncidentCategoryDefOf.ThreatBig, IncidentDef.Named("ArcaneEnemyRaid")) { }
    }

    public class IncidentHelper_ArcaneCampQuest : NormalIncidentHelper<IncidentWorker_QuestArcaneCamp>
    {
        public IncidentHelper_ArcaneCampQuest() : base(IncidentCategoryDefOf.WorldQuest, IncidentDef.Named("QuestArcaneCamp"), Find.World) { }
    }

    public class VoteHelper_ArcaneCampQuest : NormalIncidentHelper<IncidentWorker_QuestArcaneCamp>
    {
        public VoteHelper_ArcaneCampQuest() : base(IncidentCategoryDefOf.WorldQuest, IncidentDef.Named("QuestArcaneCamp")) { }
    }

    public class IncidentHelper_MagicCaravanRequest : NormalIncidentHelper<IncidentWorker_ArcaneScriptCaravan>
    {
        public IncidentHelper_MagicCaravanRequest() : base(IncidentCategoryDefOf.WorldQuest, IncidentDef.Named("MagicCaravanRequest")) { }
    }

    public class VoteHelper_MagicCaravanRequest : NormalIncidentHelper<IncidentWorker_ArcaneScriptCaravan>
    {
        public VoteHelper_MagicCaravanRequest() : base(IncidentCategoryDefOf.WorldQuest, IncidentDef.Named("MagicCaravanRequest")) { }
    }

    public class IncidentHelper_ManaDrain : NormalIncidentHelper<IncidentWorker_MakeGameCondition>
    {
        public IncidentHelper_ManaDrain() : base(IncidentCategoryDefOf.Misc, IncidentDef.Named("ManaDrain")) { }
    }

    public class VoteHelper_ManaDrain : NormalIncidentHelper<IncidentWorker_MakeGameCondition>
    {
        public VoteHelper_ManaDrain() : base(IncidentCategoryDefOf.Misc, IncidentDef.Named("ManaDrain")) { }
    }

    public class IncidentHelper_ManaSurge : NormalIncidentHelper<IncidentWorker_MakeGameCondition>
    {
        public IncidentHelper_ManaSurge() : base(IncidentCategoryDefOf.Misc, IncidentDef.Named("ManaSurge")) { }
    }

    public class VoteHelper_ManaSurge : NormalIncidentHelper<IncidentWorker_MakeGameCondition>
    {
        public VoteHelper_ManaSurge() : base(IncidentCategoryDefOf.Misc, IncidentDef.Named("ManaSurge")) { }
    }

    public class IncidentHelper_Disease_ManaSickness : NormalIncidentHelper<IncidentWorker_ArcaneSickness>
    {
        public IncidentHelper_Disease_ManaSickness() : base(IncidentCategoryDefOf.DiseaseHuman, IncidentDef.Named("Disease_ManaSickness")) { }
    }

    public class VoteHelper_Disease_ManaSickness : NormalIncidentHelper<IncidentWorker_ArcaneSickness>
    {
        public VoteHelper_Disease_ManaSickness() : base(IncidentCategoryDefOf.DiseaseHuman, IncidentDef.Named("Disease_ManaSickness")) { }
    }

    public class IncidentHelper_ElementalAssault : NormalIncidentHelper<IncidentWorker_ElementalAssault>
    {
        public IncidentHelper_ElementalAssault() : base(IncidentCategoryDefOf.ThreatBig, IncidentDef.Named("ElementalAssault")) { }
    }

    public class VoteHelper_ElementalAssault : NormalIncidentHelper<IncidentWorker_ElementalAssault>
    {
        public VoteHelper_ElementalAssault() : base(IncidentCategoryDefOf.ThreatBig, IncidentDef.Named("ElementalAssault")) { }
    }

    public class IncidentHelper_WanderingLich : NormalIncidentHelper<IncidentWorker_WanderingLich>
    {
        public IncidentHelper_WanderingLich() : base(IncidentCategoryDefOf.ThreatBig, IncidentDef.Named("WanderingLich")) { }
    }

    public class VoteHelper_WanderingLich : NormalIncidentHelper<IncidentWorker_WanderingLich>
    {
        public VoteHelper_WanderingLich() : base(IncidentCategoryDefOf.ThreatBig, IncidentDef.Named("WanderingLich")) { }
    }
}
