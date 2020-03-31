using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerScript : MonoBehaviour
{
    public int health =30;
    public int level=3;

    public void SavePlayer()
    {
        SaveSystem.Player(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        level = data.level;
        health = data.health;
    }

    public void ChangeHealth(int amount)
    {
        health += amount;
    }

    public void ChangeLevel(int amount)
    {
        level += amount;
    }
}
