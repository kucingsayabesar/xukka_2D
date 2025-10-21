using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//Скрипт количества жизней персонажа
public class player_health : MonoBehaviour {
	
	public static  int healthValue = 1;		//Начальное значение
	Text health;
	
	// Use this for initialization
	void Start () {
		health = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
	health.text = "x " + healthValue;
	if (healthValue <= 0){
	//SceneManager.LoadScene ("main_menu");
	//		Time.timeScale = 0;
	Invoke("game_over", 0.5f);
	}
}
		void game_over () {
		//		Time.timeScale = 1;
		SceneManager.LoadScene ("char_choice");
	}
}