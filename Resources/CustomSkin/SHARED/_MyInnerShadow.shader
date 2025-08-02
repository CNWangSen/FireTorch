Shader "Custom/MyInnerShadow" {
    Properties {
        _ShadowColor ("Shadow Color", Color) = (0,0,0,0.5)
        _FadeRadius ("Fade Radius", Range(0,1)) = 0.2
        _OffsetStrength ("Offset Strength", Float) = 0.1
    }
    SubShader {
        Tags { "Queue"="Transparent" "RenderType"="Transparent" }
        Blend SrcAlpha OneMinusSrcAlpha
        ZWrite Off

        Pass {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 uv : TEXCOORD0;
            };

            struct v2f {
                float2 uv : TEXCOORD0;
                float4 pos : SV_POSITION;
                float3 worldPos : TEXCOORD1;
            };

            float4 _ShadowColor;
            float _FadeRadius, _OffsetStrength;

            v2f vert (appdata v) {
                v2f o;
                // 外围顶点沿法线方向内缩
                //float mask = 1;//1 - smoothstep(0, 1, length(v.uv - 0.5)); // 基于UV计算偏移权重
                //v.vertex.xyz += v.normal * _OffsetStrength * mask;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                //o.worldPos = mul(unity_ObjectToWorld, v.vertex).xyz;
                return o;
            }

            fixed4 frag (v2f i) : SV_Target {
                // 计算到中心点的距离（径向渐变）
                float2 center = float2(1, 1);
                float dist = 1-i.uv[1];//distance(i.uv, center);
                float alpha = 1 - smoothstep(0, _FadeRadius, dist);
                return float4(_ShadowColor.rgb, _ShadowColor.a * alpha*0.3);
            }
            ENDCG
        }
    }
}