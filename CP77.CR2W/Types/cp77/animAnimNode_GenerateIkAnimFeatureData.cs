using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_GenerateIkAnimFeatureData : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] [RED("ikChainSettings")] public CArray<animIKChainSettings> IkChainSettings { get; set; }

		public animAnimNode_GenerateIkAnimFeatureData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
