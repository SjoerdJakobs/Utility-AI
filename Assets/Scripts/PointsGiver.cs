using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class PointsGiver : MonoBehaviour {

    private List<float> parameters = new List<float>(); 
	
    public PointType pointType = new PointType();

    private Dictionary<PointTypeID, int> pointsToPointType = new Dictionary<PointTypeID, int>();

    public void AddPointsToType(PointTypeID ptID, )
    {
        pointsToPointType.Add(ptID, );
    }

    public void AddType()
    {

    }

    public void ReturnPoints()
    {

    }

    
}
