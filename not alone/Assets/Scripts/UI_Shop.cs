using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UI_Shop: MonoBehaviour
{
    private Transform container;
    private Transform shopItemTemplate;

    private void Awake()
    {
        container = transform.Find("container");
        shopItemTemplate = container.Find("shopItemTemplate");
        shopItemTemplate.gameObject.SetActive(true);
    }

    private void Start()
    {
        CreateItemButton(Item.GetSprite(Item.ItemType.Weapon_Upgrade), "Weapon Upgrade", Item.GetCost(Item.ItemType.Weapon_Upgrade), 0);
        CreateItemButton(Item.GetSprite(Item.ItemType.Weapon_Speed), "Weapon Upgrade", Item.GetCost(Item.ItemType.Weapon_Speed), 1);
        CreateItemButton(Item.GetSprite(Item.ItemType.Flashlight_Upgrade), "Weapon Upgrade", Item.GetCost(Item.ItemType.Flashlight_Upgrade), 2);
        CreateItemButton(Item.GetSprite(Item.ItemType.Flashlight_Plus), "Weapon Upgrade", Item.GetCost(Item.ItemType.Flashlight_Plus), 3);
        CreateItemButton(Item.GetSprite(Item.ItemType.Healing_Potion), "Weapon Upgrade", Item.GetCost(Item.ItemType.Healing_Potion), 4);
    }

    private void CreateItemButton(Sprite itemSprite, string itemName, int itemCost, int positionIndex)
    {
        Transform shopItemTransform = Instantiate(shopItemTemplate, container);
        RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();

        float shopItemHeight = 30f;
        shopItemRectTransform.anchoredPosition = new Vector2(0, -shopItemHeight * positionIndex);

        shopItemTransform.Find("itemName").GetComponent<TextMeshProUGUI>().SetText(itemName);
        shopItemTransform.Find("costText").GetComponent<TextMeshProUGUI>().SetText(itemCost.ToString());

        shopItemTransform.Find("itemImage").GetComponent<Image>().sprite = itemSprite;
    }
}
