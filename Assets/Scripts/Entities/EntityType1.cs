using UnityEngine;
using System.Collections;

public class EntityType1 : LivingEntity {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
#region ENTITYBEHAVIOUR

[System.Serializable]
public class EntityBehaviour
{
    public float aggresion = 1;
    public float carOmniHerbi = 0;
    public float brave = 1;
    public float lazyness = 1; 
}

#endregion
