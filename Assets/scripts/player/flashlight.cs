using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class flashlight : MonoBehaviour
{
	public GameObject light;
	
	void Start()	{
		light.SetActive(false);		//По умолчанию фонарь выключен
	//	print("light not working");
	}
	void Update()	{
		if (Input.GetKeyDown("l"))	
			light.SetActive(true);	//Включение фонаря по клавише
		if (Input.GetKeyUp("l"))
			light.SetActive(false);	//Выключение фонаря при отпускании клавиши
	}
}
	