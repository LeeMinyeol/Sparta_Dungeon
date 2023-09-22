using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("UI")]
    public TMP_Text titleTxt;
    public TMP_Text nameTxt;
    public TMP_Text levelTxt;
    public TMP_Text descriptionTxt;
    public TMP_Text goldTxt;
    public TMP_Text goldTxtShadow;
    public GameObject stausBtn;
    public GameObject inventoryBtn;
    public GameObject shopBtn;
    public Slider expSlider;


    [Header("UI Status")]
    public TMP_Text atkTxt;
    public TMP_Text defTxt;
    public TMP_Text healthTxt;
    public TMP_Text criRateTxt;

    [Header("UI Inventory")]
    public GameObject EquipPopup;


    private PlayerController player;

    private void Awake()
    {
        expSlider = GetComponent<Slider>();
        player = GameManager.instance.player;
    }
    // Start is called before the first frame update
    void Start()
    {
        //titleTxt.text = GameManager.instance.player.title;
        nameTxt.text = player.name;
        levelTxt.text = player.level.ToString();
        //descriptionTxt = GameManager.instance.player.description;
        goldTxt.text = player.gold.ToString();
        goldTxtShadow.text = player.gold.ToString();

        SetUIStatus();
        
    }

    public void SetUIStatus()
    {
        atkTxt.text = player.atk.ToString();
        defTxt.text = player.def.ToString();
        healthTxt.text = player.health.ToString();
        criRateTxt.text = player.criRate.ToString();
    }

}
