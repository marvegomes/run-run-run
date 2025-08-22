using UnrealBuildTool;

public class runninginloopsTarget : TargetRules
{
	public runninginloopsTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("runninginloops");
	}
}
