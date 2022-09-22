using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      float avanza = Input.GetAxis("Vertical");
      float girar = Input.GetAxis("Horizontal");
     //transform.Translate(0,0,1);  
     transform.Translate(Vector3.forward * Time.deltaTime*20*velocidad*avanza);
     transform.Rotate(Vector3.up, Time.deltaTime*30*girar);
    }
}
