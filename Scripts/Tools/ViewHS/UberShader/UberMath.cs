using System;
using UnityEngine;

// Token: 0x0200289C RID: 10396
public static class UberMath
{
	// Token: 0x060135AE RID: 79278 RVA: 0x005A4068 File Offset: 0x005A2268
	static UberMath()
	{
		for (int i = 0; i < 512; i++)
		{
			UberMath.perm[i] = UnityEngine.Random.Range(5, 250);
		}
	}

	// Token: 0x060135AF RID: 79279 RVA: 0x005A40EE File Offset: 0x005A22EE
	private static int floor(float x)
	{
		if (x <= 0f)
		{
			return (int)x - 1;
		}
		return (int)x;
	}

	// Token: 0x060135B0 RID: 79280 RVA: 0x005A40FF File Offset: 0x005A22FF
	private static float dot(int gx, int gy, float x, float y)
	{
		return (float)gx * x + (float)gy * y;
	}

	// Token: 0x060135B1 RID: 79281 RVA: 0x005A410A File Offset: 0x005A230A
	private static float dot(int gx, int gy, int gz, float x, float y, float z)
	{
		return (float)gx * x + (float)gy * y + (float)gz * z;
	}

	// Token: 0x060135B2 RID: 79282 RVA: 0x005A411C File Offset: 0x005A231C
	public static float SimplexNoise(float xin, float yin)
	{
		float num = 0.36602542f;
		float num2 = (xin + yin) * num;
		int num3 = UberMath.floor(xin + num2);
		int num4 = UberMath.floor(yin + num2);
		float num5 = 0.21132487f;
		float num6 = (float)(num3 + num4) * num5;
		float num7 = (float)num4 - num6;
		float num8 = (float)num3 - num6;
		float num9 = yin - num7;
		float num10 = xin - num8;
		int num11;
		int num12;
		if (num10 > num9)
		{
			num11 = 1;
			num12 = 0;
		}
		else
		{
			num11 = 0;
			num12 = 1;
		}
		float num13 = num10 - (float)num11 + num5;
		float num14 = num9 - (float)num12 + num5;
		float num15 = num10 - 1f + 2f * num5;
		float num16 = num9 - 1f + 2f * num5;
		int num17 = num3 & 255;
		int num18 = num4 & 255;
		int num19 = UberMath.perm[num17 + UberMath.perm[num18]] % 12;
		int num20 = UberMath.perm[num17 + num11 + UberMath.perm[num18 + num12]] % 12;
		int num21 = UberMath.perm[num17 + 1 + UberMath.perm[num18 + 1]] % 12;
		float num22 = 0.5f - num10 * num10 - num9 * num9;
		float num23;
		if (num22 < 0f)
		{
			num23 = 0f;
		}
		else
		{
			num22 *= num22;
			num23 = num22 * num22 * UberMath.dot(UberMath.grad3[num19, 0], UberMath.grad3[num19, 1], num10, num9);
		}
		float num24 = 0.5f - num13 * num13 - num14 * num14;
		float num25;
		if (num24 < 0f)
		{
			num25 = 0f;
		}
		else
		{
			num24 *= num24;
			num25 = num24 * num24 * UberMath.dot(UberMath.grad3[num20, 0], UberMath.grad3[num20, 1], num13, num14);
		}
		float num26 = 0.5f - num15 * num15 - num16 * num16;
		float num27;
		if (num26 < 0f)
		{
			num27 = 0f;
		}
		else
		{
			num26 *= num26;
			num27 = num26 * num26 * UberMath.dot(UberMath.grad3[num21, 0], UberMath.grad3[num21, 1], num15, num16);
		}
		return 70f * (num23 + num25 + num27);
	}

	// Token: 0x060135B3 RID: 79283 RVA: 0x005A4330 File Offset: 0x005A2530
	public static float SimplexNoise(float xin, float yin, float zin)
	{
		float num = (xin + yin + zin) * 0.33333334f;
		int num2 = UberMath.floor(xin + num);
		int num3 = UberMath.floor(yin + num);
		int num4 = UberMath.floor(zin + num);
		float num5 = (float)(num2 + num3 + num4) * 0.16666667f;
		float num6 = (float)num2 - num5;
		float num7 = (float)num3 - num5;
		float num8 = (float)num4 - num5;
		float num9 = xin - num6;
		float num10 = yin - num7;
		float num11 = zin - num8;
		int num12;
		int num13;
		int num14;
		int num15;
		int num16;
		int num17;
		if (num9 >= num10)
		{
			if (num10 >= num11)
			{
				num12 = 1;
				num13 = 0;
				num14 = 0;
				num15 = 1;
				num16 = 1;
				num17 = 0;
			}
			else if (num9 >= num11)
			{
				num12 = 1;
				num13 = 0;
				num14 = 0;
				num15 = 1;
				num16 = 0;
				num17 = 1;
			}
			else
			{
				num12 = 0;
				num13 = 0;
				num14 = 1;
				num15 = 1;
				num16 = 0;
				num17 = 1;
			}
		}
		else if (num10 < num11)
		{
			num12 = 0;
			num13 = 0;
			num14 = 1;
			num15 = 0;
			num16 = 1;
			num17 = 1;
		}
		else if (num9 < num11)
		{
			num12 = 0;
			num13 = 1;
			num14 = 0;
			num15 = 0;
			num16 = 1;
			num17 = 1;
		}
		else
		{
			num12 = 0;
			num13 = 1;
			num14 = 0;
			num15 = 1;
			num16 = 1;
			num17 = 0;
		}
		float num18 = num9 - (float)num12 + 0.16666667f;
		float num19 = num10 - (float)num13 + 0.16666667f;
		float num20 = num11 - (float)num14 + 0.16666667f;
		float num21 = num9 - (float)num15 + 0.33333334f;
		float num22 = num10 - (float)num16 + 0.33333334f;
		float num23 = num11 - (float)num17 + 0.33333334f;
		float num24 = num9 - 1f + 0.5f;
		float num25 = num10 - 1f + 0.5f;
		float num26 = num11 - 1f + 0.5f;
		int num27 = num2 & 255;
		int num28 = num3 & 255;
		int num29 = num4 & 255;
		int num30 = UberMath.perm[num27 + UberMath.perm[num28 + UberMath.perm[num29]]] % 12;
		int num31 = UberMath.perm[num27 + num12 + UberMath.perm[num28 + num13 + UberMath.perm[num29 + num14]]] % 12;
		int num32 = UberMath.perm[num27 + num15 + UberMath.perm[num28 + num16 + UberMath.perm[num29 + num17]]] % 12;
		int num33 = UberMath.perm[num27 + 1 + UberMath.perm[num28 + 1 + UberMath.perm[num29 + 1]]] % 12;
		float num34 = 0.6f - num9 * num9 - num10 * num10 - num11 * num11;
		float num35;
		if (num34 < 0f)
		{
			num35 = 0f;
		}
		else
		{
			num34 *= num34;
			num35 = num34 * num34 * UberMath.dot(UberMath.grad3[num30, 0], UberMath.grad3[num30, 1], UberMath.grad3[num30, 2], num9, num10, num11);
		}
		float num36 = 0.6f - num18 * num18 - num19 * num19 - num20 * num20;
		float num37;
		if (num36 < 0f)
		{
			num37 = 0f;
		}
		else
		{
			num36 *= num36;
			num37 = num36 * num36 * UberMath.dot(UberMath.grad3[num31, 0], UberMath.grad3[num31, 1], UberMath.grad3[num31, 2], num18, num19, num20);
		}
		float num38 = 0.6f - num21 * num21 - num22 * num22 - num23 * num23;
		float num39;
		if (num38 < 0f)
		{
			num39 = 0f;
		}
		else
		{
			num38 *= num38;
			num39 = num38 * num38 * UberMath.dot(UberMath.grad3[num32, 0], UberMath.grad3[num32, 1], UberMath.grad3[num32, 2], num21, num22, num23);
		}
		float num40 = 0.6f - num24 * num24 - num25 * num25 - num26 * num26;
		float num41;
		if (num40 < 0f)
		{
			num41 = 0f;
		}
		else
		{
			num40 *= num40;
			num41 = num40 * num40 * UberMath.dot(UberMath.grad3[num33, 0], UberMath.grad3[num33, 1], UberMath.grad3[num33, 2], num24, num25, num26);
		}
		return 32f * (num35 + num37 + num39 + num41);
	}

	// Token: 0x040109E5 RID: 68069
	private static readonly int[,] grad3 = new int[,]
	{
		{
			1,
			1,
			0
		},
		{
			-1,
			1,
			0
		},
		{
			1,
			-1,
			0
		},
		{
			-1,
			-1,
			0
		},
		{
			1,
			0,
			1
		},
		{
			-1,
			0,
			1
		},
		{
			1,
			0,
			-1
		},
		{
			-1,
			0,
			-1
		},
		{
			0,
			1,
			1
		},
		{
			0,
			-1,
			1
		},
		{
			0,
			1,
			-1
		},
		{
			0,
			-1,
			-1
		}
	};

	// Token: 0x040109E6 RID: 68070
	private static readonly int[,] grad4 = new int[,]
	{
		{
			0,
			1,
			1,
			1
		},
		{
			0,
			1,
			1,
			-1
		},
		{
			0,
			1,
			-1,
			1
		},
		{
			0,
			1,
			-1,
			-1
		},
		{
			0,
			-1,
			1,
			1
		},
		{
			0,
			-1,
			1,
			-1
		},
		{
			0,
			-1,
			-1,
			1
		},
		{
			0,
			-1,
			-1,
			-1
		},
		{
			1,
			0,
			1,
			1
		},
		{
			1,
			0,
			1,
			-1
		},
		{
			1,
			0,
			-1,
			1
		},
		{
			1,
			0,
			-1,
			-1
		},
		{
			-1,
			0,
			1,
			1
		},
		{
			-1,
			0,
			1,
			-1
		},
		{
			-1,
			0,
			-1,
			1
		},
		{
			-1,
			0,
			-1,
			-1
		},
		{
			1,
			1,
			0,
			1
		},
		{
			1,
			1,
			0,
			-1
		},
		{
			1,
			-1,
			0,
			1
		},
		{
			1,
			-1,
			0,
			-1
		},
		{
			-1,
			1,
			0,
			1
		},
		{
			-1,
			1,
			0,
			-1
		},
		{
			-1,
			-1,
			0,
			1
		},
		{
			-1,
			-1,
			0,
			-1
		},
		{
			1,
			1,
			1,
			0
		},
		{
			1,
			1,
			-1,
			0
		},
		{
			1,
			-1,
			1,
			0
		},
		{
			1,
			-1,
			-1,
			0
		},
		{
			-1,
			1,
			1,
			0
		},
		{
			-1,
			1,
			-1,
			0
		},
		{
			-1,
			-1,
			1,
			0
		},
		{
			-1,
			-1,
			-1,
			0
		}
	};

	// Token: 0x040109E7 RID: 68071
	private static readonly int[,] simplex = new int[,]
	{
		{
			0,
			1,
			2,
			3
		},
		{
			0,
			1,
			3,
			2
		},
		{
			0,
			0,
			0,
			0
		},
		{
			0,
			2,
			3,
			1
		},
		{
			0,
			0,
			0,
			0
		},
		{
			0,
			0,
			0,
			0
		},
		{
			0,
			0,
			0,
			0
		},
		{
			1,
			2,
			3,
			0
		},
		{
			0,
			2,
			1,
			3
		},
		{
			0,
			0,
			0,
			0
		},
		{
			0,
			3,
			1,
			2
		},
		{
			0,
			3,
			2,
			1
		},
		{
			0,
			0,
			0,
			0
		},
		{
			0,
			0,
			0,
			0
		},
		{
			0,
			0,
			0,
			0
		},
		{
			1,
			3,
			2,
			0
		},
		{
			0,
			0,
			0,
			0
		},
		{
			0,
			0,
			0,
			0
		},
		{
			0,
			0,
			0,
			0
		},
		{
			0,
			0,
			0,
			0
		},
		{
			0,
			0,
			0,
			0
		},
		{
			0,
			0,
			0,
			0
		},
		{
			0,
			0,
			0,
			0
		},
		{
			0,
			0,
			0,
			0
		},
		{
			1,
			2,
			0,
			3
		},
		{
			0,
			0,
			0,
			0
		},
		{
			1,
			3,
			0,
			2
		},
		{
			0,
			0,
			0,
			0
		},
		{
			0,
			0,
			0,
			0
		},
		{
			0,
			0,
			0,
			0
		},
		{
			2,
			3,
			0,
			1
		},
		{
			2,
			3,
			1,
			0
		},
		{
			1,
			0,
			2,
			3
		},
		{
			1,
			0,
			3,
			2
		},
		{
			0,
			0,
			0,
			0
		},
		{
			0,
			0,
			0,
			0
		},
		{
			0,
			0,
			0,
			0
		},
		{
			2,
			0,
			3,
			1
		},
		{
			0,
			0,
			0,
			0
		},
		{
			2,
			1,
			3,
			0
		},
		{
			0,
			0,
			0,
			0
		},
		{
			0,
			0,
			0,
			0
		},
		{
			0,
			0,
			0,
			0
		},
		{
			0,
			0,
			0,
			0
		},
		{
			0,
			0,
			0,
			0
		},
		{
			0,
			0,
			0,
			0
		},
		{
			0,
			0,
			0,
			0
		},
		{
			0,
			0,
			0,
			0
		},
		{
			2,
			0,
			1,
			3
		},
		{
			0,
			0,
			0,
			0
		},
		{
			0,
			0,
			0,
			0
		},
		{
			0,
			0,
			0,
			0
		},
		{
			3,
			0,
			1,
			2
		},
		{
			3,
			0,
			2,
			1
		},
		{
			0,
			0,
			0,
			0
		},
		{
			3,
			1,
			2,
			0
		},
		{
			2,
			1,
			0,
			3
		},
		{
			0,
			0,
			0,
			0
		},
		{
			0,
			0,
			0,
			0
		},
		{
			0,
			0,
			0,
			0
		},
		{
			3,
			1,
			0,
			2
		},
		{
			0,
			0,
			0,
			0
		},
		{
			3,
			2,
			0,
			1
		},
		{
			3,
			2,
			1,
			0
		}
	};

	// Token: 0x040109E8 RID: 68072
	private static int[] perm = new int[512];
}
