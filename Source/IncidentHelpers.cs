using RimWorld;
using TorannMagic;

namespace ToolkitRimOfMagicPatch
{

    public class IncidentHelper_ArcaneEnemyRaid : WagerIncidentHelper<TorannMagic.IncidentWorker_ArcaneEnemyRaid>
    {
        public IncidentHelper_ArcaneEnemyRaid() : base(IncidentCategoryDefOf.ThreatBig, IncidentDef.Named("ArcaneEnemyRaid")) { }
    }

    public class IncidentHelper_ArcaneCampQuest : NormalIncidentHelper<TorannMagic.IncidentWorker_QuestArcaneCamp>
    {
        public IncidentHelper_ArcaneCampQuest() : base(IncidentCategoryDefOf.WorldQuest, IncidentDef.Named("QuestArcaneCamp")) { }
    }

    public class IncidentHelper_MagicCaravanRequest : NormalIncidentHelper<TorannMagic.IncidentWorker_ArcaneScriptCaravan>
    {
        public IncidentHelper_MagicCaravanRequest() : base(IncidentCategoryDefOf.WorldQuest, IncidentDef.Named("MagicCaravanRequest")) { }
    }

}
