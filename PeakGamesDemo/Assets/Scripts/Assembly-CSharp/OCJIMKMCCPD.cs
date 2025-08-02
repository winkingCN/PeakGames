using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OCJIMKMCCPD
{
	[CompilerGenerated]
	private sealed class GGCADKCAHNK : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal string LCCKDPIBKPJ;

		internal WWW HGOOIOHAIOK;

		internal Sprite OOGLCLFIPAL;

		internal string CHHHPCOIFJJ;

		internal string NBFBPNNEKMN;

		internal string GBDKKPADDFC;

		internal WWW KIAFIBBIIMN;

		internal OCJIMKMCCPD PDAPIGLEPGC;

		internal object ACLDFCNKEBA;

		internal bool LPBBDEOBEKI;

		internal int FLBKIGMFIOG;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return ACLDFCNKEBA;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return ACLDFCNKEBA;
			}
		}

		[DebuggerHidden]
		public GGCADKCAHNK()
		{
		}

		public bool MoveNext()
		{
			uint num = (uint)FLBKIGMFIOG;
			FLBKIGMFIOG = -1;
			bool flag = false;
			switch (num)
			{
			case 0u:
				HGOOIOHAIOK = new WWW(LCCKDPIBKPJ);
				num = 4294967293u;
				goto case 1u;
			case 1u:
				try
				{
					switch (num)
					{
					default:
						if (!HGOOIOHAIOK.isDone)
						{
							ACLDFCNKEBA = null;
							if (!LPBBDEOBEKI)
							{
								FLBKIGMFIOG = 1;
							}
							flag = true;
							goto end_IL_0011;
						}
						OOGLCLFIPAL = IONHCLCHCDI(HGOOIOHAIOK.bytes);
						break;
					}
					goto IL_009f;
				}
				finally
				{
					if (!flag)
					{
						FOHHLBAKLBP();
					}
				}
			case 2u:
				try
				{
					switch (num)
					{
					default:
						if (!KIAFIBBIIMN.isDone)
						{
							ACLDFCNKEBA = null;
							if (!LPBBDEOBEKI)
							{
								FLBKIGMFIOG = 2;
							}
							flag = true;
							goto end_IL_0011;
						}
						OOGLCLFIPAL = IONHCLCHCDI(KIAFIBBIIMN.bytes);
						break;
					}
					goto IL_0155;
				}
				finally
				{
					if (!flag)
					{
						GDDGNFJKMKG();
					}
				}
			default:
				{
					return false;
				}
				IL_009f:
				if (OOGLCLFIPAL == null)
				{
					PNBPNBCJFEO.MCJNJLLHIIH(CHHHPCOIFJJ);
					CHHHPCOIFJJ = HLKAEJCPMEB.OJOMNKNIAGI;
					GBDKKPADDFC = HLKAEJCPMEB.JJLECKMNALI(CHHHPCOIFJJ, NBFBPNNEKMN);
					KIAFIBBIIMN = new WWW(GBDKKPADDFC);
					num = 4294967293u;
					goto case 2u;
				}
				goto IL_0155;
				IL_0155:
				PDAPIGLEPGC.BBOBCJAHPJM = OOGLCLFIPAL;
				PDAPIGLEPGC.BBOBCJAHPJM.name = CHHHPCOIFJJ;
				PDAPIGLEPGC.DCKHOAHIFDH = true;
				FLBKIGMFIOG = -1;
				goto default;
				end_IL_0011:
				break;
			}
			return true;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			uint fLBKIGMFIOG = (uint)FLBKIGMFIOG;
			LPBBDEOBEKI = true;
			FLBKIGMFIOG = -1;
			switch (fLBKIGMFIOG)
			{
			case 1u:
				try
				{
					break;
				}
				finally
				{
					FOHHLBAKLBP();
				}
			case 2u:
				try
				{
					break;
				}
				finally
				{
					GDDGNFJKMKG();
				}
			case 0u:
				break;
			}
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		private void FOHHLBAKLBP()
		{
			if (HGOOIOHAIOK != null)
			{
				((IDisposable)HGOOIOHAIOK).Dispose();
			}
		}

		private void GDDGNFJKMKG()
		{
			if (KIAFIBBIIMN != null)
			{
				((IDisposable)KIAFIBBIIMN).Dispose();
			}
		}
	}

	public bool DCKHOAHIFDH { get; private set; }

	public Sprite BBOBCJAHPJM { get; private set; }

	private OCJIMKMCCPD()
	{
	}

	public static Sprite OGFBMKPFHLE(string CHHHPCOIFJJ)
	{
		string lCCKDPIBKPJ = HLKAEJCPMEB.POHJBJEGMFE(CHHHPCOIFJJ, "NewMapGame");
		Sprite sprite = KKLCEAHCGCK(lCCKDPIBKPJ);
		if (sprite != null)
		{
			HLKAEJCPMEB.GMOGKFBMHMK(CHHHPCOIFJJ);
			return sprite;
		}
		PNBPNBCJFEO.MCJNJLLHIIH(CHHHPCOIFJJ);
		lCCKDPIBKPJ = HLKAEJCPMEB.JJLECKMNALI(CHHHPCOIFJJ, "NewMapGame");
		return KKLCEAHCGCK(lCCKDPIBKPJ);
	}

	private static Sprite KKLCEAHCGCK(string LCCKDPIBKPJ)
	{
		byte[] bytes;
		using (WWW wWW = new WWW(LCCKDPIBKPJ))
		{
			while (!wWW.isDone)
			{
			}
			bytes = wWW.bytes;
		}
		return IONHCLCHCDI(bytes);
	}

	public static OCJIMKMCCPD CGPEONBEMMM(string CHHHPCOIFJJ, string NBFBPNNEKMN)
	{
		OCJIMKMCCPD oCJIMKMCCPD = new OCJIMKMCCPD();
		oCJIMKMCCPD.NPMHKLPJOBB(CHHHPCOIFJJ, NBFBPNNEKMN);
		return oCJIMKMCCPD;
	}

	private void NPMHKLPJOBB(string CHHHPCOIFJJ, string NBFBPNNEKMN)
	{
		string lCCKDPIBKPJ = HLKAEJCPMEB.POHJBJEGMFE(CHHHPCOIFJJ, NBFBPNNEKMN);
		new LLCJMMBBLEH(OPFAMIDHNEJ(CHHHPCOIFJJ, lCCKDPIBKPJ, NBFBPNNEKMN));
	}

	private IEnumerator OPFAMIDHNEJ(string CHHHPCOIFJJ, string LCCKDPIBKPJ, string NBFBPNNEKMN)
	{
		WWW wWW = new WWW(LCCKDPIBKPJ);
		Sprite sprite;
		try
		{
			while (!wWW.isDone)
			{
				yield return null;
			}
			sprite = IONHCLCHCDI(wWW.bytes);
		}
		finally
		{
			((GGCADKCAHNK)this).FOHHLBAKLBP();
		}
		if (sprite == null)
		{
			PNBPNBCJFEO.MCJNJLLHIIH(CHHHPCOIFJJ);
			CHHHPCOIFJJ = HLKAEJCPMEB.OJOMNKNIAGI;
			string url = HLKAEJCPMEB.JJLECKMNALI(CHHHPCOIFJJ, NBFBPNNEKMN);
			WWW wWW2 = new WWW(url);
			try
			{
				while (!wWW2.isDone)
				{
					yield return null;
				}
				sprite = IONHCLCHCDI(wWW2.bytes);
			}
			finally
			{
				((GGCADKCAHNK)this).GDDGNFJKMKG();
			}
		}
		BBOBCJAHPJM = sprite;
		BBOBCJAHPJM.name = CHHHPCOIFJJ;
		DCKHOAHIFDH = true;
	}

	private static Sprite IONHCLCHCDI(byte[] DIPNEDDIHBK)
	{
		try
		{
			Texture2D texture2D = new Texture2D(1024, 1822, TextureFormat.RGB24, false);
			texture2D.filterMode = FilterMode.Bilinear;
			Texture2D texture2D2 = texture2D;
			texture2D2.LoadImage(DIPNEDDIHBK);
			return Sprite.Create(texture2D2, Rect.MinMaxRect(0f, 0f, 1024f, 1822f), new Vector2(0.5f, 0.5f), 100f, 0u, SpriteMeshType.FullRect);
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Download, "Exception on load background image: {0}", ex.Message);
			NHNBFBDHKGN.JFPLDMEBIJH("Load Background Sprite Exception", ex.Message, ex.StackTrace);
		}
		return null;
	}
}
