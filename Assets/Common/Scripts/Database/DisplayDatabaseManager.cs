using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;
/// <summary>
/// 表示用のデータ管理クラス
/// </summary>
namespace Encounter
{
    [System.Serializable]
    public class DisplayData : Data
    {
        public string DisplayJP;
        public string DisplayEN;
    }

    public class DisplayDatabaseManager<T> : DatabaseManagerBase<T, DisplayData>
        where T : ScriptableObject
    {
        // ScriptableObjectのデータを保持する変数
        protected override T scriptableObjectData { get; set; }
        protected override string databasePath { get { return path; } set { path = value; } }
        [SerializeField]
        private string path = "";
        // 2回目以降はこっちから呼び出して計算量を減らす
        private Dictionary<int, DisplayData> displayDataDictionaryForGetDatabyID = new Dictionary<int, DisplayData>();

        // データの取得
        public override DisplayData GetDatabyID(int id)
        {
            if (displayDataDictionaryForGetDatabyID.ContainsKey(id))
            {
                return displayDataDictionaryForGetDatabyID[id];
            }

            var displayData = new DisplayData();
            var genericList = scriptableObjectData as IGenericDisplayListProvider;
            displayData = genericList.GenericDisplayList.Where(v => v.Id == id).FirstOrDefault();
            displayDataDictionaryForGetDatabyID.Add(id, displayData);
            return displayData;
        }
        public override DisplayData GetDataByLabel(string label)
        {
            var displayData = new DisplayData();
            return displayData;
        }

        // こうすると初回のみ計算量が膨大になるが、2回目以降はDictionaryを参照するだけなので計算量が少なくて済む → メモ化っていうらしい
        private void Initialize()
        {
            var genericDisplayListProvider = scriptableObjectData as IGenericDisplayListProvider;
            var displayList = genericDisplayListProvider.GenericDisplayList;

            foreach (var data in displayList)
            {
                GetDatabyID(data.Id);
            }
        }

        protected override void Awake()
        {
            SetupData();
            Initialize();
            foreach (var data in displayDataDictionaryForGetDatabyID)
            {
                Debug.Log(data.Key + " " + data.Value.DisplayJP);
            }
        }
    }

    public interface IGenericDisplayListProvider
    {
        public List<DisplayData> GenericDisplayList { get;}
    }
}
