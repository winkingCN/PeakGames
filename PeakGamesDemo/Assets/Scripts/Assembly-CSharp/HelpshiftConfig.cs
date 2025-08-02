using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class HelpshiftConfig : ScriptableObject
{
	private static HelpshiftConfig instance;

	private const string helpshiftConfigAssetName = "HelpshiftConfig";

	private const string helpshiftConfigPath = "Helpshift/Resources";

	public const string pluginVersion = "3.0.0";

	[SerializeField]
	private string apiKey;

	[SerializeField]
	private string domainName;

	[SerializeField]
	private string iosAppId;

	[SerializeField]
	private string androidAppId;

	[SerializeField]
	private int contactUsOption;

	[SerializeField]
	private bool gotoConversation;

	[SerializeField]
	private bool presentFullScreen;

	[SerializeField]
	private int enableInAppNotification = 2;

	[SerializeField]
	private bool requireEmail;

	[SerializeField]
	private bool hideNameAndEmail;

	[SerializeField]
	private bool enablePrivacy;

	[SerializeField]
	private bool showSearchOnNewConversation;

	[SerializeField]
	private int showConversationResolutionQuestion = 2;

	[SerializeField]
	private int enableDefaultFallbackLanguage = 2;

	[SerializeField]
	private bool disableEntryExitAnimations;

	[SerializeField]
	private string conversationPrefillText;

	[SerializeField]
	private bool enableInboxPolling = true;

	[SerializeField]
	private bool enableLogging;

	[SerializeField]
	private bool enableTypingIndicator;

	[SerializeField]
	private int screenOrientation = -1;

	[SerializeField]
	private bool showConversationInfoScreen;

	private string[] contactUsOptions = new string[4] { "always", "never", "after_viewing_faqs", "after_marking_answer_unhelpful" };

	[SerializeField]
	private string unityGameObject;

	[SerializeField]
	private string notificationIcon;

	[SerializeField]
	private string largeNotificationIcon;

	[SerializeField]
	private string notificationSound;

	[SerializeField]
	private string customFont;

	[SerializeField]
	private string supportNotificationChannel;

	[SerializeField]
	private string campaignsNotificationChannel;

	public static HelpshiftConfig Instance
	{
		get
		{
			instance = Resources.Load("HelpshiftConfig") as HelpshiftConfig;
			if (instance == null)
			{
				instance = ScriptableObject.CreateInstance<HelpshiftConfig>();
			}
			return instance;
		}
	}

	public bool GotoConversation
	{
		get
		{
			return gotoConversation;
		}
		set
		{
			if (gotoConversation != value)
			{
				gotoConversation = value;
			}
		}
	}

	public int ContactUs
	{
		get
		{
			return contactUsOption;
		}
		set
		{
			if (contactUsOption != value)
			{
				contactUsOption = value;
			}
		}
	}

	public bool PresentFullScreenOniPad
	{
		get
		{
			return presentFullScreen;
		}
		set
		{
			if (presentFullScreen != value)
			{
				presentFullScreen = value;
			}
		}
	}

	public bool EnableInAppNotification
	{
		get
		{
			return enableInAppNotification != 0;
		}
		set
		{
			if (enableInAppNotification != Convert.ToInt32(value))
			{
				enableInAppNotification = Convert.ToInt32(value);
			}
		}
	}

	public bool RequireEmail
	{
		get
		{
			return requireEmail;
		}
		set
		{
			if (requireEmail != value)
			{
				requireEmail = value;
			}
		}
	}

	public bool HideNameAndEmail
	{
		get
		{
			return hideNameAndEmail;
		}
		set
		{
			if (hideNameAndEmail != value)
			{
				hideNameAndEmail = value;
			}
		}
	}

	public bool EnablePrivacy
	{
		get
		{
			return enablePrivacy;
		}
		set
		{
			if (enablePrivacy != value)
			{
				enablePrivacy = value;
			}
		}
	}

	public bool ShowSearchOnNewConversation
	{
		get
		{
			return showSearchOnNewConversation;
		}
		set
		{
			if (showSearchOnNewConversation != value)
			{
				showSearchOnNewConversation = value;
			}
		}
	}

	public bool ShowConversationResolutionQuestion
	{
		get
		{
			return showConversationResolutionQuestion != 0;
		}
		set
		{
			if (showConversationResolutionQuestion != Convert.ToInt32(value))
			{
				showConversationResolutionQuestion = Convert.ToInt32(value);
			}
		}
	}

	public bool EnableDefaultFallbackLanguage
	{
		get
		{
			return enableDefaultFallbackLanguage != 0;
		}
		set
		{
			if (enableDefaultFallbackLanguage != Convert.ToInt32(value))
			{
				enableDefaultFallbackLanguage = Convert.ToInt32(value);
			}
		}
	}

	public bool DisableEntryExitAnimations
	{
		get
		{
			return disableEntryExitAnimations;
		}
		set
		{
			if (disableEntryExitAnimations != value)
			{
				disableEntryExitAnimations = value;
			}
		}
	}

	public string ConversationPrefillText
	{
		get
		{
			return conversationPrefillText;
		}
		set
		{
			if (conversationPrefillText != value)
			{
				conversationPrefillText = value;
			}
		}
	}

	public string ApiKey
	{
		get
		{
			return apiKey;
		}
		set
		{
			if (apiKey != value)
			{
				apiKey = value;
			}
		}
	}

	public string DomainName
	{
		get
		{
			return domainName;
		}
		set
		{
			if (domainName != value)
			{
				domainName = value;
			}
		}
	}

	public string AndroidAppId
	{
		get
		{
			return androidAppId;
		}
		set
		{
			if (androidAppId != value)
			{
				androidAppId = value;
			}
		}
	}

	public string iOSAppId
	{
		get
		{
			return iosAppId;
		}
		set
		{
			if (iosAppId != value)
			{
				iosAppId = value;
			}
		}
	}

	public string UnityGameObject
	{
		get
		{
			return unityGameObject;
		}
		set
		{
			if (unityGameObject != value)
			{
				unityGameObject = value;
			}
		}
	}

	public string NotificationIcon
	{
		get
		{
			return notificationIcon;
		}
		set
		{
			if (notificationIcon != value)
			{
				notificationIcon = value;
			}
		}
	}

	public string LargeNotificationIcon
	{
		get
		{
			return largeNotificationIcon;
		}
		set
		{
			if (largeNotificationIcon != value)
			{
				largeNotificationIcon = value;
			}
		}
	}

	public string NotificationSound
	{
		get
		{
			return notificationSound;
		}
		set
		{
			if (notificationSound != value)
			{
				notificationSound = value;
			}
		}
	}

	public string CustomFont
	{
		get
		{
			return customFont;
		}
		set
		{
			if (customFont != value)
			{
				customFont = value;
			}
		}
	}

	public string SupportNotificationChannel
	{
		get
		{
			return supportNotificationChannel;
		}
		set
		{
			if (supportNotificationChannel != value)
			{
				supportNotificationChannel = value;
			}
		}
	}

	public string CampaignsNotificationChannel
	{
		get
		{
			return campaignsNotificationChannel;
		}
		set
		{
			if (campaignsNotificationChannel != value)
			{
				campaignsNotificationChannel = value;
			}
		}
	}

	public bool EnableInboxPolling
	{
		get
		{
			return enableInboxPolling;
		}
		set
		{
			if (enableInboxPolling != value)
			{
				enableInboxPolling = value;
			}
		}
	}

	public bool EnableLogging
	{
		get
		{
			return enableLogging;
		}
		set
		{
			if (enableLogging != value)
			{
				enableLogging = value;
			}
		}
	}

	public bool EnableTypingIndicator
	{
		get
		{
			return enableTypingIndicator;
		}
		set
		{
			if (enableTypingIndicator != value)
			{
				enableTypingIndicator = value;
			}
		}
	}

	public int ScreenOrientation
	{
		get
		{
			return screenOrientation;
		}
		set
		{
			if (screenOrientation != value)
			{
				screenOrientation = value;
			}
		}
	}

	public bool ShowConversationInfoScreen
	{
		get
		{
			return showConversationInfoScreen;
		}
		set
		{
			if (showConversationInfoScreen != value)
			{
				showConversationInfoScreen = value;
			}
		}
	}

	public Dictionary<string, object> InstallConfig
	{
		get
		{
			return instance.EFOMKJLAKAO();
		}
	}

	public Dictionary<string, object> ApiConfig
	{
		get
		{
			return instance.JCBOFDKGLIG();
		}
	}

	public void LLDICEDNDEG()
	{
	}

	public Dictionary<string, object> JCBOFDKGLIG()
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		string value = instance.contactUsOptions[instance.contactUsOption];
		dictionary.Add("enableContactUs", value);
		dictionary.Add("gotoConversationAfterContactUs", (!instance.gotoConversation) ? "no" : "yes");
		dictionary.Add("presentFullScreenOniPad", (!instance.presentFullScreen) ? "no" : "yes");
		dictionary.Add("requireEmail", (!instance.requireEmail) ? "no" : "yes");
		dictionary.Add("hideNameAndEmail", (!instance.hideNameAndEmail) ? "no" : "yes");
		dictionary.Add("enableFullPrivacy", (!instance.enablePrivacy) ? "no" : "yes");
		dictionary.Add("showSearchOnNewConversation", (!instance.showSearchOnNewConversation) ? "no" : "yes");
		dictionary.Add("showConversationResolutionQuestion", (instance.showConversationResolutionQuestion != 0) ? "yes" : "no");
		dictionary.Add("enableTypingIndicator", (!instance.enableTypingIndicator) ? "no" : "yes");
		dictionary.Add("conversationPrefillText", instance.conversationPrefillText);
		dictionary.Add("showConversationInfoScreen", (!instance.showConversationInfoScreen) ? "no" : "yes");
		return dictionary;
	}

	public Dictionary<string, object> EFOMKJLAKAO()
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add("sdkType", "unity");
		dictionary.Add("pluginVersion", "3.0.0");
		dictionary.Add("runtimeVersion", Application.unityVersion);
		dictionary.Add("unityGameObject", instance.unityGameObject);
		dictionary.Add("notificationIcon", instance.notificationIcon);
		dictionary.Add("largeNotificationIcon", instance.largeNotificationIcon);
		dictionary.Add("notificationSound", instance.notificationSound);
		dictionary.Add("font", instance.customFont);
		dictionary.Add("supportNotificationChannelId", instance.supportNotificationChannel);
		dictionary.Add("campaignsNotificationChannelId", instance.campaignsNotificationChannel);
		dictionary.Add("enableInAppNotification", (instance.enableInAppNotification != 0) ? "yes" : "no");
		dictionary.Add("enableDefaultFallbackLanguage", (instance.enableDefaultFallbackLanguage != 0) ? "yes" : "no");
		dictionary.Add("disableEntryExitAnimations", (!instance.disableEntryExitAnimations) ? "no" : "yes");
		dictionary.Add("__hs__apiKey", instance.ApiKey);
		dictionary.Add("__hs__domainName", instance.DomainName);
		dictionary.Add("enableInboxPolling", (!instance.enableInboxPolling) ? "no" : "yes");
		dictionary.Add("enableLogging", (!instance.enableLogging) ? "no" : "yes");
		dictionary.Add("screenOrientation", instance.screenOrientation);
		return dictionary;
	}
}
