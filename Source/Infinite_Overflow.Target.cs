// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Infinite_OverflowTarget : TargetRules
{
	public Infinite_OverflowTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "Infinite_Overflow" } );
	}
}
