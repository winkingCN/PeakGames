using Dialogs;
using Ui.VerticalScroll;
using UnityEngine;
using UnityEngine.Rendering;

public class KHDBHAOFFNG
{
	private readonly global::FHOJBJMMNOD<POGHNPKEOKP, StarTournamentEntry> JKANNLPGLPJ;

	private readonly VerticalScrollEntry PPILIMLBOHA;

	private readonly int JMHEECCCKIP;

	private readonly float EDEONNLKCDF;

	private readonly float HGPPACPGBCG;

	private float DPLLMPCHLJD;

	private bool DCMONIGEKED;

	private readonly GameObject NHFJONIEMPC;

	private GameObject MIDPGHBJFCK;

	public KHDBHAOFFNG(global::FHOJBJMMNOD<POGHNPKEOKP, StarTournamentEntry> LIAJADKMKPE, GameObject OFAGDPJFEFC, VerticalScrollEntry MBLNIAACEIO, float JKNPBEOPMPK, float IBNDGNOIEEF, int EHJNMODJEAN)
	{
		JKANNLPGLPJ = LIAJADKMKPE;
		PPILIMLBOHA = MBLNIAACEIO;
		NHFJONIEMPC = OFAGDPJFEFC;
		HGPPACPGBCG = JKNPBEOPMPK;
		EDEONNLKCDF = IBNDGNOIEEF;
		JMHEECCCKIP = EHJNMODJEAN;
	}

	public void NCJIHMIBAPF()
	{
		VerticalScrollEntry verticalScrollEntry = Object.Instantiate(PPILIMLBOHA);
		verticalScrollEntry.transform.localPosition = Vector3.up * HGPPACPGBCG;
		verticalScrollEntry.transform.SetParent(JKANNLPGLPJ.MAPMKCKNGKE());
		verticalScrollEntry.transform.localPosition = verticalScrollEntry.transform.localPosition + Vector3.up * 1.24f;
		verticalScrollEntry.transform.localScale = Vector3.one * JKANNLPGLPJ.GEBNMKAGJIG;
		verticalScrollEntry.SetContent(JKANNLPGLPJ.JHBKJBFAGCB(JMHEECCCKIP));
		MIDPGHBJFCK = verticalScrollEntry.gameObject;
		PLJEFCOKOPI(false);
		SortingGroup sortingGroup = MIDPGHBJFCK.AddComponent<SortingGroup>();
		sortingGroup.sortingLayerName = "Dialogs";
		sortingGroup.sortingOrder = 120;
		DPLLMPCHLJD = JKANNLPGLPJ.FMAFOFCEPCE(JMHEECCCKIP) - EDEONNLKCDF;
	}

	public void CDHEHPKLMFC(Vector3 DLKBJLNCHBE)
	{
		MIDPGHBJFCK.transform.localPosition = DLKBJLNCHBE;
	}

	public void NNODBGKBMLK(float CAEMELGEOAE)
	{
		DPLLMPCHLJD = CAEMELGEOAE;
	}

	public void IPPIJMJLGLM(float LDMDBPLADGD)
	{
		if (DCMONIGEKED != LDMDBPLADGD < DPLLMPCHLJD)
		{
			DCMONIGEKED = !DCMONIGEKED;
			PLJEFCOKOPI(DCMONIGEKED);
		}
	}

	private void PLJEFCOKOPI(bool ABJMINLFKPM)
	{
		MIDPGHBJFCK.SetActive(ABJMINLFKPM);
		NHFJONIEMPC.SetActive(ABJMINLFKPM);
	}
}
