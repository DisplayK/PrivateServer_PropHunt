using UnrealBuildTool;

public class SnowmanWinterEvent : ModuleRules {
	public SnowmanWinterEvent(ReadOnlyTargetRules Target) : base(Target) {
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		bLegacyPublicIncludePaths = false;
		ShadowVariableWarningLevel = WarningLevel.Warning;

		PublicDependencyModuleNames.AddRange(new string[] {
			"AIModule",
			"Activation",
			"AkAudio",
			"AnimationBudgetAllocator",
			"AnimationUtilities",
			"CinematicCamera",
			"Competence",
			"Core",
			"CoreUObject",
			"CoreUtilities",
			"Customization",
			"DBDAnimationBudgetAllocator",
			"DBDAudio",
			"DBDGameplay",
			"DBDInput",
			"DBDInteraction",
			"DBDSharedTypes",
			"DBDUIViewInterfaces",
			"DBDUIViewsMobile",
			"DataTableUtilities",
			"DeadByDaylight",
			"Engine",
			"Foliage",
			"GFXUtilities",
			"GameSessionDS",
			"GameflowNotifications",
			"GameplayTagUtilities",
			"GameplayTags",
			"GameplayUtilities",
			"InputCore",
			"InputUtilities",
			"Interaction",
			"LevelSequence",
			"MediaAssets",
			"MovieScene",
			"NavigationSystem",
			"NetworkUtilities",
			"Niagara",
			"OnlineMessagesUtilities",
			"OnlinePresence",
			"OnlineSubsystemUtils",
			"OnlineTransactions",
			"Paper2D",
			"Penalty",
			"PhysicsCore",
			"PhysicsUtilities",
			"PlatformsProviders",
			"Projectile",
			"QueryService",
			"ReversibleActionSystem",
			"RewardUtilities",
			"ScaleformUI",
			"SharedAuthenticationUtilities",
			"SignificanceUtilities",
			"Slate",
			"SlateCore",
			"SocialParty",
			"SpecialEventUtilities",
			"StatSystem",
			"SystemUtilities",
			"TimeUtilities",
			"Toasts",
			"UMG",
			"VFXUtilities",
		});
	}
}
