using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHp = 5;
    public int currentHp;

    void Start()
    {
        currentHp = maxHp;
        UIController.Instance.UpdateHealth(currentHp, maxHp);
    }

    public void TakeDamage(int dmg)
    {
        currentHp -= dmg;
        if (currentHp < 0) currentHp = 0;
        UIController.Instance.UpdateHealth(currentHp, maxHp);

        if (currentHp <= 0)
        {
            GameManager.Instance.GameOver();
            gameObject.SetActive(false);
        }
    }

    public void Heal(int amount)
    {
        currentHp = Mathf.Min(currentHp + amount, maxHp);
        UIController.Instance.UpdateHealth(currentHp, maxHp);
    }

    // Start is called before the first frame update
   
}
