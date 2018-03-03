using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlanetLineFactory
{
	public static void CreateLine(float _radius, Transform _parent)
	{
		GameObject obj = GameObject.Instantiate<GameObject>(CelestialBodyReference.Instance.OrbitLineReference) as GameObject;
		obj.transform.SetParent(_parent);
		LineRenderer renderer = obj.GetComponent<LineRenderer>();
		renderer.positionCount = 101;
		for(int i=0; i<101; i++)
		{
			float relativePos = (float)i / 100;
			Vector3 pos = new Vector3(
			_parent.position.x + Mathf.Sin(2 * Mathf.PI * relativePos) * _radius,
			_parent.position.y,
			_parent.position.z + Mathf.Cos(2 * Mathf.PI * relativePos) * _radius);
			renderer.SetPosition(i, pos);
		}
	}
}
