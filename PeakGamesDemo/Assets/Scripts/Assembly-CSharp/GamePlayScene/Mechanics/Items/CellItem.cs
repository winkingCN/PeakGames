using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public abstract class CellItem : Item
	{
		[HideInInspector]
		public bool IsRecyclable;

		private Item DLGCLNKHLLM;

		private bool KKJKEMCNFGD;

		public override Cell ENCFFNKONOO
		{
			get
			{
				return IDIOLIHBJBE;
			}
			set
			{
				IDIOLIHBJBE = value;
			}
		}

		public bool NCFJOBEMANH
		{
			get
			{
				return KKJKEMCNFGD;
			}
		}

		public override void OnItemCreated(KFCEILFGADG MGOFDOMDLCO)
		{
			base.OnItemCreated(MGOFDOMDLCO);
			if (ENCFFNKONOO != null && ENCFFNKONOO.EAILOFHFNJO)
			{
				ENCFFNKONOO.LBFCDKPCDPB.OnCellItemCreated();
			}
		}

		public override int GetFireworksPriority()
		{
			int num = -1;
			if (ENCFFNKONOO.EAILOFHFNJO)
			{
				num = ENCFFNKONOO.LBFCDKPCDPB.GetFireworksPriority();
			}
			return (JLHIKIHDEIE > 0) ? num : 0;
		}

		public override int SelectedByFireworks()
		{
			DLGCLNKHLLM = this;
			if (JLHIKIHDEIE == 0)
			{
				return base.SelectedByFireworks();
			}
			int result = -1;
			if (ENCFFNKONOO.EAILOFHFNJO)
			{
				DLGCLNKHLLM = ENCFFNKONOO.LBFCDKPCDPB;
				result = ENCFFNKONOO.LBFCDKPCDPB.SelectedByFireworks();
			}
			return result;
		}

		public override Item GetMasterTarget()
		{
			return DLGCLNKHLLM;
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (KKJKEMCNFGD)
			{
				return true;
			}
			KKJKEMCNFGD = true;
			LAGEBFBEINC(CCPAJBOJDMN);
			if (ENCFFNKONOO.EAILOFHFNJO)
			{
				ENCFFNKONOO.LBFCDKPCDPB.AddToExploders(NGKLFNCDIJM);
			}
			return false;
		}

		protected virtual void PFMCDDPFKGO()
		{
			ELFBOKDHKGG = null;
			if (ENCFFNKONOO != null)
			{
				ENCFFNKONOO.RemoveCellItem();
				ENCFFNKONOO = null;
			}
			NGKLFNCDIJM.Clear();
			KKJKEMCNFGD = false;
			DLGCLNKHLLM = null;
			JLHIKIHDEIE = 0;
			base.transform.SetParent(null);
		}

		public void DoRecycle()
		{
			if (IsRecyclable)
			{
				PFMCDDPFKGO();
				base.gameObject.MEJPNNFDEBD();
			}
			else
			{
				Object.Destroy(base.gameObject);
			}
		}
	}
}
