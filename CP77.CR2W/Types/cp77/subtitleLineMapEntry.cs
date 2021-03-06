using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class subtitleLineMapEntry : CVariable
	{
		[Ordinal(0)] [RED("id")] public CRUID Id { get; set; }
		[Ordinal(1)] [RED("widget")] public wCHandle<inkWidget> Widget { get; set; }
		[Ordinal(2)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }

		public subtitleLineMapEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
