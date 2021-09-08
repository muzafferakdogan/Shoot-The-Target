using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField]private float speedHorizontal = 1f;
    [SerializeField]private float speedVertical = 1f;

    private float horizontalRotate = 0f;
    private float verticalRotate = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        horizontalRotate += speedHorizontal * Input.GetAxis("Mouse X");
        verticalRotate += speedVertical * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(verticalRotate*(-1), horizontalRotate, 0f);
    }
}
