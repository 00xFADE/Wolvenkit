using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineConsumableParameterInt : gamestateMachineActionParameterInt
	{
		[Ordinal(2)] [RED("consumed")] public CBool Consumed { get; set; }

		public gamestateMachineConsumableParameterInt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
