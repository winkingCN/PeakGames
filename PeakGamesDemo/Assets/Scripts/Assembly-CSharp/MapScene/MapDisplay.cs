using UnityEngine;

namespace MapScene
{
	public class MapDisplay : MonoBehaviour
	{
		public MapDisplayController MapDisplayController;

		public MapDisplayButton MapDisplayButton;

		public NAOEEJLHFDL MapSide;

		public float HeightOffset;

		private Transform AMOCGEEMMAE;

		private float ADEGBCPKIJE;

		private void OnEnable()
		{
			MapDisplayController.OnMapDisplaysChange();
		}

		private void OnDisable()
		{
			MapDisplayController.OnMapDisplaysChange();
		}

		public void OnMapDisplayUpdated(int CKKJMJHIJBN, float FMLGFJFCJKB)
		{
			DHFEDHFMNBM(CKKJMJHIJBN, FMLGFJFCJKB);
			JANAJHPFMGB();
		}

		private void DHFEDHFMNBM(int CMAJLIAELDP, float FMLGFJFCJKB)
		{
			float scale = MapDisplayController.GetScale();
			Vector3 vector = new Vector3(MapDisplayController.GetPositionX(MapSide), MapDisplayController.GetPositionY(), -2f);
			vector.y -= ((float)CMAJLIAELDP * 2.452f + FMLGFJFCJKB) * scale;
			base.transform.localPosition = new Vector3(vector.x, vector.y, base.transform.localPosition.z);
			MapDisplayButton.SetLocalScale(scale);
			base.transform.localScale = Vector3.one * scale;
		}

		public void SetTutorialMembers(Transform GHCKBHAAHGI, float EAJMOIEEGAP)
		{
			AMOCGEEMMAE = GHCKBHAAHGI;
			ADEGBCPKIJE = EAJMOIEEGAP;
		}

		private void JANAJHPFMGB()
		{
			if (!(AMOCGEEMMAE == null))
			{
				Vector3 position = base.transform.position;
				position.x += 0.072f;
				position.y -= ADEGBCPKIJE;
				AMOCGEEMMAE.position = position;
			}
		}
	}
}
