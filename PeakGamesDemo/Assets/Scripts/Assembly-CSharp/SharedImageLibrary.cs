using System;
using UnityEngine;

public class SharedImageLibrary : MonoBehaviour
{
	public Sprite DefaultImage;

	public Sprite[] MedalImages;

	public Sprite Anvil;

	public Sprite Bomb;

	public Sprite BoxingGlove;

	public Sprite Coin;

	public Sprite DiscoBallUi;

	public Sprite Hammer;

	public Sprite Shuffle;

	public Sprite Rocket;

	public Sprite Life;

	public Sprite Coins;

	public Sprite AnvilGlow;

	public Sprite BombGlow;

	public Sprite BoxingGloveGlow;

	public Sprite CoinGlow;

	public Sprite DiscoBallUiGlow;

	public Sprite HammerGlow;

	public Sprite ShuffleGlow;

	public Sprite RocketGlow;

	public Sprite LifeGlow;

	public Sprite CarrotCollectingImage;

	public Sprite Bubble;

	public Sprite Billboard_A_Up;

	public Sprite Billboard_A_Down;

	public Sprite Billboard_B_Up;

	public Sprite Billboard_B_Down;

	public Sprite Billboard_C_Up;

	public Sprite Billboard_C_Down;

	public Sprite Billboard_D_Up;

	public Sprite Billboard_D_Down;

	public Sprite Billboard_E_Up;

	public Sprite Billboard_E_Down;

	public Sprite[] BlueCrateLayerSprites;

	public Sprite[] CrateLayerSprites;

	public Sprite[] DuckSprites;

	public Sprite[] ColoredBalloonSprites;

	public Sprite[] GreenCrateLayerSprites;

	public Sprite[] OrangeCrateLayerSprites;

	public Sprite[] PurpleCrateLayerSprites;

	public Sprite[] RedCrateLayerSprites;

	public Sprite[] SolidColorHintBombSprites;

	public Sprite[] SolidColorHintDiscoSprites;

	public Sprite[] SolidColorHintRocketSprites;

	public Sprite[] SolidColorSprites;

	public Sprite[] YellowCrateLayerSprites;

	public Sprite[] DiscoBallSprites;

	public Sprite[] EasterEggSprites;

	public Sprite[] SodaItemCaps;

	public Sprite[] SodaItemBottles;

	public Sprite[] SodaItemTops;

	public Sprite[] BlasterSpritesYellow;

	public Sprite[] BlasterSpritesRed;

	public Sprite[] BlasterSpritesBlue;

	public Sprite[] BlasterSpritesGreen;

	public Sprite[] BlasterSpritesPurple;

	public Sprite[] PenguinSprites;

	public Sprite PenguinGoal;

	public Sprite Balloon;

	public Sprite WaterMelon;

	public Sprite Pinata;

	public Sprite Carrot;

	public Sprite ColoredCrateGoal;

	public Sprite Crate;

	public Sprite Frame;

	public Sprite Jelly;

	public Sprite GiantDuck;

	public Sprite GiantPinata;

	public Sprite EasterEggGoal;

	public Sprite ColoredBalloonGoal;

	public Sprite LightBulb;

	public Sprite Can;

	public Sprite OysterGoal;

	public Sprite Soda;

	public Sprite MetalCrate;

	public Sprite HoneyCube;

	public Sprite Diamond;

	public Sprite BillboardGoal;

	public Sprite StoneGoal;

	public Sprite SoapItem;

	public Sprite MoleGoal;

	public Sprite BubbleGoal;

	public Sprite DuckGoal;

	public Sprite BirdSprite;

	public Sprite PotionGoal;

	public Sprite UfoGoal;

	public Sprite HanoiGoal;

	public Sprite GiftGoal;

	public Sprite CoconutGoal;

	public Sprite IvyGoal;

	public Sprite VaseGoal;

	public Sprite ChainGoal;

	public Sprite WasherGoal;

	public Sprite TubeGoal;

	public Sprite LogGoal;

	public Sprite PotGoal;

	public Sprite GoldGoal;

	public Sprite ElixirGoal;

	public Sprite NewCoins;

	public static SharedImageLibrary Instance;

	public void Awake()
	{
		Instance = this;
	}

	private void OnDestroy()
	{
		Instance = null;
	}

	public Sprite GetMedalSprite(int BDKFNEDHAOJ)
	{
		BDKFNEDHAOJ = Math.Min(MedalImages.Length - 1, BDKFNEDHAOJ);
		return MedalImages[BDKFNEDHAOJ];
	}

	public Sprite GetNewCoins()
	{
		return NewCoins;
	}

	public float GoalImageScale(NOALGNJECAD NBFBPNNEKMN)
	{
		switch (NBFBPNNEKMN)
		{
		case NOALGNJECAD.EasterEgg:
			return 1.15f;
		case NOALGNJECAD.Diamond:
			return 1.5f;
		case NOALGNJECAD.Billboard:
			return 1.25f;
		case NOALGNJECAD.Ufo:
			return 1.1f;
		default:
			return 1f;
		}
	}

	public Sprite GetSpriteByInventoryType(NAAHKHPBAPA HBBIFNLDKPO)
	{
		switch (HBBIFNLDKPO)
		{
		case NAAHKHPBAPA.Anvil:
			return Anvil;
		case NAAHKHPBAPA.Bomb:
			return Bomb;
		case NAAHKHPBAPA.BoxingGlove:
			return BoxingGlove;
		case NAAHKHPBAPA.Coins:
			return Coin;
		case NAAHKHPBAPA.DiscoBall:
			return DiscoBallUi;
		case NAAHKHPBAPA.Dice:
			return Shuffle;
		case NAAHKHPBAPA.Hammer:
			return Hammer;
		case NAAHKHPBAPA.Rocket:
			return Rocket;
		case NAAHKHPBAPA.Life:
			return Life;
		case NAAHKHPBAPA.UnlimitedLife:
			return Life;
		default:
			return null;
		}
	}

	public Sprite GetGlowSpriteByItemType(NAAHKHPBAPA HBBIFNLDKPO)
	{
		switch (HBBIFNLDKPO)
		{
		case NAAHKHPBAPA.Anvil:
			return AnvilGlow;
		case NAAHKHPBAPA.Bomb:
			return BombGlow;
		case NAAHKHPBAPA.BoxingGlove:
			return BoxingGloveGlow;
		case NAAHKHPBAPA.Coins:
			return CoinGlow;
		case NAAHKHPBAPA.Dice:
			return ShuffleGlow;
		case NAAHKHPBAPA.DiscoBall:
			return DiscoBallUiGlow;
		case NAAHKHPBAPA.Hammer:
			return HammerGlow;
		case NAAHKHPBAPA.Rocket:
			return RocketGlow;
		case NAAHKHPBAPA.Life:
			return LifeGlow;
		default:
			return null;
		}
	}

	public Sprite GetGoalSpriteByItemType(NOALGNJECAD HBBIFNLDKPO)
	{
		switch (HBBIFNLDKPO)
		{
		case NOALGNJECAD.SolidColor1:
			return SolidColorSprites[0];
		case NOALGNJECAD.SolidColor2:
			return SolidColorSprites[1];
		case NOALGNJECAD.SolidColor3:
			return SolidColorSprites[2];
		case NOALGNJECAD.SolidColor4:
			return SolidColorSprites[3];
		case NOALGNJECAD.SolidColor5:
			return SolidColorSprites[4];
		case NOALGNJECAD.SolidColor6:
			return SolidColorSprites[5];
		case NOALGNJECAD.ColoredBalloon:
			return ColoredBalloonGoal;
		case NOALGNJECAD.Jelly:
			return Jelly;
		case NOALGNJECAD.Balloon:
			return Balloon;
		case NOALGNJECAD.WaterMelon:
			return WaterMelon;
		case NOALGNJECAD.Pinata:
			return Pinata;
		case NOALGNJECAD.LightBulb:
			return LightBulb;
		case NOALGNJECAD.Crate:
			return Crate;
		case NOALGNJECAD.Cage:
			return Frame;
		case NOALGNJECAD.Bubble:
			return BubbleGoal;
		case NOALGNJECAD.GiantDuck:
			return GiantDuck;
		case NOALGNJECAD.GiantPinata:
			return GiantPinata;
		case NOALGNJECAD.EasterEgg:
			return EasterEggGoal;
		case NOALGNJECAD.Carrot:
			return Carrot;
		case NOALGNJECAD.Duck:
			return DuckGoal;
		case NOALGNJECAD.ColoredCrate:
			return ColoredCrateGoal;
		case NOALGNJECAD.CanToss:
			return Can;
		case NOALGNJECAD.Oyster:
			return OysterGoal;
		case NOALGNJECAD.Soda:
			return Soda;
		case NOALGNJECAD.ColoredSoda:
			return Soda;
		case NOALGNJECAD.MetalCrate:
			return MetalCrate;
		case NOALGNJECAD.Honey:
			return HoneyCube;
		case NOALGNJECAD.Diamond:
			return Diamond;
		case NOALGNJECAD.Billboard:
			return BillboardGoal;
		case NOALGNJECAD.Stone:
			return StoneGoal;
		case NOALGNJECAD.Soap:
			return SoapItem;
		case NOALGNJECAD.Mole:
			return MoleGoal;
		case NOALGNJECAD.Penguin:
			return PenguinGoal;
		case NOALGNJECAD.Bird:
			return BirdSprite;
		case NOALGNJECAD.Potion:
			return PotionGoal;
		case NOALGNJECAD.Ufo:
			return UfoGoal;
		case NOALGNJECAD.Hanoi:
			return HanoiGoal;
		case NOALGNJECAD.Gift:
			return GiftGoal;
		case NOALGNJECAD.Coconut:
			return CoconutGoal;
		case NOALGNJECAD.Ivy:
			return IvyGoal;
		case NOALGNJECAD.Vase:
			return VaseGoal;
		case NOALGNJECAD.Chain:
			return ChainGoal;
		case NOALGNJECAD.Washer:
			return WasherGoal;
		case NOALGNJECAD.Tube:
			return TubeGoal;
		case NOALGNJECAD.Log:
			return LogGoal;
		case NOALGNJECAD.Pot:
			return PotGoal;
		case NOALGNJECAD.Gold:
			return GoldGoal;
		case NOALGNJECAD.Tomb:
			return ElixirGoal;
		default:
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.ImageLibrary, "GetSpriteByItemType > ItemType:{0} cannot be found!", HBBIFNLDKPO);
			return null;
		}
	}
}
