using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// データベース管理クラスの抽象クラス
/// </summary>
namespace Encounter
{
    public abstract class DatabaseManagerBase : Singleton<DatabaseManagerBase>
    {
        // TODO: データ取得を主に行う？
        // ここでenumとか渡して取得するか、派生クラスを作ってどうこうするかは選択かなー
        public virtual void GetData()
        {

        }
    }
}

