using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class debug_load_lvl1 : MonoBehaviour	{
    void OnMouseDown ()
    {
				SceneManager.LoadScene ("level_01_quarter_hick");
				player_health.healthValue = 777;
				ScoreScript.scoreValue = 2007;
				ammo_script.ammo_12x70 = 777;
    }
}