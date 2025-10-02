using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
   public float maxHP = 100f;
    public float currentHP;

    public GameObject hpBarPrefab;
    private EnemyHPBar hpBar;

    void Start()
    {
        currentHP = maxHP;

        GameObject canvas = GameObject.Find("EnemyHPBarManager");
        GameObject go = Instantiate(hpBarPrefab, canvas.transform);
        hpBar = go.GetComponent<EnemyHPBar>();
        hpBar.target = this.transform;
    }

    public void TakeDamage(float damage)
    {
        currentHP -= damage;
        hpBar.SetHP(currentHP, maxHP);

        if (currentHP <= 0)
        {
            Destroy(hpBar.gameObject);
            Destroy(this.gameObject);
        }
    }
}
