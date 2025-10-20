using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class ItenData : MonoBehaviour
{
    public string itemName;
    public Sprite itemIcon;
    public int maxStack = 99;

    public bool isStackable = false;
    public int healAmount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
