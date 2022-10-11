using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaInimigo : MonoBehaviour
{
    public GameObject Jogador;
    public float Velocidade = 5;
    private Rigidbody rigidbodyInimigo;
    private Animator animatorInimigo;
    private ControlaJogador controlaJogador;

    
    void Start()
    {
        Jogador = GameObject.FindWithTag("Player");
        int geraTipoZumbi = Random.Range(1, 28);
        transform.GetChild(geraTipoZumbi).gameObject.SetActive(true);
        rigidbodyInimigo = GetComponent<Rigidbody>();
        animatorInimigo = GetComponent<Animator>();
        controlaJogador = Jogador.GetComponent<ControlaJogador>();
    }

    void FixedUpdate()
    {
        Vector3 direcao = Jogador.transform.position - transform.position;


        float distancia = Vector3.Distance(transform.position, Jogador.transform.position);
        float diametro = GetComponent<CapsuleCollider>().radius * 2;

        Quaternion novaRotacao = Quaternion.LookRotation(direcao);
        rigidbodyInimigo.MoveRotation(novaRotacao);

        if (distancia > (diametro + 0.5))
        {
            rigidbodyInimigo.MovePosition(
                rigidbodyInimigo.position +
                direcao.normalized * Velocidade * Time.fixedDeltaTime);
            animatorInimigo.SetBool("Atacando", false);
        }
        else
        {
            animatorInimigo.SetBool("Atacando", true);
        }
    }
    void AtacaJogador()
    {
        Time.timeScale = 0;
        controlaJogador.TextoGameOver.SetActive(true);
        controlaJogador.TextoReiniciar.SetActive(true);
        controlaJogador.TextoTiros.SetActive(true);
        controlaJogador.TextoNumeroTiros.SetActive(true);
        controlaJogador.TextoTaxa.SetActive(true);
        controlaJogador.TextoTaxaNumero.SetActive(true);
        Jogador.GetComponent<ControlaArma>().CalculaRatio();
        controlaJogador.Vivo = false;
    }
}
