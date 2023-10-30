using UnrealBuildTool;

public class MyProject4EditorTarget : TargetRules
{
	public MyProject4EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("MyProject4");
	}
}
