using System.Collections;
using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics.Animations
{
	public class ShakeAnimation : MonoBehaviour
	{
		public enum DBOGAHDJDBC
		{
			XY = 0,
			X = 1,
			Y = 2
		}

		[HideInInspector]
		public bool IsShaking;

		private float GPKOPIPNJFF;

		private Vector3 ILKALPPMIAP;

		private float LBGBIDHJCDN;

		private float NAINHDJMFDH;

		private DBOGAHDJDBC GOOCMNFDKGH;

		private Coroutine BIBLPGFHCKC;

		private int HICMLOJMJPB;

		public void StopShake()
		{
			if (BIBLPGFHCKC != null)
			{
				StopCoroutine(BIBLPGFHCKC);
			}
			base.gameObject.transform.DOKill();
			base.gameObject.transform.localPosition = ILKALPPMIAP;
		}

		public void Shake(float FMPBJJMKCIG, float IJHGDODBFCD, float NHLJFKPLKLI, DBOGAHDJDBC AJLDJAHHGOJ = DBOGAHDJDBC.XY)
		{
			if (IsShaking)
			{
				StopShake();
			}
			ILKALPPMIAP = base.gameObject.transform.localPosition;
			GPKOPIPNJFF = Time.time + FMPBJJMKCIG;
			LBGBIDHJCDN = IJHGDODBFCD;
			NAINHDJMFDH = NHLJFKPLKLI;
			GOOCMNFDKGH = AJLDJAHHGOJ;
			IsShaking = true;
			BIBLPGFHCKC = StartCoroutine(CNPJNPMDNIB());
		}

		private IEnumerator CNPJNPMDNIB()
		{
			while (Time.time < GPKOPIPNJFF)
			{
				float x = ((GOOCMNFDKGH == DBOGAHDJDBC.Y) ? ILKALPPMIAP.x : Random.Range(ILKALPPMIAP.x - LBGBIDHJCDN, ILKALPPMIAP.x + NAINHDJMFDH));
				float y = ((GOOCMNFDKGH == DBOGAHDJDBC.X) ? ILKALPPMIAP.y : Random.Range(ILKALPPMIAP.y - LBGBIDHJCDN, ILKALPPMIAP.y + NAINHDJMFDH));
				base.gameObject.transform.localPosition = new Vector2(x, y);
				yield return null;
			}
			base.gameObject.transform.DOLocalMove(ILKALPPMIAP, 0.1f).SetEase(Ease.OutBack).OnComplete(delegate
			{
				IsShaking = false;
			});
		}
	}
}
