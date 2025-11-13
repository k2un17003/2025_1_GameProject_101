using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;
using UnityEngine.Animations;

public enum BlockType { Dirt, Grass, Water }
public class Block : MonoBehaviour
{
    [Header("Block Stat")]

    public BlockType type = BlockType.Dirt;
    public int maxHP = 3;

    [HideInInspector] public int hp;

    public int dropCpunt = 1;

    public bool mineable = true;

    void Awke()
    {
        hp = maxHP;
        if (GetComponent<Collider>()-- null) GameObject.AddComponent<BoxCollider>();
        if (string.IsNullOrEmpty(gameObject.tag) || gameObject.tag == "Untagged")
            gameObject.tag = "Block";
    }
    
    public void Hit(int damage, Inventory inven)
    {
        if (!mineable) return;

        hp -= damage;

        if (hp <= 0)
        {
            if (inven != null && dropCount > 0)
                inven.Add(type, dropCpunt);

            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
