using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene.Mechanics;
using DG.Tweening;
using GamePlayScene.Mechanics.Items;
using UnityEngine;

namespace GamePlayScene.Mechanics.Animations
{
	public class IvySpreadAnimation : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class EHIKPOEKLNA
		{
			internal Cell FIICENBDLDC;

			internal IvySpreadAnimation PDAPIGLEPGC;

			internal void AGFNGEFDHLA()
			{
				FIICENBDLDC.AddCellItemToCurrentLevel(NOALGNJECAD.Ivy);
				IvyItem ivyItem = FIICENBDLDC.FEMFMBLMKHP as IvyItem;
				if (ivyItem != null)
				{
					ivyItem.GMFMOBCBDAE = PDAPIGLEPGC;
				}
			}

			internal void KDACLOKGNAM()
			{
				FIICENBDLDC.FEMFMBLMKHP.OnCellGridChange(FIICENBDLDC.CurrentGrid);
				IvyItem ivyItem = FIICENBDLDC.FEMFMBLMKHP as IvyItem;
				if (ivyItem != null)
				{
					ivyItem.GMFMOBCBDAE = null;
				}
				PDAPIGLEPGC.TryRecycle();
			}
		}

		public Animator CurrentAnimator;

		public GameObject Animation;

		public SpriteRenderer[] SpriteRenderers;

		private int JHIABECKOLP;

		private bool IMIPCKEONOE;

		private Sequence DCFOELCGIDP;

		private const int DDAMBJHDPOG = 13;

		private static readonly List<Dictionary<IEKBFJBLGFM, int>> KJJHHCBHLCA = new List<Dictionary<IEKBFJBLGFM, int>>
		{
			new Dictionary<IEKBFJBLGFM, int>
			{
				{
					IEKBFJBLGFM.Up,
					Animator.StringToHash("Base Layer.IvySpreadUpAnimation1")
				},
				{
					IEKBFJBLGFM.Right,
					Animator.StringToHash("Base Layer.IvySpreadRightAnimation1")
				},
				{
					IEKBFJBLGFM.Down,
					Animator.StringToHash("Base Layer.IvySpreadDownAnimation1")
				},
				{
					IEKBFJBLGFM.Left,
					Animator.StringToHash("Base Layer.IvySpreadLeftAnimation1")
				},
				{
					IEKBFJBLGFM.RightUp,
					Animator.StringToHash("Base Layer.IvySpreadRightUpAnimation1")
				},
				{
					IEKBFJBLGFM.RightDown,
					Animator.StringToHash("Base Layer.IvySpreadRightDownAnimation1")
				},
				{
					IEKBFJBLGFM.LeftDown,
					Animator.StringToHash("Base Layer.IvySpreadLeftDownAnimation1")
				},
				{
					IEKBFJBLGFM.LeftUp,
					Animator.StringToHash("Base Layer.IvySpreadLeftUpAnimation1")
				},
				{
					IEKBFJBLGFM.None,
					Animator.StringToHash("Base Layer.IvySpreadCenterAnimation1")
				}
			},
			new Dictionary<IEKBFJBLGFM, int>
			{
				{
					IEKBFJBLGFM.Up,
					Animator.StringToHash("Base Layer.IvySpreadUpAnimation2")
				},
				{
					IEKBFJBLGFM.Right,
					Animator.StringToHash("Base Layer.IvySpreadRightAnimation2")
				},
				{
					IEKBFJBLGFM.Down,
					Animator.StringToHash("Base Layer.IvySpreadDownAnimation2")
				},
				{
					IEKBFJBLGFM.Left,
					Animator.StringToHash("Base Layer.IvySpreadLeftAnimation2")
				},
				{
					IEKBFJBLGFM.RightUp,
					Animator.StringToHash("Base Layer.IvySpreadRightUpAnimation2")
				},
				{
					IEKBFJBLGFM.RightDown,
					Animator.StringToHash("Base Layer.IvySpreadRightDownAnimation2")
				},
				{
					IEKBFJBLGFM.LeftDown,
					Animator.StringToHash("Base Layer.IvySpreadLeftDownAnimation2")
				},
				{
					IEKBFJBLGFM.LeftUp,
					Animator.StringToHash("Base Layer.IvySpreadLeftUpAnimation2")
				},
				{
					IEKBFJBLGFM.None,
					Animator.StringToHash("Base Layer.IvySpreadCenterAnimation2")
				}
			}
		};

		public void Prepare(Cell JHCKBLCPDPP, Cell FIICENBDLDC, int PODJBFDIHJO, bool JFDHDIIDCMO)
		{
			IMIPCKEONOE = true;
			CurrentAnimator.speed = 0.8f;
			SpriteRenderers[0].enabled = JFDHDIIDCMO;
			JHIABECKOLP = PODJBFDIHJO;
			CKKKELDIOLD iBBBMACIBGK = IPPOGIEPKEN.Items.EFLCPKAFOBA();
			iBBBMACIBGK.BHIJCAOHDCM = IvyItem.GetIvyCellSortingOrder(FIICENBDLDC.X, FIICENBDLDC.Y);
			MDOPHHOAAEF(iBBBMACIBGK);
			IEKBFJBLGFM directionTo = FIICENBDLDC.GetDirectionTo(JHCKBLCPDPP);
			CurrentAnimator.Play(KJJHHCBHLCA[PODJBFDIHJO][directionTo], 0, 0f);
			DCFOELCGIDP = DOTween.Sequence();
			DCFOELCGIDP.InsertCallback(0.35f, delegate
			{
				FIICENBDLDC.AddCellItemToCurrentLevel(NOALGNJECAD.Ivy);
				IvyItem ivyItem2 = FIICENBDLDC.FEMFMBLMKHP as IvyItem;
				if (ivyItem2 != null)
				{
					ivyItem2.GMFMOBCBDAE = this;
				}
			});
			DCFOELCGIDP.InsertCallback(1.22f, delegate
			{
				FIICENBDLDC.FEMFMBLMKHP.OnCellGridChange(FIICENBDLDC.CurrentGrid);
				IvyItem ivyItem = FIICENBDLDC.FEMFMBLMKHP as IvyItem;
				if (ivyItem != null)
				{
					ivyItem.GMFMOBCBDAE = null;
				}
				TryRecycle();
			});
		}

		private void MDOPHHOAAEF(CKKKELDIOLD IBBBMACIBGK)
		{
			int i = 0;
			for (int num = SpriteRenderers.Length; i < num; i++)
			{
				SpriteRenderer spriteRenderer = SpriteRenderers[i];
				if (spriteRenderer != null)
				{
					int num2 = ((JHIABECKOLP != 0) ? 13 : 0);
					spriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + i + num2;
					spriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
				}
			}
		}

		public void TryRecycle()
		{
			if (IMIPCKEONOE)
			{
				MEJPNNFDEBD();
			}
		}

		private void MEJPNNFDEBD()
		{
			IMIPCKEONOE = false;
			DCFOELCGIDP.Kill();
			SpriteRenderers[0].enabled = false;
			Animation.transform.localPosition = Vector3.zero;
			base.gameObject.MEJPNNFDEBD();
		}
	}
}
