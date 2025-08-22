using UnrealBuildTool;

public class runninginloopsServerTarget : TargetRules
{
	public runninginloopsServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("runninginloops");
	}
}
