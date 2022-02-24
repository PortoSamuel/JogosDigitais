using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocoSpawner : MonoBehaviour
{
    public GameObject BlocoAzul;
    public GameObject BlocoVerde;
    public GameObject BlocoAmarelo;
    public GameObject BlocoLaranja;
    public GameObject BlocoVermelho;

    GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.GetInstance();

        GameManager.changeStateDelegate += Construir;

        Construir();
    }

    void Construir()
    {
        if (gm.gameState == GameManager.GameState.GAME && gm.StateList[0] != GameManager.GameState.PAUSE)
        {
            foreach (Transform child in transform)
            {
                GameObject.Destroy(child.gameObject);
            }
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(j==4){
                        Vector3 posicao =
                        new Vector3(-5 + 1.75f * i, 4 - 1.75f * j / 2);

                        Instantiate(BlocoAzul, posicao, Quaternion.identity, transform);
                    }
                    else if(j==3){
                        Vector3 posicao =
                        new Vector3(-5 + 1.75f * i, 4 - 1.75f * j / 2);

                        Instantiate(BlocoVerde, posicao, Quaternion.identity, transform);
                    }
                    else if(j==2){
                        Vector3 posicao =
                        new Vector3(-5 + 1.75f * i, 4 - 1.75f * j / 2);

                        Instantiate(BlocoAmarelo, posicao, Quaternion.identity, transform);
                    }
                    else if(j==1){
                        Vector3 posicao =
                        new Vector3(-5 + 1.75f * i, 4 - 1.75f * j / 2);

                        Instantiate(BlocoLaranja, posicao, Quaternion.identity, transform);
                    }
                    else{
                        Vector3 posicao =
                        new Vector3(-5 + 1.75f * i, 4 - 1.75f * j / 2);

                        Instantiate(BlocoVermelho, posicao, Quaternion.identity, transform);
                    }
                    
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (
            transform.childCount <= 0 &&
            gm.gameState == GameManager.GameState.GAME
        )
        {
            gm.changeState(GameManager.GameState.ENDGAME);
        }
    }
}
