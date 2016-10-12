using UnityEngine;
using System.Collections;

public class LivingEntity : MonoBehaviour , IAmLiving
{
    [SerializeField]
    protected Stats entityStats = new Stats();

    protected bool dead;

    public event System.Action OnDeath;


    // Use this for initialization
    protected virtual void Start () {
	
	}

    #region UPDATE
    protected virtual void Update()
    {

    }
    #endregion

    #region INTERFACE
    public void TakeDamage()
    {

    }
    #endregion
}

#region ENTITYSTATS

[System.Serializable]
public class Stats
{
    public float strenght = 1;
    public float maxHealth = 10;
    public float health;
    public float healthRegen = 0.1f;
    public float maxStamina = 1;
    public float stamina;
    public float staminaRegen = 0.1f;
    public float moveMentspeed = 1;
    public float sizeMod = 1;
    public float hunger = 10;
}

#endregion
