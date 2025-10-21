using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammo_script : MonoBehaviour {

	public static  int ammo_12x70 = 100;	//Стартовое число патронов в ящике
	public static  int ammo_9x19 = 100;
	public static  int ammo_9x39 = 100;
	public static  int ammo_545x39 = 100;
	public static  int ammo_556x45 = 100;
	public static  int ammo_762x51 = 100;
	public static  int ammo_762x54 = 100;
	public static  int ammo_1143x23 = 100;
	public static  int ammo_og7b = 100;
	public static  int ammo_grenade = 100;
	Text ammo;
	
	// Use this for initialization
	void Start () {
		ammo = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
	ammo.text = " " + ammo_12x70;	//Вывод на интерфейсе количества патронов
	}
}
