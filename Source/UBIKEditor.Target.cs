// Copyright (c) Name 2020

using UnrealBuildTool;
using System.Collections.Generic;

public class UBIKEditorTarget : TargetRules
{
	public UBIKEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "UBIK" } );
	}
}
