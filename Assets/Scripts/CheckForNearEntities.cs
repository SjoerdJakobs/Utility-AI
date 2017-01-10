using UnityEngine;
using System.Collections;

public class CheckForNearEntities : MonoBehaviour {

    private float scaredMod;
    private int otherUnits;

    // Use this for initialization
    void Start () {
        StartCoroutine(slowUpdate());
	
	}
    IEnumerator slowUpdate()
    {
        while (true)
        {


            yield return new WaitForSeconds(0.5f);
        }
    }

    public void SetScarePoints(GameObject T, float sightRadius, Stats stats)
    {
        Stats ownStats = stats;
        Points ownPoints = T.GetComponent<Unit>().publicPoints;
        otherUnits = 0;
        foreach (RaycastHit r in T.transform.getWithinSphere(sightRadius))
        {
            IAmLiving livingUnit = r.collider.GetComponent<IAmLiving>();//check for component idamagable on the hit object
            if (livingUnit != null && livingUnit != T.GetComponent<IAmLiving>())//"if object has IAmLiving"
            {
                otherUnits++;
                scaredMod = 0;
                Stats othersStats = r.collider.GetComponent<Unit>().publicStats;

                scaredMod += Mathf.Clamp(25 / Extensions.distanceInPow(T.transform,r.transform.position),0,25);
                scaredMod += (ownStats.health - othersStats.health)* -2;
                scaredMod += (ownStats.sizeMod - othersStats.sizeMod)* -10;
                scaredMod += (ownStats.strenght - othersStats.strenght)* -10;
                scaredMod += (ownStats.stamina - ownStats.maxStamina) * 0.2f;
                scaredMod += ownStats.hunger;
            }
        }
        if(otherUnits == 0 && scaredMod > 0)
        {
            scaredMod--;
        }
        ownPoints.scaredPoints = scaredMod;
    }

    // Update is called once per frame
    void Update () {
	
	}
}
