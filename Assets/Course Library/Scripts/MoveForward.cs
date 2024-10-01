using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if(gameObject.CompareTag("Food"))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);



        }else{
             transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }

    
}
