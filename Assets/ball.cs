using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Debug.Log("���� �浹");
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ʈ���� �ȿ� ����");
    }

}
