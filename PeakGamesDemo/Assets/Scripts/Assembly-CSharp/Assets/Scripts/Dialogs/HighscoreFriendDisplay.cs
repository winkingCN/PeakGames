using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using caravan.protobuf.messages;

namespace Assets.Scripts.Dialogs
{
	public class HighscoreFriendDisplay : MonoBehaviour
	{
		private bool BIELEFAPPBF;

		private FriendScore PALNHLMDOGH;

		public SpriteRenderer BackgroundImage;

		public SpriteRenderer FacebookImage;

		public SpriteRenderer FrameImage;

		public Sprite HighlightFrame;

		public Sprite DefaultFrame;

		public GameObject LoadingIndicator;

		public TextMeshPro NameText;

		public TextMeshPro NoText;

		public TextMeshPro ScoreText;

		public Transform Seperator;

		private string JAIIKPOCLOD;

		public void Init(FriendScore ACPNOCINKHJ, int ONLEJMMJMGK)
		{
			PALNHLMDOGH = ACPNOCINKHJ;
			JAIIKPOCLOD = ACPNOCINKHJ.facebookId;
			BackgroundImage.enabled = ONLEJMMJMGK % 2 == 1;
			FacebookImage.enabled = false;
			LoadingIndicator.SetActive(true);
			LoadingIndicator.transform.DOLocalRotate(new Vector3(0f, 0f, 360f), 1f, RotateMode.LocalAxisAdd).SetLoops(1000, LoopType.Incremental).SetEase(Ease.Linear);
			NameText.FCJBBPHFNPJ = JCGLFEMHECF.GABGKBAKHDP.GJOKOCMIICE(PALNHLMDOGH.facebookId);
			ScoreText.FCJBBPHFNPJ = ACPNOCINKHJ.score.ToString();
			NoText.FCJBBPHFNPJ = ONLEJMMJMGK.ToString();
			if (ACPNOCINKHJ.facebookId == LECPGNKOABP.GABGKBAKHDP.EHNKLBBAKCA)
			{
				FrameImage.sprite = HighlightFrame;
				NameText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("You") + "!";
			}
			else
			{
				FrameImage.sprite = DefaultFrame;
			}
			if (ONCMBJKLKIL.GNGIGAPBFCN.HINDAIPFFJL > 0f)
			{
				float num = 1.44f;
				float hINDAIPFFJL = ONCMBJKLKIL.GNGIGAPBFCN.HINDAIPFFJL;
				float num2 = (num + hINDAIPFFJL * 0.815f) / num;
				Vector3 localPosition = Seperator.transform.localPosition;
				localPosition.y = 0.263f - (num * num2 - num) * 0.5f;
				Seperator.transform.localPosition = localPosition;
				Seperator.localScale = new Vector3(1f, num2, 1f);
			}
			LFJJCHNGDLJ lFJJCHNGDLJ = new LFJJCHNGDLJ();
			lFJJCHNGDLJ.IPAKPIGIJHK = delegate(Sprite DODBJCHDBFF, string LHOFEHMNEIG)
			{
				if (!BIELEFAPPBF && !(JAIIKPOCLOD != LHOFEHMNEIG))
				{
					LoadingIndicator.transform.DOKill();
					LoadingIndicator.SetActive(false);
					FacebookImage.sprite = DODBJCHDBFF;
					FacebookImage.enabled = true;
					FacebookImage.transform.localScale = Vector3.one;
				}
			};
			lFJJCHNGDLJ.MAMDEOJCFEI = delegate
			{
				FacebookImage.enabled = false;
			};
			LFJJCHNGDLJ @object = lFJJCHNGDLJ;
			PAFJEIOKMIK.GABGKBAKHDP.NNMEBAOIJAM(PALNHLMDOGH.facebookId, null, @object.KEJEHBBLDPO);
		}

		public void OnDestroy()
		{
			BIELEFAPPBF = true;
		}

		[CompilerGenerated]
		private void EJAINGFJLPL(Sprite DODBJCHDBFF, string LHOFEHMNEIG)
		{
			if (!BIELEFAPPBF && !(JAIIKPOCLOD != LHOFEHMNEIG))
			{
				LoadingIndicator.transform.DOKill();
				LoadingIndicator.SetActive(false);
				FacebookImage.sprite = DODBJCHDBFF;
				FacebookImage.enabled = true;
				FacebookImage.transform.localScale = Vector3.one;
			}
		}

		[CompilerGenerated]
		private void DIAEOMHGAAG()
		{
			FacebookImage.enabled = false;
		}
	}
}
