using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animImportFacialTransformNoScale : CVariable
	{
		[Ordinal(0)] [RED("rotation")] public Quaternion Rotation { get; set; }
		[Ordinal(1)] [RED("translation")] public Vector3 Translation { get; set; }

		public animImportFacialTransformNoScale(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
