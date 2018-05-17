using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour {
    GameObject inventoryPanel;
    GameObject slotPanel;
    ItemDatabase database;
    public GameObject inventorySlot;
    public GameObject inventoryItem;

    int slotAmount;
    public List<ItemDatabase.Item> items = new List<ItemDatabase.Item>();
    public List<GameObject> slots = new List<GameObject>();

    private void Start()
    {
        database = GetComponent<ItemDatabase>();
        slotAmount = 16;
        inventoryPanel = GameObject.Find("Inventroy Panel");
#pragma warning disable CS0618 // Type or member is obsolete
        slotPanel = inventoryPanel.transform.FindChild("Slot Panel").gameObject;
#pragma warning restore CS0618 // Type or member is obsolete

        for (int i = 0; i < slotAmount; i++)
        {
            items.Add(new ItemDatabase.Item());
            slots.Add(Instantiate(inventorySlot));
            slots[i].GetComponent<ItemSlot>().id = i;
            slots[i].transform.SetParent(slotPanel.transform);

        }
        AddItem(1);
        AddItem(1);
        AddItem(1);
        AddItem(1);
        AddItem(1);
        AddItem(1);
        AddItem(1);
        AddItem(1);
        AddItem(1);
        AddItem(1);
        AddItem(0);
        AddItem(0);

    }

    public void AddItem(int id) // add item to slot
    {
        ItemDatabase.Item ItemToAdd = database.FetchItemByID(id); // fetch the item

        if (ItemToAdd.Stackable && CheckIfItemInInv(ItemToAdd))
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ID == id)
                {
                    ItemData data = slots[i].transform.GetChild(0).GetComponent<ItemData>();
                    data.amount++;
                    data.transform.GetChild(0).GetComponent<TMP_Text>().text = data.amount.ToString();
                    break;
                }
            }

        }

        else { 
            for (int i = 0; i < items.Count; i++) // check the slots
            {
                if (items[i].ID == -1)
                {
                    items[i] = ItemToAdd;
                    GameObject itemObj = Instantiate(inventoryItem); // create item game object
                    itemObj.GetComponent<ItemData>().item = ItemToAdd;
                    itemObj.GetComponent<ItemData>().slot = i;
                    itemObj.transform.SetParent(slots[i].transform); // set item object to the same as slot
                    itemObj.transform.position = Vector2.zero; // set item position
                    itemObj.GetComponent<Image>().sprite = ItemToAdd.Sprite; // set item sprite
                    itemObj.name = ItemToAdd.Title;

                    break;
                }
            }
        }
        }
    

    bool CheckIfItemInInv(ItemDatabase.Item item) // checks if the item is stackable
    {
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].ID == item.ID)
                return true;
        }
        return false;
    }

}
