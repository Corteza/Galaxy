using UnityEngine;
using System;

using Random = System.Random;

public static class StarFactory
{
	public static Star Create(CelestialBodyData _data, CelestialBody _parent)
	{
		GameObject obj = GameObject.Instantiate<GameObject>(CelestialBodyReference.Instance.StarReference) as GameObject;
		Star star = obj.GetComponent<Star>();
		star.Initialize(_data, _parent);
		return star;
	}

	public static CelestialBodyData CreateData(ref Random _random)
	{
		CelestialBodyData data = new CelestialBodyData();
		data.Mass = _random.Next(8000, 12000);
		data.OrbitingPosition = 0;
		data.OrbitingRadius = 0;
		data.OrbitingSpeed = 0;
		data.Radius = data.Mass/1000f;
		return data;
	}
}