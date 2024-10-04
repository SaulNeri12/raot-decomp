Shader "Custom/CubeFx/Lit Outline" {
	Properties {
		_LightColor ("Light Color", Vector) = (0.5,0.5,0.5,1)
		_DarkColor ("Dark Color", Vector) = (0.5,0.5,0.5,1)
		[Toggle(USE_BINARY_COLORS)] _UseBinaryColor ("Hard Colors", Float) = 0
		_OutlineShade ("Outline Shade", Range(-1, 1)) = 0.95
		_DepthPower ("Depth Power", Range(0, 1)) = 0.15
		_OutlineWidth ("Outline width", Range(0.0003, 0.05)) = 0.015
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
	Fallback "Custom/CubeFx/Lit"
}