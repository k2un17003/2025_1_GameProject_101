using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public int damage = 2;

    public float speed = 8;

    public float lifeTime = 3f;

    private Vector3 moveDri;

    public void SetDirection(Vector3 dir)
    {
        moveDri = dir.normalized;
    }
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += moveDri * speed * Time.deltaTime;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController pc = other.GetComponent<PlayerController>();
            if (pc != null) 

            Destroy(gameObject);
        }
    }
}
