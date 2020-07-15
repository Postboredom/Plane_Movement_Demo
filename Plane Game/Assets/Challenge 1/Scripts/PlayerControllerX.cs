using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rollInput;
    public float rotationSpeed;
    public float verticalInput;
    public float horizantalInput;

    // Start is called before the first frame update
    void Start()
    {
        speed = 1.42f;
        rotationSpeed = 24;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's input
        verticalInput = Input.GetAxis("Vertical");
        horizantalInput = Input.GetAxis("Horizontal");
        rollInput = Input.GetAxis("Roll");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed* verticalInput * Time.deltaTime);

        // tilt plane right and left based on Input
        transform.Rotate(Vector3.up * rotationSpeed * horizantalInput * Time.deltaTime);

        // roll plane right and left based on Input
        transform.Rotate(Vector3.forward * rotationSpeed * -rollInput * Time.deltaTime);

    }
}
