using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipItem : MonoBehaviour // Confirm 버튼이 눌리면 들어오는 클래스
{
    //var newitem = ItemData.code 방금 누른 아이템을 가진 변수
    public Item selectItem;
    public List<ItemData> itemDatas;
    // 장착중인지 확인
    // 장착중이면 장착할지? 물어보기(텍스트 변경)
    // 장착중 아니면 해제할지? 물어보기(텍스트 변경)

    private void Start()
    {
        selectItem = GameManager.instance.ivManager.selectedItem;
        itemDatas = GameManager.instance.ivManager.itemDatas;

        Debug.Log(selectItem.itemData.equipment);
        if(selectItem.itemData.equipment == true)
        {
            UnEquip();
        } else
        {
            foreach(ItemData dd in itemDatas)
            {
                if(dd.type == selectItem.itemData.type)
                {
                    //장착 불가 팝업, 장착 팝업은 setActive false
                }
            }
            EquipIt();
        }
        Debug.Log(selectItem.itemData.equipment);

    }


    void EquipIt() //장착하겠다 (if isEquip != true, else => UnEquip)
    {

        selectItem.itemData.equipment = true;

    }

    void UnEquip()//해제하겠다.
    {


        selectItem.itemData.equipment = false;

    }

    private void ChageStatus() // 캐릭터 스탯 변경
    {
        //원래 스탯에서 inventory 리스트의 모든 equipment == ture 인것들만큼 더함
    }
}
