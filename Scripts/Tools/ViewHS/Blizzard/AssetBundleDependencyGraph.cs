using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Blizzard.T5.AssetManager
{
	public class AssetBundleDependencyGraph : ScriptableObject
	{
		
		public string[] allBundleNames;
		public AssetBundleDependencyGraph.Bundle[] bundles;

		[Serializable]
		public class Bundle
		{
			public uint[] allDependencies;
		}
	}	
}
