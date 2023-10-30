using UnrealBuildTool;

public class MyProject4ClientTarget : TargetRules
{
	public MyProject4ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("MyProject4");
	}
}
