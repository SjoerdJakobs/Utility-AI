using UnityEngine;
using System.Collections;

public class Unit : LivingEntity
{
    public Points publicPoints
    {
        get { return entityPoints; }
        set { entityPoints = value; }
    }

    public Stats publicStats
    {
        get { return entityStats; }
        set { entityStats = value; }
    }

    public Behaviour publicBehaviour
    {
        get { return entityBehaviour; }
        set { entityBehaviour = value; }
    }

    private CheckForNearEntities checkEntities;
    // Use this for initialization
    override protected void Start ()
    {
        base.Start();
        checkEntities = GetComponent<CheckForNearEntities>();
        StartCoroutine(slowUpdate());

    }
    IEnumerator slowUpdate()
    {
        while (true)
        {
            checkEntities.SetScarePoints(gameObject, 10, entityStats);

            yield return new WaitForSeconds(0.5f);
        }
    }
    //set points give to script choser and go on

    // Update is called once per frame
    override protected void Update ()
    {
        base.Update();

	}
}
