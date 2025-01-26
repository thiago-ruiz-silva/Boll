using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botoes : MonoBehaviour {


    //Para poder mostrar e não mostrar as mensagens ---Na (Cena) (Mensagem)---
    public GameObject mensagemDoacao, mensagemPix, mensagemPayPal;

    public int numero;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Método que chama a cena (CenaJogar)
    public void Jogar()
    {
        //Essa parte chama a cena
        UnityEngine.SceneManagement.SceneManager.LoadScene("CenaJogar");

        //Para o jogo começar
        Time.timeScale = 1;

        //Para zerar os pontos da (CenaJogar)
        PassaPontos.pontos = 0;        
    }

    //Para (Chamar) a (Cena) (Mensagem) que é a (Cena) para (Doação) do (Jogo)
    public void Doar()
    {

        //Para (Chamar) a (Cena) (Mensagem)
        UnityEngine.SceneManagement.SceneManager.LoadScene("Mensagem");
    }


    //Para (Voltar) para a (Cena) (Inicial) do (Jogo)
    public void Voltar()
    {

        //Para (Chamar) a (Cena) (Start)
        UnityEngine.SceneManagement.SceneManager.LoadScene("Start");
    }

    //Método para fechar o app
    public void Fechar()
    {
        //Para fechar o app
        Application.Quit();
    }

    //Para copiar a (Chave) (Pix) de doação do (Jogo)
    public void CopiarChavePix()
    {

        //Para copiar a (Chave) (Pix)
        GUIUtility.systemCopyBuffer = "thiagoruiz.y2@gmail.com";

        //Para que a mensagem (Doação) desapareça depois que o (Botão) (Copiar Chave Pix) for pressionado
        mensagemDoacao.SetActive(false);

        //Para mostrar a (Mensagem) (Chave Pix copiada com sucesso) depois que o (Botão) (Copiar Chave Pix) for pressionado
        mensagemPix.SetActive(true);

        //Para que não apareça a mensagem do (PayPal)
        mensagemPayPal.SetActive(false);
    }

    //Para copiar o (Email) de doação do (PayPal)
    public void CopiarEmail()
    {
        //Para copiar o (Email PayPal)
        GUIUtility.systemCopyBuffer = "thiagoruiz.y2@gmail.com";

        //Para que a mensagem (Doação) desapareça depois que o (Botão) (PayPal Donation) for pressionado
        mensagemDoacao.SetActive(false);

        //Para mostrar a (Mensagem) (O Email Paypal foi copiado com sucesso) depois que o (Botão) (Paypal Donation) for pressionado
        mensagemPayPal.SetActive(true);

        //Para que não apareça a mensagem do (Pix)
        mensagemPix.SetActive(false);
    }
}
