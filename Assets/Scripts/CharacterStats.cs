using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public string name { get; set; }
    public int level { get; set; }
    public int gold { get; set; }

    public int atk { get; set; }
    public int def { get; set; }
    public int health { get; set; }
    public int criRate { get; set; }
    public CharacterStats(string _name, int _level, int _gold, int _atk, int _def, int _health, int _criRate)
    {
        name = _name;
        level = _level;
        gold = _gold;
        atk = _atk;
        def = _def;
        health = _health;
        criRate = _criRate;

    }
    //�Է¹��� ���� (inputfield) ������ ���� enumType�� ���� ���� �ٸ���?
}
