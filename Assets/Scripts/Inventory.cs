using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ItemCode { Helm, Shield1, Shield2, Sword1, Sword2 }
public class Inventory : MonoBehaviour
{
    public int InventoryCode;


    [SerializeField]
    private List<ItemData> itemDatas;

    [SerializeField]
    private GameObject itemPrefab;


    void Start()
    {

        itemDatas = GameManager.instance.ivManager.itemDatas;
        if (InventoryCode >= 0)
        {
            DisplayItem((ItemCode)InventoryCode);

        }




    }
    public Item DisplayItem(ItemCode code)
    {
        var newItem = Instantiate(itemPrefab).GetComponent<Item>();

        newItem.itemData = itemDatas[(int)code];
        newItem.name = newItem.itemData.name;
        newItem.GetComponent<Image>().sprite = newItem.sprites[(int)code];
        if ((int)code == 2 || (int)code == 4)//새로운 이미지 대신 컬러값으로 표현
        {
            newItem.GetComponent<Image>().color = new Color(255/255f, 140/255f, 140/255f); 

        }
        newItem.transform.parent = transform;
        newItem.transform.position = transform.position;
        return newItem;
    }

}
