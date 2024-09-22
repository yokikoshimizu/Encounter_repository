using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/// <summary>
/// 敵のデータ管理クラス
/// </summary>
namespace Encounter
{
    [System.Serializable]
    public class EnemyData : Data
    {
        public string Name;
        public int Hp;
        public int Attack;
        public int Defense;
    }

    public class EnemyDatabaseManager : DatabaseManagerBase<EnemyDatabase, EnemyData>
    {
        // ScriptableObjectのデータを保持する変数
        protected override EnemyDatabase scriptableObjectData { get; set; }
        protected override string databasePath { get; set; } = "";

        // TODO enemyDataのセットアップどうしよう
        // labelとかからIDを取れるようにする
        public override EnemyData GetDatabyID(int id)
        {
            var enemyData = new EnemyData();
            var data = scriptableObjectData.EnemyList.Where(v => v.Id == id).FirstOrDefault();
            return data;
        }

        public override EnemyData GetDataByLabel(string label)
        {
            var enemyData = new EnemyData();
            var data = scriptableObjectData.EnemyList.Where(v => v.Label == label).FirstOrDefault();
            return data;
        }

        protected override void SetupData()
        {
            base.SetupData();
            var hp = EnemyDatabaseManager.Instance.GetDatabyID(1).Hp;
        }
    }
}
