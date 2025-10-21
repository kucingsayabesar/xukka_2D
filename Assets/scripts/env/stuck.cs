using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class stuck : MonoBehaviour
{
	public GameObject spawnpoint;
	public GameObject hero;
	void Update()
	{
		if (Input.GetKeyDown("q"))
		{
			print("I'M STUCK!1111");
			hero.transform.position = spawnpoint.transform.position;
		}
	}
}

