using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200096E RID: 2414
public class TransformUtil
{
	/*
	// Token: 0x0600812C RID: 33068 RVA: 0x0029C7D0 File Offset: 0x0029A9D0
	public static Vector3 GetUnitAnchor(Anchor anchor)
	{
		Vector3 result = default(Vector3);
		switch (anchor)
		{
		case Anchor.TOP_LEFT:
			result.x = 0f;
			result.y = 1f;
			result.z = 0f;
			break;
		case Anchor.TOP:
			result.x = 0.5f;
			result.y = 1f;
			result.z = 0f;
			break;
		case Anchor.TOP_RIGHT:
			result.x = 1f;
			result.y = 1f;
			result.z = 0f;
			break;
		case Anchor.LEFT:
			result.x = 0f;
			result.y = 0.5f;
			result.z = 0f;
			break;
		case Anchor.CENTER:
			result.x = 0.5f;
			result.y = 0.5f;
			result.z = 0f;
			break;
		case Anchor.RIGHT:
			result.x = 1f;
			result.y = 0.5f;
			result.z = 0f;
			break;
		case Anchor.BOTTOM_LEFT:
			result.x = 0f;
			result.y = 0f;
			result.z = 0f;
			break;
		case Anchor.BOTTOM:
			result.x = 0.5f;
			result.y = 0f;
			result.z = 0f;
			break;
		case Anchor.BOTTOM_RIGHT:
			result.x = 1f;
			result.y = 0f;
			result.z = 0f;
			break;
		case Anchor.FRONT:
			result.x = 0.5f;
			result.y = 0f;
			result.z = 1f;
			break;
		case Anchor.BACK:
			result.x = 0.5f;
			result.y = 0f;
			result.z = 0f;
			break;
		case Anchor.TOP_LEFT_XZ:
			result.x = 0f;
			result.z = 1f;
			result.y = 0f;
			break;
		case Anchor.TOP_XZ:
			result.x = 0.5f;
			result.z = 1f;
			result.y = 0f;
			break;
		case Anchor.TOP_RIGHT_XZ:
			result.x = 1f;
			result.z = 1f;
			result.y = 0f;
			break;
		case Anchor.LEFT_XZ:
			result.x = 0f;
			result.z = 0.5f;
			result.y = 0f;
			break;
		case Anchor.CENTER_XZ:
			result.x = 0.5f;
			result.z = 0.5f;
			result.y = 0f;
			break;
		case Anchor.RIGHT_XZ:
			result.x = 1f;
			result.z = 0.5f;
			result.y = 0f;
			break;
		case Anchor.BOTTOM_LEFT_XZ:
			result.x = 0f;
			result.z = 0f;
			result.y = 0f;
			break;
		case Anchor.BOTTOM_XZ:
			result.x = 0.5f;
			result.z = 0f;
			result.y = 0f;
			break;
		case Anchor.BOTTOM_RIGHT_XZ:
			result.x = 1f;
			result.z = 0f;
			result.y = 0f;
			break;
		case Anchor.FRONT_XZ:
			result.x = 0.5f;
			result.z = 0f;
			result.y = 1f;
			break;
		case Anchor.BACK_XZ:
			result.x = 0.5f;
			result.z = 0f;
			result.y = 0f;
			break;
		}
		return result;
	}

	// Token: 0x0600812D RID: 33069 RVA: 0x0029CBC4 File Offset: 0x0029ADC4
	public static Vector3 ComputeWorldPoint(Bounds bounds, Vector3 selfUnitAnchor)
	{
		return new Vector3
		{
			x = Mathf.Lerp(bounds.min.x, bounds.max.x, selfUnitAnchor.x),
			y = Mathf.Lerp(bounds.min.y, bounds.max.y, selfUnitAnchor.y),
			z = Mathf.Lerp(bounds.min.z, bounds.max.z, selfUnitAnchor.z)
		};
	}

	// Token: 0x0600812E RID: 33070 RVA: 0x0029CC58 File Offset: 0x0029AE58
	public static Vector2 ComputeUnitAnchor(Bounds bounds, Vector2 worldPoint)
	{
		return new Vector2
		{
			x = (worldPoint.x - bounds.min.x) / bounds.size.x,
			y = (worldPoint.y - bounds.min.y) / bounds.size.y
		};
	}

	// Token: 0x0600812F RID: 33071 RVA: 0x0029CCBC File Offset: 0x0029AEBC
	public static Bounds ComputeSetPointBounds(Component c)
	{
		return TransformUtil.ComputeSetPointBounds(c.gameObject, false);
	}

	// Token: 0x06008130 RID: 33072 RVA: 0x0029CCCA File Offset: 0x0029AECA
	public static Bounds ComputeSetPointBounds(GameObject go)
	{
		return TransformUtil.ComputeSetPointBounds(go, false);
	}

	// Token: 0x06008131 RID: 33073 RVA: 0x0029CCD3 File Offset: 0x0029AED3
	public static Bounds ComputeSetPointBounds(Component c, bool includeInactive)
	{
		return TransformUtil.ComputeSetPointBounds(c.gameObject, includeInactive);
	}


	// Token: 0x06008132 RID: 33074 RVA: 0x0029CCE4 File Offset: 0x0029AEE4
	public static Bounds ComputeSetPointBounds(GameObject go, bool includeInactive)
	{
		UberText component = go.GetComponent<UberText>();
		if (component != null)
		{
			return component.GetTextWorldSpaceBounds();
		}
		Renderer component2 = go.GetComponent<Renderer>();
		if (component2 != null)
		{
			return component2.bounds;
		}
		BoundsOverride component3 = go.GetComponent<BoundsOverride>();
		if (component3 != null)
		{
			return component3.bounds;
		}
		Collider component4 = go.GetComponent<Collider>();
		if (component4 != null)
		{
			Bounds bounds;
			if (component4.enabled)
			{
				bounds = component4.bounds;
			}
			else
			{
				component4.enabled = true;
				bounds = component4.bounds;
				component4.enabled = false;
			}
			MobileHitBox component5 = go.GetComponent<MobileHitBox>();
			if (component5 != null && component5.HasExecuted())
			{
				bounds.size = new Vector3(bounds.size.x / component5.m_scaleX, bounds.size.y / component5.m_scaleY, bounds.size.z / component5.m_scaleY);
			}
			return bounds;
		}
		return TransformUtil.GetBoundsOfChildren(go, includeInactive);
	}

	// Token: 0x06008133 RID: 33075 RVA: 0x0029CDDE File Offset: 0x0029AFDE
	public static OrientedBounds ComputeOrientedWorldBounds(GameObject go, bool includeAllChildren = true)
	{
		return TransformUtil.ComputeOrientedWorldBounds(go, true, includeAllChildren);
	}

	// Token: 0x06008134 RID: 33076 RVA: 0x0029CDE8 File Offset: 0x0029AFE8
	public static OrientedBounds ComputeOrientedWorldBounds(GameObject go, List<GameObject> ignoreMeshes, bool includeAllChildren = true)
	{
		return TransformUtil.ComputeOrientedWorldBounds(go, true, ignoreMeshes, includeAllChildren);
	}

	// Token: 0x06008135 RID: 33077 RVA: 0x0029CDF3 File Offset: 0x0029AFF3
	public static OrientedBounds ComputeOrientedWorldBounds(GameObject go, Vector3 minLocalPadding, Vector3 maxLocalPadding, bool includeAllChildren = true)
	{
		return TransformUtil.ComputeOrientedWorldBounds(go, true, minLocalPadding, maxLocalPadding, includeAllChildren);
	}

	// Token: 0x06008136 RID: 33078 RVA: 0x0029CDFF File Offset: 0x0029AFFF
	public static OrientedBounds ComputeOrientedWorldBounds(GameObject go, Vector3 minLocalPadding, Vector3 maxLocalPadding, List<GameObject> ignoreMeshes, bool includeAllChildren = true)
	{
		return TransformUtil.ComputeOrientedWorldBounds(go, true, minLocalPadding, maxLocalPadding, ignoreMeshes, includeAllChildren);
	}

	// Token: 0x06008137 RID: 33079 RVA: 0x0029CE0D File Offset: 0x0029B00D
	public static OrientedBounds ComputeOrientedWorldBounds(GameObject go, bool includeUberText, bool includeAllChildren = true)
	{
		return TransformUtil.ComputeOrientedWorldBounds(go, includeUberText, Vector3.zero, Vector3.zero, null, includeAllChildren);
	}

	// Token: 0x06008138 RID: 33080 RVA: 0x0029CE22 File Offset: 0x0029B022
	public static OrientedBounds ComputeOrientedWorldBounds(GameObject go, bool includeUberText, List<GameObject> ignoreMeshes, bool includeAllChildren = true)
	{
		return TransformUtil.ComputeOrientedWorldBounds(go, includeUberText, Vector3.zero, Vector3.zero, ignoreMeshes, includeAllChildren);
	}

	// Token: 0x06008139 RID: 33081 RVA: 0x0029CE37 File Offset: 0x0029B037
	public static OrientedBounds ComputeOrientedWorldBounds(GameObject go, bool includeUberText, Vector3 minLocalPadding, Vector3 maxLocalPadding, bool includeAllChildren = true)
	{
		return TransformUtil.ComputeOrientedWorldBounds(go, includeUberText, minLocalPadding, maxLocalPadding, null, includeAllChildren);
	}

	// Token: 0x0600813A RID: 33082 RVA: 0x0029CE48 File Offset: 0x0029B048
	public static OrientedBounds ComputeOrientedWorldBounds(GameObject go, bool includeUberText, Vector3 minLocalPadding, Vector3 maxLocalPadding, List<GameObject> ignoreMeshes, bool includeAllChildren = true)
	{
		if (go == null || !go.activeSelf)
		{
			return null;
		}
		List<MeshFilter> componentsWithIgnore = TransformUtil.GetComponentsWithIgnore<MeshFilter>(go, ignoreMeshes, includeAllChildren);
		List<UberText> list = null;
		if (includeUberText)
		{
			list = TransformUtil.GetComponentsWithIgnore<UberText>(go, ignoreMeshes, includeAllChildren);
		}
		if ((componentsWithIgnore == null || componentsWithIgnore.Count == 0) && (list == null || list.Count == 0))
		{
			return null;
		}
		Matrix4x4 worldToLocalMatrix = go.transform.worldToLocalMatrix;
		Vector3 vector = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
		Vector3 vector2 = new Vector3(float.MinValue, float.MinValue, float.MinValue);
		if (componentsWithIgnore != null)
		{
			foreach (MeshFilter meshFilter in componentsWithIgnore)
			{
				if (meshFilter.gameObject.activeSelf && !(meshFilter.sharedMesh == null))
				{
					Matrix4x4 localToWorldMatrix = meshFilter.transform.localToWorldMatrix;
					Bounds bounds = meshFilter.sharedMesh.bounds;
					Matrix4x4 lhs = worldToLocalMatrix * localToWorldMatrix;
					Vector3[] array = new Vector3[]
					{
						lhs * new Vector3(bounds.extents.x, 0f, 0f),
						lhs * new Vector3(0f, bounds.extents.y, 0f),
						lhs * new Vector3(0f, 0f, bounds.extents.z)
					};
					Vector3 b = localToWorldMatrix * meshFilter.sharedMesh.bounds.center;
					TransformUtil.GetBoundsMinMax(worldToLocalMatrix * (meshFilter.transform.position + b), array[0], array[1], array[2], ref vector, ref vector2);
				}
			}
		}
		if (list != null)
		{
			foreach (UberText uberText in list)
			{
				if (uberText.gameObject.activeSelf)
				{
					Matrix4x4 localToWorldMatrix2 = uberText.transform.localToWorldMatrix;
					Matrix4x4 lhs2 = worldToLocalMatrix * localToWorldMatrix2;
					Vector3[] array2 = new Vector3[]
					{
						lhs2 * new Vector3(uberText.Width * 0.5f, 0f, 0f),
						lhs2 * new Vector3(0f, uberText.Height * 0.5f),
						lhs2 * new Vector3(0f, 0f, 0.01f)
					};
					TransformUtil.GetBoundsMinMax(worldToLocalMatrix * uberText.transform.position, array2[0], array2[1], array2[2], ref vector, ref vector2);
				}
			}
		}
		if (minLocalPadding.sqrMagnitude > 0f)
		{
			vector -= minLocalPadding;
		}
		if (maxLocalPadding.sqrMagnitude > 0f)
		{
			vector2 += maxLocalPadding;
		}
		Matrix4x4 localToWorldMatrix3 = go.transform.localToWorldMatrix;
		Matrix4x4 lhs3 = localToWorldMatrix3;
		lhs3.SetColumn(3, Vector4.zero);
		Vector3 vector3 = (localToWorldMatrix3 * vector2 + localToWorldMatrix3 * vector) * 0.5f;
		Vector3 vector4 = (vector2 - vector) * 0.5f;
		return new OrientedBounds
		{
			Extents = new Vector3[]
			{
				lhs3 * new Vector3(vector4.x, 0f, 0f),
				lhs3 * new Vector3(0f, vector4.y, 0f),
				lhs3 * new Vector3(0f, 0f, vector4.z)
			},
			Origin = vector3,
			CenterOffset = go.transform.position - vector3
		};
	}

	// Token: 0x0600813B RID: 33083 RVA: 0x0029D320 File Offset: 0x0029B520
	public static bool CanComputeOrientedWorldBounds(GameObject go, bool includeAllChildren = true)
	{
		return TransformUtil.CanComputeOrientedWorldBounds(go, true, includeAllChildren);
	}

	// Token: 0x0600813C RID: 33084 RVA: 0x0029D32A File Offset: 0x0029B52A
	public static bool CanComputeOrientedWorldBounds(GameObject go, List<GameObject> ignoreMeshes, bool includeAllChildren = true)
	{
		return TransformUtil.CanComputeOrientedWorldBounds(go, true, ignoreMeshes, includeAllChildren);
	}

	// Token: 0x0600813D RID: 33085 RVA: 0x0029D335 File Offset: 0x0029B535
	public static bool CanComputeOrientedWorldBounds(GameObject go, bool includeUberText, bool includeAllChildren = true)
	{
		return TransformUtil.CanComputeOrientedWorldBounds(go, includeUberText, null, includeAllChildren);
	}

	// Token: 0x0600813E RID: 33086 RVA: 0x0029D340 File Offset: 0x0029B540
	public static bool CanComputeOrientedWorldBounds(GameObject go, bool includeUberText, List<GameObject> ignoreMeshes, bool includeAllChildren = true)
	{
		if (go == null || !go.activeSelf)
		{
			return false;
		}
		List<MeshFilter> componentsWithIgnore = TransformUtil.GetComponentsWithIgnore<MeshFilter>(go, ignoreMeshes, includeAllChildren);
		if (componentsWithIgnore != null && componentsWithIgnore.Count > 0)
		{
			return true;
		}
		if (includeUberText)
		{
			List<UberText> componentsWithIgnore2 = TransformUtil.GetComponentsWithIgnore<UberText>(go, ignoreMeshes, includeAllChildren);
			return componentsWithIgnore2 != null && componentsWithIgnore2.Count > 0;
		}
		return false;
	}

	// Token: 0x0600813F RID: 33087 RVA: 0x0029D394 File Offset: 0x0029B594
	public static List<T> GetComponentsWithIgnore<T>(GameObject obj, List<GameObject> ignoreObjects, bool includeAllChildren = true) where T : Component
	{
		List<T> list = new List<T>();
		if (includeAllChildren)
		{
			obj.GetComponentsInChildren<T>(list);
		}
		T component = obj.GetComponent<T>();
		if (component != null)
		{
			list.Add(component);
		}
		if (ignoreObjects != null && ignoreObjects.Count > 0)
		{
			T[] array = list.ToArray();
			list.Clear();
			foreach (T t in array)
			{
				bool flag = true;
				foreach (GameObject gameObject in ignoreObjects)
				{
					if (gameObject == null || t.transform == gameObject.transform || t.transform.IsChildOf(gameObject.transform))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					list.Add(t);
				}
			}
		}
		return list;
	}

	// Token: 0x06008140 RID: 33088 RVA: 0x0029D498 File Offset: 0x0029B698
	public static Vector3[] GetBoundCorners(Vector3 origin, Vector3 xExtent, Vector3 yExtent, Vector3 zExtent)
	{
		Vector3 a = origin + xExtent;
		Vector3 a2 = origin - xExtent;
		Vector3 b = yExtent + zExtent;
		Vector3 b2 = yExtent - zExtent;
		Vector3 b3 = -yExtent + zExtent;
		Vector3 b4 = -yExtent - zExtent;
		return new Vector3[]
		{
			a + b,
			a + b2,
			a + b3,
			a + b4,
			a2 - b,
			a2 - b2,
			a2 - b3,
			a2 - b4
		};
	}

	// Token: 0x06008141 RID: 33089 RVA: 0x0029D55C File Offset: 0x0029B75C
	public static void GetBoundsMinMax(Vector3 origin, Vector3 xExtent, Vector3 yExtent, Vector3 zExtent, ref Vector3 min, ref Vector3 max)
	{
		Vector3[] boundCorners = TransformUtil.GetBoundCorners(origin, xExtent, yExtent, zExtent);
		for (int i = 0; i < boundCorners.Length; i++)
		{
			min.x = Mathf.Min(boundCorners[i].x, min.x);
			min.y = Mathf.Min(boundCorners[i].y, min.y);
			min.z = Mathf.Min(boundCorners[i].z, min.z);
			max.x = Mathf.Max(boundCorners[i].x, max.x);
			max.y = Mathf.Max(boundCorners[i].y, max.y);
			max.z = Mathf.Max(boundCorners[i].z, max.z);
		}
	}

	// Token: 0x06008142 RID: 33090 RVA: 0x0029D641 File Offset: 0x0029B841
	public static void SetLocalScaleToWorldDimension(GameObject obj, params WorldDimensionIndex[] dimensions)
	{
		TransformUtil.SetLocalScaleToWorldDimension(obj, null, dimensions);
	}

	// Token: 0x06008143 RID: 33091 RVA: 0x0029D64C File Offset: 0x0029B84C
	public static void SetLocalScaleToWorldDimension(GameObject obj, List<GameObject> ignoreMeshes, params WorldDimensionIndex[] dimensions)
	{
		Vector3 localScale = obj.transform.localScale;
		OrientedBounds orientedBounds = TransformUtil.ComputeOrientedWorldBounds(obj, ignoreMeshes, true);
		for (int i = 0; i < dimensions.Length; i++)
		{
			float num = orientedBounds.Extents[dimensions[i].Index].magnitude * 2f;
			ref Vector3 ptr = ref localScale;
			int index = dimensions[i].Index;
			ptr[index] *= ((num <= Mathf.Epsilon) ? 0.001f : (dimensions[i].Dimension / num));
			if (Mathf.Abs(localScale[dimensions[i].Index]) < 0.001f)
			{
				localScale[dimensions[i].Index] = 0.001f;
			}
		}
		obj.transform.localScale = localScale;
	}

	// Token: 0x06008144 RID: 33092 RVA: 0x0029D72A File Offset: 0x0029B92A
	public static void SetPoint(Component src, Anchor srcAnchor, Component dst, Anchor dstAnchor)
	{
		TransformUtil.SetPoint(src.gameObject, TransformUtil.GetUnitAnchor(srcAnchor), dst.gameObject, TransformUtil.GetUnitAnchor(dstAnchor), Vector3.zero, false);
	}

	// Token: 0x06008145 RID: 33093 RVA: 0x0029D74F File Offset: 0x0029B94F
	public static void SetPoint(Component src, Anchor srcAnchor, GameObject dst, Anchor dstAnchor)
	{
		TransformUtil.SetPoint(src.gameObject, TransformUtil.GetUnitAnchor(srcAnchor), dst, TransformUtil.GetUnitAnchor(dstAnchor), Vector3.zero, false);
	}

	// Token: 0x06008146 RID: 33094 RVA: 0x0029D76F File Offset: 0x0029B96F
	public static void SetPoint(GameObject src, Anchor srcAnchor, Component dst, Anchor dstAnchor)
	{
		TransformUtil.SetPoint(src, TransformUtil.GetUnitAnchor(srcAnchor), dst.gameObject, TransformUtil.GetUnitAnchor(dstAnchor), Vector3.zero, false);
	}

	// Token: 0x06008147 RID: 33095 RVA: 0x0029D78F File Offset: 0x0029B98F
	public static void SetPoint(GameObject src, Anchor srcAnchor, GameObject dst, Anchor dstAnchor)
	{
		TransformUtil.SetPoint(src, TransformUtil.GetUnitAnchor(srcAnchor), dst, TransformUtil.GetUnitAnchor(dstAnchor), Vector3.zero, false);
	}

	// Token: 0x06008148 RID: 33096 RVA: 0x0029D7AA File Offset: 0x0029B9AA
	public static void SetPoint(Component src, Anchor srcAnchor, Component dst, Anchor dstAnchor, bool includeInactive)
	{
		TransformUtil.SetPoint(src.gameObject, TransformUtil.GetUnitAnchor(srcAnchor), dst.gameObject, TransformUtil.GetUnitAnchor(dstAnchor), Vector3.zero, includeInactive);
	}

	// Token: 0x06008149 RID: 33097 RVA: 0x0029D7D0 File Offset: 0x0029B9D0
	public static void SetPoint(Component src, Anchor srcAnchor, GameObject dst, Anchor dstAnchor, bool includeInactive)
	{
		TransformUtil.SetPoint(src.gameObject, TransformUtil.GetUnitAnchor(srcAnchor), dst, TransformUtil.GetUnitAnchor(dstAnchor), Vector3.zero, includeInactive);
	}

	// Token: 0x0600814A RID: 33098 RVA: 0x0029D7F1 File Offset: 0x0029B9F1
	public static void SetPoint(GameObject src, Anchor srcAnchor, Component dst, Anchor dstAnchor, bool includeInactive)
	{
		TransformUtil.SetPoint(src, TransformUtil.GetUnitAnchor(srcAnchor), dst.gameObject, TransformUtil.GetUnitAnchor(dstAnchor), Vector3.zero, includeInactive);
	}

	// Token: 0x0600814B RID: 33099 RVA: 0x0029D812 File Offset: 0x0029BA12
	public static void SetPoint(GameObject src, Anchor srcAnchor, GameObject dst, Anchor dstAnchor, bool includeInactive)
	{
		TransformUtil.SetPoint(src, TransformUtil.GetUnitAnchor(srcAnchor), dst, TransformUtil.GetUnitAnchor(dstAnchor), Vector3.zero, includeInactive);
	}

	// Token: 0x0600814C RID: 33100 RVA: 0x0029D82E File Offset: 0x0029BA2E
	public static void SetPoint(Component src, Anchor srcAnchor, Component dst, Anchor dstAnchor, Vector3 offset)
	{
		TransformUtil.SetPoint(src.gameObject, TransformUtil.GetUnitAnchor(srcAnchor), dst.gameObject, TransformUtil.GetUnitAnchor(dstAnchor), offset, false);
	}

	// Token: 0x0600814D RID: 33101 RVA: 0x0029D850 File Offset: 0x0029BA50
	public static void SetPoint(Component src, Anchor srcAnchor, GameObject dst, Anchor dstAnchor, Vector3 offset)
	{
		TransformUtil.SetPoint(src.gameObject, TransformUtil.GetUnitAnchor(srcAnchor), dst, TransformUtil.GetUnitAnchor(dstAnchor), offset, false);
	}

	// Token: 0x0600814E RID: 33102 RVA: 0x0029D86D File Offset: 0x0029BA6D
	public static void SetPoint(GameObject src, Anchor srcAnchor, Component dst, Anchor dstAnchor, Vector3 offset)
	{
		TransformUtil.SetPoint(src, TransformUtil.GetUnitAnchor(srcAnchor), dst.gameObject, TransformUtil.GetUnitAnchor(dstAnchor), offset, false);
	}

	// Token: 0x0600814F RID: 33103 RVA: 0x0029D88A File Offset: 0x0029BA8A
	public static void SetPoint(GameObject src, Anchor srcAnchor, GameObject dst, Anchor dstAnchor, Vector3 offset)
	{
		TransformUtil.SetPoint(src, TransformUtil.GetUnitAnchor(srcAnchor), dst, TransformUtil.GetUnitAnchor(dstAnchor), offset, false);
	}

	// Token: 0x06008150 RID: 33104 RVA: 0x0029D8A2 File Offset: 0x0029BAA2
	public static void SetPoint(Component src, Anchor srcAnchor, Component dst, Anchor dstAnchor, Vector3 offset, bool includeInactive)
	{
		TransformUtil.SetPoint(src.gameObject, TransformUtil.GetUnitAnchor(srcAnchor), dst.gameObject, TransformUtil.GetUnitAnchor(dstAnchor), offset, includeInactive);
	}

	// Token: 0x06008151 RID: 33105 RVA: 0x0029D8C5 File Offset: 0x0029BAC5
	public static void SetPoint(Component src, Anchor srcAnchor, GameObject dst, Anchor dstAnchor, Vector3 offset, bool includeInactive)
	{
		TransformUtil.SetPoint(src.gameObject, TransformUtil.GetUnitAnchor(srcAnchor), dst, TransformUtil.GetUnitAnchor(dstAnchor), offset, includeInactive);
	}

	// Token: 0x06008152 RID: 33106 RVA: 0x0029D8E3 File Offset: 0x0029BAE3
	public static void SetPoint(GameObject src, Anchor srcAnchor, Component dst, Anchor dstAnchor, Vector3 offset, bool includeInactive)
	{
		TransformUtil.SetPoint(src, TransformUtil.GetUnitAnchor(srcAnchor), dst.gameObject, TransformUtil.GetUnitAnchor(dstAnchor), offset, includeInactive);
	}

	// Token: 0x06008153 RID: 33107 RVA: 0x0029D901 File Offset: 0x0029BB01
	public static void SetPoint(GameObject src, Anchor srcAnchor, GameObject dst, Anchor dstAnchor, Vector3 offset, bool includeInactive)
	{
		TransformUtil.SetPoint(src, TransformUtil.GetUnitAnchor(srcAnchor), dst, TransformUtil.GetUnitAnchor(dstAnchor), offset, includeInactive);
	}

	// Token: 0x06008154 RID: 33108 RVA: 0x0029D91A File Offset: 0x0029BB1A
	public static void SetPoint(Component self, Vector3 selfUnitAnchor, Component relative, Vector3 relativeUnitAnchor)
	{
		TransformUtil.SetPoint(self.gameObject, selfUnitAnchor, relative.gameObject, relativeUnitAnchor, Vector3.zero, false);
	}

	// Token: 0x06008155 RID: 33109 RVA: 0x0029D935 File Offset: 0x0029BB35
	public static void SetPoint(Component self, Vector3 selfUnitAnchor, GameObject relative, Vector3 relativeUnitAnchor)
	{
		TransformUtil.SetPoint(self.gameObject, selfUnitAnchor, relative, relativeUnitAnchor, Vector3.zero, false);
	}

	// Token: 0x06008156 RID: 33110 RVA: 0x0029D94B File Offset: 0x0029BB4B
	public static void SetPoint(GameObject self, Vector3 selfUnitAnchor, Component relative, Vector3 relativeUnitAnchor)
	{
		TransformUtil.SetPoint(self, selfUnitAnchor, relative.gameObject, relativeUnitAnchor, Vector3.zero, false);
	}

	// Token: 0x06008157 RID: 33111 RVA: 0x0029D961 File Offset: 0x0029BB61
	public static void SetPoint(GameObject self, Vector3 selfUnitAnchor, GameObject relative, Vector3 relativeUnitAnchor)
	{
		TransformUtil.SetPoint(self, selfUnitAnchor, relative, relativeUnitAnchor, Vector3.zero, false);
	}

	// Token: 0x06008158 RID: 33112 RVA: 0x0029D972 File Offset: 0x0029BB72
	public static void SetPoint(Component self, Vector3 selfUnitAnchor, Component relative, Vector3 relativeUnitAnchor, Vector3 offset)
	{
		TransformUtil.SetPoint(self.gameObject, selfUnitAnchor, relative.gameObject, relativeUnitAnchor, offset, false);
	}

	// Token: 0x06008159 RID: 33113 RVA: 0x0029D98A File Offset: 0x0029BB8A
	public static void SetPoint(Component self, Vector3 selfUnitAnchor, GameObject relative, Vector3 relativeUnitAnchor, Vector3 offset)
	{
		TransformUtil.SetPoint(self.gameObject, selfUnitAnchor, relative, relativeUnitAnchor, offset, false);
	}

	// Token: 0x0600815A RID: 33114 RVA: 0x0029D99D File Offset: 0x0029BB9D
	public static void SetPoint(GameObject self, Vector3 selfUnitAnchor, Component relative, Vector3 relativeUnitAnchor, Vector3 offset)
	{
		TransformUtil.SetPoint(self, selfUnitAnchor, relative.gameObject, relativeUnitAnchor, offset, false);
	}

	// Token: 0x0600815B RID: 33115 RVA: 0x0029D9B0 File Offset: 0x0029BBB0
	public static void SetPoint(GameObject self, Vector3 selfUnitAnchor, GameObject relative, Vector3 relativeUnitAnchor, Vector3 offset)
	{
		TransformUtil.SetPoint(self, selfUnitAnchor, relative, relativeUnitAnchor, offset, false);
	}

	// Token: 0x0600815C RID: 33116 RVA: 0x0029D9BE File Offset: 0x0029BBBE
	public static void SetPoint(Component self, Vector3 selfUnitAnchor, Component relative, Vector3 relativeUnitAnchor, Vector3 offset, bool includeInactive)
	{
		TransformUtil.SetPoint(self.gameObject, selfUnitAnchor, relative.gameObject, relativeUnitAnchor, offset, includeInactive);
	}

	// Token: 0x0600815D RID: 33117 RVA: 0x0029D9D7 File Offset: 0x0029BBD7
	public static void SetPoint(Component self, Vector3 selfUnitAnchor, GameObject relative, Vector3 relativeUnitAnchor, Vector3 offset, bool includeInactive)
	{
		TransformUtil.SetPoint(self.gameObject, selfUnitAnchor, relative, relativeUnitAnchor, offset, includeInactive);
	}

	// Token: 0x0600815E RID: 33118 RVA: 0x0029D9EB File Offset: 0x0029BBEB
	public static void SetPoint(GameObject self, Vector3 selfUnitAnchor, Component relative, Vector3 relativeUnitAnchor, Vector3 offset, bool includeInactive)
	{
		TransformUtil.SetPoint(self, selfUnitAnchor, relative.gameObject, relativeUnitAnchor, offset, includeInactive);
	}

	// Token: 0x0600815F RID: 33119 RVA: 0x0029DA00 File Offset: 0x0029BC00
	public static void SetPoint(GameObject self, Vector3 selfUnitAnchor, GameObject relative, Vector3 relativeUnitAnchor, Vector3 offset, bool includeInactive)
	{
		if (!self || !relative)
		{
			return;
		}
		Bounds bounds = TransformUtil.ComputeSetPointBounds(self, includeInactive);
		Bounds bounds2 = TransformUtil.ComputeSetPointBounds(relative, includeInactive);
		Vector3 vector = TransformUtil.ComputeWorldPoint(bounds, selfUnitAnchor);
		Vector3 vector2 = TransformUtil.ComputeWorldPoint(bounds2, relativeUnitAnchor);
		Vector3 translation = new Vector3(vector2.x - vector.x + offset.x, vector2.y - vector.y + offset.y, vector2.z - vector.z + offset.z);
		self.transform.Translate(translation, Space.World);
	}

	// Token: 0x06008160 RID: 33120 RVA: 0x0029DA91 File Offset: 0x0029BC91
	public static Bounds GetBoundsOfChildren(Component c)
	{
		return TransformUtil.GetBoundsOfChildren(c.gameObject, false);
	}

	// Token: 0x06008161 RID: 33121 RVA: 0x0029DA9F File Offset: 0x0029BC9F
	public static Bounds GetBoundsOfChildren(GameObject go)
	{
		return TransformUtil.GetBoundsOfChildren(go, false);
	}

	// Token: 0x06008162 RID: 33122 RVA: 0x0029DAA8 File Offset: 0x0029BCA8
	public static Bounds GetBoundsOfChildren(Component c, bool includeInactive)
	{
		return TransformUtil.GetBoundsOfChildren(c.gameObject, includeInactive);
	}

	// Token: 0x06008163 RID: 33123 RVA: 0x0029DAB8 File Offset: 0x0029BCB8
	public static Bounds GetBoundsOfChildren(GameObject go, bool includeInactive)
	{
		Renderer[] componentsInChildren = go.GetComponentsInChildren<Renderer>(includeInactive);
		if (componentsInChildren.Length == 0)
		{
			return new Bounds(go.transform.position, Vector3.zero);
		}
		Bounds bounds = componentsInChildren[0].bounds;
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Bounds bounds2 = componentsInChildren[i].bounds;
			Vector3 max = Vector3.Max(bounds2.max, bounds.max);
			Vector3 min = Vector3.Min(bounds2.min, bounds.min);
			bounds.SetMinMax(min, max);
		}
		return bounds;
	}

	// Token: 0x06008164 RID: 33124 RVA: 0x0029DB3D File Offset: 0x0029BD3D
	public static Vector3 Divide(Vector3 v1, Vector3 v2)
	{
		return new Vector3(v1.x / v2.x, v1.y / v2.y, v1.z / v2.z);
	}

	// Token: 0x06008165 RID: 33125 RVA: 0x0029DB6B File Offset: 0x0029BD6B
	public static Vector3 Multiply(Vector3 v1, Vector3 v2)
	{
		return new Vector3(v1.x * v2.x, v1.y * v2.y, v1.z * v2.z);
	}

	// Token: 0x06008166 RID: 33126 RVA: 0x0029DB9C File Offset: 0x0029BD9C
	public static void SetLocalPosX(GameObject go, float x)
	{
		Transform transform = go.transform;
		transform.localPosition = new Vector3(x, transform.localPosition.y, transform.localPosition.z);
	}

	// Token: 0x06008167 RID: 33127 RVA: 0x0029DBD4 File Offset: 0x0029BDD4
	public static void SetLocalPosX(Component component, float x)
	{
		Transform transform = component.transform;
		transform.localPosition = new Vector3(x, transform.localPosition.y, transform.localPosition.z);
	}

	// Token: 0x06008168 RID: 33128 RVA: 0x0029DC0C File Offset: 0x0029BE0C
	public static void SetLocalPosY(GameObject go, float y)
	{
		Transform transform = go.transform;
		transform.localPosition = new Vector3(transform.localPosition.x, y, transform.localPosition.z);
	}

	// Token: 0x06008169 RID: 33129 RVA: 0x0029DC44 File Offset: 0x0029BE44
	public static void SetLocalPosY(Component component, float y)
	{
		Transform transform = component.transform;
		transform.localPosition = new Vector3(transform.localPosition.x, y, transform.localPosition.z);
	}

	// Token: 0x0600816A RID: 33130 RVA: 0x0029DC7C File Offset: 0x0029BE7C
	public static void SetLocalPosZ(GameObject go, float z)
	{
		Transform transform = go.transform;
		transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, z);
	}

	// Token: 0x0600816B RID: 33131 RVA: 0x0029DCB4 File Offset: 0x0029BEB4
	public static void SetLocalPosZ(Component component, float z)
	{
		Transform transform = component.transform;
		transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, z);
	}

	// Token: 0x0600816C RID: 33132 RVA: 0x0029DCEC File Offset: 0x0029BEEC
	public static void SetPosX(GameObject go, float x)
	{
		Transform transform = go.transform;
		transform.position = new Vector3(x, transform.position.y, transform.position.z);
	}

	// Token: 0x0600816D RID: 33133 RVA: 0x0029DD24 File Offset: 0x0029BF24
	public static void SetPosX(Component component, float x)
	{
		Transform transform = component.transform;
		transform.position = new Vector3(x, transform.position.y, transform.position.z);
	}

	// Token: 0x0600816E RID: 33134 RVA: 0x0029DD5C File Offset: 0x0029BF5C
	public static void SetPosY(GameObject go, float y)
	{
		Transform transform = go.transform;
		transform.position = new Vector3(transform.position.x, y, transform.position.z);
	}

	// Token: 0x0600816F RID: 33135 RVA: 0x0029DD94 File Offset: 0x0029BF94
	public static void SetPosY(Component component, float y)
	{
		Transform transform = component.transform;
		transform.position = new Vector3(transform.position.x, y, transform.position.z);
	}

	// Token: 0x06008170 RID: 33136 RVA: 0x0029DDCC File Offset: 0x0029BFCC
	public static void SetPosZ(GameObject go, float z)
	{
		Transform transform = go.transform;
		transform.position = new Vector3(transform.position.x, transform.position.y, z);
	}

	// Token: 0x06008171 RID: 33137 RVA: 0x0029DE04 File Offset: 0x0029C004
	public static void SetPosZ(Component component, float z)
	{
		Transform transform = component.transform;
		transform.position = new Vector3(transform.position.x, transform.position.y, z);
	}

	// Token: 0x06008172 RID: 33138 RVA: 0x0029DE3C File Offset: 0x0029C03C
	public static void SetLocalEulerAngleX(GameObject go, float x)
	{
		Transform transform = go.transform;
		transform.localEulerAngles = new Vector3(x, transform.localEulerAngles.y, transform.localEulerAngles.z);
	}

	// Token: 0x06008173 RID: 33139 RVA: 0x0029DE74 File Offset: 0x0029C074
	public static void SetLocalEulerAngleX(Component c, float x)
	{
		Transform transform = c.transform;
		transform.localEulerAngles = new Vector3(x, transform.localEulerAngles.y, transform.localEulerAngles.z);
	}

	// Token: 0x06008174 RID: 33140 RVA: 0x0029DEAC File Offset: 0x0029C0AC
	public static void SetLocalEulerAngleY(GameObject go, float y)
	{
		Transform transform = go.transform;
		transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, y, transform.localEulerAngles.z);
	}

	// Token: 0x06008175 RID: 33141 RVA: 0x0029DEE4 File Offset: 0x0029C0E4
	public static void SetLocalEulerAngleY(Component c, float y)
	{
		Transform transform = c.transform;
		transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, y, transform.localEulerAngles.z);
	}

	// Token: 0x06008176 RID: 33142 RVA: 0x0029DF1C File Offset: 0x0029C11C
	public static void SetLocalEulerAngleZ(GameObject go, float z)
	{
		Transform transform = go.transform;
		transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, z);
	}

	// Token: 0x06008177 RID: 33143 RVA: 0x0029DF54 File Offset: 0x0029C154
	public static void SetLocalEulerAngleZ(Component c, float z)
	{
		Transform transform = c.transform;
		transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, z);
	}

	// Token: 0x06008178 RID: 33144 RVA: 0x0029DF8C File Offset: 0x0029C18C
	public static void SetEulerAngleX(GameObject go, float x)
	{
		Transform transform = go.transform;
		transform.eulerAngles = new Vector3(x, transform.eulerAngles.y, transform.eulerAngles.z);
	}

	// Token: 0x06008179 RID: 33145 RVA: 0x0029DFC4 File Offset: 0x0029C1C4
	public static void SetEulerAngleX(Component c, float x)
	{
		Transform transform = c.transform;
		transform.eulerAngles = new Vector3(x, transform.eulerAngles.y, transform.eulerAngles.z);
	}

	// Token: 0x0600817A RID: 33146 RVA: 0x0029DFFC File Offset: 0x0029C1FC
	public static void SetEulerAngleY(GameObject go, float y)
	{
		Transform transform = go.transform;
		transform.eulerAngles = new Vector3(transform.eulerAngles.x, y, transform.eulerAngles.z);
	}

	// Token: 0x0600817B RID: 33147 RVA: 0x0029E034 File Offset: 0x0029C234
	public static void SetEulerAngleY(Component c, float y)
	{
		Transform transform = c.transform;
		transform.eulerAngles = new Vector3(transform.eulerAngles.x, y, transform.eulerAngles.z);
	}

	// Token: 0x0600817C RID: 33148 RVA: 0x0029E06C File Offset: 0x0029C26C
	public static void SetEulerAngleZ(GameObject go, float z)
	{
		Transform transform = go.transform;
		transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, z);
	}

	// Token: 0x0600817D RID: 33149 RVA: 0x0029E0A4 File Offset: 0x0029C2A4
	public static void SetEulerAngleZ(Component c, float z)
	{
		Transform transform = c.transform;
		transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, z);
	}

	// Token: 0x0600817E RID: 33150 RVA: 0x0029E0DC File Offset: 0x0029C2DC
	public static void SetLocalScaleX(Component component, float x)
	{
		Transform transform = component.transform;
		transform.localScale = new Vector3(x, transform.localScale.y, transform.localScale.z);
	}

	// Token: 0x0600817F RID: 33151 RVA: 0x0029E114 File Offset: 0x0029C314
	public static void SetLocalScaleX(GameObject go, float x)
	{
		Transform transform = go.transform;
		transform.localScale = new Vector3(x, transform.localScale.y, transform.localScale.z);
	}

	// Token: 0x06008180 RID: 33152 RVA: 0x0029E14C File Offset: 0x0029C34C
	public static void SetLocalScaleY(Component component, float y)
	{
		Transform transform = component.transform;
		transform.localScale = new Vector3(transform.localScale.x, y, transform.localScale.z);
	}

	// Token: 0x06008181 RID: 33153 RVA: 0x0029E184 File Offset: 0x0029C384
	public static void SetLocalScaleY(GameObject go, float y)
	{
		Transform transform = go.transform;
		transform.localScale = new Vector3(transform.localScale.x, y, transform.localScale.z);
	}

	// Token: 0x06008182 RID: 33154 RVA: 0x0029E1BC File Offset: 0x0029C3BC
	public static void SetLocalScaleZ(Component component, float z)
	{
		Transform transform = component.transform;
		transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, z);
	}

	// Token: 0x06008183 RID: 33155 RVA: 0x0029E1F4 File Offset: 0x0029C3F4
	public static void SetLocalScaleZ(GameObject go, float z)
	{
		Transform transform = go.transform;
		transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, z);
	}

	// Token: 0x06008184 RID: 33156 RVA: 0x0029E22C File Offset: 0x0029C42C
	public static void SetLocalScaleXY(Component component, float x, float y)
	{
		Transform transform = component.transform;
		transform.localScale = new Vector3(x, y, transform.localScale.z);
	}

	// Token: 0x06008185 RID: 33157 RVA: 0x0029E258 File Offset: 0x0029C458
	public static void SetLocalScaleXY(GameObject go, float x, float y)
	{
		Transform transform = go.transform;
		transform.localScale = new Vector3(x, y, transform.localScale.z);
	}

	// Token: 0x06008186 RID: 33158 RVA: 0x0029E284 File Offset: 0x0029C484
	public static void SetLocalScaleXY(Component component, Vector2 v)
	{
		Transform transform = component.transform;
		transform.localScale = new Vector3(v.x, v.y, transform.localScale.z);
	}

	// Token: 0x06008187 RID: 33159 RVA: 0x0029E2BC File Offset: 0x0029C4BC
	public static void SetLocalScaleXY(GameObject go, Vector2 v)
	{
		Transform transform = go.transform;
		transform.localScale = new Vector3(v.x, v.y, transform.localScale.z);
	}

	// Token: 0x06008188 RID: 33160 RVA: 0x0029E2F4 File Offset: 0x0029C4F4
	public static void SetLocalScaleXZ(Component component, float x, float z)
	{
		Transform transform = component.transform;
		transform.localScale = new Vector3(x, transform.localScale.y, z);
	}

	// Token: 0x06008189 RID: 33161 RVA: 0x0029E320 File Offset: 0x0029C520
	public static void SetLocalScaleXZ(GameObject go, float x, float z)
	{
		Transform transform = go.transform;
		transform.localScale = new Vector3(x, transform.localScale.y, z);
	}

	// Token: 0x0600818A RID: 33162 RVA: 0x0029E34C File Offset: 0x0029C54C
	public static void SetLocalScaleXZ(Component component, Vector2 v)
	{
		Transform transform = component.transform;
		transform.localScale = new Vector3(v.x, transform.localScale.y, v.y);
	}

	// Token: 0x0600818B RID: 33163 RVA: 0x0029E384 File Offset: 0x0029C584
	public static void SetLocalScaleXZ(GameObject go, Vector2 v)
	{
		Transform transform = go.transform;
		transform.localScale = new Vector3(v.x, transform.localScale.y, v.y);
	}

	// Token: 0x0600818C RID: 33164 RVA: 0x0029E3BA File Offset: 0x0029C5BA
	public static void SetLocalScaleYZ(Component component, float y, float z)
	{
		Transform transform = component.transform;
		transform.localScale = new Vector3(transform.localScale.x, y, z);
	}

	// Token: 0x0600818D RID: 33165 RVA: 0x0029E3D9 File Offset: 0x0029C5D9
	public static void SetLocalScaleYZ(GameObject go, float y, float z)
	{
		Transform transform = go.transform;
		transform.localScale = new Vector3(transform.localScale.x, y, z);
	}

	// Token: 0x0600818E RID: 33166 RVA: 0x0029E3F8 File Offset: 0x0029C5F8
	public static void SetLocalScaleYZ(Component component, Vector2 v)
	{
		Transform transform = component.transform;
		transform.localScale = new Vector3(transform.localScale.x, v.x, v.y);
	}

	// Token: 0x0600818F RID: 33167 RVA: 0x0029E421 File Offset: 0x0029C621
	public static void SetLocalScaleYZ(GameObject go, Vector2 v)
	{
		Transform transform = go.transform;
		transform.localScale = new Vector3(transform.localScale.x, v.x, v.y);
	}

	// Token: 0x06008190 RID: 33168 RVA: 0x0029E44A File Offset: 0x0029C64A
	public static void Identity(Component c)
	{
		c.transform.localScale = Vector3.one;
		c.transform.localRotation = Quaternion.identity;
		c.transform.localPosition = Vector3.zero;
	}

	// Token: 0x06008191 RID: 33169 RVA: 0x0029E47C File Offset: 0x0029C67C
	public static void Identity(GameObject go)
	{
		go.transform.localScale = Vector3.one;
		go.transform.localRotation = Quaternion.identity;
		go.transform.localPosition = Vector3.zero;
	}

	// Token: 0x06008192 RID: 33170 RVA: 0x0029E4AE File Offset: 0x0029C6AE
	public static void CopyLocal(Component destination, Component source)
	{
		TransformUtil.CopyLocal(destination.gameObject, source.gameObject);
	}

	// Token: 0x06008193 RID: 33171 RVA: 0x0029E4C1 File Offset: 0x0029C6C1
	public static void CopyLocal(Component destination, GameObject source)
	{
		TransformUtil.CopyLocal(destination.gameObject, source);
	}

	// Token: 0x06008194 RID: 33172 RVA: 0x0029E4CF File Offset: 0x0029C6CF
	public static void CopyLocal(GameObject destination, Component source)
	{
		TransformUtil.CopyLocal(destination, source.gameObject);
	}

	// Token: 0x06008195 RID: 33173 RVA: 0x0029E4E0 File Offset: 0x0029C6E0
	public static void CopyLocal(GameObject destination, GameObject source)
	{
		destination.transform.localScale = source.transform.localScale;
		destination.transform.localRotation = source.transform.localRotation;
		destination.transform.localPosition = source.transform.localPosition;
	}

	// Token: 0x06008196 RID: 33174 RVA: 0x0029E52F File Offset: 0x0029C72F
	public static void CopyLocal(Component destination, TransformProps source)
	{
		TransformUtil.CopyLocal(destination.gameObject, source);
	}

	// Token: 0x06008197 RID: 33175 RVA: 0x0029E53D File Offset: 0x0029C73D
	public static void CopyLocal(GameObject destination, TransformProps source)
	{
		destination.transform.localScale = source.scale;
		destination.transform.localRotation = source.rotation;
		destination.transform.localPosition = source.position;
	}

	// Token: 0x06008198 RID: 33176 RVA: 0x0029E572 File Offset: 0x0029C772
	public static void CopyLocal(TransformProps destination, Component source)
	{
		TransformUtil.CopyLocal(destination, source.gameObject);
	}

	// Token: 0x06008199 RID: 33177 RVA: 0x0029E580 File Offset: 0x0029C780
	public static void CopyLocal(TransformProps destination, GameObject source)
	{
		destination.scale = source.transform.localScale;
		destination.rotation = source.transform.localRotation;
		destination.position = source.transform.localPosition;
	}

	// Token: 0x0600819A RID: 33178 RVA: 0x0029E5B5 File Offset: 0x0029C7B5
	public static void CopyWorld(Component destination, Component source)
	{
		TransformUtil.CopyWorld(destination.gameObject, source);
	}

	// Token: 0x0600819B RID: 33179 RVA: 0x0029E5C3 File Offset: 0x0029C7C3
	public static void CopyWorld(Component destination, GameObject source)
	{
		TransformUtil.CopyWorld(destination.gameObject, source);
	}

	// Token: 0x0600819C RID: 33180 RVA: 0x0029E5D1 File Offset: 0x0029C7D1
	public static void CopyWorld(GameObject destination, Component source)
	{
		TransformUtil.CopyWorld(destination, source.gameObject);
	}

	// Token: 0x0600819D RID: 33181 RVA: 0x0029E5DF File Offset: 0x0029C7DF
	public static void CopyWorld(GameObject destination, GameObject source)
	{
		TransformUtil.CopyWorldScale(destination, source);
		destination.transform.rotation = source.transform.rotation;
		destination.transform.position = source.transform.position;
	}

	// Token: 0x0600819E RID: 33182 RVA: 0x0029E614 File Offset: 0x0029C814
	public static void CopyWorld(Component destination, TransformProps source)
	{
		TransformUtil.CopyWorld(destination.gameObject, source);
	}

	// Token: 0x0600819F RID: 33183 RVA: 0x0029E622 File Offset: 0x0029C822
	public static void CopyWorld(GameObject destination, TransformProps source)
	{
		TransformUtil.SetWorldScale(destination, source.scale);
		destination.transform.rotation = source.rotation;
		destination.transform.position = source.position;
	}

	// Token: 0x060081A0 RID: 33184 RVA: 0x0029E652 File Offset: 0x0029C852
	public static void CopyWorld(TransformProps destination, Component source)
	{
		TransformUtil.CopyWorld(destination, source.gameObject);
	}

	// Token: 0x060081A1 RID: 33185 RVA: 0x0029E660 File Offset: 0x0029C860
	public static void CopyWorld(TransformProps destination, GameObject source)
	{
		destination.scale = TransformUtil.ComputeWorldScale(source);
		destination.rotation = source.transform.rotation;
		destination.position = source.transform.position;
	}

	// Token: 0x060081A2 RID: 33186 RVA: 0x0029E690 File Offset: 0x0029C890
	public static void CopyWorldScale(Component destination, Component source)
	{
		TransformUtil.CopyWorldScale(destination.gameObject, source.gameObject);
	}

	// Token: 0x060081A3 RID: 33187 RVA: 0x0029E6A3 File Offset: 0x0029C8A3
	public static void CopyWorldScale(Component destination, GameObject source)
	{
		TransformUtil.CopyWorldScale(destination.gameObject, source);
	}

	// Token: 0x060081A4 RID: 33188 RVA: 0x0029E6B1 File Offset: 0x0029C8B1
	public static void CopyWorldScale(GameObject destination, Component source)
	{
		TransformUtil.CopyWorldScale(destination, source.gameObject);
	}

	// Token: 0x060081A5 RID: 33189 RVA: 0x0029E6C0 File Offset: 0x0029C8C0
	public static void CopyWorldScale(GameObject destination, GameObject source)
	{
		Vector3 scale = TransformUtil.ComputeWorldScale(source);
		TransformUtil.SetWorldScale(destination, scale);
	}

	// Token: 0x060081A6 RID: 33190 RVA: 0x0029E6DB File Offset: 0x0029C8DB
	public static void SetWorldScale(Component destination, Vector3 scale)
	{
		TransformUtil.SetWorldScale(destination.gameObject, scale);
	}

	// Token: 0x060081A7 RID: 33191 RVA: 0x0029E6EC File Offset: 0x0029C8EC
	public static void SetWorldScale(GameObject destination, Vector3 scale)
	{
		if (destination.transform.parent != null)
		{
			Transform parent = destination.transform.parent;
			while (parent != null)
			{
				scale.Scale(TransformUtil.Vector3Reciprocal(parent.localScale));
				parent = parent.parent;
			}
		}
		destination.transform.localScale = scale;
	}

	// Token: 0x060081A8 RID: 33192 RVA: 0x0029E748 File Offset: 0x0029C948
	public static Vector3 ComputeWorldScale(Component c)
	{
		return TransformUtil.ComputeWorldScale(c.gameObject);
	}

	// Token: 0x060081A9 RID: 33193 RVA: 0x0029E758 File Offset: 0x0029C958
	public static Vector3 ComputeWorldScale(GameObject go)
	{
		Vector3 localScale = go.transform.localScale;
		if (go.transform.parent != null)
		{
			Transform parent = go.transform.parent;
			while (parent != null)
			{
				localScale.Scale(parent.localScale);
				parent = parent.parent;
			}
		}
		return localScale;
	}

	// Token: 0x060081AA RID: 33194 RVA: 0x0029E7B0 File Offset: 0x0029C9B0
	public static Vector3 Vector3Reciprocal(Vector3 source)
	{
		Vector3 vector = source;
		if (vector.x != 0f)
		{
			vector.x = 1f / vector.x;
		}
		if (vector.y != 0f)
		{
			vector.y = 1f / vector.y;
		}
		if (vector.z != 0f)
		{
			vector.z = 1f / vector.z;
		}
		return vector;
	}

	// Token: 0x060081AB RID: 33195 RVA: 0x0029E820 File Offset: 0x0029CA20
	public static void OrientTo(GameObject source, GameObject target)
	{
		TransformUtil.OrientTo(source.transform, target.transform);
	}

	// Token: 0x060081AC RID: 33196 RVA: 0x0029E833 File Offset: 0x0029CA33
	public static void OrientTo(GameObject source, Component target)
	{
		TransformUtil.OrientTo(source.transform, target.transform);
	}

	// Token: 0x060081AD RID: 33197 RVA: 0x0029E846 File Offset: 0x0029CA46
	public static void OrientTo(Component source, GameObject target)
	{
		TransformUtil.OrientTo(source.transform, target.transform);
	}

	// Token: 0x060081AE RID: 33198 RVA: 0x0029E859 File Offset: 0x0029CA59
	public static void OrientTo(Component source, Component target)
	{
		TransformUtil.OrientTo(source.transform, target.transform);
	}

	// Token: 0x060081AF RID: 33199 RVA: 0x0029E86C File Offset: 0x0029CA6C
	public static void OrientTo(Transform source, Transform target)
	{
		TransformUtil.OrientTo(source, source.transform.position, target.transform.position);
	}

	// Token: 0x060081B0 RID: 33200 RVA: 0x0029E88C File Offset: 0x0029CA8C
	public static void OrientTo(Transform source, Vector3 sourcePosition, Vector3 targetPosition)
	{
		Vector3 forward = targetPosition - sourcePosition;
		if (forward.sqrMagnitude > Mathf.Epsilon)
		{
			source.rotation = Quaternion.LookRotation(forward);
		}
	}

	// Token: 0x060081B1 RID: 33201 RVA: 0x0029E8BC File Offset: 0x0029CABC
	public static Vector3 RandomVector3(Vector3 min, Vector3 max)
	{
		return new Vector3
		{
			x = UnityEngine.Random.Range(min.x, max.x),
			y = UnityEngine.Random.Range(min.y, max.y),
			z = UnityEngine.Random.Range(min.z, max.z)
		};
	}

	// Token: 0x060081B2 RID: 33202 RVA: 0x0029E91C File Offset: 0x0029CB1C
	public static void AttachAndPreserveLocalTransform(Transform child, Transform parent)
	{
		TransformProps transformProps = new TransformProps();
		TransformUtil.CopyLocal(transformProps, child);
		child.parent = parent;
		TransformUtil.CopyLocal(child, transformProps);
	}

	// Token: 0x060081B3 RID: 33203 RVA: 0x0029E944 File Offset: 0x0029CB44
	public static float GetAspectRatioValue(TransformUtil.PhoneAspectRatio aspectRatio)
	{
		switch (aspectRatio)
		{
		case TransformUtil.PhoneAspectRatio.Minimum:
			return 1.5f;
		case TransformUtil.PhoneAspectRatio.Wide:
			return 1.7777778f;
		case TransformUtil.PhoneAspectRatio.ExtraWide:
			return 2.04f;
		default:
			return 0f;
		}
	}

	// Token: 0x060081B4 RID: 33204 RVA: 0x0029E971 File Offset: 0x0029CB71
	public static Vector3 GetAspectRatioDependentPosition(Vector3 aspectSmall, Vector3 aspectWide, Vector3 aspectExtraWide)
	{
		return TransformUtil.GetAspectRatioDependentValue<Vector3>(new Func<Vector3, Vector3, float, Vector3>(Vector3.Lerp), aspectSmall, aspectWide, aspectExtraWide);
	}

	// Token: 0x060081B5 RID: 33205 RVA: 0x0029E987 File Offset: 0x0029CB87
	public static float GetAspectRatioDependentValue(float aspectSmall, float aspectWide, float aspectExtraWide)
	{
		return TransformUtil.GetAspectRatioDependentValue<float>(new Func<float, float, float, float>(Mathf.Lerp), aspectSmall, aspectWide, aspectExtraWide);
	}

	// Token: 0x060081B6 RID: 33206 RVA: 0x0029E9A0 File Offset: 0x0029CBA0
	private static T GetAspectRatioDependentValue<T>(Func<T, T, float, T> interpolator, T small, T wide, T extraWide)
	{
		Dictionary<TransformUtil.PhoneAspectRatio, T> dictionary = new Dictionary<TransformUtil.PhoneAspectRatio, T>
		{
			{
				TransformUtil.PhoneAspectRatio.Minimum,
				small
			},
			{
				TransformUtil.PhoneAspectRatio.Wide,
				wide
			},
			{
				TransformUtil.PhoneAspectRatio.ExtraWide,
				extraWide
			}
		};
		TransformUtil.PhoneAspectRatio key;
		TransformUtil.PhoneAspectRatio key2;
		float arg = TransformUtil.PhoneAspectRatioScale(out key, out key2);
		return interpolator(dictionary[key], dictionary[key2], arg);
	}

	// Token: 0x060081B7 RID: 33207 RVA: 0x0029E9EA File Offset: 0x0029CBEA
	public static bool IsExtraWideAspectRatio()
	{
		return TransformUtil.GetAspectRatioDependentValue(0f, 1f, 2f) > 1.2f;
	}

	// Token: 0x060081B8 RID: 33208 RVA: 0x0029EA08 File Offset: 0x0029CC08
	private static float PhoneAspectRatioScale(out TransformUtil.PhoneAspectRatio lowerRatio, out TransformUtil.PhoneAspectRatio upperRatio)
	{
		float num = (float)Screen.width / (float)Screen.height;
		lowerRatio = TransformUtil.PhoneAspectRatio.Minimum;
		upperRatio = TransformUtil.PhoneAspectRatio.ExtraWide;
		int num2 = EnumUtils.Length<TransformUtil.PhoneAspectRatio>();
		for (int i = 0; i < num2; i++)
		{
			TransformUtil.PhoneAspectRatio phoneAspectRatio = (TransformUtil.PhoneAspectRatio)i;
			if (TransformUtil.GetAspectRatioValue(phoneAspectRatio) > num)
			{
				lowerRatio = (TransformUtil.PhoneAspectRatio)((i > 0) ? (i - 1) : 0);
				upperRatio = ((i == 0) ? (i + TransformUtil.PhoneAspectRatio.Wide) : phoneAspectRatio);
				break;
			}
		}
		float aspectRatioValue = TransformUtil.GetAspectRatioValue(lowerRatio);
		float aspectRatioValue2 = TransformUtil.GetAspectRatioValue(upperRatio);
		float num3 = aspectRatioValue2 - aspectRatioValue;
		num = Mathf.Clamp(num, aspectRatioValue, aspectRatioValue2);
		return (num - aspectRatioValue) / num3;
	}

	// Token: 0x060081B9 RID: 33209 RVA: 0x0029EA90 File Offset: 0x0029CC90
	public static void ConstrainToScreen(GameObject go, int layer)
	{
		Camera camera = CameraUtils.FindFirstByLayer(layer);
		if (camera == null)
		{
			Log.All.PrintError("TransformUtil.ConstrainToScreen - No camera found for indicated layer.", Array.Empty<object>());
			return;
		}
		Bounds bounds = TransformUtil.ComputeSetPointBounds(go);
		Vector3[] array = new Vector3[4];
		Vector3 vector = camera.transform.InverseTransformPoint(bounds.center);
		camera.CalculateFrustumCorners(new Rect(0f, 0f, 1f, 1f), vector.z, Camera.MonoOrStereoscopicEye.Mono, array);
		Bounds bounds2 = new Bounds(camera.transform.TransformPoint(array[0]), default(Vector3));
		for (int i = 1; i < 4; i++)
		{
			Vector3 point = camera.transform.TransformPoint(array[i]);
			bounds2.Encapsulate(point);
		}
		Vector3 position = go.transform.position;
		bounds2.SetMinMax(bounds2.min - (bounds.min - position), bounds2.max - (bounds.max - position));
		Vector3 vector2 = bounds2.ClosestPoint(position) - position;
		vector2 -= camera.transform.forward * Vector3.Dot(camera.transform.forward, vector2);
		go.transform.position += vector2;
	}

	// Token: 0x020022F5 RID: 8949
	public enum PhoneAspectRatio
	{
		// Token: 0x0400D628 RID: 54824
		Minimum,
		// Token: 0x0400D629 RID: 54825
		Wide,
		// Token: 0x0400D62A RID: 54826
		ExtraWide,
		// Token: 0x0400D62B RID: 54827
		Maximum = 2
	}
	*/
}
