using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectParameter_CNameEvaluator_Blackboard : gameIEffectParameter_CNameEvaluator
	{
		[Ordinal(0)] [RED("blackboardProperty")] public gameBlackboardPropertyBindingDefinition BlackboardProperty { get; set; }

		public gameEffectParameter_CNameEvaluator_Blackboard(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
