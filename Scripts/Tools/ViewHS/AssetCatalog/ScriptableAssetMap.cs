using System;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableAssetMap:MonoBehaviour
{
	public ScriptableAssetMap.SerializableMap map = new ScriptableAssetMap.SerializableMap();

	[Serializable]
	public class SerializableMap : SerializableDictionary<string, string>
	{
	}
}