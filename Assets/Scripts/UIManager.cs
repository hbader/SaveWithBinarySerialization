using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text healthText;
    public Text levelText;

    public PlayerScript player;
    private void Update()
    {
        healthText.text = ""+player.health;
        levelText.text = "" +player.level;
    }
}
