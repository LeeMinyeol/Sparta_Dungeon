using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour // 아이템에 부착할 스크립트
{
    public ItemData itemData;
    [SerializeField]
    public List<Sprite> sprites;
    private Button btn;

    public void Start()
    {
        btn = GetComponent<Button>();

        btn.onClick.AddListener(DisplayInformation);
    }

    void DisplayInformation()
    {
        GameManager.instance.uiManager.EquipPopup.SetActive(true);
        GameManager.instance.ivManager.selectedItem = transform.GetComponent<Item>();
    }

}
