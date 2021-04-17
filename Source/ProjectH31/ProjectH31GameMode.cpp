// Copyright Epic Games, Inc. All Rights Reserved.

#include "ProjectH31GameMode.h"
#include "ProjectH31Character.h"

AProjectH31GameMode::AProjectH31GameMode()
{
	// Set default pawn class to our character
	DefaultPawnClass = AProjectH31Character::StaticClass();	
}
