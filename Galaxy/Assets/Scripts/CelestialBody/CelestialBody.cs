using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CelestialBody : MonoBehaviour
{
	public const float G = 6.673E-11f;

	abstract public CelestialBodyType Type { get; }
	protected CelestialBodyData m_data;
	
	public CelestialBody Parent;
	public float Mass;
	public float Radius;
	
	public float OrbitingRadius;
	public float OrbitingSpeed;
	public float OrbitingPosition;

	virtual public void Initialize(CelestialBodyData _data, CelestialBody _parent)
	{
		Parent = _parent;
		m_data = _data;
		Mass = _data.Mass;
		Radius = _data.Radius;
		OrbitingRadius = _data.OrbitingRadius;
		OrbitingSpeed = _data.OrbitingSpeed;
		OrbitingPosition = _data.OrbitingPosition;
		UpdateOrbit();
		gameObject.tag = Type.ToString();
		transform.localScale = new Vector3(Radius, Radius, Radius);
	}

	virtual protected void Update()
	{
		UpdateOrbit();
	}

	private float CalculateSpeed(float _radius)
	{
		return Mathf.Sqrt((G* Parent.Mass) /_radius);
	}

	private void UpdateOrbit()
	{
		if (Parent)
		{
			CalculateOrbitingPosition();
			CalculatePosition();
		}
	}

	private void CalculateOrbitingPosition()
	{
		OrbitingSpeed = CalculateSpeed(OrbitingRadius);
		OrbitingPosition += OrbitingSpeed * Time.deltaTime * 100;
		if(OrbitingPosition >= 1)
		{
			OrbitingPosition -= 1;
		}
	}

	private void CalculatePosition()
	{
		transform.position = new Vector3(
			Parent.transform.position.x + Mathf.Sin(2 * Mathf.PI * OrbitingPosition) * OrbitingRadius, 
			Parent.transform.position.y,
			Parent.transform.position.z + Mathf.Cos(2 * Mathf.PI * OrbitingPosition) * OrbitingRadius);
	}
}
