using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 3f;
    [SerializeField] GameObject deathVFX;
    [SerializeField] GameObject bloodVFX;
    [SerializeField] GameObject positionOfVFX;

    public void DealDamage(float damage)
    {
        GameObject destroyVFX = Instantiate(bloodVFX, positionOfVFX.transform.position, transform.rotation);
        Destroy(destroyVFX, 1f);
        health -= damage;
        if (health <= 0)
        {
            TriggerVFX();
            Destroy(gameObject);
        }
    }
    private void TriggerVFX()
    {
        if (!deathVFX)
        {
            return;
        }
        GameObject destroyVFX1 = Instantiate(deathVFX, positionOfVFX.transform.position, Quaternion.identity);
        Destroy(destroyVFX1, 1f);
    }
}
