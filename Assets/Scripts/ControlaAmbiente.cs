using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaAmbiente : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Quaternion rotation = Quaternion.Euler(Random.Range(6, 179), Random.Range(0, 361), 0);
        Vector3 location = transform.position;
        transform.SetPositionAndRotation(location, rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
