using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script para fazer a bola rolar (no seu próprio eixo)
public class Rolar : MonoBehaviour {

    //Variável booleana para checar se a bola está rolando para a direita ou para a esquerda
    private bool paraDireita; 

	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

        //Para pegar o clique do mouse ou o toque (Em qualquer lugar da tela)
        if (Input.GetMouseButtonDown(0))
        {
            //Se a bola estiver rolando para a direita... trocar valor da variável (paraDireita) para (false) para que a bola role para a esquerda
            if (paraDireita)
            {
                paraDireita = false;

            }
            else

            {   //Se a bola estiver rolando para a esquerda... trocar o valor da variável (paraDireita) para (true) para que a bola role para a direita
                paraDireita = true;
            }
        }

        //Para que a bola role para a direita
        if (paraDireita)
        {
            //Essa parte faz com que a bola role para a direita
            transform.Rotate (0, 0, Time.deltaTime * 262);

        } else
        {
            //Essa parte faz com que a bola role para a esquerda
            transform.Rotate(0, 0, Time.deltaTime * -262);
        }
    }
}
