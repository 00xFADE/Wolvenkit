using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ButtonHints : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("horizontalHolder")] public inkCompoundWidgetReference HorizontalHolder { get; set; }

		public ButtonHints(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
