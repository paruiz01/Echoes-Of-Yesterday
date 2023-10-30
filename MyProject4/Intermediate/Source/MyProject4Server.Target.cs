using UnrealBuildTool;

public class MyProject4ServerTarget : TargetRules
{
	public MyProject4ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("MyProject4");
	}
}
