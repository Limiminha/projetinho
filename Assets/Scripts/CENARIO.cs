using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CENARIO : MonoBehaviour
{
    public float velocidadecen;

    
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        movicenario();
    }


    void movicenario()
    {
        Vector2 deslocamento = new Vector2(0,Time.time*velocidadecen);
        GetComponent<Renderer>().material.mainTextureOffset = deslocamento;
    }
}
