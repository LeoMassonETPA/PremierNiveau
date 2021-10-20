using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{

    private Transform playerTransform { get; set; } = null;

    public Transform _eyeTransform = null;

    private Transform eyeTranform { get { return _eyeTransform; } set { _eyeTransform = value; } }

    public bool invertCamera = false;

    private void Start()
    {
        playerTransform = transform;
    }

    private void Update()
    {
        playerTransform.Rotate(Vector3.up, Input.GetAxis("Mouse X"));
        float invertValue = invertCamera == true ? 1 : -1;
        eyeTranform.Rotate(Vector3.right, Input.GetAxis("Mouse Y") * invertValue);
    }
}
