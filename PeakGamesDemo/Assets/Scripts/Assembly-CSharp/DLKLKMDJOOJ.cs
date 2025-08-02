using System.Collections.Generic;
using Caravan.Meta.LevelMeta;
using UnityEngine;

public class DLKLKMDJOOJ
{
	public bool KAMLOHKHBNK { get; private set; }

	public int LJNDDJECANK { get; private set; }

	public int BHIJCAOHDCM { get; private set; }

	public IEKBFJBLGFM AKDMMEEHGHB { get; private set; }

	public LEDBLDKJBAI BPLHOCDDLCG { get; private set; }

	public string AOMJLDBPDKP { get; private set; }

	public Vector2 GOPMNHCIIMN { get; private set; }

	public float GEBNMKAGJIG { get; private set; }

	public DLKLKMDJOOJ(List<MapFieldEntry> GKCPHEMMHNA = null)
	{
		GEBNMKAGJIG = 1f;
		if (GKCPHEMMHNA == null || GKCPHEMMHNA.Count <= 0)
		{
			return;
		}
		BPLHOCDDLCG = LEDBLDKJBAI.None;
		AKDMMEEHGHB = IEKBFJBLGFM.None;
		int count = GKCPHEMMHNA.Count;
		for (int i = 0; i < count; i++)
		{
			MapFieldEntry mapFieldEntry = GKCPHEMMHNA[i];
			string text = mapFieldEntry.key.ToLower();
			string value = mapFieldEntry.value;
			if (text.Equals("frame") && mapFieldEntry.value.Equals("1"))
			{
				KAMLOHKHBNK = true;
			}
			else if (text.Equals("capacity"))
			{
				LJNDDJECANK = int.Parse(mapFieldEntry.value);
			}
			else if (text.Equals("order"))
			{
				BHIJCAOHDCM = int.Parse(mapFieldEntry.value);
			}
			else if (text.Equals("direction"))
			{
				AKDMMEEHGHB = (IEKBFJBLGFM)int.Parse(mapFieldEntry.value);
			}
			else if (text.Equals("matchtype"))
			{
				BPLHOCDDLCG = (LEDBLDKJBAI)int.Parse(mapFieldEntry.value);
			}
			else if (text.Equals("wall"))
			{
				AOMJLDBPDKP = mapFieldEntry.value;
			}
			else if (text.Equals("offset"))
			{
				string[] array = value.Split(':');
				if (array != null && array.Length == 2)
				{
					float result = 0f;
					float result2 = 0f;
					float.TryParse(array[0], out result);
					float.TryParse(array[1], out result2);
					GOPMNHCIIMN = new Vector2(result, result2);
				}
			}
			else if (text.Equals("scale") && !string.IsNullOrEmpty(value))
			{
				float result3 = 1f;
				float.TryParse(value, out result3);
				GEBNMKAGJIG = result3;
			}
		}
	}
}
