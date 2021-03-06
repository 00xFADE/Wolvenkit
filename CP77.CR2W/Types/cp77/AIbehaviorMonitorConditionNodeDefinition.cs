using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorMonitorConditionNodeDefinition : AIbehaviorConditionNodeDefinition
	{
		[Ordinal(3)] [RED("timeout")] public CFloat Timeout { get; set; }

		public AIbehaviorMonitorConditionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
