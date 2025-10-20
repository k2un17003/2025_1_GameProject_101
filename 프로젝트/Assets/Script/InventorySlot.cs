using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class InventorySlot : MonoBehaviour
{
    public ItemData item;
    public int amount;

    [Header("UI Elements")]
    public Image itemIcon;
    public Text amountText;
    public GameObject emptySlotImage;

    public Button slotButton;
    // Start is called before the first frame update
    void Start()
    {
        UpdateSlotUI();
        slotButton.onClick.AddListener(OnSlotClick);
      
     
    }
    void OnSlotClick()
    {
        if (item != null)
        {
            ItemUsePopup.instance.ShowPopup(item, this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
