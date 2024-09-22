using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Encounter
{
	[ExcelAsset]
	public class ScenarioDisplayDatabase : ScriptableObject, IGenericDisplayListProvider
	{
		public List<DisplayData> DisplayList; // Replace 'EntityType' to an actual type that is serializable.
		public List<DisplayData> GenericDisplayList => DisplayList;
	}
}
