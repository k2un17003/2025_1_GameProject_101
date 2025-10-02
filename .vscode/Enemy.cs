using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using OpenCover.Framework.Model;
using UnityEngine;

public class Enemy : MonoBehaviour
{

 

    public float maveSpeed = 2f;

    public float traceRange = 15;

    public float attackRange = 6f;

    public float attackCooldown = 1.5f;

    public GameObject projectolePrefab;

    public Transform firePoint;

    private Transform player;

    private float lastAttackTime;

    public int maxHP = 5;

    private int currenHP;
    // Start is called before the first frame update
    void Start()
    {
        
        lastAttackTime 
         = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null) return;

        float dist = Vector3.Distance(player.position, transform.position);

      
    }
}
