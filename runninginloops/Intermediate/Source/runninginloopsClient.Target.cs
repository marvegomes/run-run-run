using UnrealBuildTool;

public class runninginloopsClientTarget : TargetRules
{
	public runninginloopsClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("runninginloops");
	}
}
