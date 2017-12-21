// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class MessagingServerEditorTarget : TargetRules
{
	public MessagingServerEditorTarget(TargetInfo Target)
	{
		Type = TargetType.Editor;
		ExtraModuleNames.Add("MessagingServer");
	}

	//
	// TargetRules interface.
	//

	// public override void SetupGlobalEnvironment(
		// TargetInfo Target,
		// ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		// ref List<string> OutExtraModuleNames
		// )
	// {
		// //OutExtraModuleNames.Add("MessagingServer");
	// }
}
