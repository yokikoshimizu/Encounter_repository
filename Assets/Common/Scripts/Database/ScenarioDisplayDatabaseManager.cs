using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Encounter
{
    public class ScenarioDisplayDatabaseManager : DisplayDatabaseManager<ScenarioDisplayDatabase>
    {
        // データの取得
        public override DisplayData GetDatabyID(int id)
        {
            var displayData = new DisplayData();
            displayData = scriptableObjectData.DisplayList.Where(v => v.Id == id).FirstOrDefault();
            return displayData;
        }
        public override DisplayData GetDataByLabel(string label)
        {
            var displayData = new DisplayData();
            return displayData;
        }
    }
}
