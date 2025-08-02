using Assets.Scripts.SceneTransitions;
using UnityEngine;

namespace NewMapScene
{
	public class MapPageSizer : MonoBehaviour
	{
		public delegate void DGACDBKJCNM(float MOFHAKELNPN);

		public Transform[] Containers;

		public CameraSizer CurrentCameraSizer;

		[HideInInspector]
		public float CurrentWidth;

		[HideInInspector]
		public float CenterPanelHeight;

		[HideInInspector]
		public float BottomPanelHeight;

		[HideInInspector]
		public float TopPanelHeight;

		[HideInInspector]
		public float CenterPanelExtend;

		private const float MFKBAMOCAMP = 0f;

		private const float HMDJNAMMNGE = 14.35f;

		public event DGACDBKJCNM PBNPBHCHODE;

		public void Start()
		{
			if (CurrentCameraSizer == null)
			{
				return;
			}
			float heightOfTopPanel = CurrentCameraSizer.HeightOfTopPanel;
			float heightOfBottomPanel = CurrentCameraSizer.HeightOfBottomPanel;
			heightOfTopPanel += ONCMBJKLKIL.GNGIGAPBFCN.ECLBGPBLGMD;
			heightOfBottomPanel += ONCMBJKLKIL.GNGIGAPBFCN.HINDAIPFFJL;
			float num = ONCMBJKLKIL.EMFKAPJMDCC / CurrentCameraSizer.DesiredWidth;
			float num2 = ONCMBJKLKIL.FHAMOHDEGMK - (heightOfTopPanel + heightOfBottomPanel) * num;
			float num3 = ((!(num2 >= 14.35f)) ? (num2 / 14.35f) : 1f);
			Vector3 localPosition = new Vector3(0f, ONCMBJKLKIL.FHAMOHDEGMK * 0.5f - heightOfTopPanel * num, 0f);
			CurrentWidth = ONCMBJKLKIL.EMFKAPJMDCC / num3;
			CenterPanelHeight = num2;
			CenterPanelExtend = num2 - 14.35f;
			BottomPanelHeight = heightOfBottomPanel * num;
			TopPanelHeight = heightOfTopPanel * num;
			int num4 = Containers.Length;
			if (num4 > 0)
			{
				for (int i = 0; i < num4; i++)
				{
					Transform transform = Containers[i];
					if (!(transform == null))
					{
						transform.transform.localScale = Vector3.one * num3;
						transform.transform.localPosition = localPosition;
					}
				}
			}
			if (this.PBNPBHCHODE != null)
			{
				this.PBNPBHCHODE(CurrentWidth);
			}
		}

		private void OnDestroy()
		{
			this.PBNPBHCHODE = null;
		}
	}
}
