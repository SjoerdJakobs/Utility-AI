using UnityEngine;
using System.Collections;

public class LivingEntity : MonoBehaviour , IAmLiving
{
    [SerializeField]
    protected Stats entityStats = new Stats();

    [SerializeField]
    protected Points entityPoints = new Points();

    [SerializeField]
    protected Behaviour entityBehaviour = new Behaviour();


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

    public void ReturnStats(Stats stats)
    {
        stats = entityStats;
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

[System.Serializable]
public class Points
{
    public float scaredPoints = 0;
    public float hungerPoints = 0;
    public float staminaPoints =0;

}

[System.Serializable]
public class Behaviour
{
    public float aggresion = 1;
    public float carOmniHerbi = 0;
    public float brave = 1;
    public float lazyness = 1;
}

#endregion
