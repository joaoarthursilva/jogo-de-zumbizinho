using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public GameObject Jogador;

    void Start()
    {
        Jogador = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        float distancia = Vector3.Distance(transform.position, Jogador.transform.position);
        float diametro = GetComponent<CapsuleCollider>().radius * 2;


        if (distancia < (diametro + 0.5))
        {
            Jogador.GetComponent<ControlaJogador>().Vivo = false;
        }

    }
}
