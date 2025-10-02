using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHPBar : MonoBehaviour
{
    
    public Transform target;

    void Update()
    {
        if (target == null) return;

        Vector3 screenPos = Camera.main.WorldToScreenPoint(target.position + Vector3.up * 2f);
        transform.position = screenPos;
    }

    public void SetHP(float current, float max)
    {
       
    }
}
