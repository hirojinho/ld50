using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleHentai : MonoBehaviour
{
    public float velocidade;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
            gameObject.transform.position += velocidade*new Vector3(1,0,0);
        if(Input.GetKey(KeyCode.A))
            gameObject.transform.position += velocidade*new Vector3(-1,0,0);
        if(Input.GetKey(KeyCode.W))
            gameObject.transform.position += velocidade*new Vector3(0,1,0);
        if(Input.GetKey(KeyCode.S))
            gameObject.transform.position += velocidade*new Vector3(0,-1,0);
    }
}
