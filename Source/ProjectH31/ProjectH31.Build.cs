// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ProjectH31 : ModuleRules
{
	public ProjectH31(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "Paper2D" });
	}
}
