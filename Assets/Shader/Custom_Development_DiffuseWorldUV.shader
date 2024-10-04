Shader "Custom/Development/DiffuseWorldUV" {
	Properties {
		_MainTex ("Texture", 2D) = "white" {}
		_Frequency ("Frequency", Float) = 1
		_TintLight ("Light Color", Vector) = (1,1,1,1)
		_TintDark ("Dark Color", Vector) = (1,1,1,1)
		_LowThreshold ("Low Threshold", Range(0, 1)) = 0
		_HighThreshold ("High Threshold", Range(0, 1)) = 1
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
	Fallback "Diffuse"
}