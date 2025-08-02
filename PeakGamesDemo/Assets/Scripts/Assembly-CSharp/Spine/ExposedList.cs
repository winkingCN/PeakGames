using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Spine
{
	[Serializable]
	[DebuggerDisplay("Count={Count}")]
	public class ExposedList<T> : IEnumerable<T>, IEnumerable
	{
		[Serializable]
		public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
		{
			private ExposedList<T> l;

			private int next;

			private int ver;

			private T current;

			object IEnumerator.Current
			{
				get
				{
					FCOMNBHGOGA();
					if (next <= 0)
					{
						throw new InvalidOperationException();
					}
					return current;
				}
			}

			public T Current
			{
				get
				{
					return current;
				}
			}

			internal Enumerator(ExposedList<T> PHILIHLPDFD)
			{
				this = default(Enumerator);
				l = PHILIHLPDFD;
				ver = PHILIHLPDFD.version;
			}

			public void Dispose()
			{
				l = null;
			}

			private void FCOMNBHGOGA()
			{
				if (l == null)
				{
					throw new ObjectDisposedException(GetType().FullName);
				}
				if (ver != l.version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
			}

			public bool MoveNext()
			{
				FCOMNBHGOGA();
				if (next < 0)
				{
					return false;
				}
				if (next < l.Count)
				{
					current = l.Items[next++];
					return true;
				}
				next = -1;
				return false;
			}

			void IEnumerator.Reset()
			{
				FCOMNBHGOGA();
				next = 0;
			}
		}

		public T[] Items;

		public int Count;

		private const int DefaultCapacity = 4;

		private static readonly T[] EmptyArray = new T[0];

		private int version;

		public int Capacity
		{
			get
			{
				return Items.Length;
			}
			set
			{
				if ((uint)value < (uint)Count)
				{
					throw new ArgumentOutOfRangeException();
				}
				Array.Resize(ref Items, value);
			}
		}

		public ExposedList()
		{
			Items = EmptyArray;
		}

		public ExposedList(IEnumerable<T> GDOLNBCOCDC)
		{
			GGIAFHJCPNF(GDOLNBCOCDC);
			ICollection<T> collection = GDOLNBCOCDC as ICollection<T>;
			if (collection == null)
			{
				Items = EmptyArray;
				NNMNDFPDCAM(GDOLNBCOCDC);
			}
			else
			{
				Items = new T[collection.Count];
				HKLMIEGKLGH(collection);
			}
		}

		public ExposedList(int MDPEMCMPAMB)
		{
			if (MDPEMCMPAMB < 0)
			{
				throw new ArgumentOutOfRangeException("capacity");
			}
			Items = new T[MDPEMCMPAMB];
		}

		internal ExposedList(T[] MBBPBGHKLJM, int MOFHAKELNPN)
		{
			Items = MBBPBGHKLJM;
			Count = MOFHAKELNPN;
		}

		public void JEACJNAKLDJ(T EJCNAJOHBFI)
		{
			if (Count == Items.Length)
			{
				JGGCKJABGHP(1);
			}
			Items[Count++] = EJCNAJOHBFI;
			version++;
		}

		public void JGGCKJABGHP(int NBPIPIKOPIA)
		{
			int num = Count + NBPIPIKOPIA;
			if (num > Items.Length)
			{
				Capacity = Math.Max(Math.Max(Capacity * 2, 4), num);
			}
		}

		public ExposedList<T> NKMKBLFBOFC(int EFILDOIJABE)
		{
			int num = Items.Length;
			T[] items = Items;
			if (EFILDOIJABE > num)
			{
				Array.Resize(ref Items, EFILDOIJABE);
			}
			else if (EFILDOIJABE < num)
			{
				for (int i = EFILDOIJABE; i < num; i++)
				{
					items[i] = default(T);
				}
			}
			Count = EFILDOIJABE;
			return this;
		}

		public void FGLKIEFPAIA(int IJHGDODBFCD)
		{
			if (Items.Length < IJHGDODBFCD)
			{
				int num = ((Items.Length != 0) ? (Items.Length * 2) : 4);
				if (num < IJHGDODBFCD)
				{
					num = IJHGDODBFCD;
				}
				Capacity = num;
			}
		}

		private void OCDHDNHIHDP(int EHJNMODJEAN, int ENMLICFLHAO)
		{
			if (EHJNMODJEAN < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (ENMLICFLHAO < 0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if ((uint)(EHJNMODJEAN + ENMLICFLHAO) > (uint)Count)
			{
				throw new ArgumentException("index and count exceed length of list");
			}
		}

		private void HKLMIEGKLGH(ICollection<T> GDOLNBCOCDC)
		{
			int count = GDOLNBCOCDC.Count;
			if (count != 0)
			{
				JGGCKJABGHP(count);
				GDOLNBCOCDC.CopyTo(Items, Count);
				Count += count;
			}
		}

		private void NNMNDFPDCAM(IEnumerable<T> NNALBMFGPCN)
		{
			foreach (T item in NNALBMFGPCN)
			{
				JEACJNAKLDJ(item);
			}
		}

		public void OJCDNLBIAPD(IEnumerable<T> GDOLNBCOCDC)
		{
			GGIAFHJCPNF(GDOLNBCOCDC);
			ICollection<T> collection = GDOLNBCOCDC as ICollection<T>;
			if (collection != null)
			{
				HKLMIEGKLGH(collection);
			}
			else
			{
				NNMNDFPDCAM(GDOLNBCOCDC);
			}
			version++;
		}

		public int EIAMMDBFDFO(T EJCNAJOHBFI)
		{
			return Array.BinarySearch(Items, 0, Count, EJCNAJOHBFI);
		}

		public int EIAMMDBFDFO(T EJCNAJOHBFI, IComparer<T> AEHAGJDIHEO)
		{
			return Array.BinarySearch(Items, 0, Count, EJCNAJOHBFI, AEHAGJDIHEO);
		}

		public int EIAMMDBFDFO(int EHJNMODJEAN, int ENMLICFLHAO, T EJCNAJOHBFI, IComparer<T> AEHAGJDIHEO)
		{
			OCDHDNHIHDP(EHJNMODJEAN, ENMLICFLHAO);
			return Array.BinarySearch(Items, EHJNMODJEAN, ENMLICFLHAO, EJCNAJOHBFI, AEHAGJDIHEO);
		}

		public void BOPEPLONIFL(bool JJNJLAEPICA = true)
		{
			if (JJNJLAEPICA)
			{
				Array.Clear(Items, 0, Items.Length);
			}
			Count = 0;
			version++;
		}

		public bool KMDACNACKII(T EJCNAJOHBFI)
		{
			return Array.IndexOf(Items, EJCNAJOHBFI, 0, Count) != -1;
		}

		public ExposedList<TOutput> OIAHKHHOELO<TOutput>(Converter<T, TOutput> BELGKAAFEAG)
		{
			if (BELGKAAFEAG == null)
			{
				throw new ArgumentNullException("converter");
			}
			ExposedList<TOutput> exposedList = new ExposedList<TOutput>(Count);
			for (int i = 0; i < Count; i++)
			{
				exposedList.Items[i] = BELGKAAFEAG(Items[i]);
			}
			exposedList.Count = Count;
			return exposedList;
		}

		public void BACJEDDPKIJ(T[] KDOGMDCDCEN)
		{
			Array.Copy(Items, 0, KDOGMDCDCEN, 0, Count);
		}

		public void BACJEDDPKIJ(T[] KDOGMDCDCEN, int KILNCNNBOGK)
		{
			Array.Copy(Items, 0, KDOGMDCDCEN, KILNCNNBOGK, Count);
		}

		public void BACJEDDPKIJ(int EHJNMODJEAN, T[] KDOGMDCDCEN, int KILNCNNBOGK, int ENMLICFLHAO)
		{
			OCDHDNHIHDP(EHJNMODJEAN, ENMLICFLHAO);
			Array.Copy(Items, EHJNMODJEAN, KDOGMDCDCEN, KILNCNNBOGK, ENMLICFLHAO);
		}

		public bool IHBHPGHBDLA(Predicate<T> GLODLGBDEPB)
		{
			JEBMHGOKPHM(GLODLGBDEPB);
			return LJEFFMAAFNK(0, Count, GLODLGBDEPB) != -1;
		}

		public T HBBNIBKHDAB(Predicate<T> GLODLGBDEPB)
		{
			JEBMHGOKPHM(GLODLGBDEPB);
			int num = LJEFFMAAFNK(0, Count, GLODLGBDEPB);
			return (num == -1) ? default(T) : Items[num];
		}

		private static void JEBMHGOKPHM(Predicate<T> GLODLGBDEPB)
		{
			if (GLODLGBDEPB == null)
			{
				throw new ArgumentNullException("match");
			}
		}

		public ExposedList<T> BGBNJNLDBNP(Predicate<T> GLODLGBDEPB)
		{
			JEBMHGOKPHM(GLODLGBDEPB);
			return BPIHKEFLGEF(GLODLGBDEPB);
		}

		private ExposedList<T> BPIHKEFLGEF(Predicate<T> GLODLGBDEPB)
		{
			ExposedList<T> exposedList = new ExposedList<T>();
			for (int i = 0; i < Count; i++)
			{
				if (GLODLGBDEPB(Items[i]))
				{
					exposedList.JEACJNAKLDJ(Items[i]);
				}
			}
			return exposedList;
		}

		public int DHIAGBLDAFJ(Predicate<T> GLODLGBDEPB)
		{
			JEBMHGOKPHM(GLODLGBDEPB);
			return LJEFFMAAFNK(0, Count, GLODLGBDEPB);
		}

		public int DHIAGBLDAFJ(int KKMNKJJENIL, Predicate<T> GLODLGBDEPB)
		{
			JEBMHGOKPHM(GLODLGBDEPB);
			CCLNIJEGPCI(KKMNKJJENIL);
			return LJEFFMAAFNK(KKMNKJJENIL, Count - KKMNKJJENIL, GLODLGBDEPB);
		}

		public int DHIAGBLDAFJ(int KKMNKJJENIL, int ENMLICFLHAO, Predicate<T> GLODLGBDEPB)
		{
			JEBMHGOKPHM(GLODLGBDEPB);
			OCDHDNHIHDP(KKMNKJJENIL, ENMLICFLHAO);
			return LJEFFMAAFNK(KKMNKJJENIL, ENMLICFLHAO, GLODLGBDEPB);
		}

		private int LJEFFMAAFNK(int KKMNKJJENIL, int ENMLICFLHAO, Predicate<T> GLODLGBDEPB)
		{
			int num = KKMNKJJENIL + ENMLICFLHAO;
			for (int i = KKMNKJJENIL; i < num; i++)
			{
				if (GLODLGBDEPB(Items[i]))
				{
					return i;
				}
			}
			return -1;
		}

		public T MPIBECBPENK(Predicate<T> GLODLGBDEPB)
		{
			JEBMHGOKPHM(GLODLGBDEPB);
			int num = IGENIBDKPJA(0, Count, GLODLGBDEPB);
			return (num != -1) ? Items[num] : default(T);
		}

		public int OIJBEKILIOM(Predicate<T> GLODLGBDEPB)
		{
			JEBMHGOKPHM(GLODLGBDEPB);
			return IGENIBDKPJA(0, Count, GLODLGBDEPB);
		}

		public int OIJBEKILIOM(int KKMNKJJENIL, Predicate<T> GLODLGBDEPB)
		{
			JEBMHGOKPHM(GLODLGBDEPB);
			CCLNIJEGPCI(KKMNKJJENIL);
			return IGENIBDKPJA(0, KKMNKJJENIL + 1, GLODLGBDEPB);
		}

		public int OIJBEKILIOM(int KKMNKJJENIL, int ENMLICFLHAO, Predicate<T> GLODLGBDEPB)
		{
			JEBMHGOKPHM(GLODLGBDEPB);
			int num = KKMNKJJENIL - ENMLICFLHAO + 1;
			OCDHDNHIHDP(num, ENMLICFLHAO);
			return IGENIBDKPJA(num, ENMLICFLHAO, GLODLGBDEPB);
		}

		private int IGENIBDKPJA(int KKMNKJJENIL, int ENMLICFLHAO, Predicate<T> GLODLGBDEPB)
		{
			int num = KKMNKJJENIL + ENMLICFLHAO;
			while (num != KKMNKJJENIL)
			{
				if (GLODLGBDEPB(Items[--num]))
				{
					return num;
				}
			}
			return -1;
		}

		public void GOHFNCCEJKF(Action<T> GPLIOLJFDPM)
		{
			if (GPLIOLJFDPM == null)
			{
				throw new ArgumentNullException("action");
			}
			for (int i = 0; i < Count; i++)
			{
				GPLIOLJFDPM(Items[i]);
			}
		}

		public Enumerator FIFMNBJLBFK()
		{
			return new Enumerator(this);
		}

		public ExposedList<T> GJAHALNBLHO(int EHJNMODJEAN, int ENMLICFLHAO)
		{
			OCDHDNHIHDP(EHJNMODJEAN, ENMLICFLHAO);
			T[] array = new T[ENMLICFLHAO];
			Array.Copy(Items, EHJNMODJEAN, array, 0, ENMLICFLHAO);
			return new ExposedList<T>(array, ENMLICFLHAO);
		}

		public int NFLFPHCMIOK(T EJCNAJOHBFI)
		{
			return Array.IndexOf(Items, EJCNAJOHBFI, 0, Count);
		}

		public int NFLFPHCMIOK(T EJCNAJOHBFI, int EHJNMODJEAN)
		{
			CCLNIJEGPCI(EHJNMODJEAN);
			return Array.IndexOf(Items, EJCNAJOHBFI, EHJNMODJEAN, Count - EHJNMODJEAN);
		}

		public int NFLFPHCMIOK(T EJCNAJOHBFI, int EHJNMODJEAN, int ENMLICFLHAO)
		{
			if (EHJNMODJEAN < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (ENMLICFLHAO < 0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if ((uint)(EHJNMODJEAN + ENMLICFLHAO) > (uint)Count)
			{
				throw new ArgumentOutOfRangeException("index and count exceed length of list");
			}
			return Array.IndexOf(Items, EJCNAJOHBFI, EHJNMODJEAN, ENMLICFLHAO);
		}

		private void FMLAJIGEAKE(int EHGOOEHDNMM, int IEDLOAAAKAJ)
		{
			if (IEDLOAAAKAJ < 0)
			{
				EHGOOEHDNMM -= IEDLOAAAKAJ;
			}
			if (EHGOOEHDNMM < Count)
			{
				Array.Copy(Items, EHGOOEHDNMM, Items, EHGOOEHDNMM + IEDLOAAAKAJ, Count - EHGOOEHDNMM);
			}
			Count += IEDLOAAAKAJ;
			if (IEDLOAAAKAJ < 0)
			{
				Array.Clear(Items, Count, -IEDLOAAAKAJ);
			}
		}

		private void CCLNIJEGPCI(int EHJNMODJEAN)
		{
			if (EHJNMODJEAN < 0 || (uint)EHJNMODJEAN > (uint)Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
		}

		public void GKEGKCPCKJG(int EHJNMODJEAN, T EJCNAJOHBFI)
		{
			CCLNIJEGPCI(EHJNMODJEAN);
			if (Count == Items.Length)
			{
				JGGCKJABGHP(1);
			}
			FMLAJIGEAKE(EHJNMODJEAN, 1);
			Items[EHJNMODJEAN] = EJCNAJOHBFI;
			version++;
		}

		private void GGIAFHJCPNF(IEnumerable<T> GDOLNBCOCDC)
		{
			if (GDOLNBCOCDC == null)
			{
				throw new ArgumentNullException("collection");
			}
		}

		public void FBMKIJLIENC(int EHJNMODJEAN, IEnumerable<T> GDOLNBCOCDC)
		{
			GGIAFHJCPNF(GDOLNBCOCDC);
			CCLNIJEGPCI(EHJNMODJEAN);
			if (GDOLNBCOCDC == this)
			{
				T[] array = new T[Count];
				BACJEDDPKIJ(array, 0);
				JGGCKJABGHP(Count);
				FMLAJIGEAKE(EHJNMODJEAN, array.Length);
				Array.Copy(array, 0, Items, EHJNMODJEAN, array.Length);
			}
			else
			{
				ICollection<T> collection = GDOLNBCOCDC as ICollection<T>;
				if (collection != null)
				{
					ELCAGEHJOKC(EHJNMODJEAN, collection);
				}
				else
				{
					FMEKLPABKAG(EHJNMODJEAN, GDOLNBCOCDC);
				}
			}
			version++;
		}

		private void ELCAGEHJOKC(int EHJNMODJEAN, ICollection<T> GDOLNBCOCDC)
		{
			int count = GDOLNBCOCDC.Count;
			JGGCKJABGHP(count);
			FMLAJIGEAKE(EHJNMODJEAN, count);
			GDOLNBCOCDC.CopyTo(Items, EHJNMODJEAN);
		}

		private void FMEKLPABKAG(int EHJNMODJEAN, IEnumerable<T> NNALBMFGPCN)
		{
			foreach (T item in NNALBMFGPCN)
			{
				GKEGKCPCKJG(EHJNMODJEAN++, item);
			}
		}

		public int MCHNHOKOCIL(T EJCNAJOHBFI)
		{
			return Array.LastIndexOf(Items, EJCNAJOHBFI, Count - 1, Count);
		}

		public int MCHNHOKOCIL(T EJCNAJOHBFI, int EHJNMODJEAN)
		{
			CCLNIJEGPCI(EHJNMODJEAN);
			return Array.LastIndexOf(Items, EJCNAJOHBFI, EHJNMODJEAN, EHJNMODJEAN + 1);
		}

		public int MCHNHOKOCIL(T EJCNAJOHBFI, int EHJNMODJEAN, int ENMLICFLHAO)
		{
			if (EHJNMODJEAN < 0)
			{
				throw new ArgumentOutOfRangeException("index", EHJNMODJEAN, "index is negative");
			}
			if (ENMLICFLHAO < 0)
			{
				throw new ArgumentOutOfRangeException("count", ENMLICFLHAO, "count is negative");
			}
			if (EHJNMODJEAN - ENMLICFLHAO + 1 < 0)
			{
				throw new ArgumentOutOfRangeException("count", ENMLICFLHAO, "count is too large");
			}
			return Array.LastIndexOf(Items, EJCNAJOHBFI, EHJNMODJEAN, ENMLICFLHAO);
		}

		public bool CJOHLENDJGO(T EJCNAJOHBFI)
		{
			int num = NFLFPHCMIOK(EJCNAJOHBFI);
			if (num != -1)
			{
				LIKBJGKHDOE(num);
			}
			return num != -1;
		}

		public int BBGLCADIONK(Predicate<T> GLODLGBDEPB)
		{
			JEBMHGOKPHM(GLODLGBDEPB);
			int num = 0;
			int num2 = 0;
			for (num = 0; num < Count && !GLODLGBDEPB(Items[num]); num++)
			{
			}
			if (num == Count)
			{
				return 0;
			}
			version++;
			for (num2 = num + 1; num2 < Count; num2++)
			{
				if (!GLODLGBDEPB(Items[num2]))
				{
					Items[num++] = Items[num2];
				}
			}
			if (num2 - num > 0)
			{
				Array.Clear(Items, num, num2 - num);
			}
			Count = num;
			return num2 - num;
		}

		public void LIKBJGKHDOE(int EHJNMODJEAN)
		{
			if (EHJNMODJEAN < 0 || (uint)EHJNMODJEAN >= (uint)Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			FMLAJIGEAKE(EHJNMODJEAN, -1);
			Array.Clear(Items, Count, 1);
			version++;
		}

		public T PMGIMCDBCOB()
		{
			if (Count == 0)
			{
				throw new InvalidOperationException("List is empty. Nothing to pop.");
			}
			int num = Count - 1;
			T result = Items[num];
			Items[num] = default(T);
			Count--;
			version++;
			return result;
		}

		public void GLFFAEJKANA(int EHJNMODJEAN, int ENMLICFLHAO)
		{
			OCDHDNHIHDP(EHJNMODJEAN, ENMLICFLHAO);
			if (ENMLICFLHAO > 0)
			{
				FMLAJIGEAKE(EHJNMODJEAN, -ENMLICFLHAO);
				Array.Clear(Items, Count, ENMLICFLHAO);
				version++;
			}
		}

		public void GLGGGAHFEGL()
		{
			Array.Reverse(Items, 0, Count);
			version++;
		}

		public void GLGGGAHFEGL(int EHJNMODJEAN, int ENMLICFLHAO)
		{
			OCDHDNHIHDP(EHJNMODJEAN, ENMLICFLHAO);
			Array.Reverse(Items, EHJNMODJEAN, ENMLICFLHAO);
			version++;
		}

		public void FCNOEDGGBBO()
		{
			Array.Sort(Items, 0, Count, Comparer<T>.Default);
			version++;
		}

		public void FCNOEDGGBBO(IComparer<T> AEHAGJDIHEO)
		{
			Array.Sort(Items, 0, Count, AEHAGJDIHEO);
			version++;
		}

		public void FCNOEDGGBBO(Comparison<T> KPOGJJNPINI)
		{
			Array.Sort(Items, KPOGJJNPINI);
			version++;
		}

		public void FCNOEDGGBBO(int EHJNMODJEAN, int ENMLICFLHAO, IComparer<T> AEHAGJDIHEO)
		{
			OCDHDNHIHDP(EHJNMODJEAN, ENMLICFLHAO);
			Array.Sort(Items, EHJNMODJEAN, ENMLICFLHAO, AEHAGJDIHEO);
			version++;
		}

		public T[] GDPLKNIEGDB()
		{
			T[] array = new T[Count];
			Array.Copy(Items, array, Count);
			return array;
		}

		public void PBHLDFFHPND()
		{
			Capacity = Count;
		}

		public bool GKBLNFKODMH(Predicate<T> GLODLGBDEPB)
		{
			JEBMHGOKPHM(GLODLGBDEPB);
			for (int i = 0; i < Count; i++)
			{
				if (!GLODLGBDEPB(Items[i]))
				{
					return false;
				}
			}
			return true;
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return FIFMNBJLBFK();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return FIFMNBJLBFK();
		}
	}
}
