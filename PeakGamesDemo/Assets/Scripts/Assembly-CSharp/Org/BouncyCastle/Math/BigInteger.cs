using System;
using System.Collections;
using System.Globalization;
using System.Text;

namespace Org.BouncyCastle.Math
{
	[Serializable]
	public class BigInteger
	{
		internal static readonly int[][] primeLists;

		internal static readonly int[] primeProducts;

		private const long IMASK = 4294967295L;

		private const ulong UIMASK = 4294967295uL;

		private static readonly int[] ZeroMagnitude;

		private static readonly byte[] ZeroEncoding;

		private static readonly BigInteger[] SMALL_CONSTANTS;

		public static readonly BigInteger Zero;

		public static readonly BigInteger One;

		public static readonly BigInteger Two;

		public static readonly BigInteger Three;

		public static readonly BigInteger Ten;

		private static readonly byte[] BitLengthTable;

		private const int chunk2 = 1;

		private const int chunk8 = 1;

		private const int chunk10 = 19;

		private const int chunk16 = 16;

		private static readonly BigInteger radix2;

		private static readonly BigInteger radix2E;

		private static readonly BigInteger radix8;

		private static readonly BigInteger radix8E;

		private static readonly BigInteger radix10;

		private static readonly BigInteger radix10E;

		private static readonly BigInteger radix16;

		private static readonly BigInteger radix16E;

		private static readonly FBIJJFGLKMK RandomSource;

		private static readonly int[] ExpWindowThresholds;

		private const int BitsPerByte = 8;

		private const int BitsPerInt = 32;

		private const int BytesPerInt = 4;

		private int[] magnitude;

		private int sign;

		private int nBits = -1;

		private int nBitLength = -1;

		private int mQuote;

		public int BitCount
		{
			get
			{
				if (nBits == -1)
				{
					if (sign < 0)
					{
						nBits = BEHECEMIINM().BitCount;
					}
					else
					{
						int num = 0;
						for (int i = 0; i < magnitude.Length; i++)
						{
							num += BDEANGAKHFK(magnitude[i]);
						}
						nBits = num;
					}
				}
				return nBits;
			}
		}

		public int BitLength
		{
			get
			{
				if (nBitLength == -1)
				{
					nBitLength = ((sign != 0) ? KJIJBIEHLPH(sign, 0, magnitude) : 0);
				}
				return nBitLength;
			}
		}

		public int IntValue
		{
			get
			{
				if (sign == 0)
				{
					return 0;
				}
				int num = magnitude.Length;
				int num2 = magnitude[num - 1];
				return (sign >= 0) ? num2 : (-num2);
			}
		}

		public long LongValue
		{
			get
			{
				if (sign == 0)
				{
					return 0L;
				}
				int num = magnitude.Length;
				long num2 = magnitude[num - 1] & 0xFFFFFFFFu;
				if (num > 1)
				{
					num2 |= (magnitude[num - 2] & 0xFFFFFFFFu) << 32;
				}
				return (sign >= 0) ? num2 : (-num2);
			}
		}

		public int SignValue
		{
			get
			{
				return sign;
			}
		}

		static BigInteger()
		{
			primeLists = new int[64][]
			{
				new int[8] { 3, 5, 7, 11, 13, 17, 19, 23 },
				new int[5] { 29, 31, 37, 41, 43 },
				new int[5] { 47, 53, 59, 61, 67 },
				new int[4] { 71, 73, 79, 83 },
				new int[4] { 89, 97, 101, 103 },
				new int[4] { 107, 109, 113, 127 },
				new int[4] { 131, 137, 139, 149 },
				new int[4] { 151, 157, 163, 167 },
				new int[4] { 173, 179, 181, 191 },
				new int[4] { 193, 197, 199, 211 },
				new int[3] { 223, 227, 229 },
				new int[3] { 233, 239, 241 },
				new int[3] { 251, 257, 263 },
				new int[3] { 269, 271, 277 },
				new int[3] { 281, 283, 293 },
				new int[3] { 307, 311, 313 },
				new int[3] { 317, 331, 337 },
				new int[3] { 347, 349, 353 },
				new int[3] { 359, 367, 373 },
				new int[3] { 379, 383, 389 },
				new int[3] { 397, 401, 409 },
				new int[3] { 419, 421, 431 },
				new int[3] { 433, 439, 443 },
				new int[3] { 449, 457, 461 },
				new int[3] { 463, 467, 479 },
				new int[3] { 487, 491, 499 },
				new int[3] { 503, 509, 521 },
				new int[3] { 523, 541, 547 },
				new int[3] { 557, 563, 569 },
				new int[3] { 571, 577, 587 },
				new int[3] { 593, 599, 601 },
				new int[3] { 607, 613, 617 },
				new int[3] { 619, 631, 641 },
				new int[3] { 643, 647, 653 },
				new int[3] { 659, 661, 673 },
				new int[3] { 677, 683, 691 },
				new int[3] { 701, 709, 719 },
				new int[3] { 727, 733, 739 },
				new int[3] { 743, 751, 757 },
				new int[3] { 761, 769, 773 },
				new int[3] { 787, 797, 809 },
				new int[3] { 811, 821, 823 },
				new int[3] { 827, 829, 839 },
				new int[3] { 853, 857, 859 },
				new int[3] { 863, 877, 881 },
				new int[3] { 883, 887, 907 },
				new int[3] { 911, 919, 929 },
				new int[3] { 937, 941, 947 },
				new int[3] { 953, 967, 971 },
				new int[3] { 977, 983, 991 },
				new int[3] { 997, 1009, 1013 },
				new int[3] { 1019, 1021, 1031 },
				new int[3] { 1033, 1039, 1049 },
				new int[3] { 1051, 1061, 1063 },
				new int[3] { 1069, 1087, 1091 },
				new int[3] { 1093, 1097, 1103 },
				new int[3] { 1109, 1117, 1123 },
				new int[3] { 1129, 1151, 1153 },
				new int[3] { 1163, 1171, 1181 },
				new int[3] { 1187, 1193, 1201 },
				new int[3] { 1213, 1217, 1223 },
				new int[3] { 1229, 1231, 1237 },
				new int[3] { 1249, 1259, 1277 },
				new int[3] { 1279, 1283, 1289 }
			};
			ZeroMagnitude = new int[0];
			ZeroEncoding = new byte[0];
			SMALL_CONSTANTS = new BigInteger[17];
			BitLengthTable = new byte[256]
			{
				0, 1, 2, 2, 3, 3, 3, 3, 4, 4,
				4, 4, 4, 4, 4, 4, 5, 5, 5, 5,
				5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 6, 6, 6, 6, 6, 6, 6, 6,
				6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
				6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
				6, 6, 6, 6, 7, 7, 7, 7, 7, 7,
				7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
				7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
				7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
				7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
				7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
				7, 7, 7, 7, 7, 7, 7, 7, 8, 8,
				8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
				8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
				8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
				8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
				8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
				8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
				8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
				8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
				8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
				8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
				8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
				8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
				8, 8, 8, 8, 8, 8
			};
			RandomSource = new FBIJJFGLKMK();
			ExpWindowThresholds = new int[8] { 7, 25, 81, 241, 673, 1793, 4609, 2147483647 };
			Zero = new BigInteger(0, ZeroMagnitude, false);
			Zero.nBits = 0;
			Zero.nBitLength = 0;
			SMALL_CONSTANTS[0] = Zero;
			for (uint num = 1u; num < SMALL_CONSTANTS.Length; num++)
			{
				SMALL_CONSTANTS[num] = FDLCDHEHEGK(num);
			}
			One = SMALL_CONSTANTS[1];
			Two = SMALL_CONSTANTS[2];
			Three = SMALL_CONSTANTS[3];
			Ten = SMALL_CONSTANTS[10];
			radix2 = AGLOJCOAJIK(2L);
			radix2E = radix2.MALBDNEDKLB(1);
			radix8 = AGLOJCOAJIK(8L);
			radix8E = radix8.MALBDNEDKLB(1);
			radix10 = AGLOJCOAJIK(10L);
			radix10E = radix10.MALBDNEDKLB(19);
			radix16 = AGLOJCOAJIK(16L);
			radix16E = radix16.MALBDNEDKLB(16);
			primeProducts = new int[primeLists.Length];
			for (int i = 0; i < primeLists.Length; i++)
			{
				int[] array = primeLists[i];
				int num2 = array[0];
				for (int j = 1; j < array.Length; j++)
				{
					num2 *= array[j];
				}
				primeProducts[i] = num2;
			}
		}

		private BigInteger(int FPJKCGMMNKB, int[] OHPENDELFKK, bool HLDFOJFCGDJ)
		{
			if (HLDFOJFCGDJ)
			{
				int i;
				for (i = 0; i < OHPENDELFKK.Length && OHPENDELFKK[i] == 0; i++)
				{
				}
				if (i == OHPENDELFKK.Length)
				{
					sign = 0;
					magnitude = ZeroMagnitude;
					return;
				}
				sign = FPJKCGMMNKB;
				if (i == 0)
				{
					magnitude = OHPENDELFKK;
					return;
				}
				magnitude = new int[OHPENDELFKK.Length - i];
				Array.Copy(OHPENDELFKK, i, magnitude, 0, magnitude.Length);
			}
			else
			{
				sign = FPJKCGMMNKB;
				magnitude = OHPENDELFKK;
			}
		}

		public BigInteger(string EDDNOJDPMCF)
			: this(EDDNOJDPMCF, 10)
		{
		}

		public BigInteger(string GFPBBLPMOOL, int PPKFDNLPFOO)
		{
			if (GFPBBLPMOOL.Length == 0)
			{
				throw new FormatException("Zero length BigInteger");
			}
			NumberStyles style;
			int num;
			BigInteger bigInteger;
			BigInteger hIMINGHNIKN;
			switch (PPKFDNLPFOO)
			{
			case 2:
				style = NumberStyles.Integer;
				num = 1;
				bigInteger = radix2;
				hIMINGHNIKN = radix2E;
				break;
			case 8:
				style = NumberStyles.Integer;
				num = 1;
				bigInteger = radix8;
				hIMINGHNIKN = radix8E;
				break;
			case 10:
				style = NumberStyles.Integer;
				num = 19;
				bigInteger = radix10;
				hIMINGHNIKN = radix10E;
				break;
			case 16:
				style = NumberStyles.AllowHexSpecifier;
				num = 16;
				bigInteger = radix16;
				hIMINGHNIKN = radix16E;
				break;
			default:
				throw new FormatException("Only bases 2, 8, 10, or 16 allowed");
			}
			int i = 0;
			sign = 1;
			if (GFPBBLPMOOL[0] == '-')
			{
				if (GFPBBLPMOOL.Length == 1)
				{
					throw new FormatException("Zero length BigInteger");
				}
				sign = -1;
				i = 1;
			}
			for (; i < GFPBBLPMOOL.Length && int.Parse(GFPBBLPMOOL[i].ToString(), style) == 0; i++)
			{
			}
			if (i >= GFPBBLPMOOL.Length)
			{
				sign = 0;
				magnitude = ZeroMagnitude;
				return;
			}
			BigInteger bigInteger2 = Zero;
			int num2 = i + num;
			if (num2 <= GFPBBLPMOOL.Length)
			{
				do
				{
					string text = GFPBBLPMOOL.Substring(i, num);
					ulong num3 = ulong.Parse(text, style);
					BigInteger eDDNOJDPMCF = FDLCDHEHEGK(num3);
					switch (PPKFDNLPFOO)
					{
					case 2:
						if (num3 >= 2)
						{
							throw new FormatException("Bad character in radix 2 string: " + text);
						}
						bigInteger2 = bigInteger2.DOKHFLENGLF(1);
						break;
					case 8:
						if (num3 >= 8)
						{
							throw new FormatException("Bad character in radix 8 string: " + text);
						}
						bigInteger2 = bigInteger2.DOKHFLENGLF(3);
						break;
					case 16:
						bigInteger2 = bigInteger2.DOKHFLENGLF(64);
						break;
					default:
						bigInteger2 = bigInteger2.IBJBIGNPNEM(hIMINGHNIKN);
						break;
					}
					bigInteger2 = bigInteger2.JEACJNAKLDJ(eDDNOJDPMCF);
					i = num2;
					num2 += num;
				}
				while (num2 <= GFPBBLPMOOL.Length);
			}
			if (i < GFPBBLPMOOL.Length)
			{
				string text2 = GFPBBLPMOOL.Substring(i);
				ulong eDDNOJDPMCF2 = ulong.Parse(text2, style);
				BigInteger bigInteger3 = FDLCDHEHEGK(eDDNOJDPMCF2);
				if (bigInteger2.sign > 0)
				{
					switch (PPKFDNLPFOO)
					{
					case 16:
						bigInteger2 = bigInteger2.DOKHFLENGLF(text2.Length << 2);
						break;
					default:
						bigInteger2 = bigInteger2.IBJBIGNPNEM(bigInteger.MALBDNEDKLB(text2.Length));
						break;
					case 2:
					case 8:
						break;
					}
					bigInteger2 = bigInteger2.JEACJNAKLDJ(bigInteger3);
				}
				else
				{
					bigInteger2 = bigInteger3;
				}
			}
			magnitude = bigInteger2.magnitude;
		}

		public BigInteger(byte[] DIPNEDDIHBK)
			: this(DIPNEDDIHBK, 0, DIPNEDDIHBK.Length)
		{
		}

		public BigInteger(byte[] DIPNEDDIHBK, int IBNDGNOIEEF, int EOFAGACBNFP)
		{
			if (EOFAGACBNFP == 0)
			{
				throw new FormatException("Zero length BigInteger");
			}
			if ((sbyte)DIPNEDDIHBK[IBNDGNOIEEF] < 0)
			{
				sign = -1;
				int num = IBNDGNOIEEF + EOFAGACBNFP;
				int i;
				for (i = IBNDGNOIEEF; i < num && (sbyte)DIPNEDDIHBK[i] == -1; i++)
				{
				}
				if (i >= num)
				{
					magnitude = One.magnitude;
					return;
				}
				int num2 = num - i;
				byte[] array = new byte[num2];
				int num3 = 0;
				while (num3 < num2)
				{
					array[num3++] = (byte)(~DIPNEDDIHBK[i++]);
				}
				while (array[--num3] == byte.MaxValue)
				{
					array[num3] = 0;
				}
				array[num3]++;
				magnitude = HHGGHLGNPCC(array, 0, array.Length);
			}
			else
			{
				magnitude = HHGGHLGNPCC(DIPNEDDIHBK, IBNDGNOIEEF, EOFAGACBNFP);
				sign = ((magnitude.Length > 0) ? 1 : 0);
			}
		}

		public BigInteger(int HLPFJFPGPKE, byte[] DIPNEDDIHBK)
			: this(HLPFJFPGPKE, DIPNEDDIHBK, 0, DIPNEDDIHBK.Length)
		{
		}

		public BigInteger(int HLPFJFPGPKE, byte[] DIPNEDDIHBK, int IBNDGNOIEEF, int EOFAGACBNFP)
		{
			switch (HLPFJFPGPKE)
			{
			default:
				throw new FormatException("Invalid sign value");
			case 0:
				sign = 0;
				magnitude = ZeroMagnitude;
				break;
			case -1:
			case 1:
				magnitude = HHGGHLGNPCC(DIPNEDDIHBK, IBNDGNOIEEF, EOFAGACBNFP);
				sign = ((magnitude.Length >= 1) ? HLPFJFPGPKE : 0);
				break;
			}
		}

		public BigInteger(int BFEHGEOKNMK, Random GECCLOFELEC)
		{
			if (BFEHGEOKNMK < 0)
			{
				throw new ArgumentException("sizeInBits must be non-negative");
			}
			nBits = -1;
			nBitLength = -1;
			if (BFEHGEOKNMK == 0)
			{
				sign = 0;
				magnitude = ZeroMagnitude;
				return;
			}
			int num = MNAIJEEKPCP(BFEHGEOKNMK);
			byte[] array = new byte[num];
			GECCLOFELEC.NextBytes(array);
			int num2 = 8 * num - BFEHGEOKNMK;
			array[0] &= (byte)(255u >> num2);
			magnitude = HHGGHLGNPCC(array, 0, array.Length);
			sign = ((magnitude.Length >= 1) ? 1 : 0);
		}

		public BigInteger(int EAJFCEBGGIG, int CFGADBIOJFG, Random GECCLOFELEC)
		{
			if (EAJFCEBGGIG < 2)
			{
				throw new ArithmeticException("bitLength < 2");
			}
			sign = 1;
			nBitLength = EAJFCEBGGIG;
			if (EAJFCEBGGIG == 2)
			{
				magnitude = ((GECCLOFELEC.Next(2) != 0) ? Three.magnitude : Two.magnitude);
				return;
			}
			int num = MNAIJEEKPCP(EAJFCEBGGIG);
			byte[] array = new byte[num];
			int num2 = 8 * num - EAJFCEBGGIG;
			byte b = (byte)(255u >> num2);
			byte b2 = (byte)(1 << 7 - num2);
			while (true)
			{
				GECCLOFELEC.NextBytes(array);
				array[0] &= b;
				array[0] |= b2;
				array[num - 1] |= 1;
				magnitude = HHGGHLGNPCC(array, 0, array.Length);
				nBits = -1;
				mQuote = 0;
				if (CFGADBIOJFG < 1 || GADFMFMICHO(CFGADBIOJFG, GECCLOFELEC, true))
				{
					break;
				}
				for (int i = 1; i < magnitude.Length - 1; i++)
				{
					magnitude[i] ^= GECCLOFELEC.Next();
					if (GADFMFMICHO(CFGADBIOJFG, GECCLOFELEC, true))
					{
						return;
					}
				}
			}
		}

		private static int MNAIJEEKPCP(int DAOOKLBFGEF)
		{
			return (DAOOKLBFGEF + 8 - 1) / 8;
		}

		internal static BigInteger HHFOMHMDAKH(int BFEHGEOKNMK)
		{
			return new BigInteger(BFEHGEOKNMK, RandomSource);
		}

		private static int[] HHGGHLGNPCC(byte[] DIPNEDDIHBK, int IBNDGNOIEEF, int EOFAGACBNFP)
		{
			int num = IBNDGNOIEEF + EOFAGACBNFP;
			int i;
			for (i = IBNDGNOIEEF; i < num && DIPNEDDIHBK[i] == 0; i++)
			{
			}
			if (i >= num)
			{
				return ZeroMagnitude;
			}
			int num2 = (num - i + 3) / 4;
			int num3 = (num - i) % 4;
			if (num3 == 0)
			{
				num3 = 4;
			}
			if (num2 < 1)
			{
				return ZeroMagnitude;
			}
			int[] array = new int[num2];
			int num4 = 0;
			int num5 = 0;
			for (int j = i; j < num; j++)
			{
				num4 <<= 8;
				num4 |= DIPNEDDIHBK[j] & 0xFF;
				num3--;
				if (num3 <= 0)
				{
					array[num5] = num4;
					num5++;
					num3 = 4;
					num4 = 0;
				}
			}
			if (num5 < array.Length)
			{
				array[num5] = num4;
			}
			return array;
		}

		public BigInteger DKGOFCBJBPB()
		{
			return (sign < 0) ? BHKOFHMDACN() : this;
		}

		private static int[] LNKPBOLNCFM(int[] MNIMEAMHNMI, int[] BCIHLCMFAEK)
		{
			int num = MNIMEAMHNMI.Length - 1;
			int num2 = BCIHLCMFAEK.Length - 1;
			long num3 = 0L;
			while (num2 >= 0)
			{
				num3 += (long)(uint)MNIMEAMHNMI[num] + (long)(uint)BCIHLCMFAEK[num2--];
				MNIMEAMHNMI[num--] = (int)num3;
				num3 = (long)((ulong)num3 >> 32);
			}
			if (num3 != 0)
			{
				while (num >= 0 && ++MNIMEAMHNMI[num--] == 0)
				{
				}
			}
			return MNIMEAMHNMI;
		}

		public BigInteger JEACJNAKLDJ(BigInteger EDDNOJDPMCF)
		{
			if (sign == 0)
			{
				return EDDNOJDPMCF;
			}
			if (sign != EDDNOJDPMCF.sign)
			{
				if (EDDNOJDPMCF.sign == 0)
				{
					return this;
				}
				if (EDDNOJDPMCF.sign < 0)
				{
					return FBGIHKPECCO(EDDNOJDPMCF.BHKOFHMDACN());
				}
				return EDDNOJDPMCF.FBGIHKPECCO(BHKOFHMDACN());
			}
			return GKFHINBFBEO(EDDNOJDPMCF.magnitude);
		}

		private BigInteger GKFHINBFBEO(int[] NOCENLMKBDO)
		{
			int[] array;
			int[] array2;
			if (magnitude.Length < NOCENLMKBDO.Length)
			{
				array = NOCENLMKBDO;
				array2 = magnitude;
			}
			else
			{
				array = magnitude;
				array2 = NOCENLMKBDO;
			}
			uint num = uint.MaxValue;
			if (array.Length == array2.Length)
			{
				num -= (uint)array2[0];
			}
			bool flag = (uint)array[0] >= num;
			int[] array3;
			if (flag)
			{
				array3 = new int[array.Length + 1];
				array.CopyTo(array3, 1);
			}
			else
			{
				array3 = (int[])array.Clone();
			}
			array3 = LNKPBOLNCFM(array3, array2);
			return new BigInteger(sign, array3, flag);
		}

		public BigInteger HLHOJGNJFDN(BigInteger EDDNOJDPMCF)
		{
			if (sign == 0 || EDDNOJDPMCF.sign == 0)
			{
				return Zero;
			}
			int[] array = ((sign <= 0) ? JEACJNAKLDJ(One).magnitude : magnitude);
			int[] array2 = ((EDDNOJDPMCF.sign <= 0) ? EDDNOJDPMCF.JEACJNAKLDJ(One).magnitude : EDDNOJDPMCF.magnitude);
			bool flag = sign < 0 && EDDNOJDPMCF.sign < 0;
			int num = System.Math.Max(array.Length, array2.Length);
			int[] array3 = new int[num];
			int num2 = array3.Length - array.Length;
			int num3 = array3.Length - array2.Length;
			for (int i = 0; i < array3.Length; i++)
			{
				int num4 = ((i >= num2) ? array[i - num2] : 0);
				int num5 = ((i >= num3) ? array2[i - num3] : 0);
				if (sign < 0)
				{
					num4 = ~num4;
				}
				if (EDDNOJDPMCF.sign < 0)
				{
					num5 = ~num5;
				}
				array3[i] = num4 & num5;
				if (flag)
				{
					array3[i] = ~array3[i];
				}
			}
			BigInteger bigInteger = new BigInteger(1, array3, true);
			if (flag)
			{
				bigInteger = bigInteger.BEHECEMIINM();
			}
			return bigInteger;
		}

		public BigInteger NLNJIKHBMAF(BigInteger HIMINGHNIKN)
		{
			return HLHOJGNJFDN(HIMINGHNIKN.BEHECEMIINM());
		}

		public static int BDEANGAKHFK(int PLCFEOMGCFK)
		{
			uint num = (uint)PLCFEOMGCFK;
			num -= (num >> 1) & 0x55555555;
			num = (num & 0x33333333) + ((num >> 2) & 0x33333333);
			num = (num + (num >> 4)) & 0xF0F0F0Fu;
			num += num >> 8;
			num += num >> 16;
			return (int)(num & 0x3F);
		}

		private static int KJIJBIEHLPH(int HLPFJFPGPKE, int EPHPFLJOBDN, int[] OHPENDELFKK)
		{
			while (true)
			{
				if (EPHPFLJOBDN >= OHPENDELFKK.Length)
				{
					return 0;
				}
				if (OHPENDELFKK[EPHPFLJOBDN] != 0)
				{
					break;
				}
				EPHPFLJOBDN++;
			}
			int num = 32 * (OHPENDELFKK.Length - EPHPFLJOBDN - 1);
			int num2 = OHPENDELFKK[EPHPFLJOBDN];
			num += DPLNBDLKNDE(num2);
			if (HLPFJFPGPKE < 0 && (num2 & -num2) == num2)
			{
				do
				{
					if (++EPHPFLJOBDN >= OHPENDELFKK.Length)
					{
						num--;
						break;
					}
				}
				while (OHPENDELFKK[EPHPFLJOBDN] == 0);
			}
			return num;
		}

		internal static int DPLNBDLKNDE(int PHFLBLJJMLI)
		{
			uint num = (uint)PHFLBLJJMLI >> 24;
			if (num != 0)
			{
				return 24 + BitLengthTable[num];
			}
			num = (uint)PHFLBLJJMLI >> 16;
			if (num != 0)
			{
				return 16 + BitLengthTable[num];
			}
			num = (uint)PHFLBLJJMLI >> 8;
			if (num != 0)
			{
				return 8 + BitLengthTable[num];
			}
			return BitLengthTable[PHFLBLJJMLI];
		}

		private bool IACIHDCOCDI()
		{
			return sign > 0 && nBits == 1;
		}

		public int JLPDKNFCNPO(object NEMEKIOEOLC)
		{
			return JLPDKNFCNPO((BigInteger)NEMEKIOEOLC);
		}

		private static int JLPDKNFCNPO(int GNLHEABEMBM, int[] AMFCENFNAJJ, int JJEBHHICNKP, int[] CNLILOEEBOJ)
		{
			while (GNLHEABEMBM != AMFCENFNAJJ.Length && AMFCENFNAJJ[GNLHEABEMBM] == 0)
			{
				GNLHEABEMBM++;
			}
			while (JJEBHHICNKP != CNLILOEEBOJ.Length && CNLILOEEBOJ[JJEBHHICNKP] == 0)
			{
				JJEBHHICNKP++;
			}
			return LNBNCEKLAHL(GNLHEABEMBM, AMFCENFNAJJ, JJEBHHICNKP, CNLILOEEBOJ);
		}

		private static int LNBNCEKLAHL(int GNLHEABEMBM, int[] AMFCENFNAJJ, int JJEBHHICNKP, int[] CNLILOEEBOJ)
		{
			int num = AMFCENFNAJJ.Length - CNLILOEEBOJ.Length - (GNLHEABEMBM - JJEBHHICNKP);
			if (num != 0)
			{
				return (num >= 0) ? 1 : (-1);
			}
			while (GNLHEABEMBM < AMFCENFNAJJ.Length)
			{
				uint num2 = (uint)AMFCENFNAJJ[GNLHEABEMBM++];
				uint num3 = (uint)CNLILOEEBOJ[JJEBHHICNKP++];
				if (num2 != num3)
				{
					return (num2 >= num3) ? 1 : (-1);
				}
			}
			return 0;
		}

		public int JLPDKNFCNPO(BigInteger EDDNOJDPMCF)
		{
			return (sign < EDDNOJDPMCF.sign) ? (-1) : ((sign > EDDNOJDPMCF.sign) ? 1 : ((sign != 0) ? (sign * LNBNCEKLAHL(0, magnitude, 0, EDDNOJDPMCF.magnitude)) : 0));
		}

		private int[] MCPDGENJCDB(int[] AMFCENFNAJJ, int[] CNLILOEEBOJ)
		{
			int i;
			for (i = 0; i < AMFCENFNAJJ.Length && AMFCENFNAJJ[i] == 0; i++)
			{
			}
			int j;
			for (j = 0; j < CNLILOEEBOJ.Length && CNLILOEEBOJ[j] == 0; j++)
			{
			}
			int num = LNBNCEKLAHL(i, AMFCENFNAJJ, j, CNLILOEEBOJ);
			int[] array3;
			if (num > 0)
			{
				int num2 = KJIJBIEHLPH(1, j, CNLILOEEBOJ);
				int num3 = KJIJBIEHLPH(1, i, AMFCENFNAJJ);
				int num4 = num3 - num2;
				int k = 0;
				int l = 0;
				int num5 = num2;
				int[] array;
				int[] array2;
				if (num4 > 0)
				{
					array = new int[(num4 >> 5) + 1];
					array[0] = 1 << num4 % 32;
					array2 = DOKHFLENGLF(CNLILOEEBOJ, num4);
					num5 += num4;
				}
				else
				{
					array = new int[1] { 1 };
					int num6 = CNLILOEEBOJ.Length - j;
					array2 = new int[num6];
					Array.Copy(CNLILOEEBOJ, j, array2, 0, num6);
				}
				array3 = new int[array.Length];
				while (true)
				{
					if (num5 < num3 || LNBNCEKLAHL(i, AMFCENFNAJJ, l, array2) >= 0)
					{
						FBGIHKPECCO(i, AMFCENFNAJJ, l, array2);
						LNKPBOLNCFM(array3, array);
						while (AMFCENFNAJJ[i] == 0)
						{
							if (++i == AMFCENFNAJJ.Length)
							{
								return array3;
							}
						}
						num3 = 32 * (AMFCENFNAJJ.Length - i - 1) + DPLNBDLKNDE(AMFCENFNAJJ[i]);
						if (num3 <= num2)
						{
							if (num3 < num2)
							{
								return array3;
							}
							num = LNBNCEKLAHL(i, AMFCENFNAJJ, j, CNLILOEEBOJ);
							if (num <= 0)
							{
								break;
							}
						}
					}
					num4 = num5 - num3;
					if (num4 == 1)
					{
						uint num7 = (uint)array2[l] >> 1;
						uint num8 = (uint)AMFCENFNAJJ[i];
						if (num7 > num8)
						{
							num4++;
						}
					}
					if (num4 < 2)
					{
						AOPINMPIMLO(l, array2);
						num5--;
						AOPINMPIMLO(k, array);
					}
					else
					{
						HBEHPNPAGIH(l, array2, num4);
						num5 -= num4;
						HBEHPNPAGIH(k, array, num4);
					}
					for (; array2[l] == 0; l++)
					{
					}
					for (; array[k] == 0; k++)
					{
					}
				}
			}
			else
			{
				array3 = new int[1];
			}
			if (num == 0)
			{
				LNKPBOLNCFM(array3, One.magnitude);
				Array.Clear(AMFCENFNAJJ, i, AMFCENFNAJJ.Length - i);
			}
			return array3;
		}

		public BigInteger MCPDGENJCDB(BigInteger HIMINGHNIKN)
		{
			if (HIMINGHNIKN.sign == 0)
			{
				throw new ArithmeticException("Division by zero error");
			}
			if (sign == 0)
			{
				return Zero;
			}
			if (HIMINGHNIKN.IACIHDCOCDI())
			{
				BigInteger bigInteger = DKGOFCBJBPB().ABOIOKBIANB(HIMINGHNIKN.DKGOFCBJBPB().BitLength - 1);
				return (HIMINGHNIKN.sign != sign) ? bigInteger.BHKOFHMDACN() : bigInteger;
			}
			int[] aMFCENFNAJJ = (int[])magnitude.Clone();
			return new BigInteger(sign * HIMINGHNIKN.sign, MCPDGENJCDB(aMFCENFNAJJ, HIMINGHNIKN.magnitude), true);
		}

		public BigInteger[] BKPFNGBMONE(BigInteger HIMINGHNIKN)
		{
			if (HIMINGHNIKN.sign == 0)
			{
				throw new ArithmeticException("Division by zero error");
			}
			BigInteger[] array = new BigInteger[2];
			if (sign == 0)
			{
				array[0] = Zero;
				array[1] = Zero;
			}
			else if (HIMINGHNIKN.IACIHDCOCDI())
			{
				int iDHLPOFDLKJ = HIMINGHNIKN.DKGOFCBJBPB().BitLength - 1;
				BigInteger bigInteger = DKGOFCBJBPB().ABOIOKBIANB(iDHLPOFDLKJ);
				int[] oHPENDELFKK = ELMNCKKJAJJ(iDHLPOFDLKJ);
				array[0] = ((HIMINGHNIKN.sign != sign) ? bigInteger.BHKOFHMDACN() : bigInteger);
				array[1] = new BigInteger(sign, oHPENDELFKK, true);
			}
			else
			{
				int[] array2 = (int[])magnitude.Clone();
				int[] oHPENDELFKK2 = MCPDGENJCDB(array2, HIMINGHNIKN.magnitude);
				array[0] = new BigInteger(sign * HIMINGHNIKN.sign, oHPENDELFKK2, true);
				array[1] = new BigInteger(sign, array2, true);
			}
			return array;
		}

		public override bool Equals(object NEMEKIOEOLC)
		{
			if (NEMEKIOEOLC == this)
			{
				return true;
			}
			BigInteger bigInteger = NEMEKIOEOLC as BigInteger;
			if (bigInteger == null)
			{
				return false;
			}
			return sign == bigInteger.sign && PMPMBPAMGBF(bigInteger);
		}

		private bool PMPMBPAMGBF(BigInteger AMFCENFNAJJ)
		{
			if (magnitude.Length != AMFCENFNAJJ.magnitude.Length)
			{
				return false;
			}
			for (int i = 0; i < magnitude.Length; i++)
			{
				if (magnitude[i] != AMFCENFNAJJ.magnitude[i])
				{
					return false;
				}
			}
			return true;
		}

		public BigInteger LBDAFCOKNPE(BigInteger EDDNOJDPMCF)
		{
			if (EDDNOJDPMCF.sign == 0)
			{
				return DKGOFCBJBPB();
			}
			if (sign == 0)
			{
				return EDDNOJDPMCF.DKGOFCBJBPB();
			}
			BigInteger bigInteger = this;
			BigInteger bigInteger2 = EDDNOJDPMCF;
			while (bigInteger2.sign != 0)
			{
				BigInteger bigInteger3 = bigInteger.MODIHOCEKBK(bigInteger2);
				bigInteger = bigInteger2;
				bigInteger2 = bigInteger3;
			}
			return bigInteger;
		}

		public override int GetHashCode()
		{
			int num = magnitude.Length;
			if (magnitude.Length > 0)
			{
				num ^= magnitude[0];
				if (magnitude.Length > 1)
				{
					num ^= magnitude[magnitude.Length - 1];
				}
			}
			return (sign >= 0) ? num : (~num);
		}

		private BigInteger CKIHMFAAHLM()
		{
			if (sign == 0)
			{
				return One;
			}
			if (sign < 0)
			{
				return new BigInteger(-1, BJGEABPAABH(magnitude, One.magnitude), true);
			}
			return GKFHINBFBEO(One.magnitude);
		}

		public bool LKECIHLDEIP(int CFGADBIOJFG)
		{
			return LKECIHLDEIP(CFGADBIOJFG, false);
		}

		internal bool LKECIHLDEIP(int CFGADBIOJFG, bool OMGIJINKKNN)
		{
			if (CFGADBIOJFG <= 0)
			{
				return true;
			}
			BigInteger bigInteger = DKGOFCBJBPB();
			if (!bigInteger.NJHNJHGDCIJ(0))
			{
				return bigInteger.Equals(Two);
			}
			if (bigInteger.Equals(One))
			{
				return false;
			}
			return bigInteger.GADFMFMICHO(CFGADBIOJFG, RandomSource, OMGIJINKKNN);
		}

		private bool GADFMFMICHO(int CFGADBIOJFG, Random GECCLOFELEC, bool OMGIJINKKNN)
		{
			int num = System.Math.Min(BitLength - 1, primeLists.Length);
			for (int i = 0; i < num; i++)
			{
				int num2 = FGLDMFGEDAD(primeProducts[i]);
				int[] array = primeLists[i];
				foreach (int num3 in array)
				{
					if (num2 % num3 == 0)
					{
						return BitLength < 16 && IntValue == num3;
					}
				}
			}
			return GPDICEJKJAN(CFGADBIOJFG, GECCLOFELEC, OMGIJINKKNN);
		}

		public bool GPDICEJKJAN(int CFGADBIOJFG, Random GECCLOFELEC)
		{
			return GPDICEJKJAN(CFGADBIOJFG, GECCLOFELEC, false);
		}

		internal bool GPDICEJKJAN(int CFGADBIOJFG, Random GECCLOFELEC, bool OMGIJINKKNN)
		{
			int bitLength = BitLength;
			int num = (CFGADBIOJFG - 1) / 2 + 1;
			if (OMGIJINKKNN)
			{
				int num2 = ((bitLength >= 1024) ? 4 : ((bitLength >= 512) ? 8 : ((bitLength < 256) ? 50 : 16)));
				if (CFGADBIOJFG < 100)
				{
					num = System.Math.Min(num2, num);
				}
				else
				{
					num -= 50;
					num += num2;
				}
			}
			int num3 = CHHBPPGOHBP(-2);
			BigInteger eKFOKNPODBK = ABOIOKBIANB(num3);
			BigInteger bigInteger = One.DOKHFLENGLF(32 * magnitude.Length).FGLDMFGEDAD(this);
			BigInteger bigInteger2 = FBGIHKPECCO(bigInteger);
			while (true)
			{
				BigInteger bigInteger3 = new BigInteger(BitLength, GECCLOFELEC);
				if (bigInteger3.sign == 0 || bigInteger3.JLPDKNFCNPO(this) >= 0 || bigInteger3.PMPMBPAMGBF(bigInteger) || bigInteger3.PMPMBPAMGBF(bigInteger2))
				{
					continue;
				}
				BigInteger bigInteger4 = ICLAEHLBPHK(bigInteger3, eKFOKNPODBK, this, false);
				if (!bigInteger4.Equals(bigInteger))
				{
					int num4 = 0;
					while (!bigInteger4.Equals(bigInteger2))
					{
						if (++num4 == num3)
						{
							return false;
						}
						bigInteger4 = ICLAEHLBPHK(bigInteger4, Two, this, false);
						if (bigInteger4.Equals(bigInteger))
						{
							return false;
						}
					}
				}
				if (--num <= 0)
				{
					break;
				}
			}
			return true;
		}

		public BigInteger HOACPDEKNMK(BigInteger EDDNOJDPMCF)
		{
			return (JLPDKNFCNPO(EDDNOJDPMCF) <= 0) ? EDDNOJDPMCF : this;
		}

		public BigInteger CLNHKLFJKHH(BigInteger EDDNOJDPMCF)
		{
			return (JLPDKNFCNPO(EDDNOJDPMCF) >= 0) ? EDDNOJDPMCF : this;
		}

		public BigInteger MODIHOCEKBK(BigInteger CEKMAJAHNAG)
		{
			if (CEKMAJAHNAG.sign < 1)
			{
				throw new ArithmeticException("Modulus must be positive");
			}
			BigInteger bigInteger = FGLDMFGEDAD(CEKMAJAHNAG);
			return (bigInteger.sign < 0) ? bigInteger.JEACJNAKLDJ(CEKMAJAHNAG) : bigInteger;
		}

		public BigInteger DDENLEMHHAM(BigInteger CEKMAJAHNAG)
		{
			if (CEKMAJAHNAG.sign < 1)
			{
				throw new ArithmeticException("Modulus must be positive");
			}
			if (CEKMAJAHNAG.IACIHDCOCDI())
			{
				return MKIHOGIPDME(CEKMAJAHNAG);
			}
			BigInteger mNIMEAMHNMI = FGLDMFGEDAD(CEKMAJAHNAG);
			BigInteger BOMGHCPINNB;
			BigInteger bigInteger = KOPJDOBEHHK(mNIMEAMHNMI, CEKMAJAHNAG, out BOMGHCPINNB);
			if (!bigInteger.Equals(One))
			{
				throw new ArithmeticException("Numbers not relatively prime.");
			}
			if (BOMGHCPINNB.sign < 0)
			{
				return BOMGHCPINNB.JEACJNAKLDJ(CEKMAJAHNAG);
			}
			return BOMGHCPINNB;
		}

		private BigInteger MKIHOGIPDME(BigInteger CEKMAJAHNAG)
		{
			if (!NJHNJHGDCIJ(0))
			{
				throw new ArithmeticException("Numbers not relatively prime.");
			}
			int num = CEKMAJAHNAG.BitLength - 1;
			long num2 = BIEGHJJIGJH(LongValue);
			if (num < 64)
			{
				num2 &= (1L << num) - 1;
			}
			BigInteger bigInteger = AGLOJCOAJIK(num2);
			if (num > 64)
			{
				BigInteger hIMINGHNIKN = FGLDMFGEDAD(CEKMAJAHNAG);
				int num3 = 64;
				do
				{
					BigInteger iDHLPOFDLKJ = bigInteger.IBJBIGNPNEM(hIMINGHNIKN).FGLDMFGEDAD(CEKMAJAHNAG);
					bigInteger = bigInteger.IBJBIGNPNEM(Two.FBGIHKPECCO(iDHLPOFDLKJ)).FGLDMFGEDAD(CEKMAJAHNAG);
					num3 <<= 1;
				}
				while (num3 < num);
			}
			if (bigInteger.sign < 0)
			{
				bigInteger = bigInteger.JEACJNAKLDJ(CEKMAJAHNAG);
			}
			return bigInteger;
		}

		private static int AEDHCBGINKA(int ELNCCDELMMH)
		{
			int num = ELNCCDELMMH + (((ELNCCDELMMH + 1) & 4) << 1);
			num *= 2 - ELNCCDELMMH * num;
			num *= 2 - ELNCCDELMMH * num;
			return num * (2 - ELNCCDELMMH * num);
		}

		private static long BIEGHJJIGJH(long ELNCCDELMMH)
		{
			long num = ELNCCDELMMH + (((ELNCCDELMMH + 1) & 4) << 1);
			num *= 2 - ELNCCDELMMH * num;
			num *= 2 - ELNCCDELMMH * num;
			num *= 2 - ELNCCDELMMH * num;
			return num * (2 - ELNCCDELMMH * num);
		}

		private static BigInteger KOPJDOBEHHK(BigInteger MNIMEAMHNMI, BigInteger BCIHLCMFAEK, out BigInteger BOMGHCPINNB)
		{
			BigInteger bigInteger = One;
			BigInteger bigInteger2 = Zero;
			BigInteger bigInteger3 = MNIMEAMHNMI;
			BigInteger bigInteger4 = BCIHLCMFAEK;
			if (bigInteger4.sign > 0)
			{
				while (true)
				{
					BigInteger[] array = bigInteger3.BKPFNGBMONE(bigInteger4);
					bigInteger3 = bigInteger4;
					bigInteger4 = array[1];
					BigInteger bigInteger5 = bigInteger;
					bigInteger = bigInteger2;
					if (bigInteger4.sign <= 0)
					{
						break;
					}
					bigInteger2 = bigInteger5.FBGIHKPECCO(bigInteger2.IBJBIGNPNEM(array[0]));
				}
			}
			BOMGHCPINNB = bigInteger;
			return bigInteger3;
		}

		private static void BGHDCHPLJMM(int[] AMFCENFNAJJ)
		{
			Array.Clear(AMFCENFNAJJ, 0, AMFCENFNAJJ.Length);
		}

		public BigInteger ICEOCBALAGC(BigInteger EKFOKNPODBK, BigInteger CEKMAJAHNAG)
		{
			if (CEKMAJAHNAG.sign < 1)
			{
				throw new ArithmeticException("Modulus must be positive");
			}
			if (CEKMAJAHNAG.Equals(One))
			{
				return Zero;
			}
			if (EKFOKNPODBK.sign == 0)
			{
				return One;
			}
			if (sign == 0)
			{
				return Zero;
			}
			bool flag = EKFOKNPODBK.sign < 0;
			if (flag)
			{
				EKFOKNPODBK = EKFOKNPODBK.BHKOFHMDACN();
			}
			BigInteger bigInteger = MODIHOCEKBK(CEKMAJAHNAG);
			if (!EKFOKNPODBK.Equals(One))
			{
				bigInteger = ((((uint)CEKMAJAHNAG.magnitude[CEKMAJAHNAG.magnitude.Length - 1] & (true ? 1u : 0u)) != 0) ? ICLAEHLBPHK(bigInteger, EKFOKNPODBK, CEKMAJAHNAG, true) : EAFPGJKEJAL(bigInteger, EKFOKNPODBK, CEKMAJAHNAG));
			}
			if (flag)
			{
				bigInteger = bigInteger.DDENLEMHHAM(CEKMAJAHNAG);
			}
			return bigInteger;
		}

		private static BigInteger EAFPGJKEJAL(BigInteger BCIHLCMFAEK, BigInteger EKFOKNPODBK, BigInteger CEKMAJAHNAG)
		{
			int num = CEKMAJAHNAG.magnitude.Length;
			BigInteger aIMMMDFLKAG = One.DOKHFLENGLF(num + 1 << 5);
			BigInteger bLKBGCBLJHC = One.DOKHFLENGLF(num << 6).MCPDGENJCDB(CEKMAJAHNAG);
			int i = 0;
			for (int bitLength = EKFOKNPODBK.BitLength; bitLength > ExpWindowThresholds[i]; i++)
			{
			}
			int num2 = 1 << i;
			BigInteger[] array = new BigInteger[num2];
			array[0] = BCIHLCMFAEK;
			BigInteger bigInteger = AEIODJIIOOI(BCIHLCMFAEK.MIOEHGDPGAG(), CEKMAJAHNAG, aIMMMDFLKAG, bLKBGCBLJHC);
			for (int j = 1; j < num2; j++)
			{
				array[j] = AEIODJIIOOI(array[j - 1].IBJBIGNPNEM(bigInteger), CEKMAJAHNAG, aIMMMDFLKAG, bLKBGCBLJHC);
			}
			int[] array2 = MPMACFLCEKD(EKFOKNPODBK.magnitude, i);
			int num3 = array2[0];
			int num4 = num3 & 0xFF;
			int num5 = num3 >> 8;
			BigInteger bigInteger2;
			if (num4 == 1)
			{
				bigInteger2 = bigInteger;
				num5--;
			}
			else
			{
				bigInteger2 = array[num4 >> 1];
			}
			int num6 = 1;
			while ((num3 = array2[num6++]) != -1)
			{
				num4 = num3 & 0xFF;
				int num7 = num5 + BitLengthTable[num4];
				for (int k = 0; k < num7; k++)
				{
					bigInteger2 = AEIODJIIOOI(bigInteger2.MIOEHGDPGAG(), CEKMAJAHNAG, aIMMMDFLKAG, bLKBGCBLJHC);
				}
				bigInteger2 = AEIODJIIOOI(bigInteger2.IBJBIGNPNEM(array[num4 >> 1]), CEKMAJAHNAG, aIMMMDFLKAG, bLKBGCBLJHC);
				num5 = num3 >> 8;
			}
			for (int l = 0; l < num5; l++)
			{
				bigInteger2 = AEIODJIIOOI(bigInteger2.MIOEHGDPGAG(), CEKMAJAHNAG, aIMMMDFLKAG, bLKBGCBLJHC);
			}
			return bigInteger2;
		}

		private static BigInteger AEIODJIIOOI(BigInteger AMFCENFNAJJ, BigInteger CEKMAJAHNAG, BigInteger AIMMMDFLKAG, BigInteger BLKBGCBLJHC)
		{
			int bitLength = AMFCENFNAJJ.BitLength;
			int bitLength2 = CEKMAJAHNAG.BitLength;
			if (bitLength < bitLength2)
			{
				return AMFCENFNAJJ;
			}
			if (bitLength - bitLength2 > 1)
			{
				int num = CEKMAJAHNAG.magnitude.Length;
				BigInteger bigInteger = AMFCENFNAJJ.JBFLJPFDHHP(num - 1);
				BigInteger bigInteger2 = bigInteger.IBJBIGNPNEM(BLKBGCBLJHC);
				BigInteger bigInteger3 = bigInteger2.JBFLJPFDHHP(num + 1);
				BigInteger bigInteger4 = AMFCENFNAJJ.KPLFKHFBNHJ(num + 1);
				BigInteger bigInteger5 = bigInteger3.IBJBIGNPNEM(CEKMAJAHNAG);
				BigInteger iDHLPOFDLKJ = bigInteger5.KPLFKHFBNHJ(num + 1);
				AMFCENFNAJJ = bigInteger4.FBGIHKPECCO(iDHLPOFDLKJ);
				if (AMFCENFNAJJ.sign < 0)
				{
					AMFCENFNAJJ = AMFCENFNAJJ.JEACJNAKLDJ(AIMMMDFLKAG);
				}
			}
			while (AMFCENFNAJJ.JLPDKNFCNPO(CEKMAJAHNAG) >= 0)
			{
				AMFCENFNAJJ = AMFCENFNAJJ.FBGIHKPECCO(CEKMAJAHNAG);
			}
			return AMFCENFNAJJ;
		}

		private static BigInteger ICLAEHLBPHK(BigInteger BCIHLCMFAEK, BigInteger EKFOKNPODBK, BigInteger CEKMAJAHNAG, bool LLGNJFDKOCJ)
		{
			int num = CEKMAJAHNAG.magnitude.Length;
			int num2 = 32 * num;
			bool flag = CEKMAJAHNAG.BitLength + 2 <= num2;
			uint cLJLEJDBFKN = (uint)CEKMAJAHNAG.HMNIFDELBKE();
			if (LLGNJFDKOCJ)
			{
				BCIHLCMFAEK = BCIHLCMFAEK.DOKHFLENGLF(num2).FGLDMFGEDAD(CEKMAJAHNAG);
			}
			int[] mNIMEAMHNMI = new int[num + 1];
			int[] array = BCIHLCMFAEK.magnitude;
			if (array.Length < num)
			{
				int[] array2 = new int[num];
				array.CopyTo(array2, num - array.Length);
				array = array2;
			}
			int i = 0;
			if (EKFOKNPODBK.magnitude.Length > 1 || EKFOKNPODBK.BitCount > 2)
			{
				for (int bitLength = EKFOKNPODBK.BitLength; bitLength > ExpWindowThresholds[i]; i++)
				{
				}
			}
			int num3 = 1 << i;
			int[][] array3 = new int[num3][];
			array3[0] = array;
			int[] array4 = NOGCEBKPPJE.IKBFGGABMKP(array);
			ILCAOJPPACB(mNIMEAMHNMI, array4, CEKMAJAHNAG.magnitude, cLJLEJDBFKN, flag);
			for (int j = 1; j < num3; j++)
			{
				array3[j] = NOGCEBKPPJE.IKBFGGABMKP(array3[j - 1]);
				IFFDKABGHBJ(mNIMEAMHNMI, array3[j], array4, CEKMAJAHNAG.magnitude, cLJLEJDBFKN, flag);
			}
			int[] array5 = MPMACFLCEKD(EKFOKNPODBK.magnitude, i);
			int num4 = array5[0];
			int num5 = num4 & 0xFF;
			int num6 = num4 >> 8;
			int[] array6;
			if (num5 == 1)
			{
				array6 = array4;
				num6--;
			}
			else
			{
				array6 = NOGCEBKPPJE.IKBFGGABMKP(array3[num5 >> 1]);
			}
			int num7 = 1;
			while ((num4 = array5[num7++]) != -1)
			{
				num5 = num4 & 0xFF;
				int num8 = num6 + BitLengthTable[num5];
				for (int k = 0; k < num8; k++)
				{
					ILCAOJPPACB(mNIMEAMHNMI, array6, CEKMAJAHNAG.magnitude, cLJLEJDBFKN, flag);
				}
				IFFDKABGHBJ(mNIMEAMHNMI, array6, array3[num5 >> 1], CEKMAJAHNAG.magnitude, cLJLEJDBFKN, flag);
				num6 = num4 >> 8;
			}
			for (int l = 0; l < num6; l++)
			{
				ILCAOJPPACB(mNIMEAMHNMI, array6, CEKMAJAHNAG.magnitude, cLJLEJDBFKN, flag);
			}
			if (LLGNJFDKOCJ)
			{
				GABJKEOAIHO(array6, CEKMAJAHNAG.magnitude, cLJLEJDBFKN);
			}
			else if (flag && JLPDKNFCNPO(0, array6, 0, CEKMAJAHNAG.magnitude) >= 0)
			{
				FBGIHKPECCO(0, array6, 0, CEKMAJAHNAG.magnitude);
			}
			return new BigInteger(1, array6, true);
		}

		private static int[] MPMACFLCEKD(int[] OHPENDELFKK, int CDFFGHBGEFP)
		{
			int num = OHPENDELFKK[0];
			int num2 = DPLNBDLKNDE(num);
			int num3 = ((OHPENDELFKK.Length - 1 << 5) + num2) / (1 + CDFFGHBGEFP) + 2;
			int[] array = new int[num3];
			int num4 = 0;
			int num5 = 33 - num2;
			num <<= num5;
			int num6 = 1;
			int num7 = 1 << CDFFGHBGEFP;
			int num8 = 0;
			int num9 = 0;
			while (true)
			{
				if (num5 < 32)
				{
					if (num6 < num7)
					{
						num6 = (num6 << 1) | (int)((uint)num >> 31);
					}
					else if (num < 0)
					{
						array[num4++] = EKBLOFKEILH(num6, num8);
						num6 = 1;
						num8 = 0;
					}
					else
					{
						num8++;
					}
					num <<= 1;
					num5++;
				}
				else
				{
					if (++num9 == OHPENDELFKK.Length)
					{
						break;
					}
					num = OHPENDELFKK[num9];
					num5 = 0;
				}
			}
			array[num4++] = EKBLOFKEILH(num6, num8);
			array[num4] = -1;
			return array;
		}

		private static int EKBLOFKEILH(int GJCJDDKPJEP, int KCBLBLAELML)
		{
			while ((GJCJDDKPJEP & 1) == 0)
			{
				GJCJDDKPJEP >>= 1;
				KCBLBLAELML++;
			}
			return GJCJDDKPJEP | (KCBLBLAELML << 8);
		}

		private static int[] MIOEHGDPGAG(int[] PHFLBLJJMLI, int[] AMFCENFNAJJ)
		{
			int num = PHFLBLJJMLI.Length - 1;
			ulong num4;
			for (int num2 = AMFCENFNAJJ.Length - 1; num2 > 0; num2--)
			{
				ulong num3 = (uint)AMFCENFNAJJ[num2];
				num4 = num3 * num3 + (uint)PHFLBLJJMLI[num];
				PHFLBLJJMLI[num] = (int)num4;
				num4 >>= 32;
				for (int num5 = num2 - 1; num5 >= 0; num5--)
				{
					ulong num6 = num3 * (uint)AMFCENFNAJJ[num5];
					num4 += ((ulong)(uint)PHFLBLJJMLI[--num] & 0xFFFFFFFFuL) + (uint)((int)num6 << 1);
					PHFLBLJJMLI[num] = (int)num4;
					num4 = (num4 >> 32) + (num6 >> 31);
				}
				num4 += (uint)PHFLBLJJMLI[--num];
				PHFLBLJJMLI[num] = (int)num4;
				if (--num >= 0)
				{
					PHFLBLJJMLI[num] = (int)(num4 >> 32);
				}
				num += num2;
			}
			num4 = (uint)AMFCENFNAJJ[0];
			num4 = num4 * num4 + (uint)PHFLBLJJMLI[num];
			PHFLBLJJMLI[num] = (int)num4;
			if (--num >= 0)
			{
				PHFLBLJJMLI[num] += (int)(num4 >> 32);
			}
			return PHFLBLJJMLI;
		}

		private static int[] IBJBIGNPNEM(int[] AMFCENFNAJJ, int[] CNLILOEEBOJ, int[] IGNEOOOFEMO)
		{
			int num = IGNEOOOFEMO.Length;
			if (num < 1)
			{
				return AMFCENFNAJJ;
			}
			int num2 = AMFCENFNAJJ.Length - CNLILOEEBOJ.Length;
			do
			{
				long num3 = IGNEOOOFEMO[--num] & 0xFFFFFFFFu;
				long num4 = 0L;
				if (num3 != 0)
				{
					for (int num5 = CNLILOEEBOJ.Length - 1; num5 >= 0; num5--)
					{
						num4 += num3 * (CNLILOEEBOJ[num5] & 0xFFFFFFFFu) + (AMFCENFNAJJ[num2 + num5] & 0xFFFFFFFFu);
						AMFCENFNAJJ[num2 + num5] = (int)num4;
						num4 = (long)((ulong)num4 >> 32);
					}
				}
				num2--;
				if (num2 >= 0)
				{
					AMFCENFNAJJ[num2] = (int)num4;
				}
			}
			while (num > 0);
			return AMFCENFNAJJ;
		}

		private int HMNIFDELBKE()
		{
			if (mQuote != 0)
			{
				return mQuote;
			}
			int eLNCCDELMMH = -magnitude[magnitude.Length - 1];
			return mQuote = AEDHCBGINKA(eLNCCDELMMH);
		}

		private static void GABJKEOAIHO(int[] AMFCENFNAJJ, int[] CEKMAJAHNAG, uint CLJLEJDBFKN)
		{
			int num = CEKMAJAHNAG.Length;
			for (int num2 = num - 1; num2 >= 0; num2--)
			{
				uint num3 = (uint)AMFCENFNAJJ[num - 1];
				ulong num4 = num3 * CLJLEJDBFKN;
				ulong num5 = num4 * (uint)CEKMAJAHNAG[num - 1] + num3;
				num5 >>= 32;
				for (int num6 = num - 2; num6 >= 0; num6--)
				{
					num5 += num4 * (uint)CEKMAJAHNAG[num6] + (uint)AMFCENFNAJJ[num6];
					AMFCENFNAJJ[num6 + 1] = (int)num5;
					num5 >>= 32;
				}
				AMFCENFNAJJ[0] = (int)num5;
			}
			if (JLPDKNFCNPO(0, AMFCENFNAJJ, 0, CEKMAJAHNAG) >= 0)
			{
				FBGIHKPECCO(0, AMFCENFNAJJ, 0, CEKMAJAHNAG);
			}
		}

		private static void IFFDKABGHBJ(int[] MNIMEAMHNMI, int[] AMFCENFNAJJ, int[] CNLILOEEBOJ, int[] CEKMAJAHNAG, uint CLJLEJDBFKN, bool LMMMMCGKIFK)
		{
			int num = CEKMAJAHNAG.Length;
			if (num == 1)
			{
				AMFCENFNAJJ[0] = (int)FJBOGKCHKLB((uint)AMFCENFNAJJ[0], (uint)CNLILOEEBOJ[0], (uint)CEKMAJAHNAG[0], CLJLEJDBFKN);
				return;
			}
			uint num2 = (uint)CNLILOEEBOJ[num - 1];
			ulong num3 = (uint)AMFCENFNAJJ[num - 1];
			ulong num4 = num3 * num2;
			ulong num5 = (uint)(int)num4 * CLJLEJDBFKN;
			ulong num6 = num5 * (uint)CEKMAJAHNAG[num - 1];
			num4 += (uint)num6;
			num4 = (num4 >> 32) + (num6 >> 32);
			for (int num7 = num - 2; num7 >= 0; num7--)
			{
				ulong num8 = num3 * (uint)CNLILOEEBOJ[num7];
				num6 = num5 * (uint)CEKMAJAHNAG[num7];
				num4 += (num8 & 0xFFFFFFFFu) + (uint)num6;
				MNIMEAMHNMI[num7 + 2] = (int)num4;
				num4 = (num4 >> 32) + (num8 >> 32) + (num6 >> 32);
			}
			MNIMEAMHNMI[1] = (int)num4;
			int num9 = (int)(num4 >> 32);
			for (int num10 = num - 2; num10 >= 0; num10--)
			{
				uint num11 = (uint)MNIMEAMHNMI[num];
				ulong num12 = (uint)AMFCENFNAJJ[num10];
				ulong num13 = num12 * num2;
				ulong num14 = (num13 & 0xFFFFFFFFu) + num11;
				ulong num15 = (uint)(int)num14 * CLJLEJDBFKN;
				ulong num16 = num15 * (uint)CEKMAJAHNAG[num - 1];
				num14 += (uint)num16;
				num14 = (num14 >> 32) + (num13 >> 32) + (num16 >> 32);
				for (int num17 = num - 2; num17 >= 0; num17--)
				{
					num13 = num12 * (uint)CNLILOEEBOJ[num17];
					num16 = num15 * (uint)CEKMAJAHNAG[num17];
					num14 += (num13 & 0xFFFFFFFFu) + (uint)num16 + (uint)MNIMEAMHNMI[num17 + 1];
					MNIMEAMHNMI[num17 + 2] = (int)num14;
					num14 = (num14 >> 32) + (num13 >> 32) + (num16 >> 32);
				}
				num14 += (uint)num9;
				MNIMEAMHNMI[1] = (int)num14;
				num9 = (int)(num14 >> 32);
			}
			MNIMEAMHNMI[0] = num9;
			if (!LMMMMCGKIFK && JLPDKNFCNPO(0, MNIMEAMHNMI, 0, CEKMAJAHNAG) >= 0)
			{
				FBGIHKPECCO(0, MNIMEAMHNMI, 0, CEKMAJAHNAG);
			}
			Array.Copy(MNIMEAMHNMI, 1, AMFCENFNAJJ, 0, num);
		}

		private static void ILCAOJPPACB(int[] MNIMEAMHNMI, int[] AMFCENFNAJJ, int[] CEKMAJAHNAG, uint CLJLEJDBFKN, bool LMMMMCGKIFK)
		{
			int num = CEKMAJAHNAG.Length;
			if (num == 1)
			{
				uint num2 = (uint)AMFCENFNAJJ[0];
				AMFCENFNAJJ[0] = (int)FJBOGKCHKLB(num2, num2, (uint)CEKMAJAHNAG[0], CLJLEJDBFKN);
				return;
			}
			ulong num3 = (uint)AMFCENFNAJJ[num - 1];
			ulong num4 = num3 * num3;
			ulong num5 = (uint)(int)num4 * CLJLEJDBFKN;
			ulong num6 = num5 * (uint)CEKMAJAHNAG[num - 1];
			num4 += (uint)num6;
			num4 = (num4 >> 32) + (num6 >> 32);
			for (int num7 = num - 2; num7 >= 0; num7--)
			{
				ulong num8 = num3 * (uint)AMFCENFNAJJ[num7];
				num6 = num5 * (uint)CEKMAJAHNAG[num7];
				num4 += (num6 & 0xFFFFFFFFu) + (uint)((int)num8 << 1);
				MNIMEAMHNMI[num7 + 2] = (int)num4;
				num4 = (num4 >> 32) + (num8 >> 31) + (num6 >> 32);
			}
			MNIMEAMHNMI[1] = (int)num4;
			int num9 = (int)(num4 >> 32);
			for (int num10 = num - 2; num10 >= 0; num10--)
			{
				uint num11 = (uint)MNIMEAMHNMI[num];
				ulong num12 = num11 * CLJLEJDBFKN;
				ulong num13 = num12 * (uint)CEKMAJAHNAG[num - 1] + num11;
				num13 >>= 32;
				for (int num14 = num - 2; num14 > num10; num14--)
				{
					num13 += num12 * (uint)CEKMAJAHNAG[num14] + (uint)MNIMEAMHNMI[num14 + 1];
					MNIMEAMHNMI[num14 + 2] = (int)num13;
					num13 >>= 32;
				}
				ulong num15 = (uint)AMFCENFNAJJ[num10];
				ulong num16 = num15 * num15;
				ulong num17 = num12 * (uint)CEKMAJAHNAG[num10];
				num13 += (num16 & 0xFFFFFFFFu) + (uint)num17 + (uint)MNIMEAMHNMI[num10 + 1];
				MNIMEAMHNMI[num10 + 2] = (int)num13;
				num13 = (num13 >> 32) + (num16 >> 32) + (num17 >> 32);
				for (int num18 = num10 - 1; num18 >= 0; num18--)
				{
					ulong num19 = num15 * (uint)AMFCENFNAJJ[num18];
					ulong num20 = num12 * (uint)CEKMAJAHNAG[num18];
					num13 += (num20 & 0xFFFFFFFFu) + (uint)((int)num19 << 1) + (uint)MNIMEAMHNMI[num18 + 1];
					MNIMEAMHNMI[num18 + 2] = (int)num13;
					num13 = (num13 >> 32) + (num19 >> 31) + (num20 >> 32);
				}
				num13 += (uint)num9;
				MNIMEAMHNMI[1] = (int)num13;
				num9 = (int)(num13 >> 32);
			}
			MNIMEAMHNMI[0] = num9;
			if (!LMMMMCGKIFK && JLPDKNFCNPO(0, MNIMEAMHNMI, 0, CEKMAJAHNAG) >= 0)
			{
				FBGIHKPECCO(0, MNIMEAMHNMI, 0, CEKMAJAHNAG);
			}
			Array.Copy(MNIMEAMHNMI, 1, AMFCENFNAJJ, 0, num);
		}

		private static uint FJBOGKCHKLB(uint AMFCENFNAJJ, uint CNLILOEEBOJ, uint CEKMAJAHNAG, uint CLJLEJDBFKN)
		{
			ulong num = (ulong)AMFCENFNAJJ * (ulong)CNLILOEEBOJ;
			uint num2 = (uint)(int)num * CLJLEJDBFKN;
			ulong num3 = CEKMAJAHNAG;
			ulong num4 = num3 * num2;
			num += (uint)num4;
			num = (num >> 32) + (num4 >> 32);
			if (num > num3)
			{
				num -= num3;
			}
			return (uint)num;
		}

		public BigInteger IBJBIGNPNEM(BigInteger HIMINGHNIKN)
		{
			if (HIMINGHNIKN == this)
			{
				return MIOEHGDPGAG();
			}
			if ((sign & HIMINGHNIKN.sign) == 0)
			{
				return Zero;
			}
			if (HIMINGHNIKN.IACIHDCOCDI())
			{
				BigInteger bigInteger = DOKHFLENGLF(HIMINGHNIKN.DKGOFCBJBPB().BitLength - 1);
				return (HIMINGHNIKN.sign <= 0) ? bigInteger.BHKOFHMDACN() : bigInteger;
			}
			if (IACIHDCOCDI())
			{
				BigInteger bigInteger2 = HIMINGHNIKN.DOKHFLENGLF(DKGOFCBJBPB().BitLength - 1);
				return (sign <= 0) ? bigInteger2.BHKOFHMDACN() : bigInteger2;
			}
			int num = magnitude.Length + HIMINGHNIKN.magnitude.Length;
			int[] array = new int[num];
			IBJBIGNPNEM(array, magnitude, HIMINGHNIKN.magnitude);
			int fPJKCGMMNKB = sign ^ HIMINGHNIKN.sign ^ 1;
			return new BigInteger(fPJKCGMMNKB, array, true);
		}

		public BigInteger MIOEHGDPGAG()
		{
			if (sign == 0)
			{
				return Zero;
			}
			if (IACIHDCOCDI())
			{
				return DOKHFLENGLF(DKGOFCBJBPB().BitLength - 1);
			}
			int num = magnitude.Length << 1;
			if ((uint)magnitude[0] >> 16 == 0)
			{
				num--;
			}
			int[] array = new int[num];
			MIOEHGDPGAG(array, magnitude);
			return new BigInteger(1, array, false);
		}

		public BigInteger BHKOFHMDACN()
		{
			if (sign == 0)
			{
				return this;
			}
			return new BigInteger(-sign, magnitude, false);
		}

		public BigInteger DGKJLCFJNAO()
		{
			if (sign < 0)
			{
				throw new ArithmeticException("Cannot be called on value < 0");
			}
			if (JLPDKNFCNPO(Two) < 0)
			{
				return Two;
			}
			BigInteger bigInteger = CKIHMFAAHLM().KMDGKCFFPOP(0);
			while (!bigInteger.GADFMFMICHO(100, RandomSource, false))
			{
				bigInteger = bigInteger.JEACJNAKLDJ(Two);
			}
			return bigInteger;
		}

		public BigInteger BEHECEMIINM()
		{
			return CKIHMFAAHLM().BHKOFHMDACN();
		}

		public BigInteger MALBDNEDKLB(int BBCGDLOJNND)
		{
			if (BBCGDLOJNND <= 0)
			{
				if (BBCGDLOJNND < 0)
				{
					throw new ArithmeticException("Negative exponent");
				}
				return One;
			}
			if (sign == 0)
			{
				return this;
			}
			if (IACIHDCOCDI())
			{
				long num = (long)BBCGDLOJNND * (long)(BitLength - 1);
				if (num > int.MaxValue)
				{
					throw new ArithmeticException("Result too large");
				}
				return One.DOKHFLENGLF((int)num);
			}
			BigInteger bigInteger = One;
			BigInteger bigInteger2 = this;
			while (true)
			{
				if ((BBCGDLOJNND & 1) == 1)
				{
					bigInteger = bigInteger.IBJBIGNPNEM(bigInteger2);
				}
				BBCGDLOJNND >>= 1;
				if (BBCGDLOJNND == 0)
				{
					break;
				}
				bigInteger2 = bigInteger2.IBJBIGNPNEM(bigInteger2);
			}
			return bigInteger;
		}

		public static BigInteger GHOLNJCAFDG(int EAJFCEBGGIG, Random GECCLOFELEC)
		{
			return new BigInteger(EAJFCEBGGIG, 100, GECCLOFELEC);
		}

		private int FGLDMFGEDAD(int CEKMAJAHNAG)
		{
			long num = 0L;
			for (int i = 0; i < magnitude.Length; i++)
			{
				long num2 = (uint)magnitude[i];
				num = ((num << 32) | num2) % CEKMAJAHNAG;
			}
			return (int)num;
		}

		private static int[] FGLDMFGEDAD(int[] AMFCENFNAJJ, int[] CNLILOEEBOJ)
		{
			int i;
			for (i = 0; i < AMFCENFNAJJ.Length && AMFCENFNAJJ[i] == 0; i++)
			{
			}
			int j;
			for (j = 0; j < CNLILOEEBOJ.Length && CNLILOEEBOJ[j] == 0; j++)
			{
			}
			int num = LNBNCEKLAHL(i, AMFCENFNAJJ, j, CNLILOEEBOJ);
			if (num > 0)
			{
				int num2 = KJIJBIEHLPH(1, j, CNLILOEEBOJ);
				int num3 = KJIJBIEHLPH(1, i, AMFCENFNAJJ);
				int num4 = num3 - num2;
				int k = 0;
				int num5 = num2;
				int[] array;
				if (num4 > 0)
				{
					array = DOKHFLENGLF(CNLILOEEBOJ, num4);
					num5 += num4;
				}
				else
				{
					int num6 = CNLILOEEBOJ.Length - j;
					array = new int[num6];
					Array.Copy(CNLILOEEBOJ, j, array, 0, num6);
				}
				while (true)
				{
					if (num5 < num3 || LNBNCEKLAHL(i, AMFCENFNAJJ, k, array) >= 0)
					{
						FBGIHKPECCO(i, AMFCENFNAJJ, k, array);
						while (AMFCENFNAJJ[i] == 0)
						{
							if (++i == AMFCENFNAJJ.Length)
							{
								return AMFCENFNAJJ;
							}
						}
						num3 = 32 * (AMFCENFNAJJ.Length - i - 1) + DPLNBDLKNDE(AMFCENFNAJJ[i]);
						if (num3 <= num2)
						{
							if (num3 < num2)
							{
								return AMFCENFNAJJ;
							}
							num = LNBNCEKLAHL(i, AMFCENFNAJJ, j, CNLILOEEBOJ);
							if (num <= 0)
							{
								break;
							}
						}
					}
					num4 = num5 - num3;
					if (num4 == 1)
					{
						uint num7 = (uint)array[k] >> 1;
						uint num8 = (uint)AMFCENFNAJJ[i];
						if (num7 > num8)
						{
							num4++;
						}
					}
					if (num4 < 2)
					{
						AOPINMPIMLO(k, array);
						num5--;
					}
					else
					{
						HBEHPNPAGIH(k, array, num4);
						num5 -= num4;
					}
					for (; array[k] == 0; k++)
					{
					}
				}
			}
			if (num == 0)
			{
				Array.Clear(AMFCENFNAJJ, i, AMFCENFNAJJ.Length - i);
			}
			return AMFCENFNAJJ;
		}

		public BigInteger FGLDMFGEDAD(BigInteger IDHLPOFDLKJ)
		{
			if (IDHLPOFDLKJ.sign == 0)
			{
				throw new ArithmeticException("Division by zero error");
			}
			if (sign == 0)
			{
				return Zero;
			}
			if (IDHLPOFDLKJ.magnitude.Length == 1)
			{
				int num = IDHLPOFDLKJ.magnitude[0];
				if (num > 0)
				{
					if (num == 1)
					{
						return Zero;
					}
					int num2 = FGLDMFGEDAD(num);
					return (num2 != 0) ? new BigInteger(sign, new int[1] { num2 }, false) : Zero;
				}
			}
			if (LNBNCEKLAHL(0, magnitude, 0, IDHLPOFDLKJ.magnitude) < 0)
			{
				return this;
			}
			int[] oHPENDELFKK;
			if (IDHLPOFDLKJ.IACIHDCOCDI())
			{
				oHPENDELFKK = ELMNCKKJAJJ(IDHLPOFDLKJ.DKGOFCBJBPB().BitLength - 1);
			}
			else
			{
				oHPENDELFKK = (int[])magnitude.Clone();
				oHPENDELFKK = FGLDMFGEDAD(oHPENDELFKK, IDHLPOFDLKJ.magnitude);
			}
			return new BigInteger(sign, oHPENDELFKK, true);
		}

		private int[] ELMNCKKJAJJ(int IDHLPOFDLKJ)
		{
			if (IDHLPOFDLKJ < 1)
			{
				return ZeroMagnitude;
			}
			int val = (IDHLPOFDLKJ + 32 - 1) / 32;
			val = System.Math.Min(val, magnitude.Length);
			int[] array = new int[val];
			Array.Copy(magnitude, magnitude.Length - val, array, 0, val);
			int num = (val << 5) - IDHLPOFDLKJ;
			if (num > 0)
			{
				array[0] &= (int)(uint.MaxValue >> num);
			}
			return array;
		}

		private BigInteger JBFLJPFDHHP(int PHFLBLJJMLI)
		{
			int num = magnitude.Length;
			if (PHFLBLJJMLI >= num)
			{
				return Zero;
			}
			int[] array = new int[num - PHFLBLJJMLI];
			Array.Copy(magnitude, 0, array, 0, num - PHFLBLJJMLI);
			return new BigInteger(sign, array, false);
		}

		private BigInteger KPLFKHFBNHJ(int PHFLBLJJMLI)
		{
			int num = magnitude.Length;
			if (PHFLBLJJMLI >= num)
			{
				return this;
			}
			int[] array = new int[PHFLBLJJMLI];
			Array.Copy(magnitude, num - PHFLBLJJMLI, array, 0, PHFLBLJJMLI);
			return new BigInteger(sign, array, false);
		}

		private static int[] DOKHFLENGLF(int[] OHPENDELFKK, int IDHLPOFDLKJ)
		{
			int num = (int)((uint)IDHLPOFDLKJ >> 5);
			int num2 = IDHLPOFDLKJ & 0x1F;
			int num3 = OHPENDELFKK.Length;
			int[] array;
			if (num2 == 0)
			{
				array = new int[num3 + num];
				OHPENDELFKK.CopyTo(array, 0);
			}
			else
			{
				int num4 = 0;
				int num5 = 32 - num2;
				int num6 = (int)((uint)OHPENDELFKK[0] >> num5);
				if (num6 != 0)
				{
					array = new int[num3 + num + 1];
					array[num4++] = num6;
				}
				else
				{
					array = new int[num3 + num];
				}
				int num7 = OHPENDELFKK[0];
				for (int i = 0; i < num3 - 1; i++)
				{
					int num8 = OHPENDELFKK[i + 1];
					array[num4++] = (num7 << num2) | (int)((uint)num8 >> num5);
					num7 = num8;
				}
				array[num4] = OHPENDELFKK[num3 - 1] << num2;
			}
			return array;
		}

		private static int PBLENPAHPHI(int[] AMFCENFNAJJ, int OMMMLCDIDCF)
		{
			int num = AMFCENFNAJJ.Length;
			while (--num >= 0)
			{
				uint num2 = (uint)AMFCENFNAJJ[num];
				AMFCENFNAJJ[num] = (int)(num2 << 1) | OMMMLCDIDCF;
				OMMMLCDIDCF = (int)(num2 >> 31);
			}
			return OMMMLCDIDCF;
		}

		public BigInteger DOKHFLENGLF(int IDHLPOFDLKJ)
		{
			if (sign == 0 || magnitude.Length == 0)
			{
				return Zero;
			}
			if (IDHLPOFDLKJ == 0)
			{
				return this;
			}
			if (IDHLPOFDLKJ < 0)
			{
				return ABOIOKBIANB(-IDHLPOFDLKJ);
			}
			BigInteger bigInteger = new BigInteger(sign, DOKHFLENGLF(magnitude, IDHLPOFDLKJ), true);
			if (nBits != -1)
			{
				bigInteger.nBits = ((sign <= 0) ? (nBits + IDHLPOFDLKJ) : nBits);
			}
			if (nBitLength != -1)
			{
				bigInteger.nBitLength = nBitLength + IDHLPOFDLKJ;
			}
			return bigInteger;
		}

		private static void HBEHPNPAGIH(int EHGOOEHDNMM, int[] OHPENDELFKK, int IDHLPOFDLKJ)
		{
			int num = (int)((uint)IDHLPOFDLKJ >> 5) + EHGOOEHDNMM;
			int num2 = IDHLPOFDLKJ & 0x1F;
			int num3 = OHPENDELFKK.Length - 1;
			if (num != EHGOOEHDNMM)
			{
				int num4 = num - EHGOOEHDNMM;
				for (int num5 = num3; num5 >= num; num5--)
				{
					OHPENDELFKK[num5] = OHPENDELFKK[num5 - num4];
				}
				for (int num6 = num - 1; num6 >= EHGOOEHDNMM; num6--)
				{
					OHPENDELFKK[num6] = 0;
				}
			}
			if (num2 != 0)
			{
				int num7 = 32 - num2;
				int num8 = OHPENDELFKK[num3];
				for (int num9 = num3; num9 > num; num9--)
				{
					int num10 = OHPENDELFKK[num9 - 1];
					OHPENDELFKK[num9] = (int)((uint)num8 >> num2) | (num10 << num7);
					num8 = num10;
				}
				OHPENDELFKK[num] = (int)((uint)OHPENDELFKK[num] >> num2);
			}
		}

		private static void AOPINMPIMLO(int EHGOOEHDNMM, int[] OHPENDELFKK)
		{
			int num = OHPENDELFKK.Length;
			int num2 = OHPENDELFKK[num - 1];
			while (--num > EHGOOEHDNMM)
			{
				int num3 = OHPENDELFKK[num - 1];
				OHPENDELFKK[num] = (int)((uint)num2 >> 1) | (num3 << 31);
				num2 = num3;
			}
			OHPENDELFKK[EHGOOEHDNMM] = (int)((uint)OHPENDELFKK[EHGOOEHDNMM] >> 1);
		}

		public BigInteger ABOIOKBIANB(int IDHLPOFDLKJ)
		{
			if (IDHLPOFDLKJ == 0)
			{
				return this;
			}
			if (IDHLPOFDLKJ < 0)
			{
				return DOKHFLENGLF(-IDHLPOFDLKJ);
			}
			if (IDHLPOFDLKJ >= BitLength)
			{
				return (sign >= 0) ? Zero : One.BHKOFHMDACN();
			}
			int num = BitLength - IDHLPOFDLKJ + 31 >> 5;
			int[] array = new int[num];
			int num2 = IDHLPOFDLKJ >> 5;
			int num3 = IDHLPOFDLKJ & 0x1F;
			if (num3 == 0)
			{
				Array.Copy(magnitude, 0, array, 0, array.Length);
			}
			else
			{
				int num4 = 32 - num3;
				int num5 = magnitude.Length - 1 - num2;
				for (int num6 = num - 1; num6 >= 0; num6--)
				{
					array[num6] = (int)((uint)magnitude[num5--] >> num3);
					if (num5 >= 0)
					{
						array[num6] |= magnitude[num5] << num4;
					}
				}
			}
			return new BigInteger(sign, array, false);
		}

		private static int[] FBGIHKPECCO(int NBGNECLIPPC, int[] AMFCENFNAJJ, int CFNLJHEIKEF, int[] CNLILOEEBOJ)
		{
			int num = AMFCENFNAJJ.Length;
			int num2 = CNLILOEEBOJ.Length;
			int num3 = 0;
			do
			{
				long num4 = (AMFCENFNAJJ[--num] & 0xFFFFFFFFu) - (CNLILOEEBOJ[--num2] & 0xFFFFFFFFu) + num3;
				AMFCENFNAJJ[num] = (int)num4;
				num3 = (int)(num4 >> 63);
			}
			while (num2 > CFNLJHEIKEF);
			if (num3 != 0)
			{
				while (--AMFCENFNAJJ[--num] == -1)
				{
				}
			}
			return AMFCENFNAJJ;
		}

		public BigInteger FBGIHKPECCO(BigInteger IDHLPOFDLKJ)
		{
			if (IDHLPOFDLKJ.sign == 0)
			{
				return this;
			}
			if (sign == 0)
			{
				return IDHLPOFDLKJ.BHKOFHMDACN();
			}
			if (sign != IDHLPOFDLKJ.sign)
			{
				return JEACJNAKLDJ(IDHLPOFDLKJ.BHKOFHMDACN());
			}
			int num = LNBNCEKLAHL(0, magnitude, 0, IDHLPOFDLKJ.magnitude);
			if (num == 0)
			{
				return Zero;
			}
			BigInteger bigInteger;
			BigInteger bigInteger2;
			if (num < 0)
			{
				bigInteger = IDHLPOFDLKJ;
				bigInteger2 = this;
			}
			else
			{
				bigInteger = this;
				bigInteger2 = IDHLPOFDLKJ;
			}
			return new BigInteger(sign * num, BJGEABPAABH(bigInteger.magnitude, bigInteger2.magnitude), true);
		}

		private static int[] BJGEABPAABH(int[] BJFMMPLNOBC, int[] HLKLHLGKICP)
		{
			int[] aMFCENFNAJJ = (int[])BJFMMPLNOBC.Clone();
			return FBGIHKPECCO(0, aMFCENFNAJJ, 0, HLKLHLGKICP);
		}

		public byte[] EDHFCNLPGJC()
		{
			return EDHFCNLPGJC(false);
		}

		public byte[] MEOCDOOKOLH()
		{
			return EDHFCNLPGJC(true);
		}

		private byte[] EDHFCNLPGJC(bool FBNJHCBHEOC)
		{
			if (sign == 0)
			{
				return (!FBNJHCBHEOC) ? new byte[1] : ZeroEncoding;
			}
			int dAOOKLBFGEF = ((!FBNJHCBHEOC || sign <= 0) ? (BitLength + 1) : BitLength);
			int num = MNAIJEEKPCP(dAOOKLBFGEF);
			byte[] array = new byte[num];
			int num2 = magnitude.Length;
			int num3 = array.Length;
			if (sign > 0)
			{
				while (num2 > 1)
				{
					uint num4 = (uint)magnitude[--num2];
					array[--num3] = (byte)num4;
					array[--num3] = (byte)(num4 >> 8);
					array[--num3] = (byte)(num4 >> 16);
					array[--num3] = (byte)(num4 >> 24);
				}
				uint num5;
				for (num5 = (uint)magnitude[0]; num5 > 255; num5 >>= 8)
				{
					array[--num3] = (byte)num5;
				}
				array[--num3] = (byte)num5;
			}
			else
			{
				bool flag = true;
				while (num2 > 1)
				{
					uint num6 = (uint)(~magnitude[--num2]);
					if (flag)
					{
						flag = ++num6 == 0;
					}
					array[--num3] = (byte)num6;
					array[--num3] = (byte)(num6 >> 8);
					array[--num3] = (byte)(num6 >> 16);
					array[--num3] = (byte)(num6 >> 24);
				}
				uint num7 = (uint)magnitude[0];
				if (flag)
				{
					num7--;
				}
				while (num7 > 255)
				{
					array[--num3] = (byte)(~num7);
					num7 >>= 8;
				}
				array[--num3] = (byte)(~num7);
				if (num3 > 0)
				{
					array[--num3] = byte.MaxValue;
				}
			}
			return array;
		}

		public override string ToString()
		{
			return NHMGCGBMCNM(10);
		}

		public string NHMGCGBMCNM(int PPKFDNLPFOO)
		{
			switch (PPKFDNLPFOO)
			{
			default:
				throw new FormatException("Only bases 2, 8, 10, 16 are allowed");
			case 2:
			case 8:
			case 10:
			case 16:
			{
				if (magnitude == null)
				{
					return "null";
				}
				if (sign == 0)
				{
					return "0";
				}
				int i;
				for (i = 0; i < magnitude.Length && magnitude[i] == 0; i++)
				{
				}
				if (i == magnitude.Length)
				{
					return "0";
				}
				StringBuilder stringBuilder = new StringBuilder();
				if (sign == -1)
				{
					stringBuilder.Append('-');
				}
				switch (PPKFDNLPFOO)
				{
				case 2:
				{
					int num9 = i;
					stringBuilder.Append(Convert.ToString(magnitude[num9], 2));
					while (++num9 < magnitude.Length)
					{
						MLKBAFANCDF(stringBuilder, Convert.ToString(magnitude[num9], 2), 32);
					}
					break;
				}
				case 8:
				{
					int num5 = 1073741823;
					BigInteger bigInteger3 = DKGOFCBJBPB();
					int num6 = bigInteger3.BitLength;
					IList list2 = LHFGHNFJIKM.PPPFFFBMGML();
					while (num6 > 30)
					{
						list2.Add(Convert.ToString(bigInteger3.IntValue & num5, 8));
						bigInteger3 = bigInteger3.ABOIOKBIANB(30);
						num6 -= 30;
					}
					stringBuilder.Append(Convert.ToString(bigInteger3.IntValue, 8));
					for (int num7 = list2.Count - 1; num7 >= 0; num7--)
					{
						MLKBAFANCDF(stringBuilder, (string)list2[num7], 10);
					}
					break;
				}
				case 16:
				{
					int num8 = i;
					stringBuilder.Append(Convert.ToString(magnitude[num8], 16));
					while (++num8 < magnitude.Length)
					{
						MLKBAFANCDF(stringBuilder, Convert.ToString(magnitude[num8], 16), 8);
					}
					break;
				}
				case 10:
				{
					BigInteger bigInteger = DKGOFCBJBPB();
					if (bigInteger.BitLength < 64)
					{
						stringBuilder.Append(Convert.ToString(bigInteger.LongValue, PPKFDNLPFOO));
						break;
					}
					long num = long.MaxValue / PPKFDNLPFOO;
					long num2 = PPKFDNLPFOO;
					int num3 = 1;
					while (num2 <= num)
					{
						num2 *= PPKFDNLPFOO;
						num3++;
					}
					BigInteger bigInteger2 = AGLOJCOAJIK(num2);
					IList list = LHFGHNFJIKM.PPPFFFBMGML();
					while (bigInteger.JLPDKNFCNPO(bigInteger2) >= 0)
					{
						BigInteger[] array = bigInteger.BKPFNGBMONE(bigInteger2);
						list.Add(Convert.ToString(array[1].LongValue, PPKFDNLPFOO));
						bigInteger = array[0];
					}
					stringBuilder.Append(Convert.ToString(bigInteger.LongValue, PPKFDNLPFOO));
					for (int num4 = list.Count - 1; num4 >= 0; num4--)
					{
						MLKBAFANCDF(stringBuilder, (string)list[num4], num3);
					}
					break;
				}
				}
				return stringBuilder.ToString();
			}
			}
		}

		private static void MLKBAFANCDF(StringBuilder OFPMFAMCHJE, string IBBBMACIBGK, int LKEBCBKPGKN)
		{
			for (int i = IBBBMACIBGK.Length; i < LKEBCBKPGKN; i++)
			{
				OFPMFAMCHJE.Append('0');
			}
			OFPMFAMCHJE.Append(IBBBMACIBGK);
		}

		private static BigInteger FDLCDHEHEGK(ulong EDDNOJDPMCF)
		{
			int num = (int)(EDDNOJDPMCF >> 32);
			int num2 = (int)EDDNOJDPMCF;
			if (num != 0)
			{
				return new BigInteger(1, new int[2] { num, num2 }, false);
			}
			if (num2 != 0)
			{
				BigInteger bigInteger = new BigInteger(1, new int[1] { num2 }, false);
				if ((num2 & -num2) == num2)
				{
					bigInteger.nBits = 1;
				}
				return bigInteger;
			}
			return Zero;
		}

		private static BigInteger FDMENBCICAD(long EDDNOJDPMCF)
		{
			if (EDDNOJDPMCF < 0)
			{
				if (EDDNOJDPMCF == long.MinValue)
				{
					return FDMENBCICAD(~EDDNOJDPMCF).BEHECEMIINM();
				}
				return FDMENBCICAD(-EDDNOJDPMCF).BHKOFHMDACN();
			}
			return FDLCDHEHEGK((ulong)EDDNOJDPMCF);
		}

		public static BigInteger AGLOJCOAJIK(long EDDNOJDPMCF)
		{
			if (EDDNOJDPMCF >= 0 && EDDNOJDPMCF < SMALL_CONSTANTS.Length)
			{
				return SMALL_CONSTANTS[EDDNOJDPMCF];
			}
			return FDMENBCICAD(EDDNOJDPMCF);
		}

		public int MGJLILGHLEA()
		{
			if (sign == 0)
			{
				return -1;
			}
			return CHHBPPGOHBP(-1);
		}

		private int CHHBPPGOHBP(int LGDEHBNLJOA)
		{
			int num = magnitude.Length;
			int num2 = 0;
			uint num3 = (uint)(magnitude[--num] & LGDEHBNLJOA);
			while (num3 == 0)
			{
				num3 = (uint)magnitude[--num];
				num2 += 32;
			}
			while ((num3 & 0xFF) == 0)
			{
				num3 >>= 8;
				num2 += 8;
			}
			while ((num3 & 1) == 0)
			{
				num3 >>= 1;
				num2++;
			}
			return num2;
		}

		public bool NJHNJHGDCIJ(int IDHLPOFDLKJ)
		{
			if (IDHLPOFDLKJ < 0)
			{
				throw new ArithmeticException("Bit position must not be negative");
			}
			if (sign < 0)
			{
				return !BEHECEMIINM().NJHNJHGDCIJ(IDHLPOFDLKJ);
			}
			int num = IDHLPOFDLKJ / 32;
			if (num >= magnitude.Length)
			{
				return false;
			}
			int num2 = magnitude[magnitude.Length - 1 - num];
			return ((num2 >> IDHLPOFDLKJ % 32) & 1) > 0;
		}

		public BigInteger CIAIADPNAON(BigInteger EDDNOJDPMCF)
		{
			if (sign == 0)
			{
				return EDDNOJDPMCF;
			}
			if (EDDNOJDPMCF.sign == 0)
			{
				return this;
			}
			int[] array = ((sign <= 0) ? JEACJNAKLDJ(One).magnitude : magnitude);
			int[] array2 = ((EDDNOJDPMCF.sign <= 0) ? EDDNOJDPMCF.JEACJNAKLDJ(One).magnitude : EDDNOJDPMCF.magnitude);
			bool flag = sign < 0 || EDDNOJDPMCF.sign < 0;
			int num = System.Math.Max(array.Length, array2.Length);
			int[] array3 = new int[num];
			int num2 = array3.Length - array.Length;
			int num3 = array3.Length - array2.Length;
			for (int i = 0; i < array3.Length; i++)
			{
				int num4 = ((i >= num2) ? array[i - num2] : 0);
				int num5 = ((i >= num3) ? array2[i - num3] : 0);
				if (sign < 0)
				{
					num4 = ~num4;
				}
				if (EDDNOJDPMCF.sign < 0)
				{
					num5 = ~num5;
				}
				array3[i] = num4 | num5;
				if (flag)
				{
					array3[i] = ~array3[i];
				}
			}
			BigInteger bigInteger = new BigInteger(1, array3, true);
			if (flag)
			{
				bigInteger = bigInteger.BEHECEMIINM();
			}
			return bigInteger;
		}

		public BigInteger FHLALGENPPH(BigInteger EDDNOJDPMCF)
		{
			if (sign == 0)
			{
				return EDDNOJDPMCF;
			}
			if (EDDNOJDPMCF.sign == 0)
			{
				return this;
			}
			int[] array = ((sign <= 0) ? JEACJNAKLDJ(One).magnitude : magnitude);
			int[] array2 = ((EDDNOJDPMCF.sign <= 0) ? EDDNOJDPMCF.JEACJNAKLDJ(One).magnitude : EDDNOJDPMCF.magnitude);
			bool flag = (sign < 0 && EDDNOJDPMCF.sign >= 0) || (sign >= 0 && EDDNOJDPMCF.sign < 0);
			int num = System.Math.Max(array.Length, array2.Length);
			int[] array3 = new int[num];
			int num2 = array3.Length - array.Length;
			int num3 = array3.Length - array2.Length;
			for (int i = 0; i < array3.Length; i++)
			{
				int num4 = ((i >= num2) ? array[i - num2] : 0);
				int num5 = ((i >= num3) ? array2[i - num3] : 0);
				if (sign < 0)
				{
					num4 = ~num4;
				}
				if (EDDNOJDPMCF.sign < 0)
				{
					num5 = ~num5;
				}
				array3[i] = num4 ^ num5;
				if (flag)
				{
					array3[i] = ~array3[i];
				}
			}
			BigInteger bigInteger = new BigInteger(1, array3, true);
			if (flag)
			{
				bigInteger = bigInteger.BEHECEMIINM();
			}
			return bigInteger;
		}

		public BigInteger KMDGKCFFPOP(int IDHLPOFDLKJ)
		{
			if (IDHLPOFDLKJ < 0)
			{
				throw new ArithmeticException("Bit address less than zero");
			}
			if (NJHNJHGDCIJ(IDHLPOFDLKJ))
			{
				return this;
			}
			if (sign > 0 && IDHLPOFDLKJ < BitLength - 1)
			{
				return EDCFLPFHEOA(IDHLPOFDLKJ);
			}
			return CIAIADPNAON(One.DOKHFLENGLF(IDHLPOFDLKJ));
		}

		public BigInteger FKDNNOLIGPH(int IDHLPOFDLKJ)
		{
			if (IDHLPOFDLKJ < 0)
			{
				throw new ArithmeticException("Bit address less than zero");
			}
			if (!NJHNJHGDCIJ(IDHLPOFDLKJ))
			{
				return this;
			}
			if (sign > 0 && IDHLPOFDLKJ < BitLength - 1)
			{
				return EDCFLPFHEOA(IDHLPOFDLKJ);
			}
			return NLNJIKHBMAF(One.DOKHFLENGLF(IDHLPOFDLKJ));
		}

		public BigInteger OGNPAPCPIFJ(int IDHLPOFDLKJ)
		{
			if (IDHLPOFDLKJ < 0)
			{
				throw new ArithmeticException("Bit address less than zero");
			}
			if (sign > 0 && IDHLPOFDLKJ < BitLength - 1)
			{
				return EDCFLPFHEOA(IDHLPOFDLKJ);
			}
			return FHLALGENPPH(One.DOKHFLENGLF(IDHLPOFDLKJ));
		}

		private BigInteger EDCFLPFHEOA(int IDHLPOFDLKJ)
		{
			int[] array = (int[])magnitude.Clone();
			array[array.Length - 1 - (IDHLPOFDLKJ >> 5)] ^= 1 << IDHLPOFDLKJ;
			return new BigInteger(sign, array, false);
		}
	}
}
