using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeZumbis : MonoBehaviour
{
    public GameObject Zumbi;
    private float contaTempo = 0;
    public float TempoGerarZumbi = 1;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        contaTempo += Time.deltaTime;
        if (contaTempo >= TempoGerarZumbi)
        {
            Instantiate(Zumbi, transform.position, transform.rotation);
            contaTempo = 0;
        }
    }
}
