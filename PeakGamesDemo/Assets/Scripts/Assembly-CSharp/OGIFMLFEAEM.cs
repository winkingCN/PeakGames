using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class OGIFMLFEAEM
{
	private KBDINLHCLJK GMFKFCNPDKF = new KBDINLHCLJK(0);

	public readonly int BHIJCAOHDCM;

	public readonly int BNNIJEPHLBJ;

	public readonly NOALGNJECAD ENBPGGCIADN;

	[CompilerGenerated]
	private static Dictionary<string, int> BNNGCGADLDB;

	[CompilerGenerated]
	private static Dictionary<string, int> KKEGLKJKJLK;

	public int GMCGMPEEHJP
	{
		get
		{
			return GMFKFCNPDKF.JBGOANMLBFA;
		}
		set
		{
			GMFKFCNPDKF.JBGOANMLBFA = value;
		}
	}

	public OGIFMLFEAEM(string AMMGCEDJGCH, int ENMLICFLHAO)
	{
		GMCGMPEEHJP = ENMLICFLHAO;
		BNNIJEPHLBJ = ENMLICFLHAO;
		AMMGCEDJGCH = AMMGCEDJGCH.ToLowerInvariant();
		ENBPGGCIADN = GFIJHHFKCAJ(AMMGCEDJGCH);
		BHIJCAOHDCM = EMLECGIFNPP(AMMGCEDJGCH);
	}

	public OGIFMLFEAEM(NOALGNJECAD ECOPIDONACO, int ENMLICFLHAO)
	{
		ENBPGGCIADN = ECOPIDONACO;
		GMCGMPEEHJP = ENMLICFLHAO;
	}

	private int EMLECGIFNPP(string AMMGCEDJGCH)
	{
		int result = 50;
		switch (AMMGCEDJGCH)
		{
		case "yellowcubegoal":
			result = 100;
			break;
		case "redcubegoal":
			result = 100;
			break;
		case "bluecubegoal":
			result = 100;
			break;
		case "greencubegoal":
			result = 100;
			break;
		case "purplecubegoal":
			result = 100;
			break;
		case "orangecubegoal":
			result = 100;
			break;
		case "bubblegoal":
			result = 10;
			break;
		case "crategoal":
			result = 56;
			break;
		case "framegoal":
			result = 56;
			break;
		case "colorcrategoal":
			result = 55;
			break;
		case "giantduckgoal":
			result = 1;
			break;
		case "giantpinatagoal":
			result = 1;
			break;
		case "duckgoal":
			result = 5;
			break;
		}
		return result;
	}

	public static NOALGNJECAD GFIJHHFKCAJ(string AMMGCEDJGCH)
	{
		NOALGNJECAD result = NOALGNJECAD.None;
		switch (AMMGCEDJGCH)
		{
		case "yellowcubegoal":
			result = NOALGNJECAD.SolidColor1;
			break;
		case "redcubegoal":
			result = NOALGNJECAD.SolidColor2;
			break;
		case "bluecubegoal":
			result = NOALGNJECAD.SolidColor3;
			break;
		case "greencubegoal":
			result = NOALGNJECAD.SolidColor4;
			break;
		case "purplecubegoal":
			result = NOALGNJECAD.SolidColor5;
			break;
		case "orangecubegoal":
			result = NOALGNJECAD.SolidColor6;
			break;
		case "bubblegoal":
			result = NOALGNJECAD.Bubble;
			break;
		case "crategoal":
			result = NOALGNJECAD.Crate;
			break;
		case "framegoal":
			result = NOALGNJECAD.Cage;
			break;
		case "colorcrategoal":
			result = NOALGNJECAD.ColoredCrate;
			break;
		case "balloongoal":
			result = NOALGNJECAD.Balloon;
			break;
		case "watermelongoal":
			result = NOALGNJECAD.WaterMelon;
			break;
		case "giantduckgoal":
			result = NOALGNJECAD.GiantDuck;
			break;
		case "giantpinatagoal":
			result = NOALGNJECAD.GiantPinata;
			break;
		case "carrotgoal":
			result = NOALGNJECAD.Carrot;
			break;
		case "duckgoal":
			result = NOALGNJECAD.Duck;
			break;
		case "colorballoongoal":
			result = NOALGNJECAD.ColoredBalloon;
			break;
		case "lightbulbgoal":
			result = NOALGNJECAD.LightBulb;
			break;
		case "jellygoal":
			result = NOALGNJECAD.Jelly;
			break;
		case "pinatagoal":
			result = NOALGNJECAD.Pinata;
			break;
		case "cangoal":
			result = NOALGNJECAD.CanToss;
			break;
		case "easteregggoal":
			result = NOALGNJECAD.EasterEgg;
			break;
		case "oystergoal":
			result = NOALGNJECAD.Oyster;
			break;
		case "sodagoal":
			result = NOALGNJECAD.Soda;
			break;
		case "metalcrategoal":
			result = NOALGNJECAD.MetalCrate;
			break;
		case "honeygoal":
			result = NOALGNJECAD.Honey;
			break;
		case "diamondgoal":
			result = NOALGNJECAD.Diamond;
			break;
		case "billboardgoal":
			result = NOALGNJECAD.Billboard;
			break;
		case "soapgoal":
			result = NOALGNJECAD.Soap;
			break;
		case "molegoal":
			result = NOALGNJECAD.Mole;
			break;
		case "penguingoal":
			result = NOALGNJECAD.Penguin;
			break;
		case "birdgoal":
			result = NOALGNJECAD.Bird;
			break;
		case "potiongoal":
			result = NOALGNJECAD.Potion;
			break;
		case "stonegoal":
			result = NOALGNJECAD.Stone;
			break;
		case "ufogoal":
			result = NOALGNJECAD.Ufo;
			break;
		case "hanoigoal":
			result = NOALGNJECAD.Hanoi;
			break;
		case "giftgoal":
			result = NOALGNJECAD.Gift;
			break;
		case "coconutgoal":
			result = NOALGNJECAD.Coconut;
			break;
		case "ivygoal":
			result = NOALGNJECAD.Ivy;
			break;
		case "vasegoal":
			result = NOALGNJECAD.Vase;
			break;
		case "chaingoal":
			result = NOALGNJECAD.Chain;
			break;
		case "washergoal":
			result = NOALGNJECAD.Washer;
			break;
		case "tubegoal":
			result = NOALGNJECAD.Tube;
			break;
		case "loggoal":
			result = NOALGNJECAD.Log;
			break;
		case "potgoal":
			result = NOALGNJECAD.Pot;
			break;
		case "goldgoal":
			result = NOALGNJECAD.Gold;
			break;
		case "elixirgoal":
			result = NOALGNJECAD.Tomb;
			break;
		}
		return result;
	}

	public override string ToString()
	{
		return string.Format("({0} = {1}/{2}) ", ENBPGGCIADN, GMCGMPEEHJP, BNNIJEPHLBJ);
	}

	public void PNLODLPOLJB(int NNIDKMJGAJO)
	{
		GMCGMPEEHJP -= NNIDKMJGAJO;
		if (GMCGMPEEHJP < 0)
		{
			GMCGMPEEHJP = 0;
		}
	}

	public void DFCJGFCNFDP(int NNIDKMJGAJO)
	{
		GMCGMPEEHJP += NNIDKMJGAJO;
	}
}
