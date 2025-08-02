using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneTransformVariants
{
	public static Vector3 GetBattleGroundTopCurve(float t,float i,float N)
	{
		return ZoneTransformVariants.GetSineCurve3D(t,i,N);
	}
	public static Vector3 GetBattleGroundDownCurve(float t,float i,float N)
	{
		return ZoneTransformVariants.GetCosCurve3D(t,i,N);
	}

	private static List<float> Dy= new List<float>(){0f,0.4f,0.8f,0.4f};
	public static Vector3 GetSineCurve2D(float t, float i, float N)
	{
		Vector3 pos = Vector3.zero;
		float phase = i/N;

        pos.x = (2.6f+phase/3f)*Mathf.Cos((-5*t/360f+phase)*6.28f);//+1.5f*Mathf.Cos((-3*t/360f+phase)*6.28f);
        pos.z = (1.8f+phase/3f)*Mathf.Sin((-5*t/360f+phase)*6.28f);
        if(i<0)
        {
        	i=0;
        }
		pos.y = 0f + ZoneTransformVariants.Dy[((int)i)%4];
        return pos;
	}
	public static Vector3 GetCosCurve2D(float t, float i, float N)
	{
		Vector3 pos = Vector3.zero;
		float phase = i/N; 
        pos.x = (2f-phase/1f)*Mathf.Cos((4*t/360f+phase)*6.28f);//+1.2f*Mathf.Cos((4*t/360f+phase)*6.28f);
        pos.z = (1.2f-phase/1f)*Mathf.Sin((4*t/360f+phase)*6.28f);
        if(i<0)
        {
        	i=0;
        }
		pos.y = 0f + ZoneTransformVariants.Dy[((int)i)%4];
        return pos;
	}

	public static Vector3 GetSineCurve3D(float t, float i, float N)
	{
		Vector3 pos = Vector3.zero;
		float phase = i/N; 
        pos.x = 1.8f*Mathf.Cos((2*t/360f+phase)*6.28f)+1.5f*Mathf.Cos((1*t/360f+phase)*6.28f);
        pos.y = 0.8f+(i/50f)*4f;
        pos.z = 1.8f*Mathf.Sin((3*t/360f+phase)*6.28f);
        return pos;
	}
	public static Vector3 GetCosCurve3D(float t, float i, float N)
	{
		Vector3 pos = Vector3.zero;
		float phase = i/N; 
        pos.x = 1.2f*Mathf.Sin((4*t/360f+phase)*6.28f)+1.2f*Mathf.Cos((3*t/360f+phase)*6.28f);
        pos.y = 0.8f+(i/50f)*4f;
        pos.z = 1.2f*Mathf.Sin((1*t/360f+phase)*6.28f);
        return pos;
	}
	public static Vector3 GetCurve1(float t, float i, float N)
	{
		Vector3 pos = Vector3.zero;
        pos.x = 1.5f*Mathf.Sin((2*t/360f+i/N)*6.28f)+1.3f*Mathf.Cos((7*t/360f+i/N)*6.28f);
        pos.x*=1.5f*Mathf.Sin((2*t/360f+i/N)*6.28f);
        pos.x+=1.3f*Mathf.Cos((2*t/360f+i/N)*6.28f);
        pos.y = 0.8f+(i/50f)*4f;
        pos.z = 1.3f*Mathf.Sin((5*t/360f+i/N)*6.28f);
        pos.z*=1.5f*Mathf.Sin((2*t/360f+i/N)*6.28f);
        pos.z+=1.3f*Mathf.Cos((2*t/360f+i/N)*6.28f);
        return pos;		
	}



}