using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : CelestialBody
{
	override public CelestialBodyType Type { get { return CelestialBodyType.Planet; } }

	public override void Initialize(CelestialBodyData _data, CelestialBody _parent)
	{
		base.Initialize(_data, _parent);
		Invoke("SetTrailRendererEnable", 0.5f);
		GetComponent<TrailRenderer>().enabled = false;
	}

	private void SetTrailRendererEnable()
	{
		GetComponent<TrailRenderer>().Clear();
		GetComponent<TrailRenderer>().enabled = true;
	}
}
