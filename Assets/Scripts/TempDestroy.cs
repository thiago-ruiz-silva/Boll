using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script para destroir os espinhos
public class TempDestroy : MonoBehaviour {

    //Variável para armazenar o tempo (Que é o tempo que demora para o objeto ser (destruído))
    float tempo = 1.4f;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Para pegar o tempo (Time.deltaTime) para que o tempo seja contado em segundos
        //E decrementar o tempo 
        tempo -= Time.deltaTime;

        //Para quando o tempo chegar a (Zero) destruir o espinho (Para liberar memória)
        if (tempo <= 0)
        {
            //Para chamar o método que destroi o espinho
            Destroy(this.gameObject);            
        }
	}
}
