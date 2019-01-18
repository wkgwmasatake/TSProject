using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerGauge : MonoBehaviour {

    const int PowerMax = 100;   //ゲージの最大量
    const float PlusPower = PowerMax*0.01f;    //パワーを足す量
    float Power;    //パワー保持

    int Count;      //Count MAXになったら反転

	// Use this for initialization
	void Start () {

        Power = 0;
        GaugeRender(0);

        Count = 0;
    }
	
	// Update is called once per frame
	void Update () {
        OnClick();
	}

    public void GaugeRender(float Power)
    {
        this.GetComponent<Image>().fillAmount = (Power / PowerMax);
    }

    private void OnClick()
    {
        if(Input.GetMouseButton(0)){
            Count++;

            if(Count / 100 == 0)
                GaugeRender(Power += PlusPower);
            if (Count / 100 == 1)
                GaugeRender(Power -= PlusPower);
            if (Count > 200)
                Count = 0;
        }
    }
}
