using System.Collections.Generic;

namespace BestHTTP.SocketIO.JsonEncoders
{
	public sealed class LitJsonEncoder : IJsonEncoder
	{
		public List<object> Decode(string json)
		{
			FEECFKHIBHI jIGJDAHIIBA = new FEECFKHIBHI(json);
			return IHDGPBGOHBP.DMJOGBEIBNM<List<object>>(jIGJDAHIIBA);
		}

		public string Encode(List<object> obj)
		{
			JGHOOMMOCFJ jGHOOMMOCFJ = new JGHOOMMOCFJ();
			IHDGPBGOHBP.PDBENFDNJAI(obj, jGHOOMMOCFJ);
			return jGHOOMMOCFJ.ToString();
		}
	}
}
