using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldStaticSoundEmitterNode : worldNode
	{
		[Ordinal(2)] [RED("radius")] public CFloat Radius { get; set; }
		[Ordinal(3)] [RED("audioName")] public CName AudioName { get; set; }
		[Ordinal(4)] [RED("Settings")] public CHandle<audioAmbientAreaSettings> Settings { get; set; }
		[Ordinal(5)] [RED("usePhysicsObstruction")] public CBool UsePhysicsObstruction { get; set; }
		[Ordinal(6)] [RED("occlusionEnabled")] public CBool OcclusionEnabled { get; set; }
		[Ordinal(7)] [RED("acousticRepositioningEnabled")] public CBool AcousticRepositioningEnabled { get; set; }
		[Ordinal(8)] [RED("obstructionChangeTime")] public CFloat ObstructionChangeTime { get; set; }
		[Ordinal(9)] [RED("useDoppler")] public CBool UseDoppler { get; set; }
		[Ordinal(10)] [RED("dopplerFactor")] public CFloat DopplerFactor { get; set; }
		[Ordinal(11)] [RED("setOpenDoorEmitter")] public CBool SetOpenDoorEmitter { get; set; }
		[Ordinal(12)] [RED("emitterMetadataName")] public CName EmitterMetadataName { get; set; }
		[Ordinal(13)] [RED("overrideRolloff")] public CBool OverrideRolloff { get; set; }
		[Ordinal(14)] [RED("rolloffOverride")] public CFloat RolloffOverride { get; set; }
		[Ordinal(15)] [RED("ambientPaletteTag")] public CName AmbientPaletteTag { get; set; }

		public worldStaticSoundEmitterNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
