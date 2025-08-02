using System;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	public class TMP_PhoneNumberValidator : TMP_InputValidator
	{
		public override char PIBLOPJEGEL(ref string FCJBBPHFNPJ, ref int FADJPCHMMBH, char GKDKBFOPOJG)
		{
			Debug.Log("Trying to validate...");
			if (GKDKBFOPOJG < '0' && GKDKBFOPOJG > '9')
			{
				return '\0';
			}
			int length = FCJBBPHFNPJ.Length;
			for (int i = 0; i < length + 1; i++)
			{
				switch (i)
				{
				case 0:
					if (i == length)
					{
						FCJBBPHFNPJ = "(" + GKDKBFOPOJG;
					}
					FADJPCHMMBH = 2;
					break;
				case 1:
					if (i == length)
					{
						FCJBBPHFNPJ += GKDKBFOPOJG;
					}
					FADJPCHMMBH = 2;
					break;
				case 2:
					if (i == length)
					{
						FCJBBPHFNPJ += GKDKBFOPOJG;
					}
					FADJPCHMMBH = 3;
					break;
				case 3:
					if (i == length)
					{
						FCJBBPHFNPJ = FCJBBPHFNPJ + GKDKBFOPOJG + ") ";
					}
					FADJPCHMMBH = 6;
					break;
				case 4:
					if (i == length)
					{
						FCJBBPHFNPJ = FCJBBPHFNPJ + ") " + GKDKBFOPOJG;
					}
					FADJPCHMMBH = 7;
					break;
				case 5:
					if (i == length)
					{
						FCJBBPHFNPJ = FCJBBPHFNPJ + " " + GKDKBFOPOJG;
					}
					FADJPCHMMBH = 7;
					break;
				case 6:
					if (i == length)
					{
						FCJBBPHFNPJ += GKDKBFOPOJG;
					}
					FADJPCHMMBH = 7;
					break;
				case 7:
					if (i == length)
					{
						FCJBBPHFNPJ += GKDKBFOPOJG;
					}
					FADJPCHMMBH = 8;
					break;
				case 8:
					if (i == length)
					{
						FCJBBPHFNPJ = FCJBBPHFNPJ + GKDKBFOPOJG + "-";
					}
					FADJPCHMMBH = 10;
					break;
				case 9:
					if (i == length)
					{
						FCJBBPHFNPJ = FCJBBPHFNPJ + "-" + GKDKBFOPOJG;
					}
					FADJPCHMMBH = 11;
					break;
				case 10:
					if (i == length)
					{
						FCJBBPHFNPJ += GKDKBFOPOJG;
					}
					FADJPCHMMBH = 11;
					break;
				case 11:
					if (i == length)
					{
						FCJBBPHFNPJ += GKDKBFOPOJG;
					}
					FADJPCHMMBH = 12;
					break;
				case 12:
					if (i == length)
					{
						FCJBBPHFNPJ += GKDKBFOPOJG;
					}
					FADJPCHMMBH = 13;
					break;
				case 13:
					if (i == length)
					{
						FCJBBPHFNPJ += GKDKBFOPOJG;
					}
					FADJPCHMMBH = 14;
					break;
				}
			}
			return GKDKBFOPOJG;
		}
	}
}
