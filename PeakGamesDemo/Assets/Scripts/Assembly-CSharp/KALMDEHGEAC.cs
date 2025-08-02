using System;

public class KALMDEHGEAC : EEBNPONHKOK
{
	private const int IOCOCGHMNGB = 20;

	private uint NAHACOBOKIM;

	private uint MPNNHCHGEGL;

	private uint AJBHIPPAFIJ;

	private uint GCLNAIGNJJN;

	private uint CCFJELJJBPD;

	private uint[] CBPFFIBINEH = new uint[80];

	private int ABBPDEOGNFE;

	private const uint MGOGGACMKHA = 1518500249u;

	private const uint CMCKLHLOOLK = 1859775393u;

	private const uint AFFCLCABDKA = 2400959708u;

	private const uint HALGOKKGIOM = 3395469782u;

	public override string KFKMEPMEBND
	{
		get
		{
			return "SHA-1";
		}
	}

	public KALMDEHGEAC()
	{
		OMOKOKFNBKI();
	}

	public KALMDEHGEAC(KALMDEHGEAC LLIEHCKNJEM)
		: base(LLIEHCKNJEM)
	{
		AKBPCECABIO(LLIEHCKNJEM);
	}

	private void AKBPCECABIO(KALMDEHGEAC LLIEHCKNJEM)
	{
		AKBPCECABIO((EEBNPONHKOK)LLIEHCKNJEM);
		NAHACOBOKIM = LLIEHCKNJEM.NAHACOBOKIM;
		MPNNHCHGEGL = LLIEHCKNJEM.MPNNHCHGEGL;
		AJBHIPPAFIJ = LLIEHCKNJEM.AJBHIPPAFIJ;
		GCLNAIGNJJN = LLIEHCKNJEM.GCLNAIGNJJN;
		CCFJELJJBPD = LLIEHCKNJEM.CCFJELJJBPD;
		Array.Copy(LLIEHCKNJEM.CBPFFIBINEH, 0, CBPFFIBINEH, 0, LLIEHCKNJEM.CBPFFIBINEH.Length);
		ABBPDEOGNFE = LLIEHCKNJEM.ABBPDEOGNFE;
	}

	public override int EEMLLAMENHO()
	{
		return 20;
	}

	internal override void ICKIHAABCPI(byte[] MOPCLEEGDFB, int ELICNEDIBGB)
	{
		CBPFFIBINEH[ABBPDEOGNFE] = PGOKFBKEOAB.EFODDMAJNOA(MOPCLEEGDFB, ELICNEDIBGB);
		if (++ABBPDEOGNFE == 16)
		{
			DPACJDFHLKB();
		}
	}

	internal override void IIENDLEDGMC(long EAJFCEBGGIG)
	{
		if (ABBPDEOGNFE > 14)
		{
			DPACJDFHLKB();
		}
		CBPFFIBINEH[14] = (uint)((ulong)EAJFCEBGGIG >> 32);
		CBPFFIBINEH[15] = (uint)EAJFCEBGGIG;
	}

	public override int LCNOFBMOHHM(byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		OJILOEAPDCL();
		PGOKFBKEOAB.MPMAFPANDLC(NAHACOBOKIM, BILGCJNPJGJ, EMAKNGBIFDC);
		PGOKFBKEOAB.MPMAFPANDLC(MPNNHCHGEGL, BILGCJNPJGJ, EMAKNGBIFDC + 4);
		PGOKFBKEOAB.MPMAFPANDLC(AJBHIPPAFIJ, BILGCJNPJGJ, EMAKNGBIFDC + 8);
		PGOKFBKEOAB.MPMAFPANDLC(GCLNAIGNJJN, BILGCJNPJGJ, EMAKNGBIFDC + 12);
		PGOKFBKEOAB.MPMAFPANDLC(CCFJELJJBPD, BILGCJNPJGJ, EMAKNGBIFDC + 16);
		OMOKOKFNBKI();
		return 20;
	}

	public override void OMOKOKFNBKI()
	{
		base.OMOKOKFNBKI();
		NAHACOBOKIM = 1732584193u;
		MPNNHCHGEGL = 4023233417u;
		AJBHIPPAFIJ = 2562383102u;
		GCLNAIGNJJN = 271733878u;
		CCFJELJJBPD = 3285377520u;
		ABBPDEOGNFE = 0;
		Array.Clear(CBPFFIBINEH, 0, CBPFFIBINEH.Length);
	}

	private static uint KEFHMDALCHB(uint OJOAGEHFPNP, uint AAIEJDNAODP, uint PHFLBLJJMLI)
	{
		return (OJOAGEHFPNP & AAIEJDNAODP) | (~OJOAGEHFPNP & PHFLBLJJMLI);
	}

	private static uint JGOHMOHEFMJ(uint OJOAGEHFPNP, uint AAIEJDNAODP, uint PHFLBLJJMLI)
	{
		return OJOAGEHFPNP ^ AAIEJDNAODP ^ PHFLBLJJMLI;
	}

	private static uint HBGOKILMBJG(uint OJOAGEHFPNP, uint AAIEJDNAODP, uint PHFLBLJJMLI)
	{
		return (OJOAGEHFPNP & AAIEJDNAODP) | (OJOAGEHFPNP & PHFLBLJJMLI) | (AAIEJDNAODP & PHFLBLJJMLI);
	}

	internal override void DPACJDFHLKB()
	{
		for (int i = 16; i < 80; i++)
		{
			uint num = CBPFFIBINEH[i - 3] ^ CBPFFIBINEH[i - 8] ^ CBPFFIBINEH[i - 14] ^ CBPFFIBINEH[i - 16];
			CBPFFIBINEH[i] = (num << 1) | (num >> 31);
		}
		uint num2 = NAHACOBOKIM;
		uint num3 = MPNNHCHGEGL;
		uint num4 = AJBHIPPAFIJ;
		uint num5 = GCLNAIGNJJN;
		uint num6 = CCFJELJJBPD;
		int num7 = 0;
		for (int j = 0; j < 4; j++)
		{
			num6 += ((num2 << 5) | (num2 >> 27)) + KEFHMDALCHB(num3, num4, num5) + CBPFFIBINEH[num7++] + 1518500249;
			num3 = (num3 << 30) | (num3 >> 2);
			num5 += ((num6 << 5) | (num6 >> 27)) + KEFHMDALCHB(num2, num3, num4) + CBPFFIBINEH[num7++] + 1518500249;
			num2 = (num2 << 30) | (num2 >> 2);
			num4 += ((num5 << 5) | (num5 >> 27)) + KEFHMDALCHB(num6, num2, num3) + CBPFFIBINEH[num7++] + 1518500249;
			num6 = (num6 << 30) | (num6 >> 2);
			num3 += ((num4 << 5) | (num4 >> 27)) + KEFHMDALCHB(num5, num6, num2) + CBPFFIBINEH[num7++] + 1518500249;
			num5 = (num5 << 30) | (num5 >> 2);
			num2 += ((num3 << 5) | (num3 >> 27)) + KEFHMDALCHB(num4, num5, num6) + CBPFFIBINEH[num7++] + 1518500249;
			num4 = (num4 << 30) | (num4 >> 2);
		}
		for (int k = 0; k < 4; k++)
		{
			num6 += ((num2 << 5) | (num2 >> 27)) + JGOHMOHEFMJ(num3, num4, num5) + CBPFFIBINEH[num7++] + 1859775393;
			num3 = (num3 << 30) | (num3 >> 2);
			num5 += ((num6 << 5) | (num6 >> 27)) + JGOHMOHEFMJ(num2, num3, num4) + CBPFFIBINEH[num7++] + 1859775393;
			num2 = (num2 << 30) | (num2 >> 2);
			num4 += ((num5 << 5) | (num5 >> 27)) + JGOHMOHEFMJ(num6, num2, num3) + CBPFFIBINEH[num7++] + 1859775393;
			num6 = (num6 << 30) | (num6 >> 2);
			num3 += ((num4 << 5) | (num4 >> 27)) + JGOHMOHEFMJ(num5, num6, num2) + CBPFFIBINEH[num7++] + 1859775393;
			num5 = (num5 << 30) | (num5 >> 2);
			num2 += ((num3 << 5) | (num3 >> 27)) + JGOHMOHEFMJ(num4, num5, num6) + CBPFFIBINEH[num7++] + 1859775393;
			num4 = (num4 << 30) | (num4 >> 2);
		}
		for (int l = 0; l < 4; l++)
		{
			num6 += (uint)((int)(((num2 << 5) | (num2 >> 27)) + HBGOKILMBJG(num3, num4, num5) + CBPFFIBINEH[num7++]) + -1894007588);
			num3 = (num3 << 30) | (num3 >> 2);
			num5 += (uint)((int)(((num6 << 5) | (num6 >> 27)) + HBGOKILMBJG(num2, num3, num4) + CBPFFIBINEH[num7++]) + -1894007588);
			num2 = (num2 << 30) | (num2 >> 2);
			num4 += (uint)((int)(((num5 << 5) | (num5 >> 27)) + HBGOKILMBJG(num6, num2, num3) + CBPFFIBINEH[num7++]) + -1894007588);
			num6 = (num6 << 30) | (num6 >> 2);
			num3 += (uint)((int)(((num4 << 5) | (num4 >> 27)) + HBGOKILMBJG(num5, num6, num2) + CBPFFIBINEH[num7++]) + -1894007588);
			num5 = (num5 << 30) | (num5 >> 2);
			num2 += (uint)((int)(((num3 << 5) | (num3 >> 27)) + HBGOKILMBJG(num4, num5, num6) + CBPFFIBINEH[num7++]) + -1894007588);
			num4 = (num4 << 30) | (num4 >> 2);
		}
		for (int m = 0; m < 4; m++)
		{
			num6 += (uint)((int)(((num2 << 5) | (num2 >> 27)) + JGOHMOHEFMJ(num3, num4, num5) + CBPFFIBINEH[num7++]) + -899497514);
			num3 = (num3 << 30) | (num3 >> 2);
			num5 += (uint)((int)(((num6 << 5) | (num6 >> 27)) + JGOHMOHEFMJ(num2, num3, num4) + CBPFFIBINEH[num7++]) + -899497514);
			num2 = (num2 << 30) | (num2 >> 2);
			num4 += (uint)((int)(((num5 << 5) | (num5 >> 27)) + JGOHMOHEFMJ(num6, num2, num3) + CBPFFIBINEH[num7++]) + -899497514);
			num6 = (num6 << 30) | (num6 >> 2);
			num3 += (uint)((int)(((num4 << 5) | (num4 >> 27)) + JGOHMOHEFMJ(num5, num6, num2) + CBPFFIBINEH[num7++]) + -899497514);
			num5 = (num5 << 30) | (num5 >> 2);
			num2 += (uint)((int)(((num3 << 5) | (num3 >> 27)) + JGOHMOHEFMJ(num4, num5, num6) + CBPFFIBINEH[num7++]) + -899497514);
			num4 = (num4 << 30) | (num4 >> 2);
		}
		NAHACOBOKIM += num2;
		MPNNHCHGEGL += num3;
		AJBHIPPAFIJ += num4;
		GCLNAIGNJJN += num5;
		CCFJELJJBPD += num6;
		ABBPDEOGNFE = 0;
		Array.Clear(CBPFFIBINEH, 0, 16);
	}

	public override MIPBJNJHNGA FDCFKGAEJFF()
	{
		return new KALMDEHGEAC(this);
	}

	public override void OMOKOKFNBKI(MIPBJNJHNGA CJHEIBNHNNE)
	{
		KALMDEHGEAC lLIEHCKNJEM = (KALMDEHGEAC)CJHEIBNHNNE;
		AKBPCECABIO(lLIEHCKNJEM);
	}
}
