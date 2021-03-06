using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameHitRepresentationVisualTaggedOverride : ISerializable
	{
		[Ordinal(0)] [RED("visualTags")] public redTagList VisualTags { get; set; }
		[Ordinal(1)] [RED("represenationOverride")] public gameHitShapeContainer RepresenationOverride { get; set; }

		public gameHitRepresentationVisualTaggedOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
