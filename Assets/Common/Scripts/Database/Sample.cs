using System;
using System.Collections;
using System.Collections.Generic;
using Encounter;
using UnityEngine;

[ExcelAsset]
public class Sample : ScriptableObject
{
	public List<ItemDatabaseSO> Sheet1; // Replace 'EntityType' to an actual type that is serializable.
}
