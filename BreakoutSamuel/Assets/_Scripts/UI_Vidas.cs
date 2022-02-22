using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Vidas : MonoBehaviour
{
    Text texComp;

    GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        texComp = GetComponent<Text>();

        gm = GameManager.GetInstance();
    }

    // Update is called once per frame
    void Update()
    {
        texComp.text = $"Vidas: {gm.vidas}";
    }
}
