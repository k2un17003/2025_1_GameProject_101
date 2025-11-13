using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Search;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Dictionary<BlockType, int> item = new();

    public void Add(BlockType type, int count = 1)
    {
        if (!Items.ContainsKey(type)) Items[type] = 0;
        item[type] += count;
        Debug.Log($"[Inventory] +{count} {type}  (총 {item[type]})");
    }

    public bool Consume(BlockType type, int count = 1)
    {
        if (!item.TryGetValue(type, out var have) || have < count) return false;
        item[type] = have - count;
        Debug.Log($"[Inventory] -{count} {type}  (총 {item[type]})");
        return true;
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
