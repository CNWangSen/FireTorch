using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02002899 RID: 10393
public class UberCurve : MonoBehaviour
{
	// Token: 0x0601359C RID: 79260 RVA: 0x005A3762 File Offset: 0x005A1962
	private void Awake()
	{
		this.CatmullRomInit();
	}

	// Token: 0x0601359D RID: 79261 RVA: 0x005A376A File Offset: 0x005A196A
	private void OnDrawGizmos()
	{
		this.CatmullRomGizmo();
	}

	// Token: 0x0601359E RID: 79262 RVA: 0x005A3774 File Offset: 0x005A1974
	public Vector3 CatmullRomEvaluateWorldPosition(float position)
	{
		Vector3 position2 = this.CatmullRomEvaluateLocalPosition(position);
		return base.transform.TransformPoint(position2);
	}

	// Token: 0x0601359F RID: 79263 RVA: 0x005A3798 File Offset: 0x005A1998
	public Vector3 CatmullRomEvaluateLocalPosition(float position)
	{
		if (this.m_controlPoints == null)
		{
			return Vector3.zero;
		}
		int num = this.m_controlPoints.Count;
		if (!this.m_Looping)
		{
			num = this.m_controlPoints.Count - 1;
		}
		if (this.m_Reverse && !this.m_renderingGizmo)
		{
			position = 1f - position;
		}
		position = Mathf.Clamp01(position);
		int num2 = Mathf.FloorToInt(position * (float)num);
		float i = position * (float)num - (float)num2;
		Vector3 position2 = this.m_controlPoints[this.ClampIndexCatmullRom(num2 - 1)].position;
		Vector3 position3 = this.m_controlPoints[num2].position;
		Vector3 position4 = this.m_controlPoints[this.ClampIndexCatmullRom(num2 + 1)].position;
		Vector3 position5 = this.m_controlPoints[this.ClampIndexCatmullRom(num2 + 2)].position;
		return this.CatmullRomCalc(i, position2, position3, position4, position5);
	}

	// Token: 0x060135A0 RID: 79264 RVA: 0x005A387C File Offset: 0x005A1A7C
	public Vector3 CatmullRomEvaluateDirection(float position)
	{
		if (this.m_controlPoints == null)
		{
			return Vector3.zero;
		}
		Vector3 b = this.CatmullRomEvaluateLocalPosition(position);
		return Vector3.Normalize(this.CatmullRomEvaluateLocalPosition(position + 0.01f) - b);
	}

	// Token: 0x060135A1 RID: 79265 RVA: 0x005A38B8 File Offset: 0x005A1AB8
	private void CatmullRomInit()
	{
		if (this.m_controlPoints != null)
		{
			return;
		}
		this.m_controlPoints = new List<UberCurve.UberCurveControlPoint>();
		for (int i = 0; i < 4; i++)
		{
			UberCurve.UberCurveControlPoint uberCurveControlPoint = new UberCurve.UberCurveControlPoint();
			uberCurveControlPoint.position = new Vector3(0f, 0f, (float)i * 4f);
			this.m_controlPoints.Add(uberCurveControlPoint);
		}
	}

	// Token: 0x060135A2 RID: 79266 RVA: 0x005A3914 File Offset: 0x005A1B14
	[ContextMenu("Show Curve Steps")]
	private void ShowRenderSteps()
	{
		this.m_renderStepPoints = !this.m_renderStepPoints;
	}

	// Token: 0x060135A3 RID: 79267 RVA: 0x005A3928 File Offset: 0x005A1B28
	private void CatmullRomGizmo()
	{
		if (this.m_gizmoSteps < 1)
		{
			this.m_gizmoSteps = 1;
		}
		if (this.m_controlPoints == null)
		{
			this.CatmullRomInit();
		}
		if (this.m_controlPoints.Count < 4)
		{
			return;
		}
		this.m_renderingGizmo = true;
		Gizmos.matrix = base.transform.localToWorldMatrix;
		float num;
		if (this.m_Looping)
		{
			num = 1f / (float)(this.m_gizmoSteps * this.m_controlPoints.Count);
		}
		else
		{
			num = 1f / (float)(this.m_gizmoSteps * (this.m_controlPoints.Count - 1));
		}
		Gizmos.color = Color.cyan;
		Vector3 from = this.m_controlPoints[0].position;
		for (float num2 = 0f; num2 <= 1f; num2 += num)
		{
			Vector3 vector = this.CatmullRomEvaluateLocalPosition(num2);
			Gizmos.DrawLine(from, vector);
			from = vector;
		}
		if (this.m_renderStepPoints)
		{
			Gizmos.color = new Color(0.2f, 0.2f, 0.9f, 0.75f);
			for (float num3 = 0f; num3 <= 1f; num3 += num)
			{
				Gizmos.DrawSphere(this.CatmullRomEvaluateLocalPosition(num3), this.m_HandleSize * 0.15f);
			}
		}
		if (this.m_renderControlPoints)
		{
			Gizmos.color = new Color(0.3f, 0.3f, 1f, 1f);
			for (int i = 0; i < this.m_controlPoints.Count; i++)
			{
				Gizmos.DrawSphere(this.m_controlPoints[i].position, 0.25f);
			}
		}
		this.m_renderingGizmo = false;
	}

	// Token: 0x060135A4 RID: 79268 RVA: 0x005A3ABC File Offset: 0x005A1CBC
	private Vector3 CatmullRomCalc(float i, Vector3 pointA, Vector3 pointB, Vector3 pointC, Vector3 pointD)
	{
		Vector3 a = 0.5f * (2f * pointB);
		Vector3 a2 = 0.5f * (pointC - pointA);
		Vector3 a3 = 0.5f * (2f * pointA - 5f * pointB + 4f * pointC - pointD);
		Vector3 a4 = 0.5f * (-pointA + 3f * pointB - 3f * pointC + pointD);
		return a + a2 * i + a3 * i * i + a4 * i * i * i;
	}

	// Token: 0x060135A5 RID: 79269 RVA: 0x005A3BA0 File Offset: 0x005A1DA0
	private int ClampIndexCatmullRom(int pos)
	{
		if (this.m_Looping)
		{
			if (pos < 0)
			{
				pos = this.m_controlPoints.Count - 1;
			}
			if (pos > this.m_controlPoints.Count)
			{
				pos = 1;
			}
			else if (pos > this.m_controlPoints.Count - 1)
			{
				pos = 0;
			}
		}
		else
		{
			if (pos < 0)
			{
				pos = 0;
			}
			if (pos > this.m_controlPoints.Count - 1)
			{
				pos = this.m_controlPoints.Count - 1;
			}
		}
		return pos;
	}

	// Token: 0x040109CD RID: 68045
	public bool m_Looping;

	// Token: 0x040109CE RID: 68046
	public bool m_Reverse;

	// Token: 0x040109CF RID: 68047
	public float m_HandleSize = 0.3f;

	// Token: 0x040109D0 RID: 68048
	public List<UberCurve.UberCurveControlPoint> m_controlPoints;

	// Token: 0x040109D1 RID: 68049
	private int m_gizmoSteps = 10;

	// Token: 0x040109D2 RID: 68050
	private bool m_renderControlPoints;

	// Token: 0x040109D3 RID: 68051
	private bool m_renderStepPoints;

	// Token: 0x040109D4 RID: 68052
	private bool m_renderingGizmo;

	// Token: 0x0200289A RID: 10394
	[Serializable]
	public class UberCurveControlPoint
	{
		// Token: 0x040109D5 RID: 68053
		public Vector3 position = Vector3.zero;
	}
}
