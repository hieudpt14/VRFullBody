// Copyright (c) Name 2020

using UnrealBuildTool;
using System.Collections.Generic;

public class UBIKTarget : TargetRules
{
	public UBIKTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "UBIK" } );
	}
}
