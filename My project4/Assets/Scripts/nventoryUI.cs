using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nventoryUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void UpateInventory(Inventory myInven)
    {
        foreach (var item in myInven.items)
        {
            switch(item.Key)
            {
                case BlockType.Dirt:
                    break;
                    case BlockType.Grass:
                    break;
                case BlockType.Water:
                    break;
            }
        }
    }
}
