using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float verticalInput;
    float magnitude = 25.5f;
   

    private void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {
      
        verticalInput = Input.GetAxis("Vertical");

        // Move the vehicle forward based on vertical input

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);

    }
}
