using UnityEngine;

public class CelestialBodyReference : MonoBehaviour
{
	private static CelestialBodyReference m_instance;
	public static CelestialBodyReference Instance { get { return m_instance; } }

	public GameObject PlanetReference;
	public GameObject StarReference;
	public GameObject OrbitLineReference;

	private void Awake()
	{
		m_instance = this;
	}

	private void OnDestroy()
	{
		m_instance = null;
	}
}
