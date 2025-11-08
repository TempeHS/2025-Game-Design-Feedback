using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;     // for Slider (health bar)

public class PlayerController : MonoBehaviour
{
    [Header("Health Settings")]
    [SerializeField] private int maxHealth = 100;
    private int currentHealth;

    [Header("UI")]
    [SerializeField] private Slider healthSlider;

    [Header("Death")]
    [SerializeField] private GameObject deathEffect;
    private bool isDead = false;

    void Start()
    {
        currentHealth = maxHealth;
        if (healthSlider != null)
            healthSlider.maxValue = maxHealth;
        UpdateHealthUI();
    }

    // Call this from any collision or trigger event
    public void TakeDamage(int amount)
    {
        if (isDead) return;
        currentHealth = Mathf.Max(currentHealth - amount, 0);
        UpdateHealthUI();

        if (currentHealth == 0)
            Die();
    }

    private void UpdateHealthUI()
    {
        if (healthSlider != null)
            healthSlider.value = currentHealth;
    }

    private void Die()
    {
        isDead = true;
        // optional: spawn a death effect (particles, sound, etc.)
        if (deathEffect != null)
            Instantiate(deathEffect, transform.position, Quaternion.identity);

        // disable movement, play animation, or destroy
        // GetComponent<PlayerMovement>().enabled = false;
        Destroy(gameObject);
    }

    // Example: damage on trigger with "Enemy" tag
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Enemy"))
        {
            // You could pull damage from the enemy component instead of hard-coding
            TakeDamage(25);
        }
    }
}


