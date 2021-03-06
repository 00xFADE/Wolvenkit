using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MenuDataBuilder : IScriptable
	{
		[Ordinal(0)] [RED("data")] public CArray<MenuData> Data { get; set; }

		public MenuDataBuilder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
