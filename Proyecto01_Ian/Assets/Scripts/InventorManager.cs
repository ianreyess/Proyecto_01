using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorManager : MonoBehaviour
{
   public static InventorManager Instance;
   public List<Item> Items = new List<Item>();
   public Transform ItemContent;
   public GameObject InventoryItem;

   private void Awake()
   {
       Instance = this;
   }

   public void Add(Item item)
   {
       Items.Add(item);
   }

   public void Remove(Item item)
   {
       Items.Remove(item);
   }

   public void ListItems()
   {
       foreach (var item in Items)
       {
           GameObject obj = Instantiate(InventoryItem, ItemContent);
           var itemName = obj.transform.Find("itemName").GetComponent<Text>();
           var itemIcon = obj.transform.Find("itemIcon").GetComponent<Image>();

           
           itemName.text = item.ItemName;
           itemIcon.sprite = item.icon;
       }
   }
}