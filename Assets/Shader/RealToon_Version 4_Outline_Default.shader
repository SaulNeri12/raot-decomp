Shader "RealToon/Version 4/Outline/Default" {
	Properties {
		[Header((RealToon V4.1.2))] [Header((Outline x Default))] [Space(20)] [Enum(Off,2,On,0)] _DoubleSided ("Double Sided", Float) = 2
		[Space(10)] [Header(xxxxxxxxxxxxxxxx)] [Header((Texture Color))] _Texture ("Texture", 2D) = "white" {}
		_MainColor ("Main Color", Vector) = (0.8014706,0.8014706,0.8014706,1)
		[MaterialToggle] _Transparent ("Transparent", Float) = 0
		[MaterialToggle] _TexturePatternStyle ("Texture Pattern Style", Float) = 0
		[Space(10)] [Header(xxxxxxxxxxxxxxxx)] [Header((Normal Map))] [Normal] _NormalMap ("Normal Map", 2D) = "bump" {}
		_NormalIntensity ("Intensity", Float) = 1
		[Space(10)] [Header(xxxxxxxxxxxxxxxx)] [Header((Color Adjustment))] _Saturation ("Saturation", Range(0, 2)) = 1
		[Space(10)] [Header(xxxxxxxxxxxxxxxx)] [Header((Outline))] _OutlineWidth ("Width", Range(0, 1)) = 0.003
		_OutlineColor ("Color", Vector) = (0,0,0,1)
		[MaterialToggle] _DynamicNoiseOutline ("Dynamic Noise Outline", Float) = 0
		_OutlineNoiseIntensity ("Noise Intensity", Range(0, 1)) = 0
		[Space(8)] [Enum(VNormal,0,Origin,1)] _OutlineMode ("Outline Mode", Float) = 0
		[Space(10)] [Header(xxxxxxxxxxxxxxxx)] [Header((Self Lit))] _SelfLitIntensity ("Intensity", Range(0, 1)) = 0
		_SelfLitPower ("Power", Float) = 1
		_SelfLitColor ("Color", Vector) = (1,1,1,1)
		[MaterialToggle] _SelfLitHighContrast ("High Contrast", Float) = 0
		[Space(8)] _MaskSelfLit ("Mask Self Lit", 2D) = "white" {}
		[Space(10)] [Header(xxxxxxxxxxxxxxxx)] [Header((Gloss))] _GlossIntensity ("Intensity", Float) = 0
		_Glossiness ("Glossiness", Range(0, 1)) = 0.5
		_GlossColor ("Color", Vector) = (1,1,1,1)
		[MaterialToggle] _MainTextureColorGloss ("Main Texture Color Gloss", Float) = 0
		[MaterialToggle] _SoftGloss ("Soft Gloss", Float) = 0
		[Space(8)] _MaskGloss ("Mask Gloss", 2D) = "white" {}
		[Space(8)] [Header(Gloss Texture)] _GlossTextureIntensity ("Intensity", Range(0, 1)) = 0
		_GlossTexture ("Gloss Texture", 2D) = "black" {}
		_GlossTextureRotate ("Rotate", Float) = 0
		[MaterialToggle] _GlossTextureFollowObjectRotation ("Follow Object Rotation", Float) = 0
		[MaterialToggle] _GlossTextureFollowLight ("Follow Light", Float) = 0
		[MaterialToggle] _ShadowMaskGlossTexture ("Shadow Mask Gloss Texture", Float) = 1
		[Space(10)] [Header(xxxxxxxxxxxxxxxx)] [Header((Shadow))] _ShadowOverrideColor ("Override Color", Vector) = (1,1,1,1)
		_ShadowAddLight ("Add Light", Float) = 1
		[Space(8)] _AdjustLightPointSpotlight ("Adjust Light (Point & Spotlight)", Float) = 1
		_SaturationPointSpotlight ("Saturation (Point & Spotlight)", Range(0, 2)) = 1
		[Space(8)] _AdjustLightDirectionalLight ("Adjust Light (Directional Light)", Float) = 1
		[Space(8)] [Header(Self Shadow)] _SelfShadowIntensity ("Intensity", Range(0, 1)) = 1
		_SelfShadowColor ("Color", Vector) = (0,0,0,1)
		_SelfShadowSize ("Size", Range(0, 1)) = 0.56
		_SelfShadowHardness ("Hardness", Range(0, 1)) = 1
		[MaterialToggle] _SelfShadowatViewDirection ("Self Shadow at View Direction", Float) = 0
		[Space(8)] [Header(Shadow Color Texture)] _ShadowColorTextureIntensity ("Intensity", Range(0, 1)) = 0
		_ShadowColorTexture ("Shadow Color Texture", 2D) = "black" {}
		_ShadowColorTexturePower ("Power", Float) = 0
		[Space(8)] [Header(ShadowT)] _ShadowTIntensity ("Intensity", Range(0, 1)) = 0
		_ShadowTTexture ("ShadowT Texture", 2D) = "white" {}
		_ShadowTLightSize ("Light Size", Float) = 0.5
		_ShadowTShadowSize ("Shadow Size", Float) = 0
		[MaterialToggle] _ShowShadowTOnLight ("Show On Light", Float) = 1
		[MaterialToggle] _ShowShadowTOnSelfShadow ("Show On Self Shadow", Float) = 0
		[MaterialToggle] _LightFalloffAffectShadowT ("Light Falloff Affect ShadowT", Float) = 0
		[Space(8)] [Header(Shadow PTexture)] _ShadowPTextureIntensity ("Intensity", Range(0, 1)) = 0
		_ShadowPTexture ("Shadow PTexture", 2D) = "white" {}
		[Space(10)] [Header(xxxxxxxxxxxxxxxx)] [Header((Lighting))] [MaterialToggle] _UseGILighting ("Use GI Lighting", Float) = 1
		[MaterialToggle] _GIFlatShade ("GI Flat Shade", Float) = 0
		_GIShadeSize ("GI Shade Size", Range(0, 1)) = 0
		[Space(8)] [MaterialToggle] _DirectionalLightAffectShadow ("Directional Light Affect Shadow", Float) = 0
		[MaterialToggle] _EnableLightFalloff ("Enable Light Falloff", Float) = 1
		[Space(10)] [Header(xxxxxxxxxxxxxxxx)] [Header((Reflection))] _ReflectionIntensity ("Intensity", Range(0, 1)) = 0
		_DefaultReflectionRoughtness ("Default Reflection Roughtness", Range(0, 1)) = 0
		[MaterialToggle] _ReflectionBlendToMainTexture ("Reflection Blend To Main Texture", Float) = 0
		[Space(8)] _MaskReflection ("Mask Reflection", 2D) = "white" {}
		[Space(8)] [Header(FReflection)] [MaterialToggle] _UseFReflection ("Use FReflection", Float) = 0
		_FReflection ("FReflection", 2D) = "white" {}
		[Space(10)] [Header(xxxxxxxxxxxxxxxx)] [Header((Fresnel))] _FresnelIntensity ("Intensity", Range(0, 1)) = 0
		_FresnelColor ("Color", Vector) = (1,1,1,1)
		_FresnelFill ("Fill", Float) = 1
		[MaterialToggle] _HardEdgeFresnel ("Hard Edge Fresnel", Float) = 0
		[MaterialToggle] _FresnelOnLight ("On Light", Float) = 1
		[MaterialToggle] _FresnelOnShadowDark ("On Shadow/Dark", Float) = 0
		[Space(10)] [Header(xxxxxxxxxxxxxxxx)] [Header((See Through))] _RefVal ("ID", Float) = 0
		[Enum(None,8,A,0,B,2)] _Oper ("Set 1", Float) = 8
		[Enum(None,8,A,6,B,7)] _Compa ("Set 2", Float) = 8
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