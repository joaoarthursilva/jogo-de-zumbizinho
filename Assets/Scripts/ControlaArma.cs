using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlaArma : MonoBehaviour
{
    public GameObject Bala;
    public GameObject CanoDaArma;
    public int numeroTiros;
    public int contagemMortos;
    public int TaxaDePrecisao;
    public float ratio = 0.00f;
    public Text contagemMortosTexto;
    public Text contagemTirosTexto;
    public Text taxaPrecisaoTexto;
    

    void Start()
    {
        contagemMortosTexto.text = "0";
        numeroTiros = 0;
    }
    public void ContaTiros()
    {
        Instantiate(Bala, CanoDaArma.transform.position, CanoDaArma.transform.rotation);
        numeroTiros += 1;
        string numeroTirosString = numeroTiros.ToString();
        contagemTirosTexto.text = numeroTirosString;
    }
    public void ContaMortos()
    {
        contagemMortos += 1;
        string contagemMortosString = contagemMortos.ToString();
        contagemMortosTexto.text = contagemMortosString;
    }
    public void CalculaRatio()
    {
        Debug.Log("1: " + ratio);
        ratio = contagemMortos / numeroTiros;
        Debug.Log("2: " + ratio);
        string ratioString = ratio.ToString("F2");
        Debug.Log("3: " + ratio);
        taxaPrecisaoTexto.text = ratioString;
        Debug.Log("3: " + ratio);
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ContaTiros();
        }
    }
    
}
