using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 3, -6);
    public float followSpeed = 10f;
    public float rotationSpeed = 100f;

    float yaw;
    float pitch;

    void LateUpdate()
    {
        if (!target) return;

        // 마우스 회전
        yaw += Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        pitch -= Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
        pitch = Mathf.Clamp(pitch, -35, 60);

        Quaternion rotation = Quaternion.Euler(pitch, yaw, 0);
        Vector3 desiredPosition = target.position + rotation * offset;

        transform.position = Vector3.Lerp(transform.position, desiredPosition, followSpeed * Time.deltaTime);
        transform.LookAt(target.position + Vector3.up * 1.5f);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
