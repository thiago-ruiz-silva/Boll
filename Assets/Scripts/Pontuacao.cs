using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{

    //Esse script deve ser colocado no (Canvas) das (Cenas): (Recorde) e (GameOver)


    //Para passar os valores para o (Jogo) ---Ver (Canvas) das (Cenas): (Recorde) e (GameOver)----
    public Text pontuacao, recorde;

    //Para armazenar a pontuação mais alta feita no (Jogo)
    public float maximo;

    void Start()
    {

        //Para pegar a pontuação do (Jogo)
        pontuacao.text = (PassaPontos.pontos.ToString("F2"));
    }

    // Update is called once per frame
    void Update()
    {
        //Para "zerar" os pontos que o (Jogador) fez
        if (PassaPontos.zerarPontos)
        {
            //Para que o valor volte a ser (0)
            pontuacao.text = "0,00";

        }       

        //Para armazenar no banco de dados a pontuação mais alta feita no (Jogo)
        maximo = PlayerPrefs.GetFloat("recorde", PassaPontos.maximo);

        //Para mostrar o valor da pontuação mais alta feita no (Jogo)
        recorde.text = maximo.ToString("F2");
    }
}