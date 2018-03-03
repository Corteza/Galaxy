using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSystem : MonoBehaviour
{
	public int Seed;

	private void Start()
	{
		StarSystemFactory.Create(Seed);
	}
}
