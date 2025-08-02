using System;
using UnityEngine;

// Token: 0x020009F8 RID: 2552
public class ShaderUtils
{
	// Token: 0x06008706 RID: 34566 RVA: 0x002C3F6A File Offset: 0x002C216A
	public static Shader FindShader(string name)
	{
		return HSViewer.GetHSShader(name);//ShaderPreCompiler.GetShader(name);
	}
}
