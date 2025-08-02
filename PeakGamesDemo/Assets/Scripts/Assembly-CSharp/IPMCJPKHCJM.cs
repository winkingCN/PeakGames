using BestHTTP;
using caravan.protobuf.messages;

public static class IPMCJPKHCJM
{
	public static GBJNCLLOCJB KMJBHHCCJFD(this HTTPRequestStates FJCNPLPKFKP)
	{
		switch (FJCNPLPKFKP)
		{
		case HTTPRequestStates.Initial:
			return GBJNCLLOCJB.HttpInitial;
		case HTTPRequestStates.Queued:
			return GBJNCLLOCJB.HttpQueued;
		case HTTPRequestStates.Processing:
			return GBJNCLLOCJB.HttpProcessing;
		case HTTPRequestStates.Finished:
			return GBJNCLLOCJB.HttpFinished;
		case HTTPRequestStates.Error:
			return GBJNCLLOCJB.HttpError;
		case HTTPRequestStates.Aborted:
			return GBJNCLLOCJB.HttpAborted;
		case HTTPRequestStates.ConnectionTimedOut:
			return GBJNCLLOCJB.HttpConnectionTimedOut;
		case HTTPRequestStates.TimedOut:
			return GBJNCLLOCJB.HttpTimedOut;
		default:
			return GBJNCLLOCJB.HttpNone;
		}
	}

	public static GBJNCLLOCJB KMJBHHCCJFD(this ResultCodes FJCNPLPKFKP)
	{
		switch (FJCNPLPKFKP)
		{
		case ResultCodes.RESULT_SUCCESS:
			return GBJNCLLOCJB.ResultSuccess;
		case ResultCodes.RESULT_FAIL_GENERIC:
			return GBJNCLLOCJB.ResultFailGeneric;
		case ResultCodes.RESULT_FAIL_PARSE_ERROR:
			return GBJNCLLOCJB.ResultFailParseError;
		case ResultCodes.RESULT_UNDER_MAINTENANCE:
			return GBJNCLLOCJB.ResultUnderMaintenance;
		case ResultCodes.RESULT_NO_SUCH_USER:
			return GBJNCLLOCJB.ResultNoSuchUser;
		case ResultCodes.RESULT_INVALID_TOKEN:
			return GBJNCLLOCJB.ResultInvalidToken;
		case ResultCodes.RESULT_INVALID_FB_CONNECT_SCENARIO:
			return GBJNCLLOCJB.ResultInvalidFbConnectScenario;
		case ResultCodes.RESULT_OUT_OF_SYNC:
			return GBJNCLLOCJB.ResultOutOfSync;
		case ResultCodes.RESULT_DEVICE_BAN:
			return GBJNCLLOCJB.ResultDeviceBan;
		default:
			return GBJNCLLOCJB.ResultUnknownBackendStatus;
		}
	}
}
