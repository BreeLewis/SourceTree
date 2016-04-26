using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerBarDown : MonoBehaviour {

	Image fillImage;
	float timeAmount = 120;
	float time;
	public Text timeText;

	void Start () 
	{
		fillImage = this.GetComponent<Image>();
		time = timeAmount;
	}
	

	void Update () 
	{
		if (time > 0) 
		{
			time -= Time.deltaTime;
			fillImage.fillAmount = time / timeAmount; //9/10, 8/10.....0/10
			timeText.text = "Time: " +time.ToString("F");
		}
	}
}
