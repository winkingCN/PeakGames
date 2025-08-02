public abstract class MMFNPAKGMJD
{
	public const byte EMBDKECCNLL = 0;

	public const byte CLLPKGCODAH = 10;

	public const byte CNKJFHOJAEC = 20;

	public const byte CFNIKNGLDLJ = 21;

	public const byte CEOEJLLAIMH = 22;

	public const byte FLMKLFINIFI = 30;

	public const byte PPAMADFNIOO = 40;

	public const byte MOJGKPKPOLD = 41;

	public const byte KHOFOKDOCMB = 42;

	public const byte JGCHCGCDMGH = 43;

	public const byte PMOMFJLFKJH = 44;

	public const byte MLABFIJBJGL = 45;

	public const byte JBNBBADGKGL = 46;

	public const byte LLONHGFAGAL = 47;

	public const byte IBOCGPHECLK = 48;

	public const byte ANCPJPGMNNJ = 49;

	public const byte CKFGKFCHKIL = 50;

	public const byte ADGLJPCHBCL = 51;

	public const byte FDDBMCJODFD = 60;

	public const byte ADMFIAHICPP = 70;

	public const byte HNHCCDDLDEA = 71;

	public const byte HOIHEBJKMBH = 80;

	public const byte APGICKBKCMM = 90;

	public const byte PCAHPIDALGM = 100;

	public const byte OBPHAHPOINP = 110;

	public const byte DCIOCGOILGO = 111;

	public const byte GMFEDFGNJID = 112;

	public const byte GJGGKIEKIOE = 113;

	public const byte FGDDGJJLDNH = 114;

	public const byte DLOPIMNBICC = 115;

	public const byte NFDFLEFPHJM = 86;

	public static string CILJKDELPFP(byte LHIDNPKMPPJ)
	{
		switch (LHIDNPKMPPJ)
		{
		case 0:
			return "close_notify";
		case 10:
			return "unexpected_message";
		case 20:
			return "bad_record_mac";
		case 21:
			return "decryption_failed";
		case 22:
			return "record_overflow";
		case 30:
			return "decompression_failure";
		case 40:
			return "handshake_failure";
		case 41:
			return "no_certificate";
		case 42:
			return "bad_certificate";
		case 43:
			return "unsupported_certificate";
		case 44:
			return "certificate_revoked";
		case 45:
			return "certificate_expired";
		case 46:
			return "certificate_unknown";
		case 47:
			return "illegal_parameter";
		case 48:
			return "unknown_ca";
		case 49:
			return "access_denied";
		case 50:
			return "decode_error";
		case 51:
			return "decrypt_error";
		case 60:
			return "export_restriction";
		case 70:
			return "protocol_version";
		case 71:
			return "insufficient_security";
		case 80:
			return "internal_error";
		case 90:
			return "user_canceled";
		case 100:
			return "no_renegotiation";
		case 110:
			return "unsupported_extension";
		case 111:
			return "certificate_unobtainable";
		case 112:
			return "unrecognized_name";
		case 113:
			return "bad_certificate_status_response";
		case 114:
			return "bad_certificate_hash_value";
		case 115:
			return "unknown_psk_identity";
		case 86:
			return "inappropriate_fallback";
		default:
			return "UNKNOWN";
		}
	}

	public static string GMPMIOJECLI(byte LHIDNPKMPPJ)
	{
		return CILJKDELPFP(LHIDNPKMPPJ) + "(" + LHIDNPKMPPJ + ")";
	}
}
