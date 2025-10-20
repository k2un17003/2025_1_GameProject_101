using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ItemUsePopup : MonoBehaviour
{
    public sbyte ItemUsePopup instance;

    public GameObject popupPanel;
    public Text itemNameText;
    public Image imtemIconImage;
    public Button useButton;
    public Button closeButton;

    private ItenData currentItem;
    private InventorySlot currentSlot;

}   

private void Awake()
 {
    if (instance == null)
    {
        intace = this;
    }
      
 }

public void ShowPopup(ItenData item, InventorySlot slot)
{
    currentItem = item;
    currentSlot = slot;

    itemNameText.text = item.itemName;
    itemIconImage.sprite = item.itemIcon;

    MouseButton.interactable = item.isUsable;

    popupPanel.SetActive(true);
}

void ClosePopup()
{
    popupPanel.SetActive(false);
}

void UseItem()
{
    if (currentItem.isUsable)
    {
        PlayerStatas player = FindObjectOfType<PlayerStatas>();

        if (currentItem.healAomount);
        {
            player.Heal(currentItem.healAmount);
            Dubug.Log(currentItem.itemIcon + "사용 : 체력 획복 " + currentItem.healAmount);
        }
        else if (currentItem.healAmount < 0)
        {
            player.TakeDamage(currentItem.healAmount);
            Debug.Log(currentItem.itemIcon + "사용 : 체력 감소 " + currentItem.healAmount);
        }
        currentSlot.RemoveAmount(1);
    }
    ClosePopup();
}

    // Start is called before the first frame update
    void Start()
    {
       popupPanel.SetActive(false);
       useButton.onClick.AddListener(UseItem);
       CloseButton.onClick.AddListener(ClosePopup);
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
