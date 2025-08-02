using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

public class NAAGDFCLOPE
{
	private static JDIDFKABKGN KNPOFJNFLJB;

	[CompilerGenerated]
	private static Func<string, bool> JANLDOMIIEF;

	public static JDIDFKABKGN GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				DIOELAHNLKJ();
			}
			return KNPOFJNFLJB;
		}
	}

	private NAAGDFCLOPE()
	{
	}

	private static void DIOELAHNLKJ()
	{
		KNPOFJNFLJB = new ICLJKKIOKKF();
	}

	public static bool NGLAKDICBJJ()
	{
		try
		{
			string[] source = new string[14]
			{
				"/Applications/Cydia.app", "/private/var/lib/cydia", "/private/var/tmp/cydia.log", "/System/Library/LaunchDaemons/com.saurik.Cydia.Startup.plist", "/usr/libexec/sftp-server", "/usr/bin/sshd", "/usr/sbin/sshd", "/Applications/FakeCarrier.app", "/Applications/SBSettings.app", "/Applications/WinterBoard.app",
				"/Library/MobileSubstrate/MobileSubstrate.dylib", "/etc/apt", "/bin/hash", "/private/var/lib/apt/"
			};
			return source.Any(File.Exists);
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.CaravanNativeTools, "Can not detect system files. Considering not jailed: {0}", ex.Message);
		}
		return false;
	}
}
