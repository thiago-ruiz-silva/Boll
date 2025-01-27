using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script para fazer a bola se mover para a esquerda ou direita (Esse script deve ser colocado em um objeto vázio e dentro desse objeto vázio deve-se colocar o objeto bola)
public class Mover : MonoBehaviour {

    //Variável booleana para checar se a (Bola) está se movendo para a direita ou para a esquerda
    private bool paraDireita, numero;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Para pegar o clique do mouse ou o toque (Em qualquer lugar da tela)
        if (Input.GetMouseButtonDown(0))
        {

            //Se a bola estiver se movendo para a direita... trocar valor da variável  (paraDireita) para (false) para que a bola mova-se para a esquerda
            if (paraDireita)
            {
                paraDireita = false;

            }
            else

            {
                //Se a bola estiver se movendo para a esquerda... trocar valor da variável (paraDireita) para (true) para que a bola mova-se para a direita
                paraDireita = true;
            }            
        }
        //Se a bola estiver se movendo para a direita
        if (paraDireita)
        {
            //Essa parte faz com que a bola mova-se para a direita
            transform.Translate (Time.deltaTime * -7, 0, 0);
        }
        else
        {
            //Essa parte faz com que a bola mova-se para a esquerda
            transform.Translate (Time.deltaTime * 7, 0, 0);
        }
    }
}
