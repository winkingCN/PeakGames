using System;
using System.Collections.Generic;

namespace Assets.Scripts.PeakAB.Pocos
{
	[Serializable]
	public class Result
	{
		public string abtest_id;

		public string abtest_name;

		public object screens;

		public object triggers;

		public List<Condition> conditions;

		public List<string> test_types;

		public Variant variant;

		public int ExecutionLevel;

		public bool OKLNLIMIKBP()
		{
			if (conditions == null)
			{
				return true;
			}
			for (int i = 0; i < conditions.Count; i++)
			{
				if (!PLIFFMMBNPM(conditions[i]).IONCPAHMPIL())
				{
					return false;
				}
			}
			return true;
		}

		private JIDJCBGKJPF PLIFFMMBNPM(Condition CFGGBONGJNP)
		{
			string condition_name = CFGGBONGJNP.condition_name;
			string condition_value = CFGGBONGJNP.condition_value;
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AbTesting, "PeakABParser > Evaluating condition:{0} with value:{1}", condition_name, condition_value);
			switch (condition_name)
			{
			case "level":
				return new DNJJPNFMPOP(condition_value);
			case "version":
				return new EIOOPOOHIGN(condition_value);
			case "facebook_connect":
				return new GJGBPCIOLGN(condition_value);
			case "platform":
				return new NIPHONJBBJL(condition_value);
			case "process_at_level":
			{
				BFBIHDKDMHG bFBIHDKDMHG = new BFBIHDKDMHG(condition_value);
				ExecutionLevel = bFBIHDKDMHG.NMJKMELLOLE();
				return bFBIHDKDMHG;
			}
			case "in_ab":
				return new LDLAGAOEPKK(condition_value);
			case "not_in_ab":
				return new NLCPIACAMHH(condition_value);
			default:
				return new KJPKOCFGOOC();
			}
		}
	}
}
