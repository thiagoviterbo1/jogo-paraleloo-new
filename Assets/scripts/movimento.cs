using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    public float velocdisparo = 12.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * velocdisparo * Time.deltaTime);

     if ( transform.position.y > 6.0f){
            Destroy(this.gameObject);
            }   

    }
}

