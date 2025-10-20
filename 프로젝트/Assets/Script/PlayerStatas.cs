using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatas : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void Heal(int amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        Debug.Log("���� ü�� : " + currentHealth);

        // Update is called once per frame
        void Update()
    {
        
    }
}
