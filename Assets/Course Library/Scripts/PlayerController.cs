using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    public GameObject projectilePrefab;
    float horizontalInput;
    float verticalInput;
    public float xRange = 25;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Makes the character move left and right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * 25 * Time.deltaTime * horizontalInput);

        // Makes the bounds the player can move in
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

         if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Makes the character move left and right
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * 25 * Time.deltaTime * verticalInput);

        // Makes the bounds the player can move in
        if(transform.position.z > 28)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 28);
        }

         if(transform.position.z < -10)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -10);
        }
    

        //check if the player is pressing space
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
