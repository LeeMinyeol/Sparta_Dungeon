using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Character Status")]
    public string name;
    public int level;
    public int gold;
    public int atk;
    public int def;
    public int health;
    public int criRate;

    public CharacterStats playerStatus;

    private void Awake()
    {
        playerStatus = new CharacterStats("Knight", 6, 88888, 30, 20, 100, 25);

    }
    private void Start()
    {
        //SetPlayerStatus();
        //playerStatus = new CharacterStats(name, level, gold, atk, def, health, criRate);
        SetPlayerStatus();
    }

    public void SetPlayerStatus()
    {
        name = playerStatus.name;
        level = playerStatus.level;
        gold = playerStatus.gold;
        atk = playerStatus.atk;
        def = playerStatus.def;
        health = playerStatus.health;
        criRate = playerStatus.criRate;
    }
}
