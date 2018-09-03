using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPController : MonoBehaviour {

    Slider _slider;

    float hp = 0;

	// Use this for initialization
	void Start () {
        //スライダーを取得する
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}