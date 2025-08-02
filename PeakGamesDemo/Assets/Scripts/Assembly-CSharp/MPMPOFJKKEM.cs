using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

internal class MPMPOFJKKEM : NGLCIALNDGA
{
	public class BDGKKNDEJLG : Exception
	{
		public BDGKKNDEJLG(string OEFCOJLNCKP)
			: base(OEFCOJLNCKP)
		{
		}
	}

	private readonly List<IntPtr> PHEFFKBMAIA = new List<IntPtr>();

	private AndroidJavaObject NHDFFFHJAHE;

	private AndroidJavaClass EKNCFDHDEAC;

	private AndroidJavaObject IACLMEKOOJO;

	private AndroidJavaObject IIDBEOBBIGI
	{
		get
		{
			if (NHDFFFHJAHE == null)
			{
				NHDFFFHJAHE = new AndroidJavaObject("com.crashlytics.android.Crashlytics");
			}
			return NHDFFFHJAHE;
		}
	}

	private AndroidJavaClass NPAELIPCPIA
	{
		get
		{
			if (EKNCFDHDEAC == null)
			{
				EKNCFDHDEAC = new AndroidJavaClass("io.fabric.unity.crashlytics.android.CrashlyticsAndroidWrapper");
			}
			return EKNCFDHDEAC;
		}
	}

	private AndroidJavaObject GABGKBAKHDP
	{
		get
		{
			if (IACLMEKOOJO == null)
			{
				IACLMEKOOJO = IIDBEOBBIGI.CallStatic<AndroidJavaObject>("getInstance", new object[0]);
			}
			if (IACLMEKOOJO == null)
			{
				throw new BDGKKNDEJLG("Couldn't get an instance of the Crashlytics class!");
			}
			return IACLMEKOOJO;
		}
	}

	public override void LEKBJGOMHNP()
	{
		NPAELIPCPIA.CallStatic("crash");
	}

	public override void ILNNDCGJCKG(string OEFCOJLNCKP)
	{
		GABGKBAKHDP.CallStatic("log", OEFCOJLNCKP);
	}

	public override void JEMODHFMDHO(string IKNCPEPOKGJ, string EDDNOJDPMCF)
	{
		GABGKBAKHDP.CallStatic("setString", IKNCPEPOKGJ, EDDNOJDPMCF);
	}

	public override void AJDNJDFOGOH(string GMBNJCKNOBD)
	{
		GABGKBAKHDP.CallStatic("setUserIdentifier", GMBNJCKNOBD);
	}

	public override void CHBONNOODHO(string HCMFNNPEKDN)
	{
		GABGKBAKHDP.CallStatic("setUserEmail", HCMFNNPEKDN);
	}

	public override void NFKIHNEPNFJ(string IOCMOCCFALN)
	{
		GABGKBAKHDP.CallStatic("setUserName", IOCMOCCFALN);
	}

	public override void JFPLDMEBIJH(string IOCMOCCFALN, string OJCKIOENBEL, StackTrace MECGPCLCGKG)
	{
		JFPLDMEBIJH(IOCMOCCFALN, OJCKIOENBEL, MECGPCLCGKG.ToString());
	}

	public override void JFPLDMEBIJH(string IOCMOCCFALN, string OJCKIOENBEL, string OEJFCIGGCHA)
	{
		PHEFFKBMAIA.Clear();
		IntPtr clazz = AndroidJNI.FindClass("java/lang/Exception");
		IntPtr methodID = AndroidJNI.GetMethodID(clazz, "<init>", "(Ljava/lang/String;)V");
		jvalue[] array = new jvalue[1];
		array[0].l = AndroidJNI.NewStringUTF(IOCMOCCFALN + " : " + OJCKIOENBEL);
		IntPtr intPtr = AndroidJNI.NewObject(clazz, methodID, array);
		PHEFFKBMAIA.Add(array[0].l);
		PHEFFKBMAIA.Add(intPtr);
		IntPtr clazz2 = AndroidJNI.FindClass("java/lang/StackTraceElement");
		IntPtr methodID2 = AndroidJNI.GetMethodID(clazz2, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V");
		Dictionary<string, string>[] array2 = NGLCIALNDGA.EEBPMDNNGFJ(OEJFCIGGCHA);
		IntPtr intPtr2 = AndroidJNI.NewObjectArray(array2.Length, clazz2, IntPtr.Zero);
		PHEFFKBMAIA.Add(intPtr2);
		for (int i = 0; i < array2.Length; i++)
		{
			Dictionary<string, string> dictionary = array2[i];
			jvalue[] array3 = new jvalue[4];
			array3[0].l = AndroidJNI.NewStringUTF(dictionary["class"]);
			array3[1].l = AndroidJNI.NewStringUTF(dictionary["method"]);
			array3[2].l = AndroidJNI.NewStringUTF(dictionary["file"]);
			PHEFFKBMAIA.Add(array3[0].l);
			PHEFFKBMAIA.Add(array3[1].l);
			PHEFFKBMAIA.Add(array3[2].l);
			array3[3].i = int.Parse(dictionary["line"]);
			IntPtr intPtr3 = AndroidJNI.NewObject(clazz2, methodID2, array3);
			PHEFFKBMAIA.Add(intPtr3);
			AndroidJNI.SetObjectArrayElement(intPtr2, i, intPtr3);
		}
		IntPtr methodID3 = AndroidJNI.GetMethodID(clazz, "setStackTrace", "([Ljava/lang/StackTraceElement;)V");
		jvalue[] array4 = new jvalue[1];
		array4[0].l = intPtr2;
		AndroidJNI.CallVoidMethod(intPtr, methodID3, array4);
		IntPtr clazz3 = AndroidJNI.FindClass("com/crashlytics/android/Crashlytics");
		IntPtr staticMethodID = AndroidJNI.GetStaticMethodID(clazz3, "logException", "(Ljava/lang/Throwable;)V");
		jvalue[] array5 = new jvalue[1];
		array5[0].l = intPtr;
		AndroidJNI.CallStaticVoidMethod(clazz3, staticMethodID, array5);
		foreach (IntPtr pHEFFKBMAIum in PHEFFKBMAIA)
		{
			AndroidJNI.DeleteLocalRef(pHEFFKBMAIum);
		}
	}
}
