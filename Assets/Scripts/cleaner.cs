using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cleaner : MonoBehaviour
{
    Rigidbody2D rg;

    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    } 
    
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);      
    }
    
}