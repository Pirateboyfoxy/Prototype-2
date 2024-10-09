using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    public GameObject projectilePrefab;
    float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * 25 * Time.deltaTime * horizontalInput);

        if(transform.position.x < -20)
        {
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }

         if(transform.position.x > 20)
        {
            transform.position = new Vector3(10, transform.position.y, transform.position.z);
        }
    

    //check if the player is pressing space
    if(Input.GetKeyDown(KeyCode.Space))
    {
        // launch a projectile from the player
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
    }
    }
}
