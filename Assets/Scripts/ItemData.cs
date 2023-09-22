using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item Data", menuName = "Scriptable Object/Item Data", order = 0)]
public class ItemData : ScriptableObject
{
    [SerializeField]
    private int code { get; set; }

    [SerializeField]
    private string name;

    [SerializeField]
    private string description;

    [SerializeField]
    private int atk;

    [SerializeField]
    private int def;

    [SerializeField]
    public bool equipment { get; set; }

    [SerializeField]
    public string type;

    [SerializeField]
    private Sprite sprite { get; set; }

}
