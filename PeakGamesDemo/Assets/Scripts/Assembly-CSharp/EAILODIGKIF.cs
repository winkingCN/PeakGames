using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

[DefaultMember("Item")]
public class EAILODIGKIF<TKey, TValue> : IDictionary<TKey, TValue>, LCCNGCJDGCF, INotifyPropertyChanged, IEnumerable, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>
{
	private const string CJFNPJEEIOD = "Count";

	private const string CJEDMNHAHKI = "Item[]";

	private const string NAPCFDPHNAM = "Keys";

	private const string EKIECNLDEIO = "Values";

	private IDictionary<TKey, TValue> IPPKPFJOBIA;

	protected IDictionary<TKey, TValue> KJEDFPOOKNL
	{
		get
		{
			return IPPKPFJOBIA;
		}
	}

	public ICollection<TKey> JDADAMJHIHM
	{
		get
		{
			return KJEDFPOOKNL.Keys;
		}
	}

	public ICollection<TValue> DPOJAOMGCME
	{
		get
		{
			return KJEDFPOOKNL.Values;
		}
	}

	public TValue AHANCLBKKID
	{
		get
		{
			return KJEDFPOOKNL[IKNCPEPOKGJ];
		}
		set
		{
			GKEGKCPCKJG(IKNCPEPOKGJ, value, false);
		}
	}

	public int GMCGMPEEHJP
	{
		get
		{
			return KJEDFPOOKNL.Count;
		}
	}

	public bool ILMKNJIIHIJ
	{
		get
		{
			return KJEDFPOOKNL.IsReadOnly;
		}
	}

	public event NBLGHLNFAGA NNLKEDBCNEM;

	public event PropertyChangedEventHandler DJIOJMCKGMF;

	public EAILODIGKIF()
	{
		IPPKPFJOBIA = new Dictionary<TKey, TValue>();
	}

	public EAILODIGKIF(IDictionary<TKey, TValue> EAPGOBAJLJE)
	{
		IPPKPFJOBIA = new Dictionary<TKey, TValue>(EAPGOBAJLJE);
	}

	public EAILODIGKIF(IEqualityComparer<TKey> AEHAGJDIHEO)
	{
		IPPKPFJOBIA = new Dictionary<TKey, TValue>(AEHAGJDIHEO);
	}

	public EAILODIGKIF(int MDPEMCMPAMB)
	{
		IPPKPFJOBIA = new Dictionary<TKey, TValue>(MDPEMCMPAMB);
	}

	public EAILODIGKIF(IDictionary<TKey, TValue> EAPGOBAJLJE, IEqualityComparer<TKey> AEHAGJDIHEO)
	{
		IPPKPFJOBIA = new Dictionary<TKey, TValue>(EAPGOBAJLJE, AEHAGJDIHEO);
	}

	public EAILODIGKIF(int MDPEMCMPAMB, IEqualityComparer<TKey> AEHAGJDIHEO)
	{
		IPPKPFJOBIA = new Dictionary<TKey, TValue>(MDPEMCMPAMB, AEHAGJDIHEO);
	}

	public void Add(TKey IKNCPEPOKGJ, TValue EDDNOJDPMCF)
	{
		GKEGKCPCKJG(IKNCPEPOKGJ, EDDNOJDPMCF, true);
	}

	public bool ContainsKey(TKey IKNCPEPOKGJ)
	{
		return KJEDFPOOKNL.ContainsKey(IKNCPEPOKGJ);
	}

	public bool Remove(TKey IKNCPEPOKGJ)
	{
		if (IKNCPEPOKGJ == null)
		{
			throw new ArgumentNullException("key");
		}
		TValue value;
		KJEDFPOOKNL.TryGetValue(IKNCPEPOKGJ, out value);
		bool flag = KJEDFPOOKNL.Remove(IKNCPEPOKGJ);
		if (flag)
		{
			AJDBLOEFFNC();
		}
		return flag;
	}

	public bool TryGetValue(TKey IKNCPEPOKGJ, out TValue EDDNOJDPMCF)
	{
		return KJEDFPOOKNL.TryGetValue(IKNCPEPOKGJ, out EDDNOJDPMCF);
	}

	public void Add(KeyValuePair<TKey, TValue> EJCNAJOHBFI)
	{
		GKEGKCPCKJG(EJCNAJOHBFI.Key, EJCNAJOHBFI.Value, true);
	}

	public void Clear()
	{
		if (KJEDFPOOKNL.Count > 0)
		{
			KJEDFPOOKNL.Clear();
			AJDBLOEFFNC();
		}
	}

	public bool Contains(KeyValuePair<TKey, TValue> EJCNAJOHBFI)
	{
		return KJEDFPOOKNL.Contains(EJCNAJOHBFI);
	}

	public void CopyTo(KeyValuePair<TKey, TValue>[] KDOGMDCDCEN, int KILNCNNBOGK)
	{
		KJEDFPOOKNL.CopyTo(KDOGMDCDCEN, KILNCNNBOGK);
	}

	public bool Remove(KeyValuePair<TKey, TValue> EJCNAJOHBFI)
	{
		return Remove(EJCNAJOHBFI.Key);
	}

	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return KJEDFPOOKNL.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable)KJEDFPOOKNL).GetEnumerator();
	}

	public void OJCDNLBIAPD(IDictionary<TKey, TValue> IEECOIONEJM)
	{
		if (IEECOIONEJM == null)
		{
			throw new ArgumentNullException("items");
		}
		if (IEECOIONEJM.Count <= 0)
		{
			return;
		}
		if (KJEDFPOOKNL.Count > 0)
		{
			if (IEECOIONEJM.Keys.Any((TKey BENKLGPHLGI) => KJEDFPOOKNL.ContainsKey(BENKLGPHLGI)))
			{
				throw new ArgumentException("An item with the same key has already been added.");
			}
			foreach (KeyValuePair<TKey, TValue> item in IEECOIONEJM)
			{
				KJEDFPOOKNL.Add(item);
			}
		}
		else
		{
			IPPKPFJOBIA = new Dictionary<TKey, TValue>(IEECOIONEJM);
		}
		AJDBLOEFFNC(GOCEGGDFJIE.Add, IEECOIONEJM.ToArray());
	}

	private void GKEGKCPCKJG(TKey IKNCPEPOKGJ, TValue EDDNOJDPMCF, bool DOIAFIHCPPL)
	{
		if (IKNCPEPOKGJ == null)
		{
			throw new ArgumentNullException("key");
		}
		TValue value;
		if (KJEDFPOOKNL.TryGetValue(IKNCPEPOKGJ, out value))
		{
			if (DOIAFIHCPPL)
			{
				throw new ArgumentException("An item with the same key has already been added.");
			}
			if (!object.Equals(value, EDDNOJDPMCF))
			{
				KJEDFPOOKNL[IKNCPEPOKGJ] = EDDNOJDPMCF;
				AJDBLOEFFNC(GOCEGGDFJIE.Replace, new KeyValuePair<TKey, TValue>(IKNCPEPOKGJ, EDDNOJDPMCF), new KeyValuePair<TKey, TValue>(IKNCPEPOKGJ, value));
			}
		}
		else
		{
			KJEDFPOOKNL[IKNCPEPOKGJ] = EDDNOJDPMCF;
			AJDBLOEFFNC(GOCEGGDFJIE.Add, new KeyValuePair<TKey, TValue>(IKNCPEPOKGJ, EDDNOJDPMCF));
		}
	}

	private void LHPAPIMDPCA()
	{
		LHPAPIMDPCA("Count");
		LHPAPIMDPCA("Item[]");
		LHPAPIMDPCA("Keys");
		LHPAPIMDPCA("Values");
	}

	protected virtual void LHPAPIMDPCA(string JLBJHIEFAFJ)
	{
		if (this.DJIOJMCKGMF != null)
		{
			this.DJIOJMCKGMF(this, new PropertyChangedEventArgs(JLBJHIEFAFJ));
		}
	}

	private void AJDBLOEFFNC()
	{
		LHPAPIMDPCA();
		if (this.NNLKEDBCNEM != null)
		{
			this.NNLKEDBCNEM(this, new DJBKCEMMGIL(GOCEGGDFJIE.Reset));
		}
	}

	private void AJDBLOEFFNC(GOCEGGDFJIE GPLIOLJFDPM, KeyValuePair<TKey, TValue> MDPMHLNPLMK)
	{
		LHPAPIMDPCA();
		if (this.NNLKEDBCNEM != null)
		{
			this.NNLKEDBCNEM(this, new DJBKCEMMGIL(GPLIOLJFDPM, MDPMHLNPLMK));
		}
	}

	private void AJDBLOEFFNC(GOCEGGDFJIE GPLIOLJFDPM, KeyValuePair<TKey, TValue> GANOIMIHIDB, KeyValuePair<TKey, TValue> MFLAFJACJPO)
	{
		LHPAPIMDPCA();
		if (this.NNLKEDBCNEM != null)
		{
			this.NNLKEDBCNEM(this, new DJBKCEMMGIL(GPLIOLJFDPM, GANOIMIHIDB, MFLAFJACJPO));
		}
	}

	private void AJDBLOEFFNC(GOCEGGDFJIE GPLIOLJFDPM, IList CGHHOLLIOAE)
	{
		LHPAPIMDPCA();
		if (this.NNLKEDBCNEM != null)
		{
			this.NNLKEDBCNEM(this, new DJBKCEMMGIL(GPLIOLJFDPM, CGHHOLLIOAE));
		}
	}

	[CompilerGenerated]
	private bool EDADDJCKOAP(TKey BENKLGPHLGI)
	{
		return KJEDFPOOKNL.ContainsKey(BENKLGPHLGI);
	}
}
