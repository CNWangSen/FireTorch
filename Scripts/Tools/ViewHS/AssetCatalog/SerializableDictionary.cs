using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000019 RID: 25
[Serializable]
public class SerializableDictionary<TKey, TValue> : Dictionary<TKey, TValue>, ISerializationCallbackReceiver
{
	// Token: 0x06000096 RID: 150 RVA: 0x000036C8 File Offset: 0x000018C8
	public void OnBeforeSerialize()
	{
		this.keys.Clear();
		this.values.Clear();
		foreach (KeyValuePair<TKey, TValue> keyValuePair in this)
		{
			this.keys.Add(keyValuePair.Key);
			this.values.Add(keyValuePair.Value);
		}
	}

	// Token: 0x06000097 RID: 151 RVA: 0x0000374C File Offset: 0x0000194C
	public void OnAfterDeserialize()
	{
		base.Clear();
		if (this.keys.Count != this.values.Count)
		{
			throw new Exception(string.Format("There are {0} keys and {1} values after deserialization. Make sure that both kay and value types are serializable", this.keys.Count, this.values.Count));
		}
		for (int i = 0; i < this.keys.Count; i++)
		{
			base.Add(this.keys[i], this.values[i]);
		}
	}

	// Token: 0x04000058 RID: 88
	[SerializeField]
	private List<TKey> keys = new List<TKey>();

	// Token: 0x04000059 RID: 89
	[SerializeField]
	private List<TValue> values = new List<TValue>();
}
