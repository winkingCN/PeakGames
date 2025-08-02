using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;

namespace GamePlayScene.Mechanics.Items
{
	public abstract class GeneratorBasedItem : Item
	{
		public NOALGNJECAD GenerateItemType;

		protected int DNEBHKPJOJJ = 1;

		protected int BOCFHAEPEIA = 1;

		protected int MLJEJFFFBOJ;

		private readonly List<Cell> FHOGJGODDMO = new List<Cell>();

		private bool LBKPPKEADMM;

		private static int BMLABDEBFII;

		public override int JLHIKIHDEIE
		{
			get
			{
				return BMLABDEBFII;
			}
			set
			{
				BMLABDEBFII = value;
			}
		}

		public abstract void Sleep();

		public abstract void ForceSleep();

		public abstract Cell GetRandomCell();

		public abstract void PlayThrowAnimation(List<Cell> FNHOIPIKEMJ);

		protected void PACACNHKKHA()
		{
			StartCoroutine(DGDPGDFALDL());
		}

		private IEnumerator DGDPGDFALDL()
		{
			if (LBKPPKEADMM)
			{
				yield break;
			}
			yield return null;
			int num = ELFBOKDHKGG.GEHOAFJDMPE(GenerateItemType);
			int num2 = Math.Min(num, DNEBHKPJOJJ);
			FallManager.IncreaseWaitingFallBlocker();
			if (num2 <= 0)
			{
				LBKPPKEADMM = true;
				FallManager.DecreaseWaitingFallBlocker();
				yield break;
			}
			if (num <= 1)
			{
				MJPAKGMNFAC.GABGKBAKHDP.EPOFJEDKNPF(GenerateItemType);
			}
			bool flag = false;
			MLJEJFFFBOJ++;
			if (MLJEJFFFBOJ % BOCFHAEPEIA == 0)
			{
				MLJEJFFFBOJ = 0;
				FHOGJGODDMO.Clear();
				for (int i = 0; i < num2; i++)
				{
					Cell randomCell = GetRandomCell();
					if (randomCell == null)
					{
						break;
					}
					FHOGJGODDMO.Add(randomCell);
					ELFBOKDHKGG.GKKIFODLNDE(GenerateItemType);
					randomCell.ReserveForItem(GenerateItemType);
					flag = true;
				}
			}
			if (flag)
			{
				PlayThrowAnimation(FHOGJGODDMO);
			}
			FallManager.DecreaseWaitingFallBlocker();
			yield return null;
		}

		protected virtual void LNGOKFALMCD(Cell FIICENBDLDC)
		{
			if (FIICENBDLDC != null)
			{
				FIICENBDLDC.ApplyReservedItem();
			}
			ELFBOKDHKGG.DJNEAFJLFIH(GenerateItemType);
		}

		public override int GetLayerCount()
		{
			return ELFBOKDHKGG.GEHOAFJDMPE(GenerateItemType);
		}
	}
}
