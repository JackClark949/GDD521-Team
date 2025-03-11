using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class playerHealth : MonoBehaviour
{
    [SerializeField]
    float HP = 100f;
    float addHealth = 50f;


    [SerializeField]
    float hpDeductTime = 1f;
    [SerializeField]
    public float nextHPDeductTime;

    private void DeductHP()
    {
        float currentTime = Time.time;
        if (currentTime > nextHPDeductTime)
        {
            nextHPDeductTime = currentTime + hpDeductTime;
        }
    }



    public void TakeDamage(float damage)
    {
        HP -= damage;
        if (HP <= 0)
        {
            Destroy(gameObject);
        }



    }

    public void Healing()
    {
        HP += addHealth;
        if (HP > 100)
        {
            HP = 100;
        }



    }
}

    

