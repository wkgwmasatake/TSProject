using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereGaugeManager : MonoBehaviour {

    int HP;
    public Text Hp;

    // Use this for initialization
    void Start () {
        HP = 100;
    }

    // Update is called once per frame
    void Update () {
        Hp.text = "HP:" + HP.ToString() + "%";
        OnClick();
    }

    public void SphereGaugeRender(float HP)
    {
        this.GetComponent<Image>().fillAmount = HP/100;
    }

    private void OnClick()
    {
        if (Input.GetMouseButton(0) && HP > 0)
        {
            SphereGaugeRender(--HP);
        }
    }

}
