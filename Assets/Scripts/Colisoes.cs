using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//Nesse script tive que colocar também a contagem dos pontos (tempo) para poder passar o valor dos pontos para outra cena
public class Colisoes : MonoBehaviour
{


    //Variável (pontos) para contagem dos pontos (Tempo)
    public float pontos = 0;
    //Variável (maximo) para marcar a pontuação mais alta
    public float maximo = 0;
    //Text (pontuacao) para mostrar os pontos (Tempo) na (Tela)
    public Text pontuacao;
    //Text (recorde) para mostrar a pontuação mais alta na (Tela) de (Gameover e de Recorde) ---MUDANÇAS FORAM FEITAS. ANALIZAR MELHOR PARA ENTENDER---
    public Text recorde;


    // Use this for initialization
    void Start()
    {

        PassaPontos.zerarPontos = false;

        //Para passar os (Pontos) (Tempo) para a outra cena
        pontos = PassaPontos.pontos;

        //Para pegar o valor da pontuação na memória
        //Para pegar o valor do (recorde) e passar para a variável (maximo)
        PassaPontos.maximo = PlayerPrefs.GetFloat("recorde", PassaPontos.maximo);
    }

    // Update is called once per frame
    void Update()
    {
        //Para incrementar os pontos (Tempo)
        pontos += Time.deltaTime;

        //Para exibir a pontuação na (Tela) (Dentro dos parenteses tem que colocar o (F2) para só apresentar duas casas decimais)
        pontuacao.text = (pontos.ToString("F2"));

        //Para exibir a pontuação mais alta na (Tela) (Nesse caso só na (Tela) de GameOver)
        recorde.text = (maximo.ToString("F2"));
    }

    private void OnCollisionEnter2D(Collision2D outro)
    {
        //Para checar as colisões da bola com os espinhos (Tanto espinhos que caem, quanto os espinhos que estão nas laterais do (Jogo))
        if (outro.gameObject.CompareTag("Espinhos"));
        {

            //Para se a pontuação feita no jogo for mais alta que o recorde do jogo, a pontuação atual será o novo recorde
            if (pontos > PassaPontos.maximo)
            {
                PassaPontos.maximo = pontos;

                //Para armazenar a pontuação na memória 
                PlayerPrefs.SetFloat("recorde", pontos);

                //Para (Abrir) a (Cena) (Record)
                UnityEngine.SceneManagement.SceneManager.LoadScene("Record");
            }
            else
            {
                //Para chamar a cena de (GameOver) (Trocar de Cena)
                UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");

                //Para passar o valor dos pontos (Tempo) para o (Script) (PassaPontos) e assim poder passar os pontos (Tempo) para a outra cena
                PassaPontos.pontos = pontos;
            }           
        }
    }
}
