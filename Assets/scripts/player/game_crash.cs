using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

//Скрипт выхода в главное меню при нажатии клавиши ESCAPE
public class game_crash : MonoBehaviour
{
	void Update()
	{
		if (Input.GetKey("escape"))
		{
			//print("GAME CRASHED!1111");
			//Application.Quit ();
			SceneManager.LoadScene ("main_menu");
		}
	}
}

