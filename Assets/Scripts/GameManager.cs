using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public PlayerController player;
    public UIManager uiManager;
    public InventoryManager ivManager;
    private void Awake()
    {
        instance = this;
    }
}
