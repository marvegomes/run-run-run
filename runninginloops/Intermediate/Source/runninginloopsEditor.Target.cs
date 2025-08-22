using UnrealBuildTool;

public class runninginloopsEditorTarget : TargetRules
{
	public runninginloopsEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("runninginloops");
	}
}
