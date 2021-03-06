using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WidgetsPoolItemSpawnData : IScriptable
	{
		[Ordinal(0)] [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(1)] [RED("requestVersion")] public CInt32 RequestVersion { get; set; }

		public WidgetsPoolItemSpawnData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
