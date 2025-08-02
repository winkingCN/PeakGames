using System;
using System.IO;

public abstract class EDOEBJJFOBM : LNKPCJLANAO
{
	public static EDOEBJJFOBM HPDCKMOPEMM(byte[] MBBPBGHKLJM)
	{
		try
		{
			MemoryStream memoryStream = new MemoryStream(MBBPBGHKLJM, false);
			AOKAOIHEKIH aOKAOIHEKIH = new AOKAOIHEKIH(memoryStream, MBBPBGHKLJM.Length);
			EDOEBJJFOBM result = aOKAOIHEKIH.DMHLIGLGJGI();
			if (memoryStream.Position != memoryStream.Length)
			{
				throw new IOException("extra data found after object");
			}
			return result;
		}
		catch (InvalidCastException)
		{
			throw new IOException("cannot recognise object in byte array");
		}
	}

	public static EDOEBJJFOBM IHHDEKPLKHC(Stream FILBOAMBNOP)
	{
		try
		{
			return new AOKAOIHEKIH(FILBOAMBNOP).DMHLIGLGJGI();
		}
		catch (InvalidCastException)
		{
			throw new IOException("cannot recognise object in stream");
		}
	}

	public sealed override EDOEBJJFOBM IIHKEACDNID()
	{
		return this;
	}

	internal abstract void LMDBBPLCJDM(JBLJHINPLMC NMHOOGAGLOA);

	protected abstract bool IMHPDJGGAGJ(EDOEBJJFOBM LABMKGMAEGK);

	protected abstract int BGFGDLGFEPI();

	internal bool JEIBPIEIFGK(EDOEBJJFOBM NEMEKIOEOLC)
	{
		return IMHPDJGGAGJ(NEMEKIOEOLC);
	}

	internal int DLFOFMGBLDL()
	{
		return BGFGDLGFEPI();
	}
}
