using UnityEngine;
using System.Collections;

public enum PointTypeID
{
    NullStateID = 0,
    Wandering = 1,
    Alerting = 2,
    Fleeing = 3,
    Charge = 4,
    Patrol = 5,
    death = 6
}

public class Unit : MonoBehaviour {

    private PointsGiver pointGiver;

    // Use this for initialization
    void Start () {
        pointGiver = GetComponent<PointsGiver>();
	
	}

    void addingTypes()
    {
        //pointGiver.ad
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
