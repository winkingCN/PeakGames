Shader "Unlit/Gradient3Color" {
	Properties {
		_MainTex ("Texture", 2D) = "white" {}
		_ColorTop ("Top Color", Vector) = (1,1,1,1)
		_ColorMid ("Mid Color", Vector) = (1,1,1,1)
		_ColorBot ("Bot Color", Vector) = (1,1,1,1)
		_Middle ("Middle", Range(0.001, 0.999)) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
}