using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Random = System.Random;

public static class StarSystemFactory
{
	public static void Create(int _seed)
	{
		Random random = new Random(_seed);
		int planets = random.Next(3, 9);
		CelestialBodyData starData = StarFactory.CreateData(ref random);
		Star star = StarFactory.Create(starData, null);
		float minRadius = random.Next(20,30);
		for(int i=0; i<planets; i++)
		{
			CelestialBodyData planetData = PlanetFactory.CreateData(ref random, minRadius);
			minRadius = planetData.OrbitingRadius + 20;
			Planet planet = PlanetFactory.Create(planetData, star);
			PlanetLineFactory.CreateLine(planet.OrbitingRadius, planet.Parent.transform);
		}
	}
}
