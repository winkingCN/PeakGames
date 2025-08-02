using System.Collections.Generic;

namespace Assets.Scripts.Dialogs
{
	public class BoosterSelectDialog : SimpleDialog
	{
		public static List<NOALGNJECAD> LatestSelectedItems;

		public PrelevelDialogBooster[] Boosters;

		protected readonly NAAHKHPBAPA[] FOHMHKLNLEG = new NAAHKHPBAPA[3]
		{
			NAAHKHPBAPA.Rocket,
			NAAHKHPBAPA.Bomb,
			NAAHKHPBAPA.DiscoBall
		};

		public void UpdateBoosterCounts()
		{
			for (int i = 0; i < FOHMHKLNLEG.Length; i++)
			{
				Boosters[i].UpdateBoosterCounts();
			}
		}

		protected List<NOALGNJECAD> KACBDDJNKHC()
		{
			List<NOALGNJECAD> list = new List<NOALGNJECAD>(5);
			int i = 0;
			for (int num = Boosters.Length; i < num; i++)
			{
				PrelevelDialogBooster prelevelDialogBooster = Boosters[i];
				if (prelevelDialogBooster.EMHPOLAIJOK)
				{
					switch (prelevelDialogBooster.ENBPGGCIADN)
					{
					case NAAHKHPBAPA.Rocket:
						GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.PreLevelDialog, "Rocket added as prelevel item.");
						list.Add(NOALGNJECAD.Rocket);
						break;
					case NAAHKHPBAPA.Bomb:
						GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.PreLevelDialog, "Bomb added as prelevel item.");
						list.Add(NOALGNJECAD.Bomb);
						break;
					case NAAHKHPBAPA.DiscoBall:
						GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.PreLevelDialog, "Discoball added as prelevel item.");
						list.Add(NOALGNJECAD.DiscoBall);
						break;
					}
				}
			}
			return list;
		}

		public override bool ShouldBeClosedOnSceneChange()
		{
			return false;
		}
	}
}
