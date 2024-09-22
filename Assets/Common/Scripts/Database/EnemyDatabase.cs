using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Encounter
{
	[ExcelAsset]
	public class EnemyDatabase : ScriptableObject
	{
		public List<EnemyData> EnemyList; // Replace 'EntityType' to an actual type that is serializable.
	}
}
