using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text TextGold;
	// Use this for initialization
	void Start () {
        TextGold.text = DataController.Instance.Gold.ToString();
        StartCoroutine(StartCollectGold());
	}
	

    //코루틴 - 시간에 관련된것을 실행할때
    IEnumerator StartCollectGold()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(1f);  //1초를 쉬는것
            DataController.Instance.Gold += DataController.Instance.GoldPerSec;
            TextGold.text = DataController.Instance.Gold.ToString();
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
