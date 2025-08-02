using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200289D RID: 10397
[ExecuteAlways]
public class UberShuriken : MonoBehaviour
{
	// Token: 0x060135B4 RID: 79284 RVA: 0x005A471F File Offset: 0x005A291F
	private void Awake()
	{
		if (this.m_UberCurve == null)
		{
			this.m_UberCurve = base.GetComponent<UberCurve>();
		}
		this.UpdateParticleSystemList();
	}

	// Token: 0x060135B5 RID: 79285 RVA: 0x005A4741 File Offset: 0x005A2941
	private void Update()
	{
		this.m_time = Time.time;
		this.UpdateParticles();
	}

	// Token: 0x060135B6 RID: 79286 RVA: 0x005A4754 File Offset: 0x005A2954
	private void OnDrawGizmosSelected()
	{
		Gizmos.matrix = base.transform.localToWorldMatrix;
		Gizmos.color = Color.blue;
		if (this.m_CurlNoise && this.m_CurlNoiseGizmoSize > 0f)
		{
			int num = 10;
			float num2 = Mathf.Max(Mathf.Abs(this.m_CurlNoiseScale * 0.25f), 1f) * this.m_CurlNoiseGizmoSize;
			float num3 = 1f / ((float)num * 1.2f);
			float num4 = 1f;
			float num5 = 0f;
			for (int i = 0; i < num; i++)
			{
				Gizmos.color = new Color(0f, 0f, 1f - num4, 1f);
				num4 -= num3;
				float num6 = (float)i * 0.75f;
				Vector4[] array = this.GizmoCirclePoints(20 * Mathf.Max(Mathf.FloorToInt(Mathf.Abs(this.m_CurlNoiseScale)), 10), num6 * num2);
				Vector4 v = array[array.Length - 1];
				for (int j = 0; j < array.Length; j++)
				{
					Gizmos.color = new Color(array[j].w * 0.5f, array[j].w, 1f, 1f);
					Gizmos.DrawLine(v, array[j]);
					v = array[j];
				}
				Vector4[] array2 = this.GizmoCircleLines(10, num5 * num2, num6 * num2);
				for (int k = 0; k < array2.Length; k += 2)
				{
					Gizmos.color = new Color(array2[k].w * 0.5f, array2[k].w, 1f, 1f);
					Gizmos.DrawLine(array2[k], array2[k + 1]);
				}
				num5 = num6;
			}
		}
		Gizmos.matrix = Matrix4x4.identity;
	}

	// Token: 0x060135B7 RID: 79287 RVA: 0x005A4954 File Offset: 0x005A2B54
	private Vector4[] GizmoCirclePoints(int numOfPoints, float radius)
	{
		Vector4[] array = new Vector4[numOfPoints];
		float num = 0f;
		float num2 = 6.2831855f / (float)numOfPoints;
		for (int i = 0; i < numOfPoints; i++)
		{
			num += num2;
			array[i] = this.GizmoCurlNoisePoint(new Vector3(Mathf.Cos(num) * radius, Mathf.Sin(num) * radius, 0f));
		}
		return array;
	}

	// Token: 0x060135B8 RID: 79288 RVA: 0x005A49B0 File Offset: 0x005A2BB0
	private Vector4[] GizmoCircleLines(int numOfPoints, float previousRadius, float radius)
	{
		int num = numOfPoints * 2;
		Vector4[] array = new Vector4[num];
		float num2 = 0f;
		float num3 = 6.283f / (float)numOfPoints;
		for (int i = 0; i < num; i += 2)
		{
			num2 += num3;
			array[i] = this.GizmoCurlNoisePoint(new Vector3(Mathf.Cos(num2) * previousRadius, Mathf.Sin(num2) * previousRadius, 0f));
			array[i + 1] = this.GizmoCurlNoisePoint(new Vector3(Mathf.Cos(num2) * radius, Mathf.Sin(num2) * radius, 0f));
		}
		return array;
	}

	// Token: 0x060135B9 RID: 79289 RVA: 0x005A4A40 File Offset: 0x005A2C40
	private Vector4 GizmoCurlNoisePoint(Vector3 point)
	{
		float time = this.m_time;
		float num = this.m_CurlNoiseAnimation.x * time;
		float num2 = this.m_CurlNoiseAnimation.y * time;
		float num3 = this.m_CurlNoiseAnimation.z * time;
		Vector3 vector = point * this.m_CurlNoiseScale * 0.1f;
		float num4 = UberMath.SimplexNoise(5f + vector.x + num, vector.y + num2, vector.z + num3) * this.m_CurlNoisePower;
		float num5 = UberMath.SimplexNoise(6f + vector.y + num, vector.z + num2, vector.x + num3) * this.m_CurlNoisePower;
		float num6 = UberMath.SimplexNoise(7f + vector.z + num, vector.x + num2, vector.y + num3) * this.m_CurlNoisePower;
		Vector3 vector2 = new Vector3(point.x + num4, point.y + num5, point.z + num6);
		float w = Mathf.Max(num4, Mathf.Max(num5, num6));
		return new Vector4(vector2.x, vector2.y, vector2.z, w);
	}

	// Token: 0x060135BA RID: 79290 RVA: 0x005A4B7C File Offset: 0x005A2D7C
	private void UpdateParticles()
	{
		this.m_followCurveIntervalIndex = ((this.m_followCurveIntervalIndex + 1 > 3) ? (this.m_followCurveIntervalIndex = 0) : (this.m_followCurveIntervalIndex + 1));
		this.m_curlNoiseIntervalIndex = ((this.m_curlNoiseIntervalIndex + 1 > 3) ? 0 : (this.m_curlNoiseIntervalIndex + 1));
		foreach (ParticleSystem particleSystem in this.m_particleSystems)
		{
			if (!(particleSystem == null))
			{
				int particleCount = particleSystem.particleCount;
				if (particleCount == 0)
				{
					break;
				}
				if (this.m_particles == null || particleCount > this.m_particles.Length)
				{
					this.ResizeParticlesBuffer(particleCount);
				}
				particleSystem.GetParticles(this.m_particles);
				if (this.m_FollowCurveDirection || this.m_FollowCurvePosition)
				{
					this.FollowCurveOverLife(particleSystem, this.m_particles, particleCount);
				}
				if (this.m_CurlNoise)
				{
					this.ParticleCurlNoise(particleSystem, this.m_particles, particleCount);
				}
				if (this.m_Twinkle)
				{
					this.ParticleTwinkle(particleSystem, this.m_particles, particleCount);
				}
				particleSystem.SetParticles(this.m_particles, particleCount);
			}
		}
	}

	// Token: 0x060135BB RID: 79291 RVA: 0x005A4CA8 File Offset: 0x005A2EA8
	private void UpdateParticleSystemList()
	{
		this.m_particleSystems.Clear();
		if (this.m_IncludeChildren)
		{
			ParticleSystem[] componentsInChildren = base.GetComponentsInChildren<ParticleSystem>();
			if (base.GetComponent<ParticleSystem>() == null || componentsInChildren.Length == 0)
			{
				Debug.LogError("Failed to find a ParticleSystem");
			}
			foreach (ParticleSystem item in componentsInChildren)
			{
				this.m_particleSystems.Add(item);
			}
			return;
		}
		ParticleSystem component = base.GetComponent<ParticleSystem>();
		if (component == null)
		{
			Debug.LogError("Failed to find a ParticleSystem");
		}
		this.m_particleSystems.Add(component);
	}

	// Token: 0x060135BC RID: 79292 RVA: 0x005A4D35 File Offset: 0x005A2F35
	private void ResizeParticlesBuffer(int newCount)
	{
		this.m_particles = new ParticleSystem.Particle[newCount];
	}

	// Token: 0x060135BD RID: 79293 RVA: 0x005A4D44 File Offset: 0x005A2F44
	private void FollowCurveOverLife(ParticleSystem particleSystem, ParticleSystem.Particle[] particles, int particleCount)
	{
		if (this.m_UberCurve == null)
		{
			this.CreateCurve();
		}
		for (int i = this.m_followCurveIntervalIndex; i < particleCount; i += 3)
		{
			float position = 1f - particles[i].remainingLifetime / particles[i].startLifetime;
			if (this.m_FollowCurvePosition)
			{
				Vector3 a = Vector3.zero;
				if (particleSystem.main.simulationSpace == ParticleSystemSimulationSpace.World)
				{
					a = this.m_UberCurve.CatmullRomEvaluateWorldPosition(position);
				}
				else
				{
					a = this.m_UberCurve.CatmullRomEvaluateLocalPosition(position);
				}
				Vector3 vector = a - particles[i].position;
				vector = Vector3.Lerp(particles[i].velocity, vector, this.m_FollowCurvePositionAttraction);
				particles[i].velocity = vector * this.m_FollowCurvePositionIntensity;
			}
			if (this.m_FollowCurveDirection)
			{
				Vector3 velocity = this.m_UberCurve.CatmullRomEvaluateDirection(position).normalized * particles[i].velocity.magnitude;
				particles[i].velocity = velocity;
			}
		}
	}

	// Token: 0x060135BE RID: 79294 RVA: 0x005A4E63 File Offset: 0x005A3063
	private void CreateCurve()
	{
		if (this.m_UberCurve != null)
		{
			return;
		}
		this.m_UberCurve = base.GetComponent<UberCurve>();
		if (this.m_UberCurve != null)
		{
			return;
		}
		this.m_UberCurve = base.gameObject.AddComponent<UberCurve>();
	}

	// Token: 0x060135BF RID: 79295 RVA: 0x005A4EA0 File Offset: 0x005A30A0
	private void ParticleCurlNoise(ParticleSystem particleSystem, ParticleSystem.Particle[] particles, int particleCount)
	{
		float time = this.m_time;
		float num = this.m_CurlNoiseAnimation.x * time;
		float num2 = this.m_CurlNoiseAnimation.y * time;
		float num3 = this.m_CurlNoiseAnimation.z * time;
		for (int i = this.m_curlNoiseIntervalIndex; i < particleCount; i += 3)
		{
			float time2 = 1f - particles[i].remainingLifetime / particles[i].startLifetime;
			float num4 = this.m_CurlNoiseOverLifetime.Evaluate(time2) * this.m_CurlNoisePower;
			Vector3 velocity = particles[i].velocity;
			Vector3 vector = particles[i].position * this.m_CurlNoiseScale * 0.1f;
			velocity.x += UberMath.SimplexNoise(5f + vector.x + num, vector.y + num2, vector.z + num3) * num4;
			velocity.y += UberMath.SimplexNoise(6f + vector.y + num, vector.z + num2, vector.x + num3) * num4;
			velocity.z += UberMath.SimplexNoise(7f + vector.z + num, vector.x + num2, vector.y + num3) * num4;
			velocity = velocity.normalized * particles[i].velocity.magnitude;
			particles[i].velocity = velocity;
		}
	}

	// Token: 0x060135C0 RID: 79296 RVA: 0x005A5034 File Offset: 0x005A3234
	private void ParticleTwinkle(ParticleSystem particleSystem, ParticleSystem.Particle[] particles, int particleCount)
	{
		for (int i = 0; i < particleCount; i++)
		{
			float num = particles[i].remainingLifetime / particles[i].startLifetime;
			Vector3 position = particles[i].position;
			Color c = particles[i].startColor;
			c.a = Mathf.Clamp01(UberMath.SimplexNoise((position.x + position.y + position.z - num - (float)i * 3.33f) * this.m_TwinkleRate, 0.5f) + this.m_TwinkleBias + num * this.m_TwinkleOverLifetime.Evaluate(num));
			particles[i].startColor = c;
		}
	}

	// Token: 0x040109E9 RID: 68073
	private const int VORTEX_NOISE_INVERVAL = 3;

	// Token: 0x040109EA RID: 68074
	private const int FOLLOW_CURVE_INVERVAL = 3;

	// Token: 0x040109EB RID: 68075
	private const int CURL_NOISE_INVERVAL = 3;

	// Token: 0x040109EC RID: 68076
	public bool m_IncludeChildren;

	// Token: 0x040109ED RID: 68077
	public UberCurve m_UberCurve;

	// Token: 0x040109EE RID: 68078
	public bool m_FollowCurveDirection;

	// Token: 0x040109EF RID: 68079
	public bool m_FollowCurvePosition;

	// Token: 0x040109F0 RID: 68080
	public float m_FollowCurvePositionAttraction = 0.5f;

	// Token: 0x040109F1 RID: 68081
	public float m_FollowCurvePositionIntensity = 1.7f;

	// Token: 0x040109F2 RID: 68082
	public AnimationCurve m_FollowCurvePositionOverLifetime = new AnimationCurve(new Keyframe[]
	{
		new Keyframe(0f, 1f),
		new Keyframe(1f, 1f)
	});

	// Token: 0x040109F3 RID: 68083
	public bool m_CurlNoise;

	// Token: 0x040109F4 RID: 68084
	public float m_CurlNoisePower = 1f;

	// Token: 0x040109F5 RID: 68085
	public AnimationCurve m_CurlNoiseOverLifetime = new AnimationCurve(new Keyframe[]
	{
		new Keyframe(0f, 0f),
		new Keyframe(1f, 1f)
	});

	// Token: 0x040109F6 RID: 68086
	public float m_CurlNoiseScale = 1f;

	// Token: 0x040109F7 RID: 68087
	public Vector3 m_CurlNoiseAnimation = Vector3.zero;

	// Token: 0x040109F8 RID: 68088
	public float m_CurlNoiseGizmoSize = 1f;

	// Token: 0x040109F9 RID: 68089
	public bool m_Twinkle;

	// Token: 0x040109FA RID: 68090
	public float m_TwinkleRate = 1f;

	// Token: 0x040109FB RID: 68091
	[Range(-1f, 1f)]
	public float m_TwinkleBias;

	// Token: 0x040109FC RID: 68092
	public AnimationCurve m_TwinkleOverLifetime = new AnimationCurve(new Keyframe[]
	{
		new Keyframe(0f, 0f),
		new Keyframe(1f, 1f)
	});

	// Token: 0x040109FD RID: 68093
	private List<ParticleSystem> m_particleSystems = new List<ParticleSystem>();

	// Token: 0x040109FE RID: 68094
	private ParticleSystem.Particle[] m_particles;

	// Token: 0x040109FF RID: 68095
	private float m_time;

	// Token: 0x04010A00 RID: 68096
	private int m_followCurveIntervalIndex = 1;

	// Token: 0x04010A01 RID: 68097
	private int m_curlNoiseIntervalIndex = 2;
}
