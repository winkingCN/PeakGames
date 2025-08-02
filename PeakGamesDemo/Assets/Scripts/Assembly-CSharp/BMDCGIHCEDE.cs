using System;
using caravan.protobuf.messages;

public class BMDCGIHCEDE : IKDMCJPBBIH
{
	public readonly string MKAHOEOFHDM;

	public readonly string ACMDKLDPDLB;

	public readonly string HDGCPKIEBDE;

	public readonly string EPAHOGAEDIB;

	private const int GHAOBBIJAON = 1;

	public bool GPMFHHMEBOO;

	public bool EOHFELACNEA;

	public bool CDLDCBCKJFG;

	public bool LIGMDMEJIDB;

	public string IJGFHAKOCNH;

	public override MessageTypes LOICNFDHCJK
	{
		get
		{
			return MessageTypes.VALIDATE_PAYMENT_MSG;
		}
	}

	public BMDCGIHCEDE(string PINNJBGMGOA, string CIDGIIHKCFN, string LFCPPDHKCOA, string JELMKJDBGBN)
	{
		MKAHOEOFHDM = LFCPPDHKCOA;
		ACMDKLDPDLB = PINNJBGMGOA;
		EPAHOGAEDIB = CIDGIIHKCFN;
		HDGCPKIEBDE = JELMKJDBGBN;
	}

	public override void HOBMBHFKMJI(bool FCFNMGAMKCJ)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ValidatePaymentReply, "Payment failed (no response).");
		GPMFHHMEBOO = true;
		CDLDCBCKJFG = false;
		LIGMDMEJIDB = false;
		EOHFELACNEA = false;
	}

	public override GenericMessage DIMAFEDACMK()
	{
		GenericMessage genericMessage = BFEDIIJOFCG(LOICNFDHCJK);
		ValidatePaymentMessage validatePaymentMessage = new ValidatePaymentMessage();
		validatePaymentMessage.message = ACMDKLDPDLB;
		validatePaymentMessage.receipt = EPAHOGAEDIB;
		validatePaymentMessage.store = 1;
		validatePaymentMessage.transactionId = MKAHOEOFHDM;
		validatePaymentMessage.productId = HDGCPKIEBDE;
		ValidatePaymentMessage fNHFILKPEDI = validatePaymentMessage;
		IKDMCJPBBIH.MCAAJOHOFGL(fNHFILKPEDI, genericMessage);
		return genericMessage;
	}

	protected override MessageTypes CNBNEEJFGHI()
	{
		return MessageTypes.VALIDATE_PAYMENT_RESPONSE_MSG;
	}

	protected override Type JLFLPEDHMOE()
	{
		return typeof(ValidatePaymentResponseMessage);
	}

	public override int MCFABAAMELG()
	{
		return 14;
	}

	protected override void NLMICJNOMCD(object OMJOIIOONMO, ResultCodes NONNALMDLEL)
	{
		ValidatePaymentResponseMessage fKMLFBJGCMF = (ValidatePaymentResponseMessage)OMJOIIOONMO;
		ICKPFMKIIBM = new EIPHDMONLEG(this, fKMLFBJGCMF, NONNALMDLEL.KMJBHHCCJFD());
	}
}
