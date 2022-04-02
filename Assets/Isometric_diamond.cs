using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Isometric_diamond : MonoBehaviour
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
    }
}
