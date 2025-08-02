using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts.Dialogs
{
	public abstract class SimpleDialog : Dialog
	{
		private const float DAOOGNMAHNK = (float)Math.PI * 2f / 3f;

		private float LLIEHCKNJEM = 1.5f;

		private Sequence BJCJLNMDBMA;

		public BoxCollider2D[] Colliders;

		protected void JNHCICHFNHL()
		{
			if (Colliders == null)
			{
				return;
			}
			for (int i = 0; i < Colliders.Length; i++)
			{
				BoxCollider2D boxCollider2D = Colliders[i];
				if (boxCollider2D != null)
				{
					boxCollider2D.enabled = true;
				}
			}
		}

		protected void JBLHLNCOLHD()
		{
			if (Colliders == null)
			{
				return;
			}
			for (int i = 0; i < Colliders.Length; i++)
			{
				BoxCollider2D boxCollider2D = Colliders[i];
				if (boxCollider2D != null)
				{
					boxCollider2D.enabled = false;
				}
			}
		}

		protected virtual void BLELAMHLLNN()
		{
		}

		public float EaseOutElastic(float HFLODNLEGFL, float FMPBJJMKCIG, float PKHNNLFNOAI, float JNNLMAGFFJH)
		{
			float num = HFLODNLEGFL / FMPBJJMKCIG;
			return (Math.Abs(num) < 1E-06f) ? 0f : ((!(Math.Abs(num - 1f) < 1E-06f)) ? (Mathf.Pow(2f, -10f * num) * Mathf.Sin((num * 10f - 0.75f) * ((float)Math.PI * 2f / 3f)) + 1f) : 1f);
		}

		public override void PlayDialogInAnimation()
		{
			ActivateDialog(true);
			MNINPDJIIGP();
			float x = base.gameObject.transform.localScale.x;
			BJCJLNMDBMA = DOTween.Sequence();
			BJCJLNMDBMA.Append(base.gameObject.transform.DOScale(x + 0.02f, 0.08f * LLIEHCKNJEM));
			BJCJLNMDBMA.Append(base.gameObject.transform.DOScale(x - 0.01f, 0.06f * LLIEHCKNJEM));
			BJCJLNMDBMA.Append(base.gameObject.transform.DOScale(x, 0.04f * LLIEHCKNJEM));
			BJCJLNMDBMA.AppendCallback(delegate
			{
				JNHCICHFNHL();
				BLELAMHLLNN();
			});
			BJCJLNMDBMA.OnComplete(delegate
			{
				BJCJLNMDBMA = null;
			});
		}

		public override Sequence PlayDialogOutAnimation()
		{
			if (BJCJLNMDBMA != null && BJCJLNMDBMA.IsPlaying())
			{
				BJCJLNMDBMA.Kill();
			}
			JBLHLNCOLHD();
			ActivateDialog(false);
			return null;
		}

		public override void PlayDialogOutFast()
		{
			if (BJCJLNMDBMA != null && BJCJLNMDBMA.IsPlaying())
			{
				BJCJLNMDBMA.Kill();
			}
			JBLHLNCOLHD();
			ActivateDialog(false);
		}

		public override void DialogCreated()
		{
			base.NCJFEFMJKFA = Time.frameCount;
			JBLHLNCOLHD();
			MNINPDJIIGP();
		}

		public override void SetDialogBounds()
		{
			if (!(TouchBounds == null))
			{
				Vector3 vector = default(Vector3);
				vector.x = base.transform.position.x + TouchBounds.Offset.x;
				vector.y = base.transform.position.y + TouchBounds.Offset.y;
				vector.z = 0f;
				Vector3 center = vector;
				vector = default(Vector3);
				vector.x = TouchBounds.Size.x * base.transform.localScale.x;
				vector.y = TouchBounds.Size.y * base.transform.localScale.y;
				vector.z = 0f;
				Vector3 size = vector;
				OIFNJALJLMD = new Bounds(center, size);
			}
		}

		public override Bounds GetDialogBounds()
		{
			return OIFNJALJLMD;
		}

		public void ActivateDialog(bool EDDNOJDPMCF)
		{
			base.gameObject.SetActive(EDDNOJDPMCF);
		}

		private void MNINPDJIIGP()
		{
			float y = ((!ONCMBJKLKIL.PEFHCKMBHOM) ? OffsetY : IPadOffsetY);
			base.gameObject.transform.position = new Vector3(0f, y, -2f);
		}

		[CompilerGenerated]
		private void NIEFLOFJGFI()
		{
			JNHCICHFNHL();
			BLELAMHLLNN();
		}

		[CompilerGenerated]
		private void MCAEGFLAPIF()
		{
			BJCJLNMDBMA = null;
		}
	}
}
