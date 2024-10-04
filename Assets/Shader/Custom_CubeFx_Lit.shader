Shader "Custom/CubeFx/Lit" {
	Properties {
		_LightColor ("Light Color", Vector) = (0.5,0.5,0.5,1)
		_DarkColor ("Dark Color", Vector) = (0.5,0.5,0.5,1)
		[Toggle(USE_BINARY_COLORS)] _UseBinaryColor ("Hard Colors", Float) = 0
		_Ramp ("Toon Ramp (RGB)", 2D) = "gray" {}
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = 1;
		}
		ENDCG
	}
	Fallback "Diffuse"
}