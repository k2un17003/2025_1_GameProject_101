using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;


   
               
public class Monster: MonoBehaviour

   
{
    public int Health = 100;
    public float TIMER = 1.0f;
    public int AtackPoint = 10;
    private readonly object Public;



    // Start is called before the first frame update
    void Start()
    {
        Health += 100;

    }

    // Update is called once per frame
    object Update()
    {
        TIMER -= Time.deltaTime;

        if (TIMER <= 0)

        {
            TIMER = 1.0f;
            Health += 20;
        }

        Public void CharacterHit(int Damage)
   
        {
            Health -= Damage;

        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            CharacterHit(AtackPoint);

        }

        CheckDeath();
      


       
           

    }

    void CharacterHit(int Damage)
    {
        Health -= Damage;

    }
    void CheckDeath()
    {
        if (Health <= 0)
            Destroy(gameObject);

    }  }

    
      