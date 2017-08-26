using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour { //로직은 구현하지 말고 메터 데이터 정의


    // Singleton class Start
    #region [Singleton class Start]
    static GameObject _container;
    static GameObject Container
    {
        get
        {
            return _container;
        }
    }

    static DataController _instance;
    public static DataController Instance
    {
        get
        {
            if (!_instance)
            {
                _container = new GameObject();
                _container.name = "DataController";
                _instance = _container.AddComponent(typeof(DataController)) as DataController;
                DontDestroyOnLoad(_container);
            }
            return _instance;
        }
    }
    #endregion

    public int Gold = 0;
    public int GoldPerSec = 1;  //1초에 쌓일 골드량 정의

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
