using System;
using System.IO;
using caravan.protobuf.messages;

public abstract class IKDMCJPBBIH
{
	public int EEFMIHDPJPG;

	public long GDMECFECCOM;

	protected NADPOFCHCON ICKPFMKIIBM;

	public abstract MessageTypes LOICNFDHCJK { get; }

	public void IPAKPIGIJHK()
	{
		if (ICKPFMKIIBM == null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Command, "Command has no replies: {0}, Id:{1}", LOICNFDHCJK, EEFMIHDPJPG);
			return;
		}
		GBJNCLLOCJB gBJNCLLOCJB = ICKPFMKIIBM.EFIMKKLBHPM();
		GBJNCLLOCJB jBJJMKONACJ = ICKPFMKIIBM.JBJJMKONACJ;
		if (gBJNCLLOCJB == GBJNCLLOCJB.ResultSuccess && jBJJMKONACJ == GBJNCLLOCJB.ResultSuccess)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Command, "Success: {0}, Id:{1}", LOICNFDHCJK, EEFMIHDPJPG);
			ICKPFMKIIBM.JLECFJEAFCD();
		}
		else
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Command, "Failed on CommandLevel: {0}, Id:{1}, S:{2}, C:{3}", LOICNFDHCJK, EEFMIHDPJPG, jBJJMKONACJ, gBJNCLLOCJB);
			ICKPFMKIIBM.AIGOFKAJFBM();
		}
	}

	public void HBCDLJHLOMK(bool FCFNMGAMKCJ, GBJNCLLOCJB OJCKIOENBEL)
	{
		GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Command, "Command Failed (RequestLevel): {0}, Id:{1}, Status:{2}", LOICNFDHCJK, EEFMIHDPJPG, OJCKIOENBEL);
		if (ICKPFMKIIBM != null)
		{
			ICKPFMKIIBM.AIGOFKAJFBM();
			return;
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Command, "No Reply! Executing FailedAndNoReply for {0},{1}", LOICNFDHCJK, EEFMIHDPJPG);
		HOBMBHFKMJI(FCFNMGAMKCJ);
	}

	public virtual void HOBMBHFKMJI(bool FCFNMGAMKCJ)
	{
	}

	public abstract GenericMessage DIMAFEDACMK();

	protected GenericMessage BFEDIIJOFCG(MessageTypes JFKPBEAPMDC)
	{
		GenericMessage genericMessage = new GenericMessage();
		genericMessage.type = JFKPBEAPMDC;
		genericMessage.id = EEFMIHDPJPG;
		return genericMessage;
	}

	protected static void MCAAJOHOFGL<R>(R FNHFILKPEDI, GenericMessage GDFBAKKHFIC)
	{
		using (MemoryStream memoryStream = new MemoryStream())
		{
			KIHMBFDKLJM.GABGKBAKHDP.BGGEDOONAPL.Serialize(memoryStream, FNHFILKPEDI);
			GDFBAKKHFIC.data = memoryStream.ToArray();
		}
	}

	public void GKPOLPBJIBG(GenericMessage GDFBAKKHFIC)
	{
		if (GDFBAKKHFIC == null)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Command, "A command does not have a response with id {0} ", EEFMIHDPJPG);
			ICKPFMKIIBM = new NADPOFCHCON(this, GBJNCLLOCJB.NoId);
			return;
		}
		if (GDFBAKKHFIC.id != EEFMIHDPJPG)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Command, "Response Id and Request Id do not match!");
			ICKPFMKIIBM = new NADPOFCHCON(this, GBJNCLLOCJB.IdDoesNotMatch);
			return;
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Command, "Processing message type: {0}", GDFBAKKHFIC.type);
		if (GDFBAKKHFIC.type != CNBNEEJFGHI())
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Command, "Command reply should be {0}. Marking as failed. However it is: {1}", CNBNEEJFGHI(), GDFBAKKHFIC.type);
			ICKPFMKIIBM = new NADPOFCHCON(this, GBJNCLLOCJB.MsgTypeNotCorrect);
			return;
		}
		Type type = JLFLPEDHMOE();
		if (type != null)
		{
			byte[] data = GDFBAKKHFIC.data;
			using (Stream source = new MemoryStream(data))
			{
				object obj = KIHMBFDKLJM.GABGKBAKHDP.BGGEDOONAPL.Deserialize(source, null, type);
				if (obj == null)
				{
					ICKPFMKIIBM = new NADPOFCHCON(this, GBJNCLLOCJB.CanNotDeserialize);
				}
				else
				{
					NLMICJNOMCD(obj, GDFBAKKHFIC.resultCode);
				}
				return;
			}
		}
		NLMICJNOMCD(null, GDFBAKKHFIC.resultCode);
	}

	public virtual bool NAFCDEECGEF()
	{
		return true;
	}

	protected abstract MessageTypes CNBNEEJFGHI();

	protected abstract Type JLFLPEDHMOE();

	protected abstract void NLMICJNOMCD(object OMJOIIOONMO, ResultCodes NONNALMDLEL);

	public virtual int MCFABAAMELG()
	{
		return 10;
	}

	public void LIFPNHAFPHP(int BDKFNEDHAOJ)
	{
		EEFMIHDPJPG = BDKFNEDHAOJ;
		GDMECFECCOM = LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM;
	}
}
