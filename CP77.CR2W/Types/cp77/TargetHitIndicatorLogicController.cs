using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TargetHitIndicatorLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("animName")] public CName AnimName { get; set; }
		[Ordinal(2)] [RED("animationPriority")] public CInt32 AnimationPriority { get; set; }

		public TargetHitIndicatorLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
