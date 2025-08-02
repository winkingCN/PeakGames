Shader "Peak/RingShader" {
	Properties {
		[PerRendererData] _MainTex ("Sprite Texture", 2D) = "white" {}
		_colorA ("Color A", Vector) = (1,1,1,1)
		_x ("X", Float) = 0.5
		_y ("Y", Float) = 0.5
		_scaleX ("Scale X", Float) = 1
		_scaleY ("Scale Y", Float) = 1
		_ratio ("Ratio", Range(0, 2)) = 1.4142135
		_thickness ("Thickness", Range(0.01, 0.5)) = 0.02
		_alpha ("Alpha", Range(0, 1)) = 1
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