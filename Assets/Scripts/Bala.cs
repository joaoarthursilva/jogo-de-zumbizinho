using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bala : MonoBehaviour
{
    public float Velocidade;
    public GameObject ControlaArma;
    private Rigidbody rigidbodyBala;
    public int contagemMortos;
    private ControlaArma jogador;
    private void Start()
    {
        rigidbodyBala = GetComponent<Rigidbody>();
        jogador = GameObject.Find("Jogador").GetComponent<ControlaArma>();
    }

    void FixedUpdate()
    {
        rigidbodyBala.MovePosition(rigidbodyBala.position +
            transform.forward * Velocidade * Time.fixedDeltaTime);
    }
    void OnTriggerEnter(Collider objetoDeColisao)
    {
        if (objetoDeColisao.tag == "Inimigo")
        {
            Destroy(objetoDeColisao.gameObject);
            jogador.ContaMortos();
        }
        Destroy(gameObject);
    }
}
