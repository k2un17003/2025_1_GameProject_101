using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 5f;

    public float jumpPower = 5f;

    public float gravity = -9.81f;

   
    public float rotactionSpeed = 10f;

    

    private CharacterController controller;

    private Vector3 velocity;

    private bool isGrounded;

    public int maxHP = 100;

    private int currentHP;
    // Start is called before the first frame update
    void Start()
    {
      
       

        currentHP = maxHP;
        

    }

    // Update is called once per frame
    void Update()
    {

    }
}

