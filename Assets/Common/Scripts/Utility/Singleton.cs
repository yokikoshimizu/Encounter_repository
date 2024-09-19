using UnityEngine;

namespace Encounter
{
    public class Singleton<T> : MonoBehaviour
      where T : Singleton<T> //Singletonクラスを継承したクラスのみを対象に
    {
        public static T Instance
        {
            get
            {
                if (_instance == null) // _instanceが存在しない場合、
                {
                    _instance = FindObjectOfType<T>(); // クラスを探す
                    CheckExistenceInstance(); // インスタンスが存在しているか確認
                }

                return _instance;
            }
        }

        private static T _instance;

        /// <summary>
        /// インスタンスが存在していない場合、ゲームオブジェクトを作成
        /// </summary>
        private static void CheckExistenceInstance()
        {
            // インスタンスが存在している場合、処理を終了
            if (_instance != null) return;

            // オブジェクトを生成
            var gameObj = new GameObject();
            gameObj.name = typeof(T).Name;
            _instance = gameObj.AddComponent<T>();

            DontDestroyOnLoad(gameObj);
        }

        private void Awake()
        {
            RemoveDuplicates();
        }

        private void RemoveDuplicates()
        {
            if (_instance == null)
            {
                _instance = this as T;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}