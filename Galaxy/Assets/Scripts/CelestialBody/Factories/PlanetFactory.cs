using UnityEngine;
using System;

using Random = System.Random;

public static class PlanetFactory
{
	public static Planet Create(CelestialBodyData _data, CelestialBody _parent)
	{
		GameObject obj = GameObject.Instantiate<GameObject>(CelestialBodyReference.Instance.PlanetReference) as GameObject;
		Planet planet = obj.GetComponent<Planet>();
		planet.Initialize(_data, _parent);
		return planet;
	}
	
	public static CelestialBodyData CreateData(ref Random _random, float _minRadius)
	{
		CelestialBodyData data = new CelestialBodyData();
		data.Mass = _random.Next(400, 600);
		data.OrbitingPosition = (float)_random.NextDouble();
		data.OrbitingRadius = (float)(_random.NextDouble() * 30) + _minRadius;
		data.OrbitingSpeed = 0;
		data.Radius = data.Mass / 100f;
		return data;
	}
}
