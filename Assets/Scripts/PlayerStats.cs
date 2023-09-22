using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [Header("캐릭터 정보")]
    public TMP_Text atkTxt;
    public TMP_Text defTxt;
    public TMP_Text healthTxt;
    public TMP_Text criRateTxt;

    private PlayerController player;

    private void Awake()
    {
        player = GameManager.instance.player;
    }
    // Start is called before the first frame update
    void Start()
    {
        atkTxt.text = player.atk.ToString();
        defTxt.text = player.def.ToString();
        healthTxt.text = player.health.ToString();
        criRateTxt.text = player.criRate.ToString();
    }

}
