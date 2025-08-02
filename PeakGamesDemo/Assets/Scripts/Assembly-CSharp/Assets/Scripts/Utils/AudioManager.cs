using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Assets.Scripts.SceneTransitions;
using DG.Tweening;
using GamePlayScene.Mechanics;
using UnityEngine;

namespace Assets.Scripts.Utils
{
	public class AudioManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class PMKIEFJPFDA
		{
			internal ItemResources.AudioProps GFKKCPCHDGN;

			internal GCEAKOOGDJK LJCPOAOKFOE;

			internal AudioSource JNCFHKGILOI;

			internal float LAAIPKIPGJL;

			internal void AGFNGEFDHLA()
			{
				PlayAudioProps(GFKKCPCHDGN, LJCPOAOKFOE, JNCFHKGILOI, LAAIPKIPGJL);
			}
		}

		[CompilerGenerated]
		private sealed class FOGMGMFKMEB
		{
			internal Action JFBIIKLKNGE;

			internal void AGFNGEFDHLA()
			{
				if (IELJFBMMCCI.CurrentMusicSource.isPlaying)
				{
					IELJFBMMCCI.CurrentMusicSource.Stop();
				}
				BGJKAMKIPBO(JFBIIKLKNGE);
			}
		}

		[CompilerGenerated]
		private sealed class IBIJLAHOPEC
		{
			internal AudioClip PNBMCLEJMLM;

			internal bool HFHBMPKFFLF;

			internal void AGFNGEFDHLA()
			{
				IELJFBMMCCI.CurrentFxSource.PlayOneShot(PNBMCLEJMLM);
				if (HFHBMPKFFLF)
				{
					MBFHBJECDGO = new LLCJMMBBLEH(DNIHMODFKKG(PNBMCLEJMLM.length));
				}
			}
		}

		[CompilerGenerated]
		private sealed class PIOGAMADGLI
		{
			internal string IOCMOCCFALN;

			internal void AGFNGEFDHLA()
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AudioManager, "Load music: {0}", IOCMOCCFALN);
				IELJFBMMCCI.CurrentMusicSource.clip = Resources.Load("Musics/" + IOCMOCCFALN) as AudioClip;
				IELJFBMMCCI.CurrentMusicSource.loop = true;
				IELJFBMMCCI.CurrentMusicSource.enabled = true;
				IELJFBMMCCI.CurrentMusicSource.volume = 1f;
				IELJFBMMCCI.CurrentMusicSource.Play();
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AudioManager, "Play music: {0}", IOCMOCCFALN);
			}
		}

		public AudioSource CurrentMusicSource;

		public AudioSource CurrentFxSource;

		private static AudioManager IELJFBMMCCI;

		private static float[] LOFFGLFJMCM;

		private static int[] AHBCCPHNKPJ;

		private static bool DHAMFGJFMKD;

		private static readonly string[] HKJHHLFNAKH = new string[3] { "gameplay2_wolf", "gameplay1", "gameplay3_mus" };

		private static readonly string ELDIEANKPNC = "map1";

		private static readonly KOOGPFAPGGD[] LBCHKDINHOL = new KOOGPFAPGGD[4]
		{
			KOOGPFAPGGD.Cube1,
			KOOGPFAPGGD.Cube2,
			KOOGPFAPGGD.Cube3,
			KOOGPFAPGGD.Cube4
		};

		private static int OGGOMNPMDJP = -1;

		private static Dictionary<KOOGPFAPGGD, List<AudioClip>> PCJJGDCJLOB = new Dictionary<KOOGPFAPGGD, List<AudioClip>>();

		private static List<string> BCKAIALAKIN;

		private static LLCJMMBBLEH HEODCMMAFHN;

		private static int FMGHAHEHIOP;

		private static List<LIMIJHEGEDE> PBFNFMDJLJH = new List<LIMIJHEGEDE>();

		private bool NBCPBMBOCII;

		private static bool EBFCJGEFCPG;

		private static LLCJMMBBLEH MBFHBJECDGO;

		private static float GKAPIJKFEKB;

		private static List<AudioSource> OBMFKOCDHMG = new List<AudioSource>();

		private static readonly HashSet<KOOGPFAPGGD> LGJBHPAPMNM = new HashSet<KOOGPFAPGGD>
		{
			KOOGPFAPGGD.UiClick,
			KOOGPFAPGGD.UiClose
		};

		private static readonly HashSet<KOOGPFAPGGD> EMHCNPAOPKB = new HashSet<KOOGPFAPGGD>
		{
			KOOGPFAPGGD.ChestCardFly,
			KOOGPFAPGGD.ChestCardTurn,
			KOOGPFAPGGD.ChestCardLand,
			KOOGPFAPGGD.ChestFly,
			KOOGPFAPGGD.UiBuyBooster,
			KOOGPFAPGGD.UiClick,
			KOOGPFAPGGD.UiClose,
			KOOGPFAPGGD.UiGameplayStar1,
			KOOGPFAPGGD.UiGameplayStar2,
			KOOGPFAPGGD.UiGameplayStar3,
			KOOGPFAPGGD.UiGoalComplete,
			KOOGPFAPGGD.UiLevelUnlock,
			KOOGPFAPGGD.UiLifeFill,
			KOOGPFAPGGD.UiPopupStar1,
			KOOGPFAPGGD.UiPopupStar2,
			KOOGPFAPGGD.UiPopupStar3,
			KOOGPFAPGGD.UiEpisodeUnlockCelebration,
			KOOGPFAPGGD.UiEpisodeUnlockLand,
			KOOGPFAPGGD.UiCoinCollect,
			KOOGPFAPGGD.CrownEgoDialog,
			KOOGPFAPGGD.CrownInfoDialogFill,
			KOOGPFAPGGD.CrownInfoDialogParticle,
			KOOGPFAPGGD.StarChestOpen1,
			KOOGPFAPGGD.StarChestOpen2,
			KOOGPFAPGGD.StarChestOpen3,
			KOOGPFAPGGD.DailyBonusCardFly,
			KOOGPFAPGGD.DailyBonusCardTurn,
			KOOGPFAPGGD.DailyBonusCardLand,
			KOOGPFAPGGD.UiLifeCollect,
			KOOGPFAPGGD.LevelWinCoinReward,
			KOOGPFAPGGD.ChestCardCountIncrease,
			KOOGPFAPGGD.LifeReveal,
			KOOGPFAPGGD.TreasureKeyFly,
			KOOGPFAPGGD.TreasureKeyHit,
			KOOGPFAPGGD.TreasureChestKeyReveal,
			KOOGPFAPGGD.TreasureChestKeyFly,
			KOOGPFAPGGD.TreasureChestKeyUnlock,
			KOOGPFAPGGD.StingerBoosterUnlocked,
			KOOGPFAPGGD.BoosterCollectAppear,
			KOOGPFAPGGD.BoosterCollectHit,
			KOOGPFAPGGD.CalendarTextEnter,
			KOOGPFAPGGD.CalendarRewardFly,
			KOOGPFAPGGD.CalendarRewardPlace,
			KOOGPFAPGGD.CalendarGiftExpand,
			KOOGPFAPGGD.CalendarGiftExplode
		};

		private static readonly HashSet<KOOGPFAPGGD> JFILGKBCHHN = new HashSet<KOOGPFAPGGD>
		{
			KOOGPFAPGGD.BoosterAnvil,
			KOOGPFAPGGD.BoosterBoxing,
			KOOGPFAPGGD.BoosterDice,
			KOOGPFAPGGD.BoosterHammerEnter,
			KOOGPFAPGGD.BoosterHammerExit,
			KOOGPFAPGGD.BoosterHammerUse,
			KOOGPFAPGGD.ComboBombBomb,
			KOOGPFAPGGD.ComboDiscoDisco,
			KOOGPFAPGGD.ComboMerge,
			KOOGPFAPGGD.ComboRocketBombExplode,
			KOOGPFAPGGD.ComboRocketBombSpin,
			KOOGPFAPGGD.ComboRocketRocket,
			KOOGPFAPGGD.FireworkExplode1,
			KOOGPFAPGGD.FireworkExplode2,
			KOOGPFAPGGD.FireworkUp1,
			KOOGPFAPGGD.FireworkUp2,
			KOOGPFAPGGD.GoalBannerIn,
			KOOGPFAPGGD.GoalBannerOut,
			KOOGPFAPGGD.InvalidTap,
			KOOGPFAPGGD.ItemSpecialBomb,
			KOOGPFAPGGD.ItemSpecialCreate,
			KOOGPFAPGGD.ItemSpecialDiscoExplode,
			KOOGPFAPGGD.ItemSpecialDiscoRay,
			KOOGPFAPGGD.ItemSpecialRocket,
			KOOGPFAPGGD.RemainingPlace,
			KOOGPFAPGGD.RemainingThrow,
			KOOGPFAPGGD.UiBuyBooster,
			KOOGPFAPGGD.UiClick,
			KOOGPFAPGGD.UiClose,
			KOOGPFAPGGD.UiGameplayStar1,
			KOOGPFAPGGD.UiGameplayStar2,
			KOOGPFAPGGD.UiGameplayStar3,
			KOOGPFAPGGD.UiGoalComplete,
			KOOGPFAPGGD.UiLevelUnlock,
			KOOGPFAPGGD.UiLifeFill,
			KOOGPFAPGGD.UiPopupStar1,
			KOOGPFAPGGD.UiPopupStar2,
			KOOGPFAPGGD.UiPopupStar3,
			KOOGPFAPGGD.CrownEgoDialog,
			KOOGPFAPGGD.SpecialItemPlace,
			KOOGPFAPGGD.StingerEndGameOfferIntro,
			KOOGPFAPGGD.StingerEndGameOfferAccepted,
			KOOGPFAPGGD.StingerLevelComplete,
			KOOGPFAPGGD.StingerLevelFailed,
			KOOGPFAPGGD.StingerCelebration,
			KOOGPFAPGGD.StingerLogo,
			KOOGPFAPGGD.Cube1,
			KOOGPFAPGGD.Cube2,
			KOOGPFAPGGD.Cube3,
			KOOGPFAPGGD.Cube4,
			KOOGPFAPGGD.Last5MovesIn,
			KOOGPFAPGGD.Last5MovesOut
		};

		private static Dictionary<KOOGPFAPGGD, HNJNHMPOGEL> FBKCCMBKFIN = new Dictionary<KOOGPFAPGGD, HNJNHMPOGEL>
		{
			{
				KOOGPFAPGGD.BoosterAnvil,
				new HNJNHMPOGEL("FX/booster_anvil")
			},
			{
				KOOGPFAPGGD.BoosterBoxing,
				new HNJNHMPOGEL("FX/booster_boxing")
			},
			{
				KOOGPFAPGGD.BoosterCollectAppear,
				new HNJNHMPOGEL("FX/ui_booster_collect_appear")
			},
			{
				KOOGPFAPGGD.BoosterCollectHit,
				new HNJNHMPOGEL("FX/ui_booster_collect_hit")
			},
			{
				KOOGPFAPGGD.BoosterDice,
				new HNJNHMPOGEL("FX/booster_dice")
			},
			{
				KOOGPFAPGGD.BoosterHammerEnter,
				new HNJNHMPOGEL("FX/booster_hammer_enter")
			},
			{
				KOOGPFAPGGD.BoosterHammerExit,
				new HNJNHMPOGEL("FX/booster_hammer_exit")
			},
			{
				KOOGPFAPGGD.BoosterHammerUse,
				new HNJNHMPOGEL("FX/booster_hammer_use")
			},
			{
				KOOGPFAPGGD.ChestFly,
				new HNJNHMPOGEL("FX/chest_fly")
			},
			{
				KOOGPFAPGGD.ChestCardCountIncrease,
				new HNJNHMPOGEL("FX/chest_card_count_increase")
			},
			{
				KOOGPFAPGGD.ChestCardFly,
				new HNJNHMPOGEL("FX/chest_card_fly")
			},
			{
				KOOGPFAPGGD.ChestCardLand,
				new HNJNHMPOGEL("FX/ui_life_fill")
			},
			{
				KOOGPFAPGGD.ChestCardTurn,
				new HNJNHMPOGEL("FX/chest_card_turn")
			},
			{
				KOOGPFAPGGD.ComboBombBomb,
				new HNJNHMPOGEL("FX/combo_bomb_bomb")
			},
			{
				KOOGPFAPGGD.ComboDiscoDisco,
				new HNJNHMPOGEL("FX/combo_disco_disco")
			},
			{
				KOOGPFAPGGD.ComboMerge,
				new HNJNHMPOGEL("FX/combo_merge")
			},
			{
				KOOGPFAPGGD.ComboRocketBombExplode,
				new HNJNHMPOGEL("FX/combo_rocket_bomb_explode")
			},
			{
				KOOGPFAPGGD.ComboRocketBombSpin,
				new HNJNHMPOGEL("FX/combo_rocket_bomb_spin")
			},
			{
				KOOGPFAPGGD.ComboRocketRocket,
				new HNJNHMPOGEL("FX/combo_rocket_rocket")
			},
			{
				KOOGPFAPGGD.CrownEgoDialog,
				new HNJNHMPOGEL("FX/crown_ego")
			},
			{
				KOOGPFAPGGD.CrownInfoDialogFill,
				new HNJNHMPOGEL("FX/crown_fill")
			},
			{
				KOOGPFAPGGD.CrownInfoDialogParticle,
				new HNJNHMPOGEL("FX/crown_particle")
			},
			{
				KOOGPFAPGGD.Cube1,
				new HNJNHMPOGEL("FX/item_cube_1")
			},
			{
				KOOGPFAPGGD.Cube2,
				new HNJNHMPOGEL("FX/item_cube_2")
			},
			{
				KOOGPFAPGGD.Cube3,
				new HNJNHMPOGEL("FX/item_cube_3")
			},
			{
				KOOGPFAPGGD.Cube4,
				new HNJNHMPOGEL("FX/item_cube_4")
			},
			{
				KOOGPFAPGGD.DailyBonusCardFly,
				new HNJNHMPOGEL("FX/daily_bonus_card_fly")
			},
			{
				KOOGPFAPGGD.DailyBonusCardLand,
				new HNJNHMPOGEL("FX/daily_bonus_card_land")
			},
			{
				KOOGPFAPGGD.DailyBonusCardTurn,
				new HNJNHMPOGEL("FX/daily_bonus_card_turn")
			},
			{
				KOOGPFAPGGD.FireworkExplode1,
				new HNJNHMPOGEL("FX/firework_explode1")
			},
			{
				KOOGPFAPGGD.FireworkExplode2,
				new HNJNHMPOGEL("FX/firework_explode2")
			},
			{
				KOOGPFAPGGD.FireworkUp1,
				new HNJNHMPOGEL("FX/firework_up1")
			},
			{
				KOOGPFAPGGD.FireworkUp2,
				new HNJNHMPOGEL("FX/firework_up2")
			},
			{
				KOOGPFAPGGD.GoalBannerIn,
				new HNJNHMPOGEL("FX/ui_goal_in")
			},
			{
				KOOGPFAPGGD.GoalBannerOut,
				new HNJNHMPOGEL("FX/ui_goal_out")
			},
			{
				KOOGPFAPGGD.InvalidTap,
				new HNJNHMPOGEL("FX/ui_invalid_click")
			},
			{
				KOOGPFAPGGD.Last5MovesIn,
				new HNJNHMPOGEL("FX/last_5_moves_in")
			},
			{
				KOOGPFAPGGD.Last5MovesOut,
				new HNJNHMPOGEL("FX/last_5_moves_out")
			},
			{
				KOOGPFAPGGD.LevelWinCoinReward,
				new HNJNHMPOGEL("FX/level_win_coin_reward")
			},
			{
				KOOGPFAPGGD.LifeReveal,
				new HNJNHMPOGEL("FX/life_reveal")
			},
			{
				KOOGPFAPGGD.RemainingPlace,
				new HNJNHMPOGEL("FX/remaining_place")
			},
			{
				KOOGPFAPGGD.RemainingThrow,
				new HNJNHMPOGEL("FX/remaining_throw")
			},
			{
				KOOGPFAPGGD.SpecialItemPlace,
				new HNJNHMPOGEL("FX/specialItem_place")
			},
			{
				KOOGPFAPGGD.StarChestOpen1,
				new HNJNHMPOGEL("FX/star_chest_collect_1")
			},
			{
				KOOGPFAPGGD.StarChestOpen2,
				new HNJNHMPOGEL("FX/star_chest_collect_2")
			},
			{
				KOOGPFAPGGD.StarChestOpen3,
				new HNJNHMPOGEL("FX/star_chest_collect_3")
			},
			{
				KOOGPFAPGGD.StingerBoosterUnlocked,
				new HNJNHMPOGEL("FX/stg_toon_blast_booster_unlocked")
			},
			{
				KOOGPFAPGGD.StingerCelebration,
				new HNJNHMPOGEL("FX/stg_toon_blast_celebration")
			},
			{
				KOOGPFAPGGD.StingerEndGameOfferAccepted,
				new HNJNHMPOGEL("FX/stg_toon_blast_end_game_offer_accepted")
			},
			{
				KOOGPFAPGGD.StingerEndGameOfferIntro,
				new HNJNHMPOGEL("FX/stg_toon_blast_end_game_offer_intro")
			},
			{
				KOOGPFAPGGD.StingerLevelComplete,
				new HNJNHMPOGEL("FX/stg_toon_blast_level_complete")
			},
			{
				KOOGPFAPGGD.StingerLevelFailed,
				new HNJNHMPOGEL("FX/stg_toon_blast_level_failed")
			},
			{
				KOOGPFAPGGD.StingerLogo,
				new HNJNHMPOGEL("FX/stg_toon_blast_logo")
			},
			{
				KOOGPFAPGGD.TreasureChestKeyFly,
				new HNJNHMPOGEL("FX/treasure_chest_key_fly")
			},
			{
				KOOGPFAPGGD.TreasureChestKeyReveal,
				new HNJNHMPOGEL("FX/treasure_chest_key_reveal")
			},
			{
				KOOGPFAPGGD.TreasureChestKeyUnlock,
				new HNJNHMPOGEL("FX/treasure_chest_key_unlock")
			},
			{
				KOOGPFAPGGD.TreasureKeyFly,
				new HNJNHMPOGEL("FX/treasure_key_fly")
			},
			{
				KOOGPFAPGGD.TreasureKeyHit,
				new HNJNHMPOGEL("FX/treasure_key_hit")
			},
			{
				KOOGPFAPGGD.UiBuyBooster,
				new HNJNHMPOGEL("FX/ui_buy_booster")
			},
			{
				KOOGPFAPGGD.UiClick,
				new HNJNHMPOGEL("FX/ui_click")
			},
			{
				KOOGPFAPGGD.UiClose,
				new HNJNHMPOGEL("FX/ui_close_v2")
			},
			{
				KOOGPFAPGGD.UiCoinCollect,
				new HNJNHMPOGEL("FX/ui_coin_collect")
			},
			{
				KOOGPFAPGGD.UiEpisodeUnlockCelebration,
				new HNJNHMPOGEL("FX/ui_episode_unlock_celebration")
			},
			{
				KOOGPFAPGGD.UiEpisodeUnlockLand,
				new HNJNHMPOGEL("FX/ui_episode_unlock_land")
			},
			{
				KOOGPFAPGGD.UiGameplayStar1,
				new HNJNHMPOGEL("FX/ui_gameplay_star1")
			},
			{
				KOOGPFAPGGD.UiGameplayStar2,
				new HNJNHMPOGEL("FX/ui_gameplay_star2")
			},
			{
				KOOGPFAPGGD.UiGameplayStar3,
				new HNJNHMPOGEL("FX/ui_gameplay_star3")
			},
			{
				KOOGPFAPGGD.UiGoalComplete,
				new HNJNHMPOGEL("FX/ui_goal_complete")
			},
			{
				KOOGPFAPGGD.UiLevelUnlock,
				new HNJNHMPOGEL("FX/ui_level_unlock")
			},
			{
				KOOGPFAPGGD.UiLifeCollect,
				new HNJNHMPOGEL("FX/ui_life_collect")
			},
			{
				KOOGPFAPGGD.UiLifeFill,
				new HNJNHMPOGEL("FX/ui_life_fill")
			},
			{
				KOOGPFAPGGD.UiPopupStar1,
				new HNJNHMPOGEL("FX/ui_popup_star1")
			},
			{
				KOOGPFAPGGD.UiPopupStar2,
				new HNJNHMPOGEL("FX/ui_popup_star2")
			},
			{
				KOOGPFAPGGD.UiPopupStar3,
				new HNJNHMPOGEL("FX/ui_popup_star3")
			},
			{
				KOOGPFAPGGD.ItemSpecialBomb,
				new HNJNHMPOGEL("FX/item_special_bomb")
			},
			{
				KOOGPFAPGGD.ItemSpecialCreate,
				new HNJNHMPOGEL("FX/item_special_create")
			},
			{
				KOOGPFAPGGD.ItemSpecialDiscoExplode,
				new HNJNHMPOGEL("FX/item_special_disco_explode")
			},
			{
				KOOGPFAPGGD.ItemSpecialDiscoRay,
				new HNJNHMPOGEL("FX/item_special_disco_ray")
			},
			{
				KOOGPFAPGGD.ItemSpecialRocket,
				new HNJNHMPOGEL("FX/item_special_rocket")
			},
			{
				KOOGPFAPGGD.CalendarTextEnter,
				new HNJNHMPOGEL("FX/calendar_text_enter")
			},
			{
				KOOGPFAPGGD.CalendarRewardFly,
				new HNJNHMPOGEL("FX/calendar_reward_fly")
			},
			{
				KOOGPFAPGGD.CalendarRewardPlace,
				new HNJNHMPOGEL("FX/calendar_reward_place")
			},
			{
				KOOGPFAPGGD.CalendarGiftExpand,
				new HNJNHMPOGEL("FX/calendar_gift_expand")
			},
			{
				KOOGPFAPGGD.CalendarGiftExplode,
				new HNJNHMPOGEL("FX/calendar_gift_explode")
			}
		};

		public static int MPHNEKNMGML
		{
			get
			{
				return OGGOMNPMDJP;
			}
		}

		public static bool NAEBPOAPIFP
		{
			get
			{
				return DHAMFGJFMKD;
			}
			set
			{
				DHAMFGJFMKD = value;
				MuteExternalAudioSources(!DHAMFGJFMKD);
			}
		}

		public static bool MMJKLIMKEHG
		{
			get
			{
				return EBFCJGEFCPG;
			}
			set
			{
				EBFCJGEFCPG = value;
				PlaySong();
			}
		}

		public static void ProcessDownloadedAudioFiles()
		{
			string path = Path.Combine(Application.persistentDataPath, "temp_audio");
			if (Directory.Exists(path))
			{
				if (HEODCMMAFHN != null)
				{
					HEODCMMAFHN.BPPFBMCJOAH();
				}
				HEODCMMAFHN = new LLCJMMBBLEH(OCJJFPPGFEO(), true);
			}
		}

		private static IEnumerator OCJJFPPGFEO()
		{
			PCJJGDCJLOB = new Dictionary<KOOGPFAPGGD, List<AudioClip>>();
			string path = Path.Combine(Application.persistentDataPath, "temp_audio");
			string[] directories = Directory.GetDirectories(path);
			int i = 0;
			for (int num = directories.Length; i < num; i++)
			{
				KOOGPFAPGGD key = (KOOGPFAPGGD)Enum.Parse(value: Path.GetFileName(directories[i]), enumType: typeof(KOOGPFAPGGD));
				if (!PCJJGDCJLOB.ContainsKey(key))
				{
					PCJJGDCJLOB.Add(key, new List<AudioClip>());
				}
				string[] files = Directory.GetFiles(directories[i]);
				if (files.Length <= 0)
				{
					continue;
				}
				int j = 0;
				for (int num2 = files.Length; j < num2; j++)
				{
					string text = files[j];
					if (text.Contains(".ogg"))
					{
						WWW wWW = new WWW("file://" + text);
						yield return wWW.isDone;
						AudioClip audioClipCompressed = wWW.GetAudioClipCompressed(false);
						audioClipCompressed.LoadAudioData();
						PCJJGDCJLOB[key].Add(audioClipCompressed);
						if (!string.IsNullOrEmpty(wWW.error))
						{
							GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.AudioManager, "Error loading downloaded sounds");
						}
					}
				}
			}
			yield return null;
		}

		public static void IncreaseSongCounter()
		{
			OGGOMNPMDJP = ++OGGOMNPMDJP % HKJHHLFNAKH.Length;
		}

		public void LateUpdate()
		{
			int count = PBFNFMDJLJH.Count;
			if (count == 0)
			{
				return;
			}
			for (int i = 0; i < count; i++)
			{
				LIMIJHEGEDE lIMIJHEGEDE = PBFNFMDJLJH[i];
				if (lIMIJHEGEDE.BNEMAJGEKKB != KOOGPFAPGGD.ClassicExplode || GKAPIJKFEKB < Time.time)
				{
					LMCELHPBDKB(lIMIJHEGEDE.NNHKHAGCFEH, lIMIJHEGEDE.PDDHKECLNFH, lIMIJHEGEDE.OOKPAHPCFBJ);
				}
			}
			PBFNFMDJLJH.Clear();
		}

		public void Awake()
		{
			if (IELJFBMMCCI != null)
			{
				UnityEngine.Object.Destroy(IELJFBMMCCI.gameObject);
			}
			IELJFBMMCCI = this;
			UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
			int num = (int)Enum.GetValues(typeof(KOOGPFAPGGD)).Cast<KOOGPFAPGGD>().Max();
			LOFFGLFJMCM = new float[num + 1];
			AHBCCPHNKPJ = new int[num + 1];
			NAEBPOAPIFP = MDGKDGMGGCL.GABGKBAKHDP.NBJEKKIECGE();
			MMJKLIMKEHG = MDGKDGMGGCL.GABGKBAKHDP.AGGMHHLFFDA();
		}

		public static void FilterQueue(KOOGPFAPGGD MOKLDCMGFFB)
		{
			for (int num = PBFNFMDJLJH.Count - 1; num >= 0; num--)
			{
				if (PBFNFMDJLJH[num].BNEMAJGEKKB == MOKLDCMGFFB)
				{
					PBFNFMDJLJH.RemoveAt(num);
				}
			}
		}

		public static void PlayAudioPropsLater(float FDGGGNOCCJM, ItemResources.AudioProps GFKKCPCHDGN, GCEAKOOGDJK LJCPOAOKFOE = GCEAKOOGDJK.Frame, AudioSource JNCFHKGILOI = null, float LAAIPKIPGJL = 1f)
		{
			DOTween.Sequence().InsertCallback(FDGGGNOCCJM, delegate
			{
				PlayAudioProps(GFKKCPCHDGN, LJCPOAOKFOE, JNCFHKGILOI, LAAIPKIPGJL);
			});
		}

		public static void PlayAudioProps(ItemResources.AudioProps GFKKCPCHDGN, GCEAKOOGDJK LJCPOAOKFOE = GCEAKOOGDJK.Frame, AudioSource JNCFHKGILOI = null, float LAAIPKIPGJL = 1f)
		{
			if (IELJFBMMCCI == null)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.AudioManager, "Audio Manager is not ready yet!");
			}
			else
			{
				if (!NAEBPOAPIFP || IELJFBMMCCI.NBCPBMBOCII)
				{
					return;
				}
				KOOGPFAPGGD audioTag = GFKKCPCHDGN.AudioTag;
				AudioClip audioClip = GFKKCPCHDGN.AudioClip;
				if (audioClip == null)
				{
					return;
				}
				int num = (int)audioTag;
				if ((LJCPOAOKFOE != GCEAKOOGDJK.Single || !(Time.time - LOFFGLFJMCM[num] < audioClip.length)) && (LJCPOAOKFOE != GCEAKOOGDJK.Frame || Time.frameCount != AHBCCPHNKPJ[num]))
				{
					LOFFGLFJMCM[num] = Time.time;
					AHBCCPHNKPJ[num] = Time.frameCount;
					if (KECFAFOANII(audioTag))
					{
						GKAPIJKFEKB = Time.time + audioClip.length;
					}
					GBMMHIPGHJB(audioClip, JNCFHKGILOI, audioTag, LAAIPKIPGJL);
				}
			}
		}

		public static void Play(KOOGPFAPGGD MOKLDCMGFFB, GCEAKOOGDJK LJCPOAOKFOE = GCEAKOOGDJK.Frame, AudioSource JNCFHKGILOI = null, float LAAIPKIPGJL = 1f)
		{
			if (IELJFBMMCCI == null)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.AudioManager, "Audio Manager is not ready yet!");
			}
			else
			{
				if (!NAEBPOAPIFP || IELJFBMMCCI.NBCPBMBOCII)
				{
					return;
				}
				AudioClip audioClip = CIOJKBFOJBH(MOKLDCMGFFB);
				if (audioClip == null)
				{
					return;
				}
				if ((LJCPOAOKFOE != GCEAKOOGDJK.Single || !(Time.time - LOFFGLFJMCM[(int)MOKLDCMGFFB] < audioClip.length)) && (LJCPOAOKFOE != GCEAKOOGDJK.Frame || Time.frameCount != AHBCCPHNKPJ[(int)MOKLDCMGFFB]))
				{
					LOFFGLFJMCM[(int)MOKLDCMGFFB] = Time.time;
					AHBCCPHNKPJ[(int)MOKLDCMGFFB] = Time.frameCount;
					if (KECFAFOANII(MOKLDCMGFFB))
					{
						GKAPIJKFEKB = Time.time + audioClip.length;
					}
					GBMMHIPGHJB(audioClip, JNCFHKGILOI, MOKLDCMGFFB, LAAIPKIPGJL);
				}
			}
		}

		private static AudioClip CIOJKBFOJBH(KOOGPFAPGGD DHLIPHHBOOG)
		{
			if (DHLIPHHBOOG == KOOGPFAPGGD.ClassicExplode)
			{
				DHLIPHHBOOG = LBCHKDINHOL[FMGHAHEHIOP++ % LBCHKDINHOL.Length];
			}
			return (!FBKCCMBKFIN.ContainsKey(DHLIPHHBOOG)) ? null : FBKCCMBKFIN[DHLIPHHBOOG].NEMMFAPDCMC;
		}

		private static void GBMMHIPGHJB(AudioClip AICMMKJMNKA, AudioSource JNCFHKGILOI, KOOGPFAPGGD MOKLDCMGFFB, float LAAIPKIPGJL)
		{
			PBFNFMDJLJH.Add(new LIMIJHEGEDE(AICMMKJMNKA, JNCFHKGILOI, MOKLDCMGFFB, LAAIPKIPGJL));
		}

		private static bool KECFAFOANII(KOOGPFAPGGD DHLIPHHBOOG)
		{
			switch (DHLIPHHBOOG)
			{
			case KOOGPFAPGGD.ComboBombBomb:
			case KOOGPFAPGGD.ComboDiscoDisco:
			case KOOGPFAPGGD.ComboMerge:
			case KOOGPFAPGGD.ComboRocketBombExplode:
			case KOOGPFAPGGD.ComboRocketBombSpin:
			case KOOGPFAPGGD.ComboRocketRocket:
			case KOOGPFAPGGD.EasterEggExplode:
			case KOOGPFAPGGD.EasterEggTransform:
			case KOOGPFAPGGD.ItemBalloon:
			case KOOGPFAPGGD.ItemBalloonGenerator1:
			case KOOGPFAPGGD.ItemBubble:
			case KOOGPFAPGGD.ItemBubblePlace:
			case KOOGPFAPGGD.ItemCan1:
			case KOOGPFAPGGD.ItemCan2:
			case KOOGPFAPGGD.ItemCan3:
			case KOOGPFAPGGD.ItemCanClear:
			case KOOGPFAPGGD.ItemCrate1:
			case KOOGPFAPGGD.ItemCrate23:
			case KOOGPFAPGGD.ItemFish:
			case KOOGPFAPGGD.ItemFrame:
			case KOOGPFAPGGD.GiantDuckLanding:
			case KOOGPFAPGGD.ItemGiantPinata_1_2:
			case KOOGPFAPGGD.ItemGiantPinata_3:
			case KOOGPFAPGGD.ItemLightbulb1:
			case KOOGPFAPGGD.ItemLightbulb2:
			case KOOGPFAPGGD.ItemMagichat:
			case KOOGPFAPGGD.ItemSpecialBomb:
			case KOOGPFAPGGD.ItemSpecialCreate:
			case KOOGPFAPGGD.ItemSpecialDiscoExplode:
			case KOOGPFAPGGD.ItemSpecialDiscoRay:
			case KOOGPFAPGGD.ItemSpecialRocket:
			case KOOGPFAPGGD.ItemWaterMelon1:
			case KOOGPFAPGGD.ItemWaterMelon2:
				return true;
			default:
				return false;
			}
		}

		public void OnEnable()
		{
			NBCPBMBOCII = false;
		}

		public void OnDisable()
		{
			NBCPBMBOCII = true;
		}

		private static void LMCELHPBDKB(AudioClip AICMMKJMNKA, AudioSource JNCFHKGILOI = null, float LAAIPKIPGJL = 1f)
		{
			if (JNCFHKGILOI == null)
			{
				IELJFBMMCCI.CurrentFxSource.PlayOneShot(AICMMKJMNKA, LAAIPKIPGJL);
			}
			else
			{
				JNCFHKGILOI.PlayOneShot(AICMMKJMNKA, LAAIPKIPGJL);
			}
		}

		public static void ForceStopAll()
		{
			IELJFBMMCCI.CurrentFxSource.clip = null;
			IELJFBMMCCI.CurrentFxSource.enabled = false;
			IELJFBMMCCI.CurrentFxSource.enabled = true;
		}

		public static void StopSong(Action JFBIIKLKNGE = null, bool LJMFPIHKIHC = false)
		{
			if (IELJFBMMCCI == null)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.AudioManager, "Audio Manager is not ready yet!");
				if (JFBIIKLKNGE != null)
				{
					JFBIIKLKNGE();
				}
				return;
			}
			if (IELJFBMMCCI.CurrentMusicSource.clip == null)
			{
				if (JFBIIKLKNGE != null)
				{
					JFBIIKLKNGE();
				}
				return;
			}
			bool isPlaying = IELJFBMMCCI.CurrentMusicSource.isPlaying;
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AudioManager, "Music is playing: {0}", isPlaying);
			if (!isPlaying)
			{
				BGJKAMKIPBO(JFBIIKLKNGE);
				return;
			}
			IELJFBMMCCI.CurrentMusicSource.DOFade(0f, (!LJMFPIHKIHC) ? 0.4f : 0.24f).OnComplete(delegate
			{
				if (IELJFBMMCCI.CurrentMusicSource.isPlaying)
				{
					IELJFBMMCCI.CurrentMusicSource.Stop();
				}
				BGJKAMKIPBO(JFBIIKLKNGE);
			});
		}

		private static void BGJKAMKIPBO(Action JFBIIKLKNGE)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AudioManager, "Music will be cleared");
			AudioClip clip = IELJFBMMCCI.CurrentMusicSource.clip;
			IELJFBMMCCI.CurrentMusicSource.clip = null;
			IELJFBMMCCI.CurrentMusicSource.enabled = false;
			Resources.UnloadAsset(clip);
			if (JFBIIKLKNGE != null)
			{
				JFBIIKLKNGE();
			}
		}

		public static void PlaySong()
		{
			PJBGFLKHMHO();
			if (!EBFCJGEFCPG)
			{
				StopSong();
				return;
			}
			switch (CaravanSceneManager.CurrentScene)
			{
			case GKBHIKONCKJ.GamePlay:
				if (OGGOMNPMDJP < 0)
				{
					OGGOMNPMDJP = 0;
				}
				BNEAFCPKGMA(HKJHHLFNAKH[OGGOMNPMDJP]);
				break;
			case GKBHIKONCKJ.Map:
				BNEAFCPKGMA(ELDIEANKPNC);
				break;
			}
		}

		public static void PlayStinger(KOOGPFAPGGD CCJCMCNPOGA, bool HFHBMPKFFLF = false)
		{
			PJBGFLKHMHO();
			if (IELJFBMMCCI == null)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.AudioManager, "Audio Manager is not ready yet!");
				return;
			}
			AudioClip PNBMCLEJMLM = CCIKCCJPMDB(CCJCMCNPOGA);
			if (IELJFBMMCCI.NBCPBMBOCII || !NAEBPOAPIFP)
			{
				return;
			}
			StopSong(delegate
			{
				IELJFBMMCCI.CurrentFxSource.PlayOneShot(PNBMCLEJMLM);
				if (HFHBMPKFFLF)
				{
					MBFHBJECDGO = new LLCJMMBBLEH(DNIHMODFKKG(PNBMCLEJMLM.length));
				}
			}, true);
		}

		private static AudioClip CCIKCCJPMDB(KOOGPFAPGGD CCJCMCNPOGA)
		{
			if (FBKCCMBKFIN.ContainsKey(CCJCMCNPOGA))
			{
				return FBKCCMBKFIN[CCJCMCNPOGA].NEMMFAPDCMC;
			}
			return null;
		}

		private static void PJBGFLKHMHO()
		{
			if (MBFHBJECDGO != null)
			{
				MBFHBJECDGO.BPPFBMCJOAH();
				MBFHBJECDGO = null;
			}
		}

		private static IEnumerator DNIHMODFKKG(float ILKPNNFCCND)
		{
			yield return new WaitForSeconds(ILKPNNFCCND);
			yield return null;
			PlaySong();
		}

		private static void BNEAFCPKGMA(string IOCMOCCFALN)
		{
			if (IELJFBMMCCI == null)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.AudioManager, "Audio Manager is not ready yet!");
			}
			else if (!IELJFBMMCCI.NBCPBMBOCII && MMJKLIMKEHG)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AudioManager, "Will play music: {0}", IOCMOCCFALN);
				StopSong(delegate
				{
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AudioManager, "Load music: {0}", IOCMOCCFALN);
					IELJFBMMCCI.CurrentMusicSource.clip = Resources.Load("Musics/" + IOCMOCCFALN) as AudioClip;
					IELJFBMMCCI.CurrentMusicSource.loop = true;
					IELJFBMMCCI.CurrentMusicSource.enabled = true;
					IELJFBMMCCI.CurrentMusicSource.volume = 1f;
					IELJFBMMCCI.CurrentMusicSource.Play();
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AudioManager, "Play music: {0}", IOCMOCCFALN);
				});
			}
		}

		public static void PlayStingerWithoutStopingSong(KOOGPFAPGGD FPMHIINPOLN)
		{
			if (IELJFBMMCCI == null)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.AudioManager, "Audio Manager is not ready yet!");
			}
			else if (NAEBPOAPIFP && !IELJFBMMCCI.NBCPBMBOCII)
			{
				LMCELHPBDKB(CCIKCCJPMDB(FPMHIINPOLN));
			}
		}

		public static void RegisterExternalAudioSource(AudioSource JKHLMLIANAI)
		{
			if (!OBMFKOCDHMG.Contains(JKHLMLIANAI))
			{
				OBMFKOCDHMG.Add(JKHLMLIANAI);
			}
		}

		public static void DeRegisterExternalAudioSource(AudioSource JKHLMLIANAI)
		{
			OBMFKOCDHMG.Remove(JKHLMLIANAI);
		}

		public static void ResetExternalAudioSources()
		{
			MuteExternalAudioSources(true);
			OBMFKOCDHMG = new List<AudioSource>();
		}

		public static void CheckAndMuteExternalAudioSources(bool CKDKMDNHHLD)
		{
			if (DHAMFGJFMKD)
			{
				MuteExternalAudioSources(CKDKMDNHHLD);
			}
		}

		public static void MuteExternalAudioSources(bool CKDKMDNHHLD)
		{
			int i = 0;
			for (int count = OBMFKOCDHMG.Count; i < count; i++)
			{
				if (OBMFKOCDHMG[i] != null)
				{
					OBMFKOCDHMG[i].mute = CKDKMDNHHLD;
				}
			}
		}

		public static void ExecuteFXChange()
		{
			if (DHAMFGJFMKD)
			{
				switch (CaravanSceneManager.CurrentScene)
				{
				case GKBHIKONCKJ.Map:
					LoadMapAudioFiles();
					break;
				case GKBHIKONCKJ.GamePlay:
					LoadGameplayAudioFiles();
					break;
				}
			}
			else
			{
				UnloadAllAudioFiles();
			}
		}

		public static void LoadMapAudioFiles()
		{
			DCEGGBKPLFG(EMHCNPAOPKB);
		}

		public static void LoadGameplayAudioFiles()
		{
			DCEGGBKPLFG(JFILGKBCHHN);
		}

		private static void DCEGGBKPLFG(HashSet<KOOGPFAPGGD> APNABIDFKGK)
		{
			FMBCMAIMEAN();
			if (!DHAMFGJFMKD)
			{
				return;
			}
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			Dictionary<KOOGPFAPGGD, HNJNHMPOGEL> dictionary = new Dictionary<KOOGPFAPGGD, HNJNHMPOGEL>();
			foreach (KeyValuePair<KOOGPFAPGGD, HNJNHMPOGEL> item in FBKCCMBKFIN)
			{
				if (APNABIDFKGK.Contains(item.Key))
				{
					AudioClip iIKCDPKOBPE = item.Value.NEMMFAPDCMC ?? Resources.Load<AudioClip>(item.Value.MJCBDBIDMGF);
					dictionary.Add(item.Key, new HNJNHMPOGEL(item.Value.MJCBDBIDMGF, iIKCDPKOBPE));
				}
				else
				{
					dictionary.Add(item.Key, new HNJNHMPOGEL(item.Value.MJCBDBIDMGF));
				}
			}
			FBKCCMBKFIN = dictionary;
			stopwatch.Stop();
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AudioManager, "Total time to load all audioclips is " + stopwatch.ElapsedMilliseconds + " miliseconds");
		}

		private static void FMBCMAIMEAN()
		{
			foreach (KOOGPFAPGGD item in LGJBHPAPMNM)
			{
				if (FBKCCMBKFIN.ContainsKey(item))
				{
					HNJNHMPOGEL hNJNHMPOGEL = FBKCCMBKFIN[item];
					if (hNJNHMPOGEL.NEMMFAPDCMC == null)
					{
						FBKCCMBKFIN[item] = new HNJNHMPOGEL(hNJNHMPOGEL.MJCBDBIDMGF, Resources.Load<AudioClip>(hNJNHMPOGEL.MJCBDBIDMGF));
					}
				}
			}
		}

		public static void UnloadAllAudioFiles()
		{
			Dictionary<KOOGPFAPGGD, HNJNHMPOGEL> dictionary = new Dictionary<KOOGPFAPGGD, HNJNHMPOGEL>();
			foreach (KeyValuePair<KOOGPFAPGGD, HNJNHMPOGEL> item in FBKCCMBKFIN)
			{
				if (LGJBHPAPMNM.Contains(item.Key))
				{
					HNJNHMPOGEL value = item.Value;
					dictionary.Add(item.Key, new HNJNHMPOGEL(value.MJCBDBIDMGF, value.NEMMFAPDCMC));
				}
				else
				{
					dictionary.Add(item.Key, new HNJNHMPOGEL(item.Value.MJCBDBIDMGF));
				}
			}
			FBKCCMBKFIN = dictionary;
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AudioManager, "All AudioClips are removed but still in memory. They will be removed at the next Resource GC.");
		}
	}
}
