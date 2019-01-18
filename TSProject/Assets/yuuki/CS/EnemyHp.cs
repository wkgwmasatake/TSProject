using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHp : MonoBehaviour {

    float HP = 100;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<Text>().text = "HP:" + HP.ToString() + "%";
	}
}
