 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espinhos : MonoBehaviour
{

    //Para passar o (Objeto) (Espinho) 
    public GameObject espinhos;

    //Para a variável (intervaloCriarEspinhos) que será usada para determinar quando os (Espinhos) serão (Criados)
    //(Fator) para (Diminuir) o (Intervalo) de (Criação) dos (Espinhos)
    float intervaloCriarEspinhos, fator;

    //---(posicaoEsquerda & posicaoDireita) para determinada a posição que os (Espinhos) vão ser (Criados)---
    //---(posicaoEsquerda) para os (Espinhos) que serão (Criados) da (Metade) da (Tela) pra (Esquerda)---
    //---(posicaoDireita) para os (Espinhos) que serão (Criados) da (Metade) da (Tela) pra (Direita)---
    //---(distanciaEspinho) para (Variar) qual (Espinho) será (Criado) primeiro || O da (Direita) ou o da (Esquerda)---
    int posicaoEsquerda, posicaoDireita, distaciaEspinho;


    void Start()
    {

        //Para que o (Primeiro) (Intervalo) seja de (1) segundo
        intervaloCriarEspinhos = 1;

        //Para ir (Variando) (Cada vez menos) o (Tempo) de (Criação) dos (Espinhos)
        fator = 0.005f;
    }

    // Update is called once per frame
    void Update()
    {

        //Para (Diminuir) a (Variável) (intervaloCriarEspinho) até que ela chegue a (0) || (Zero)
        intervaloCriarEspinhos -= Time.deltaTime;
        
        //Para enquanto a variável for (Maior) que (Zero) 
        if (intervaloCriarEspinhos <= 0)
        {

            //Para sortear a posição do (Espinho) que será criado do lado (Esquerdo) da (Tela) do (Jogo)
            posicaoEsquerda = Random.Range(-6, 0);

            //Para sortear a posição do (Espinho) que será criado do lado (Direito) da (Tela) do (Jogo)
            posicaoDireita = Random.Range(1, 7);

            //Para sortear o (Espinho) que sairá primeiro ---O do lado (Esquerdo) ou do lado (Direito)---
            //---Essa variável mudará durante o (Jogo) para que o espinhos caiam de forma mais (Aleatória)---
            distaciaEspinho = Random.Range(1, 3);


            //Para que o (Espinho) da (Direita) saia antes do (Espinho) da (Esquerda) 
            if (distaciaEspinho == 1)
            {

                //Para (Criar) os (Espinhos) na tela do (Jogo)
                Instantiate(espinhos, new Vector2(posicaoEsquerda, 6), Quaternion.identity);

                Instantiate(espinhos, new Vector2(posicaoDireita, 5), Quaternion.identity);
            }

            //Para que o (Espinho) da (Esquerda) saia antes do (Espinho) da (Direita) 
            if (distaciaEspinho == 2)
            {

                //Para (Criar) os (Espinhos) na tela do (Jogo)
                Instantiate(espinhos, new Vector2(posicaoEsquerda, 5), Quaternion.identity);

                Instantiate(espinhos, new Vector2(posicaoDireita, 6), Quaternion.identity);              
            }
            
            //Para que espere (O tempo que está definido abaixo) para (Criar) os próximos (Espinhos)
            intervaloCriarEspinhos = 1 - fator;

            //(Fator) para que os (Espinhos) sejam (Criados) cada vez mais rápidos
            //---Para que o (Intervalo) de (Tempo) para (Criar) os (Espinhos) seja cada vez (Menor)---
            fator += 0.003f;
        }
    }
}
