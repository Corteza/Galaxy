using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : CelestialBody
{
	override public CelestialBodyType Type { get { return CelestialBodyType.Star; } }
}
