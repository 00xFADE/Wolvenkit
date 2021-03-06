using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class IsAnyThreatClose : AIAutonomousConditions
	{
		[Ordinal(0)] [RED("distance")] public CFloat Distance { get; set; }

		public IsAnyThreatClose(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
