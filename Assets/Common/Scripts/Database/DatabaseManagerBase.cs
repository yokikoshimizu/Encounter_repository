using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/// <summary>
/// データベース管理クラスの抽象クラス
/// </summary>
namespace Encounter
{
    // データを格納するクラス
    [System.Serializable]
    public class Data
    {
        public int Id;
        public string Label;
    }

    public abstract class DatabaseManagerBase<T, TData> : Singleton<DatabaseManagerBase<T, TData>>
        where T : ScriptableObject
        where TData : Data
    {
        // ScriptableObjectのデータを保持する変数
        protected abstract T scriptableObjectData { get; set; }
        protected abstract string databasePath { get; set; }

        // データの取得
        public abstract TData GetDatabyID(int id);
        public abstract TData GetDataByLabel(string label);
        // scriptableObjectのデータを読み込む TODO Addressableから読み込むようにしたい
        protected virtual void SetupData()
        {
            scriptableObjectData = Resources.Load<T>(databasePath);
        }
        protected virtual void Awake()
        {
            SetupData();
        }
    }
}

