using System.Collections;
using UnityEngine;

public class RotateByMovement : MonoBehaviour
{
	private Vector3 m_previousPos = Vector3.zero;
    void Update()
    {
		Transform transform = this.gameObject.transform;
		if (this.m_previousPos == transform.localPosition)
		{
			return;
		}
		if (this.m_previousPos == Vector3.zero)
		{
			this.m_previousPos = transform.localPosition;
			return;
		}
		Vector3 localPosition = transform.localPosition;
		float num = localPosition.z - this.m_previousPos.z;
		float num2 = Mathf.Sqrt(Mathf.Pow(localPosition.x - this.m_previousPos.x, 2f) + Mathf.Pow(num, 2f));
		float num3 = Mathf.Asin(num / num2) * 180f / 3.1415927f;
		num3 -= 90f;
		this.gameObject.transform.localEulerAngles = new Vector3(90f, num3, 0f);
		this.m_previousPos = localPosition;
	}
}
