using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameVisionModuleParams : CVariable
	{
		[Ordinal(0)] [RED("visionTag")] public CName VisionTag { get; set; }
		[Ordinal(1)] [RED("meshComponents")] public CArray<gameMeshDef> MeshComponents { get; set; }

		public gameVisionModuleParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
