﻿using UnityEngine;
using System.Collections;

public class Score_Text : MonoBehaviour 
{
	
	// Use this for initialization
	public GUIText text;
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		guiText.text = "Score: " + Player.score;
		
	}
}
