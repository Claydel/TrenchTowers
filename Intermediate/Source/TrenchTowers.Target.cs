using UnrealBuildTool;

public class TrenchTowersTarget : TargetRules
{
	public TrenchTowersTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("TrenchTowers");
	}
}
