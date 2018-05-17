using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;
using System;

public class ItemDatabase : MonoBehaviour {
    private List<Item> database = new List<Item>(); // Json database
    private JsonData itemData;

    void Start()
    {
        itemData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/StreamingAssets/Items.Json")); // change from json object to be readible by c#
        ConstructItemDatabase();

        Debug.Log(FetchItemByID(0).Title);
    }

    public Item FetchItemByID(int id)
    {
        for (int i = 0; i < database.Count; i++)
            if (database[i].ID == id)
                return database[i];

        return null;
    }


    void ConstructItemDatabase()
    {
        for (int i = 0; i < itemData.Count; i++)
        {
            database.Add(new Item(
                (int)itemData[i]["id"],
                itemData[i]["title"].ToString(),
                (int)itemData[i]["value"],
                (int)itemData[i]["power"],
                (int)itemData[i]["defense"],
                (int)itemData[i]["vitality"],
                (bool)itemData[i]["stackable"],
                itemData[i]["slug"].ToString()

                ));
                
        }
    }




    public class Item
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Value { get; set; }
        public int Power { get; set; }
        public int Vitality { get; set; }
        public int Defense { get; set; }
        public string Slug { get; set; }
        public bool Stackable { get; set; }
        public Sprite Sprite { get; set; }

        public Item(int id, string title, int value, int power, int defense, int vitality, bool stackable, string slug)
        {
            this.ID = id;
            this.Title = title;
            this.Value = value;
            this.Power = power;
            this.Defense = defense;
            this.Vitality = vitality;
            this.Stackable = stackable;
            this.Slug = slug;
            this.Sprite = Resources.Load<Sprite>("Items/" + slug);
        }

        public Item()
        {
            this.ID = -1;
        }
    }


}

