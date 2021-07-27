using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour 
{
    private Image healthBar;
    [SerializeField]
    float currentHealth;
    float maxHealth = 100f;

    PlayerStats Player;

    private void Start()
    {
        healthBar = GetComponent<Image>();
        Player = FindObjectOfType<PlayerStats>();
    }

    private void FixedUpdate()
    {
        currentHealth = Player.health;
        healthBar.fillAmount = currentHealth / maxHealth;     
    }
}
