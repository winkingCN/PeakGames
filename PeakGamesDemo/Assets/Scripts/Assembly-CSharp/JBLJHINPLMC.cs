using System;
using System.IO;

public class JBLJHINPLMC : JJOLEANMIHG
{
	public JBLJHINPLMC(Stream EDKDOJFEFMD)
		: base(EDKDOJFEFMD)
	{
	}

	private void CFNBLFIGKEK(int EOFAGACBNFP)
	{
		if (EOFAGACBNFP > 127)
		{
			int num = 1;
			uint num2 = (uint)EOFAGACBNFP;
			while ((num2 >>= 8) != 0)
			{
				num++;
			}
			WriteByte((byte)((uint)num | 0x80u));
			for (int num3 = (num - 1) * 8; num3 >= 0; num3 -= 8)
			{
				WriteByte((byte)(EOFAGACBNFP >> num3));
			}
		}
		else
		{
			WriteByte((byte)EOFAGACBNFP);
		}
	}

	internal void AGNEJPEMPAP(int MOKLDCMGFFB, byte[] DIPNEDDIHBK)
	{
		WriteByte((byte)MOKLDCMGFFB);
		CFNBLFIGKEK(DIPNEDDIHBK.Length);
		Write(DIPNEDDIHBK, 0, DIPNEDDIHBK.Length);
	}

	internal void AGNEJPEMPAP(int MOKLDCMGFFB, byte LEPEJBPNEGF, byte[] DIPNEDDIHBK)
	{
		WriteByte((byte)MOKLDCMGFFB);
		CFNBLFIGKEK(DIPNEDDIHBK.Length + 1);
		WriteByte(LEPEJBPNEGF);
		Write(DIPNEDDIHBK, 0, DIPNEDDIHBK.Length);
	}

	internal void AGNEJPEMPAP(int MOKLDCMGFFB, byte[] DIPNEDDIHBK, int IBNDGNOIEEF, int EOFAGACBNFP)
	{
		WriteByte((byte)MOKLDCMGFFB);
		CFNBLFIGKEK(EOFAGACBNFP);
		Write(DIPNEDDIHBK, IBNDGNOIEEF, EOFAGACBNFP);
	}

	internal void DCFAKMDJNLN(int KCHENLJCHHH, int LGPKPEMILHA)
	{
		if (LGPKPEMILHA < 31)
		{
			WriteByte((byte)(KCHENLJCHHH | LGPKPEMILHA));
			return;
		}
		WriteByte((byte)((uint)KCHENLJCHHH | 0x1Fu));
		if (LGPKPEMILHA < 128)
		{
			WriteByte((byte)LGPKPEMILHA);
			return;
		}
		byte[] array = new byte[5];
		int num = array.Length;
		array[--num] = (byte)((uint)LGPKPEMILHA & 0x7Fu);
		do
		{
			LGPKPEMILHA >>= 7;
			array[--num] = (byte)(((uint)LGPKPEMILHA & 0x7Fu) | 0x80u);
		}
		while (LGPKPEMILHA > 127);
		Write(array, num, array.Length - num);
	}

	internal void AGNEJPEMPAP(int KCHENLJCHHH, int LGPKPEMILHA, byte[] DIPNEDDIHBK)
	{
		DCFAKMDJNLN(KCHENLJCHHH, LGPKPEMILHA);
		CFNBLFIGKEK(DIPNEDDIHBK.Length);
		Write(DIPNEDDIHBK, 0, DIPNEDDIHBK.Length);
	}

	protected void DPPBMODABNA()
	{
		WriteByte(5);
		WriteByte(0);
	}

	[Obsolete("Use version taking an Asn1Encodable arg instead")]
	public virtual void ELPOLPFGCHA(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null)
		{
			DPPBMODABNA();
			return;
		}
		if (NEMEKIOEOLC is EDOEBJJFOBM)
		{
			((EDOEBJJFOBM)NEMEKIOEOLC).LMDBBPLCJDM(this);
			return;
		}
		if (NEMEKIOEOLC is LNKPCJLANAO)
		{
			((LNKPCJLANAO)NEMEKIOEOLC).IIHKEACDNID().LMDBBPLCJDM(this);
			return;
		}
		throw new IOException("object not Asn1Object");
	}

	public virtual void ELPOLPFGCHA(LNKPCJLANAO NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null)
		{
			DPPBMODABNA();
		}
		else
		{
			NEMEKIOEOLC.IIHKEACDNID().LMDBBPLCJDM(this);
		}
	}

	public virtual void ELPOLPFGCHA(EDOEBJJFOBM NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null)
		{
			DPPBMODABNA();
		}
		else
		{
			NEMEKIOEOLC.LMDBBPLCJDM(this);
		}
	}
}
