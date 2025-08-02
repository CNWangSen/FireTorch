using System;

// Token: 0x0200096D RID: 2413
public struct WorldDimensionIndex
{
	// Token: 0x0600812B RID: 33067 RVA: 0x0029C7C0 File Offset: 0x0029A9C0
	public WorldDimensionIndex(float dimension, int index)
	{
		this.Dimension = dimension;
		this.Index = index;
	}

	// Token: 0x040067A8 RID: 26536
	public float Dimension;

	// Token: 0x040067A9 RID: 26537
	public int Index;
}
