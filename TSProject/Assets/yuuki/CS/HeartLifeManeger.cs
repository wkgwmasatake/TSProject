using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartLifeManeger : MonoBehaviour
{
    public GameObject GOHeart;

    const int PlayerLifeMax = 20;
    int PlayerLife;

    int XMax = PlayerLifeMax / 2;

    float XPos;
    float YPos;

    // Use this for initialization
    void Start()
    {
        PlayerLife = PlayerLifeMax;
        HeartCreate(PlayerLife);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlayerLife -= 1;
            HeartCreate(PlayerLife);
        }
    }

    void HeartCreate(int PlayerLife)
    {
        HeartDestroy();

        int setLife = PlayerLife;

        for (YPos = 0; 2 > YPos; YPos++)
        {
            for (XPos = 0; setLife > XPos && 10 > XPos; XPos++)
            {
                Instantiate(GOHeart, new Vector2(XPos, -YPos), transform.rotation);
            }
            setLife -= 10;
        }
    }
    
    void HeartDestroy()
    {
         GameObject[] Hearts = GameObject.FindGameObjectsWithTag("Heart");

        foreach (GameObject Heart in Hearts)
        {
                Destroy(Heart);
        }
    }
}