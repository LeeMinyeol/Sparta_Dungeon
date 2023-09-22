using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipItem : MonoBehaviour // Confirm ��ư�� ������ ������ Ŭ����
{
    //var newitem = ItemData.code ��� ���� �������� ���� ����
    public Item selectItem;
    public List<ItemData> itemDatas;
    // ���������� Ȯ��
    // �������̸� ��������? �����(�ؽ�Ʈ ����)
    // ������ �ƴϸ� ��������? �����(�ؽ�Ʈ ����)

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
                    //���� �Ұ� �˾�, ���� �˾��� setActive false
                }
            }
            EquipIt();
        }
        Debug.Log(selectItem.itemData.equipment);

    }


    void EquipIt() //�����ϰڴ� (if isEquip != true, else => UnEquip)
    {

        selectItem.itemData.equipment = true;

    }

    void UnEquip()//�����ϰڴ�.
    {


        selectItem.itemData.equipment = false;

    }

    private void ChageStatus() // ĳ���� ���� ����
    {
        //���� ���ȿ��� inventory ����Ʈ�� ��� equipment == ture �ΰ͵鸸ŭ ����
    }
}
