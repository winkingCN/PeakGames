using System;
using System.Collections.Generic;
using UnityEngine;

namespace GamePlayScene.Mechanics
{
	public class ItemResourcesManager : MonoBehaviour
	{
		private static ItemResourcesManager KNPOFJNFLJB;

		public ItemResources SolidColorItemResources;

		public ItemResources BombItemResources;

		public ItemResources DiscoBallItemResources;

		public ItemResources RockItemResources;

		public ItemResources RocketAndBombItemResources;

		public ItemResources DiscoBallAndBombItemResources;

		public ItemResources DiscoBallAndRocketItemResources;

		public ItemResources DoubleDiscoBallItemResources;

		public ItemResources DoubleRocketItemResources;

		public ItemResources DoubleBombItemResources;

		public Dictionary<NOALGNJECAD, ItemResources> _itemResourcesDictionary;

		private List<GameObject> JIEPNECGIGO;

		public static ItemResourcesManager GABGKBAKHDP
		{
			get
			{
				return KNPOFJNFLJB;
			}
		}

		public void Awake()
		{
			if (KNPOFJNFLJB != null)
			{
				UnityEngine.Object.Destroy(KNPOFJNFLJB);
			}
			KNPOFJNFLJB = this;
			JIEPNECGIGO = new List<GameObject>();
			_itemResourcesDictionary = new Dictionary<NOALGNJECAD, ItemResources>(default(AJMGAIKBHGB))
			{
				{
					NOALGNJECAD.SolidColor1,
					SolidColorItemResources
				},
				{
					NOALGNJECAD.SolidColor2,
					null
				},
				{
					NOALGNJECAD.SolidColor3,
					null
				},
				{
					NOALGNJECAD.SolidColor4,
					null
				},
				{
					NOALGNJECAD.SolidColor5,
					null
				},
				{
					NOALGNJECAD.SolidColor6,
					null
				},
				{
					NOALGNJECAD.Rocket,
					RockItemResources
				},
				{
					NOALGNJECAD.Bomb,
					BombItemResources
				},
				{
					NOALGNJECAD.DiscoBall,
					DiscoBallItemResources
				},
				{
					NOALGNJECAD.RocketAndBomb,
					RocketAndBombItemResources
				},
				{
					NOALGNJECAD.DiscoBallAndBomb,
					DiscoBallAndBombItemResources
				},
				{
					NOALGNJECAD.DiscoBallAndRocket,
					DiscoBallAndRocketItemResources
				},
				{
					NOALGNJECAD.DoubleDiscoBall,
					DoubleDiscoBallItemResources
				},
				{
					NOALGNJECAD.DoubleRocket,
					DoubleRocketItemResources
				},
				{
					NOALGNJECAD.DoubleBomb,
					DoubleBombItemResources
				}
			};
		}

		private void OnDestroy()
		{
			UnloadAll();
			KNPOFJNFLJB = null;
		}

		public void RecycleAll()
		{
			int count = JIEPNECGIGO.Count;
			for (int i = 0; i < count; i++)
			{
				if (JIEPNECGIGO[i] != null)
				{
					JIEPNECGIGO[i].AACDKEGKCOL();
				}
			}
		}

		public void UnloadAll()
		{
			_itemResourcesDictionary = null;
			KNPOFJNFLJB = null;
		}

		public void InitItem(NOALGNJECAD HBBIFNLDKPO)
		{
			if (!_itemResourcesDictionary.ContainsKey(HBBIFNLDKPO))
			{
				try
				{
					ItemResources original = Resources.Load(JKJEMBLKFAH(HBBIFNLDKPO), typeof(ItemResources)) as ItemResources;
					_itemResourcesDictionary[HBBIFNLDKPO] = UnityEngine.Object.Instantiate(original, Vector3.zero, Quaternion.identity);
				}
				catch (Exception ex)
				{
					GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.ItemPrefabLoader, "Error loading resoures for item:{0} path:{1} Error:{2} Stack:{3}", HBBIFNLDKPO, JKJEMBLKFAH(HBBIFNLDKPO), ex.Message, ex.StackTrace);
				}
				switch (HBBIFNLDKPO)
				{
				case NOALGNJECAD.Balloon:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(10);
					break;
				case NOALGNJECAD.Duck:
				case NOALGNJECAD.GiantDuck:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(2);
					break;
				case NOALGNJECAD.Crate:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(4);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[1].FLFDKMOOIFL(4);
					break;
				case NOALGNJECAD.MagicHat:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(5);
					break;
				case NOALGNJECAD.ColoredBalloon:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(5);
					break;
				case NOALGNJECAD.LightBulb:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(5);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[1].FLFDKMOOIFL(5);
					break;
				case NOALGNJECAD.ColoredCrate:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(4);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[1].FLFDKMOOIFL(4);
					break;
				case NOALGNJECAD.Pinata:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(5);
					break;
				case NOALGNJECAD.CanToss:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(9);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[1].FLFDKMOOIFL(2);
					break;
				case NOALGNJECAD.EasterEgg:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(5);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[1].FLFDKMOOIFL(5);
					break;
				case NOALGNJECAD.Cage:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(4);
					break;
				case NOALGNJECAD.Oyster:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(3);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[1].FLFDKMOOIFL(3);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[2].FLFDKMOOIFL(3);
					break;
				case NOALGNJECAD.Soda:
				case NOALGNJECAD.ColoredSoda:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(3);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[1].FLFDKMOOIFL(3);
					break;
				case NOALGNJECAD.WaterMelon:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(3);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[1].FLFDKMOOIFL(3);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[2].FLFDKMOOIFL(3);
					break;
				case NOALGNJECAD.MetalCrate:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(5);
					break;
				case NOALGNJECAD.Fish:
					_itemResourcesDictionary[HBBIFNLDKPO].Animators[0].FLFDKMOOIFL(5);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(5);
					JIEPNECGIGO.Add(_itemResourcesDictionary[HBBIFNLDKPO].Animators[0]);
					break;
				case NOALGNJECAD.Honey:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(5);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[1].FLFDKMOOIFL(5);
					break;
				case NOALGNJECAD.Diamond:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(5);
					break;
				case NOALGNJECAD.Billboard:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(5);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[1].FLFDKMOOIFL(5);
					break;
				case NOALGNJECAD.Jelly:
					_itemResourcesDictionary[HBBIFNLDKPO].Animators[0].FLFDKMOOIFL(5);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(1);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[1].FLFDKMOOIFL(1);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[2].FLFDKMOOIFL(1);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[3].FLFDKMOOIFL(2);
					JIEPNECGIGO.Add(_itemResourcesDictionary[HBBIFNLDKPO].Animators[0]);
					break;
				case NOALGNJECAD.Bubble:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(2);
					break;
				case NOALGNJECAD.BalloonGenerator:
					_itemResourcesDictionary[HBBIFNLDKPO].Animators[0].FLFDKMOOIFL(5);
					JIEPNECGIGO.Add(_itemResourcesDictionary[HBBIFNLDKPO].Animators[0]);
					break;
				case NOALGNJECAD.Soap:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(5);
					_itemResourcesDictionary[HBBIFNLDKPO].Animators[0].FLFDKMOOIFL(18);
					JIEPNECGIGO.Add(_itemResourcesDictionary[HBBIFNLDKPO].Animators[0]);
					break;
				case NOALGNJECAD.Mole:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(5);
					break;
				case NOALGNJECAD.Penguin:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(5);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[1].FLFDKMOOIFL(5);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[2].FLFDKMOOIFL(5);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[3].FLFDKMOOIFL(5);
					_itemResourcesDictionary[HBBIFNLDKPO].Animators[0].FLFDKMOOIFL(5);
					JIEPNECGIGO.Add(_itemResourcesDictionary[HBBIFNLDKPO].Animators[0]);
					break;
				case NOALGNJECAD.BirdHouse:
					_itemResourcesDictionary[HBBIFNLDKPO].Animators[0].FLFDKMOOIFL(5);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(5);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[1].FLFDKMOOIFL(5);
					JIEPNECGIGO.Add(_itemResourcesDictionary[HBBIFNLDKPO].Animators[0]);
					break;
				case NOALGNJECAD.Potion:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(20);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[1].FLFDKMOOIFL(5);
					break;
				case NOALGNJECAD.Barrel:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(5);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[1].FLFDKMOOIFL(5);
					break;
				case NOALGNJECAD.Hanoi:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(5);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[1].FLFDKMOOIFL(5);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[2].FLFDKMOOIFL(5);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[3].FLFDKMOOIFL(5);
					break;
				case NOALGNJECAD.Coconut:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(5);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[1].FLFDKMOOIFL(5);
					break;
				case NOALGNJECAD.Ivy:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(8);
					break;
				case NOALGNJECAD.Fireworks:
					_itemResourcesDictionary[HBBIFNLDKPO].Animators[0].FLFDKMOOIFL(9);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(9);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[1].FLFDKMOOIFL(9);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[2].FLFDKMOOIFL(9);
					break;
				case NOALGNJECAD.Vase:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(9);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[1].FLFDKMOOIFL(9);
					break;
				case NOALGNJECAD.Chain:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(10);
					break;
				case NOALGNJECAD.Washer:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(3);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[1].FLFDKMOOIFL(3);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[2].FLFDKMOOIFL(3);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[3].FLFDKMOOIFL(3);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[4].FLFDKMOOIFL(3);
					break;
				case NOALGNJECAD.Tube:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(3);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[1].FLFDKMOOIFL(3);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[2].FLFDKMOOIFL(3);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[3].FLFDKMOOIFL(3);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[4].FLFDKMOOIFL(3);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[5].FLFDKMOOIFL(3);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[6].FLFDKMOOIFL(3);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[7].FLFDKMOOIFL(3);
					break;
				case NOALGNJECAD.Log:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(3);
					break;
				case NOALGNJECAD.Pot:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(3);
					break;
				case NOALGNJECAD.Safe:
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[0].FLFDKMOOIFL(3);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[1].FLFDKMOOIFL(6);
					_itemResourcesDictionary[HBBIFNLDKPO].Particles[2].FLFDKMOOIFL(3);
					_itemResourcesDictionary[HBBIFNLDKPO].Animators[0].FLFDKMOOIFL(6);
					break;
				}
			}
		}

		public ItemResources GetResources(NOALGNJECAD HBBIFNLDKPO)
		{
			InitItem(HBBIFNLDKPO);
			ItemResources itemResources = null;
			if (HBBIFNLDKPO == NOALGNJECAD.SolidColor1 || HBBIFNLDKPO == NOALGNJECAD.SolidColor2 || HBBIFNLDKPO == NOALGNJECAD.SolidColor3 || HBBIFNLDKPO == NOALGNJECAD.SolidColor4 || HBBIFNLDKPO == NOALGNJECAD.SolidColor5 || HBBIFNLDKPO == NOALGNJECAD.SolidColor6)
			{
				return _itemResourcesDictionary[NOALGNJECAD.SolidColor1];
			}
			return _itemResourcesDictionary[HBBIFNLDKPO];
		}

		private string JKJEMBLKFAH(NOALGNJECAD HBBIFNLDKPO)
		{
			string text = "Items/";
			switch (HBBIFNLDKPO)
			{
			case NOALGNJECAD.ColoredBalloon:
				text += "ColoredBalloonItemResources";
				break;
			case NOALGNJECAD.Duck:
				text += "DuckItemResources";
				break;
			case NOALGNJECAD.Balloon:
				text += "BalloonItemResources";
				break;
			case NOALGNJECAD.Pinata:
				text += "PinataItemResources";
				break;
			case NOALGNJECAD.LightBulb:
				text += "LightBulbItemResources";
				break;
			case NOALGNJECAD.Crate:
				text += "CrateItemResources";
				break;
			case NOALGNJECAD.ColoredCrate:
				text += "ColoredCrateItemResources";
				break;
			case NOALGNJECAD.GiantDuck:
				text += "GiantDuckItemResources";
				break;
			case NOALGNJECAD.EasterEgg:
				text += "EasterEggItemResources";
				break;
			case NOALGNJECAD.MagicHat:
				text += "MagicHatItemResources";
				break;
			case NOALGNJECAD.Jelly:
				text += "JellyItemResources";
				break;
			case NOALGNJECAD.CanToss:
				text += "CanTossItemResources";
				break;
			case NOALGNJECAD.Cage:
				text += "CageItemResources";
				break;
			case NOALGNJECAD.GiantPinata:
				text += "GiantPinataItemResources";
				break;
			case NOALGNJECAD.Oyster:
				text += "OysterItemResources";
				break;
			case NOALGNJECAD.Soda:
				text += "SodaItemResources";
				break;
			case NOALGNJECAD.WaterMelon:
				text += "WaterMelonItemResources";
				break;
			case NOALGNJECAD.MetalCrate:
				text += "MetalCrateResources";
				break;
			case NOALGNJECAD.Fish:
				text += "FishItemResources";
				break;
			case NOALGNJECAD.BalloonGenerator:
				text += "BalloonGeneratorResources";
				break;
			case NOALGNJECAD.Honey:
				text += "HoneyItemResources";
				break;
			case NOALGNJECAD.Diamond:
				text += "DiamondItemResources";
				break;
			case NOALGNJECAD.Billboard:
				text += "BillboardItemResources";
				break;
			case NOALGNJECAD.ColoredSoda:
				text += "ColoredSodaItemResources";
				break;
			case NOALGNJECAD.Blaster:
				text += "BlasterItemResources";
				break;
			case NOALGNJECAD.Bubble:
				text += "BubbleResources";
				break;
			case NOALGNJECAD.Soap:
				text += "SoapItemResources";
				break;
			case NOALGNJECAD.Mole:
				text += "MoleItemResources";
				break;
			case NOALGNJECAD.Penguin:
				text += "PenguinItemResources";
				break;
			case NOALGNJECAD.BirdHouse:
				text += "BirdHouseItemResources";
				break;
			case NOALGNJECAD.Potion:
				text += "PotionItemResources";
				break;
			case NOALGNJECAD.Barrel:
				text += "BarrelItemResources";
				break;
			case NOALGNJECAD.Wall:
				text += "WallItemResources";
				break;
			case NOALGNJECAD.Stone:
				text += "StoneItemResources";
				break;
			case NOALGNJECAD.Ufo:
				text += "UfoItemResources";
				break;
			case NOALGNJECAD.Hanoi:
				text += "HanoiItemResources";
				break;
			case NOALGNJECAD.Gift:
				text += "GiftItemResources";
				break;
			case NOALGNJECAD.Coconut:
				text += "CoconutItemResources";
				break;
			case NOALGNJECAD.Ivy:
				text += "IvyItemResources";
				break;
			case NOALGNJECAD.Fireworks:
				text += "FireworksItemResources";
				break;
			case NOALGNJECAD.Vase:
				text += "VaseItemResources";
				break;
			case NOALGNJECAD.Chain:
				text += "ChainItemResources";
				break;
			case NOALGNJECAD.Washer:
				text += "WasherItemResources";
				break;
			case NOALGNJECAD.Tube:
				text += "TubeItemResources";
				break;
			case NOALGNJECAD.Log:
				text += "LogItemResources";
				break;
			case NOALGNJECAD.LogFake:
				text += "LogFakeItemResources";
				break;
			case NOALGNJECAD.Pot:
				text += "PotItemResources";
				break;
			case NOALGNJECAD.Safe:
				text += "SafeItemResources";
				break;
			case NOALGNJECAD.Tomb:
				text += "TombItemResources";
				break;
			default:
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.ItemPrefabLoader, "Error Getting path of the item type:{0}", HBBIFNLDKPO);
				break;
			}
			return text;
		}
	}
}
