using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float Health, MaxHealth;

    [SerializeField] private HealthBarUI HealthBar;

    void Start()
    {
        HealthBar.SetMaxHealth(MaxHealth);
    }

    void Update()
    {
       if(Input.GetKeyDown("j"))
       {
            SetHealth(-20f);
       }

       if(Input.GetKeyDown("h"))
       {
            SetHealth(20f);
       }
    }

    public void SetHealth(float healthChange)
    {
        Health += healthChange;
        Health = Mathf.Clamp(Health, 0, MaxHealth);
        HealthBar.SetHealth(Health);
    }
}
