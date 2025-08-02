using System;

[Flags]
public enum NGPCELMDKGK
{
	Normal = 0,
	OnlyTranslation = 7,
	NoRotationOrReflection = 1,
	NoScale = 2,
	NoScaleOrReflection = 6
}
