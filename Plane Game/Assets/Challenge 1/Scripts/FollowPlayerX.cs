using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    public float offset;
    float rotationDamping = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        offset = 15.0f;
    }

    // Update is called once per frame

    void LateUpdate()
    {
        if (!plane)
            return;

        float wantedRotationAngleSide = plane.transform.eulerAngles.y;
        float currentRotationAngleSide = transform.eulerAngles.y;

        float wantedRotationAngleUp = plane.transform.eulerAngles.x;
        float currentRotationAngleUp = transform.eulerAngles.x;

        currentRotationAngleSide = Mathf.LerpAngle(currentRotationAngleSide, wantedRotationAngleSide, rotationDamping * Time.deltaTime);

        currentRotationAngleUp = Mathf.LerpAngle(currentRotationAngleUp, wantedRotationAngleUp, rotationDamping * Time.deltaTime);

        Quaternion currentRotation = Quaternion.Euler(currentRotationAngleUp, currentRotationAngleSide, 0);

        transform.position = plane.transform.position;
        transform.position -= currentRotation * Vector3.forward * offset;

        transform.LookAt(plane.transform);

        transform.position += transform.up;
    }
}
