using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] float baseHealth = 3;
    float health;
    Text healthText;

    void Start()
    {
        health = baseHealth - PlayerPrefsController.GetDifficulty();
        healthText = GetComponent<Text>();
        UpdateHealth();
        Debug.Log("difficulty setting currently is " + PlayerPrefsController.GetDifficulty());
    }
    private void UpdateHealth()
    {
        healthText.text = health.ToString();
    }
    public void DecreaseHealth()
    {
        health -= 1;
        UpdateHealth();
        if (health <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoose();
        }
    }
}
