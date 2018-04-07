using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public static int maxHealth = 30;
	public int currentHealth;

	public Text healthText;
	public Text timeSurvivedText;
	public float timeSurvived;

	public GameObject gameOverScreen;

	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
		healthText.text = "Health " + currentHealth + "/" + maxHealth;
		timeSurvived = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timeSurvived += Time.deltaTime;
		timeSurvivedText.text = "Time: " + timeSurvived.ToString();
	}

	public void enemyComplete(int damageVal){
		currentHealth -= damageVal;
		
		string tempstr = "Health " + currentHealth + "/" + maxHealth;
		healthText.text = tempstr;

		if(currentHealth > 0){
			
		}
		else{
			gameOverScreen.SetActive(true);
			Time.timeScale = 0f;
		}
	}
}
