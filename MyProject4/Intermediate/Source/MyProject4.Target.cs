using UnrealBuildTool;

public class MyProject4Target : TargetRules
{
	public MyProject4Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("MyProject4");
	}
}
