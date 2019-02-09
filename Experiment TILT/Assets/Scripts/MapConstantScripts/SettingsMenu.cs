using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour {

	public GameObject opScreen;
	private touchTilt touchTilt;
	private PhoneTilt phoneTilt;
	
	void Start(){
		touchTilt = GetComponent<touchTilt>();
		phoneTilt = GetComponent<PhoneTilt>();
		opScreen.SetActive(false);
	}

	public void openMenu(){
		opScreen.SetActive(true);
		Time.timeScale = 0;
	}
	public void closeSettingsMenu(){
		opScreen.SetActive(false);
		Time.timeScale = 1;
	}
	public void TouchTiltOn(){
		touchTilt.enabled = true;
		phoneTilt.enabled = false;
	}
	public void PhoneTiltOn(){
		touchTilt.enabled = false;
		phoneTilt.enabled = true;
	}

}
