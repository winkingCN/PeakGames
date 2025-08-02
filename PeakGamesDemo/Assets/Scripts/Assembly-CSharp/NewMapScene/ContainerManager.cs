using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace NewMapScene
{
	public class ContainerManager : MonoBehaviour
	{
		public delegate void FCPNDKIJDKN(EBMDNGEJJBO NKKBNNINLDI);

		public float PageTransitionDuration;

		public float MenuTransitionDuration;

		public Transform Shop;

		public Transform Inbox;

		public Transform Map;

		public Transform Social;

		public Transform Leaderboard;

		public Transform Container;

		public Transform ShopButton;

		public Transform ShopButtonSeperator;

		public Transform InboxButton;

		public Transform InboxButtonSeperator;

		public Transform MapButton;

		public Transform MapButtonSeperator;

		public Transform SocialButton;

		public Transform SocialButtonSeperator;

		public Transform LeaderboardButton;

		public Transform Highlight;

		public Transform BottomPanel;

		public BoxCollider2D ShopButtonCollider;

		public BoxCollider2D InboxButtonCollider;

		public BoxCollider2D MapButtonCollider;

		public BoxCollider2D SocialButtonCollider;

		public BoxCollider2D LeaderboardButtonCollider;

		public GameObject PassiveShop;

		public GameObject PassiveInbox;

		public GameObject PassiveMap;

		public GameObject PassiveSocial;

		public GameObject PassiveLeaderboard;

		public GameObject ActiveShop;

		public GameObject ActiveInbox;

		public GameObject ActiveMap;

		public GameObject ActiveSocial;

		public GameObject ActiveLeaderboard;

		public Transform ActiveShopIcon;

		public Transform ActiveInboxIcon;

		public Transform ActiveSocialIcon;

		public Transform ActiveMapIcon;

		public Transform ActiveLeaderboardIcon;

		public SpriteRenderer[] ShadowsRight;

		public SpriteRenderer[] ShadowsLeft;

		public GameObject BottomPanelBlocker;

		public SpriteRenderer SocialButtonPinkBorder1;

		public SpriteRenderer SocialButtonPinkBorder2;

		private int ANLFBMILANK;

		private int FIFHFGEHLLA;

		private Sequence PLFJIGGEHFE;

		private float FJEFBFJJHJD;

		private int AHFGEBIKGBB = -1;

		private int ELMGDHINOEB;

		public int EELLFKJKKAN
		{
			get
			{
				return ANLFBMILANK;
			}
		}

		public EBMDNGEJJBO HCICOAGHMKJ
		{
			get
			{
				return HGLDDHHAMKE(AHFGEBIKGBB);
			}
		}

		public event FCPNDKIJDKN HJOKHPIGEAM;

		public event FCPNDKIJDKN IKHJGHKNFJM;

		public void Start()
		{
			float y = 0f;
			float y2 = 1f;
			bool flag = false;
			float y3 = 0f;
			float y4 = 0f;
			if (ONCMBJKLKIL.GNGIGAPBFCN.HINDAIPFFJL > 0f)
			{
				float hINDAIPFFJL = ONCMBJKLKIL.GNGIGAPBFCN.HINDAIPFFJL;
				float num = 1.62f;
				float num2 = (num + hINDAIPFFJL) / num;
				y2 = num2;
				y = (0f - (num * num2 - num)) * 0.5f;
				float num3 = 1.69f;
				y4 = (num3 + hINDAIPFFJL * 0.5746f) / num3;
				y3 = (0f - hINDAIPFFJL) * 0.68f;
				flag = true;
			}
			if (flag)
			{
				Vector3 localPosition = ShopButtonSeperator.transform.localPosition;
				localPosition.y = y3;
				ShopButtonSeperator.transform.localPosition = localPosition;
				localPosition = InboxButtonSeperator.transform.localPosition;
				localPosition.y = y3;
				InboxButtonSeperator.transform.localPosition = localPosition;
				localPosition = MapButtonSeperator.transform.localPosition;
				localPosition.y = y3;
				MapButtonSeperator.transform.localPosition = localPosition;
				localPosition = SocialButtonSeperator.transform.localPosition;
				localPosition.y = y3;
				SocialButtonSeperator.transform.localPosition = localPosition;
				Vector3 localScale = new Vector3(1f, y4, 1f);
				ShopButtonSeperator.transform.localScale = localScale;
				InboxButtonSeperator.transform.localScale = localScale;
				MapButtonSeperator.transform.localScale = localScale;
				SocialButtonSeperator.transform.localScale = localScale;
			}
			FJEFBFJJHJD = BottomPanel.localScale.x;
			float num4 = ONCMBJKLKIL.EMFKAPJMDCC / FJEFBFJJHJD;
			Highlight.localScale = new Vector3(100f * num4 / 6f, y2, 1f);
			Highlight.transform.localPosition = new Vector3(0f, y, 0f);
			float eMFKAPJMDCC = ONCMBJKLKIL.EMFKAPJMDCC;
			float num5 = 0.23f;
			Shop.localPosition = new Vector3(-2f * eMFKAPJMDCC - 2f * num5, 0f, 0f);
			Inbox.localPosition = new Vector3(-1f * eMFKAPJMDCC - num5, 0f, 0f);
			Map.localPosition = new Vector3(0f, 0f, 0f);
			Social.localPosition = new Vector3(1f * eMFKAPJMDCC + num5, 0f, 0f);
			Leaderboard.localPosition = new Vector3(2f * eMFKAPJMDCC + num5 * 2f, 0f, 0f);
			for (int i = 0; i < ShadowsRight.Length; i++)
			{
				float x = eMFKAPJMDCC * 0.5f + 0.175f + (float)i * (eMFKAPJMDCC + num5);
				ShadowsRight[i].transform.localPosition = new Vector3(x, 0f, 0f);
			}
			for (int j = 0; j < ShadowsLeft.Length; j++)
			{
				float x2 = (0f - eMFKAPJMDCC) * 0.5f - 0.175f - (float)j * (eMFKAPJMDCC + num5);
				ShadowsLeft[j].transform.localPosition = new Vector3(x2, 0f, 0f);
			}
			JJAMDABPGBP();
		}

		public EBMDNGEJJBO GetActivePage()
		{
			return HGLDDHHAMKE(ANLFBMILANK);
		}

		public void OnSwipe(int AJLDJAHHGOJ)
		{
			if (AJLDJAHHGOJ < 0)
			{
				LOJMENIOKJO();
			}
			else
			{
				KEKCIIHGKNL();
			}
		}

		private void LOJMENIOKJO()
		{
			ANLFBMILANK++;
			if (ANLFBMILANK > 2)
			{
				ANLFBMILANK = 2;
			}
			JJAMDABPGBP();
		}

		private void KEKCIIHGKNL()
		{
			ANLFBMILANK--;
			if (ANLFBMILANK < -2)
			{
				ANLFBMILANK = -2;
			}
			JJAMDABPGBP();
		}

		private void JJAMDABPGBP()
		{
			if (this.HJOKHPIGEAM != null)
			{
				this.HJOKHPIGEAM(HGLDDHHAMKE(ANLFBMILANK));
			}
			float eMFKAPJMDCC = ONCMBJKLKIL.EMFKAPJMDCC;
			float num = ONCMBJKLKIL.EMFKAPJMDCC / FJEFBFJJHJD;
			float num2 = 0.23f;
			if (PLFJIGGEHFE != null && PLFJIGGEHFE.IsPlaying())
			{
				PLFJIGGEHFE.Kill();
			}
			PLFJIGGEHFE = DOTween.Sequence();
			PLFJIGGEHFE.SetEase(Ease.Linear);
			Container.DOKill(true);
			PLFJIGGEHFE.Append(Container.DOLocalMoveX((float)(-ANLFBMILANK) * (eMFKAPJMDCC + num2), PageTransitionDuration).SetEase(Ease.OutExpo));
			PassiveShop.SetActive(true);
			PassiveInbox.SetActive(true);
			PassiveMap.SetActive(true);
			PassiveSocial.SetActive(true);
			PassiveLeaderboard.SetActive(true);
			ActiveShop.SetActive(false);
			ActiveInbox.SetActive(false);
			ActiveMap.SetActive(false);
			ActiveSocial.SetActive(false);
			ActiveLeaderboard.SetActive(false);
			float[] array;
			Transform target;
			int num3;
			switch (ANLFBMILANK)
			{
			case -2:
				array = new float[9] { -2f, -1f, -0.5f, 0f, 0.5f, 1f, 1.5f, 2f, 2.5f };
				PassiveShop.SetActive(false);
				ActiveShop.SetActive(true);
				target = ActiveShopIcon;
				num3 = 0;
				break;
			case -1:
				array = new float[9] { -2.5f, -2f, -1f, 0f, 0.5f, 1f, 1.5f, 2f, 2.5f };
				PassiveInbox.SetActive(false);
				ActiveInbox.SetActive(true);
				target = ActiveInboxIcon;
				num3 = 2;
				break;
			case 1:
				array = new float[9] { -2.5f, -2f, -1.5f, -1f, -0.5f, 0f, 1f, 2f, 2.5f };
				PassiveSocial.SetActive(false);
				ActiveSocial.SetActive(true);
				target = ActiveSocialIcon;
				num3 = 6;
				break;
			case 2:
				array = new float[9] { -2.5f, -2f, -1.5f, -1f, -0.5f, 0f, 0.5f, 1f, 2f };
				PassiveLeaderboard.SetActive(false);
				ActiveLeaderboard.SetActive(true);
				target = ActiveLeaderboardIcon;
				num3 = 8;
				break;
			default:
				array = new float[9] { -2.5f, -2f, -1.5f, -1f, 0f, 1f, 1.5f, 2f, 2.5f };
				PassiveMap.SetActive(false);
				ActiveMap.SetActive(true);
				target = ActiveMapIcon;
				num3 = 4;
				break;
			}
			float num4 = num / 6f;
			for (int i = 0; i < array.Length; i++)
			{
				array[i] *= num4;
			}
			Vector3 localPosition = ShopButton.localPosition;
			localPosition.x = array[0];
			PLFJIGGEHFE.Join(ShopButton.DOLocalMove(localPosition, 0.3f));
			localPosition = ShopButtonSeperator.localPosition;
			localPosition.x = array[1];
			PLFJIGGEHFE.Join(ShopButtonSeperator.DOLocalMove(localPosition, 0.3f));
			localPosition = InboxButton.localPosition;
			localPosition.x = array[2];
			PLFJIGGEHFE.Join(InboxButton.DOLocalMove(localPosition, 0.3f));
			localPosition = InboxButtonSeperator.localPosition;
			localPosition.x = array[3];
			PLFJIGGEHFE.Join(InboxButtonSeperator.DOLocalMove(localPosition, 0.3f));
			localPosition = MapButton.localPosition;
			localPosition.x = array[4];
			PLFJIGGEHFE.Join(MapButton.DOLocalMove(localPosition, 0.3f));
			localPosition = MapButtonSeperator.localPosition;
			localPosition.x = array[5];
			PLFJIGGEHFE.Join(MapButtonSeperator.DOLocalMove(localPosition, 0.3f));
			localPosition = SocialButton.localPosition;
			localPosition.x = array[6];
			PLFJIGGEHFE.Join(SocialButton.DOLocalMove(localPosition, 0.3f));
			localPosition = SocialButtonSeperator.localPosition;
			localPosition.x = array[7];
			PLFJIGGEHFE.Join(SocialButtonSeperator.DOLocalMove(localPosition, 0.3f));
			localPosition = LeaderboardButton.localPosition;
			localPosition.x = array[8];
			PLFJIGGEHFE.Join(LeaderboardButton.DOLocalMove(localPosition, 0.3f));
			localPosition = Highlight.transform.localPosition;
			localPosition.x = array[num3];
			Highlight.DOKill();
			PLFJIGGEHFE.Join(Highlight.DOLocalMove(localPosition, PageTransitionDuration).SetEase(Ease.OutExpo));
			PLFJIGGEHFE.OnComplete(delegate
			{
				if (this.IKHJGHKNFJM != null)
				{
					this.IKHJGHKNFJM(HGLDDHHAMKE(ANLFBMILANK));
				}
				PLFJIGGEHFE = null;
			});
			if (AHFGEBIKGBB != ANLFBMILANK)
			{
				AHFGEBIKGBB = ANLFBMILANK;
				target.DOKill(true);
				target.DOPunchScale(Vector3.one * 0.5f, MenuTransitionDuration, 3);
			}
		}

		public void FocusSocial(bool GPHFFEDJIDE)
		{
			BottomPanelBlocker.SetActive(GPHFFEDJIDE);
			if (GPHFFEDJIDE && ELMGDHINOEB == 0)
			{
				ELMGDHINOEB = 300;
				GFFMFGMCOBP.KMHPJHNHCLG(SocialButton, "UI", 300, 0);
				SocialButtonPinkBorder1.enabled = false;
				SocialButtonPinkBorder2.enabled = false;
			}
			else if (!GPHFFEDJIDE && ELMGDHINOEB == 300)
			{
				ELMGDHINOEB = 0;
				GFFMFGMCOBP.KMHPJHNHCLG(SocialButton, "UI", -300, 0);
				SocialButtonPinkBorder1.enabled = true;
				SocialButtonPinkBorder2.enabled = true;
			}
			ShopButtonCollider.enabled = !GPHFFEDJIDE;
			InboxButtonCollider.enabled = !GPHFFEDJIDE;
			MapButtonCollider.enabled = !GPHFFEDJIDE;
			SocialButtonCollider.enabled = !GPHFFEDJIDE;
			LeaderboardButtonCollider.enabled = !GPHFFEDJIDE;
		}

		public EBMDNGEJJBO GetCurrentMapPage()
		{
			return HGLDDHHAMKE(ANLFBMILANK);
		}

		private EBMDNGEJJBO HGLDDHHAMKE(int BPLJLJLKFLH)
		{
			switch (BPLJLJLKFLH)
			{
			case -2:
				return EBMDNGEJJBO.Shop;
			case -1:
				return EBMDNGEJJBO.Lives;
			case 1:
				return EBMDNGEJJBO.Social;
			case 2:
				return EBMDNGEJJBO.Leaderboard;
			default:
				return EBMDNGEJJBO.Map;
			}
		}

		public void SlideToPosition(int LDMDBPLADGD)
		{
			if (LDMDBPLADGD < -2)
			{
				LDMDBPLADGD = -2;
			}
			if (LDMDBPLADGD > 2)
			{
				LDMDBPLADGD = 2;
			}
			ANLFBMILANK = LDMDBPLADGD;
			JJAMDABPGBP();
		}

		public void SlideToNext(float BFANLMJKGLB)
		{
			ANLFBMILANK += ((!(BFANLMJKGLB > 0f)) ? 1 : (-1));
			ANLFBMILANK = Math.Max(-2, Math.Min(2, ANLFBMILANK));
			JJAMDABPGBP();
		}

		public void SlideToNearest()
		{
			float eMFKAPJMDCC = ONCMBJKLKIL.EMFKAPJMDCC;
			float x = Container.transform.localPosition.x;
			float num = Math.Abs(x);
			int num2 = (int)((num + eMFKAPJMDCC * 0.5f) / eMFKAPJMDCC);
			int num3 = ((!(x > 0f)) ? 1 : (-1));
			ANLFBMILANK = num2 * num3;
			ANLFBMILANK = Math.Max(-2, Math.Min(2, ANLFBMILANK));
			JJAMDABPGBP();
		}

		public void KillTweens()
		{
			if (PLFJIGGEHFE != null)
			{
				PLFJIGGEHFE.Kill();
			}
			Container.DOKill();
		}

		[CompilerGenerated]
		private void FNCACCKNKGL()
		{
			if (this.IKHJGHKNFJM != null)
			{
				this.IKHJGHKNFJM(HGLDDHHAMKE(ANLFBMILANK));
			}
			PLFJIGGEHFE = null;
		}
	}
}
