// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class MessagingServerTarget : TargetRules
{
	public MessagingServerTarget(TargetInfo Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("MessagingServer");
	}

	//
	// TargetRules interface.
	//

	// public override void SetupBinaries(
		// TargetInfo Target,
		// ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		// ref List<string> OutExtraModuleNames
		// )
	// {
		// //OutExtraModuleNames.Add("MessagingServer");
	// }
}
