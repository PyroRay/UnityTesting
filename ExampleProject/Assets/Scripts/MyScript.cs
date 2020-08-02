using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    class Item
    {
        public string name = "Unnamed Item";
        public string description = "Undescribed item.";
        public int worth = 1;
        public bool canBeSold = true;
        public int weight = 0;

        public string Name { get => name; set => name = value; }
        public int Worth { get => worth; set => worth = value; }
        public bool CanBeSold { get => canBeSold; set => canBeSold = value; }
    }
   
    class Equipment : Item
    {
        public int currentDurability = 100;
        public int maxDurability = 100;
    }

    enum ArmorType
    {
        Helmet,
        Chest,
        Gloves,
        Girdle,
        Boots
    }

    class Armor : Equipment
    {
        public ArmorType type = ArmorType.Helmet;
        public int defense = 1;
    }

    enum WeaponType
    {
        Sword,
        Axe,
        Hammer,
        Staff
    }
    class Weapon : Equipment
    {
        public WeaponType type = WeaponType.Sword;
        public int minDamage = 1;
        public int maxDamage = 2;
        public float attackTime = .6f;
        public bool dealsBluntDamage = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        Item item = new Item();
        item.Name = "Goblin Tooth";
        item.Worth = 4;
        item.CanBeSold = true;
        Debug.Log("This " + item.Name + " is worth " + item.Worth + " golden coins!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
