using System;
using System.Collections.Generic;
using UnityEngine;

namespace I2.Loc
{
	public class LocalizationParamsManager : MonoBehaviour, JMFAIACBIGP
	{
		[Serializable]
		public struct ParamValue
		{
			public string Name;

			public string Value;
		}

		[SerializeField]
		public List<ParamValue> _Params = new List<ParamValue>();

		public bool _AutoRegister;

		public string GetParameterValue(string GFIIAOBDDPB)
		{
			if (_Params != null)
			{
				int i = 0;
				for (int count = _Params.Count; i < count; i++)
				{
					if (_Params[i].Name == GFIIAOBDDPB)
					{
						return _Params[i].Value;
					}
				}
			}
			return null;
		}

		public void SetParameterValue(string GFIIAOBDDPB, string GFMBLOKELFA, bool EICBKCAGIGD = true)
		{
			bool flag = false;
			int i = 0;
			for (int count = _Params.Count; i < count; i++)
			{
				if (_Params[i].Name == GFIIAOBDDPB)
				{
					ParamValue value = _Params[i];
					value.Value = GFMBLOKELFA;
					_Params[i] = value;
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				_Params.Add(new ParamValue
				{
					Name = GFIIAOBDDPB,
					Value = GFMBLOKELFA
				});
			}
			if (EICBKCAGIGD)
			{
				OnLocalize();
			}
		}

		public void OnLocalize()
		{
			Localize component = GetComponent<Localize>();
			if (component != null)
			{
				component.OnLocalize(true);
			}
		}

		public virtual void OnEnable()
		{
			if (_AutoRegister)
			{
				DoAutoRegister();
			}
		}

		[KGHIPLIMGAG]
		public void AutoStart()
		{
			if (_AutoRegister)
			{
				DoAutoRegister();
			}
		}

		public void DoAutoRegister()
		{
			if (!PNAJOCHGJFO.OAANICEABPL.Contains(this))
			{
				PNAJOCHGJFO.OAANICEABPL.Add(this);
				PNAJOCHGJFO.EBEBNPMKGEO(true);
			}
		}

		public void OnDisable()
		{
			PNAJOCHGJFO.OAANICEABPL.Remove(this);
		}
	}
}
