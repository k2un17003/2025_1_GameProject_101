using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum EnemyState { Idle, Patrol, Trace, Attack, RunAway, Die }
public class EnemyFSM : MonoBehaviour
{
    public EnemyState state;
    private Transform player;
   

    public float traceDistance = 10f;
    public float attackDistance = 2f;
    public float runAwayDistance = 15f;

    public float maxHP = 100f;
    public float currentHP;
    // Start is called before the first frame update
    void Start()
    {
        currentHP = maxHP;
        player = GameObject.FindGameObjectWithTag("Player").transform;
     
    }

    // Update is called once per frame
    void Update()
    {

    }
}
