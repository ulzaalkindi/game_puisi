﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class jawab : MonoBehaviour {
    public GameObject feed_benar, feed_salah,detail;
	// Use this for initialization
	void Start () {
		
	}
	public void jawaban(bool jawab)
    {
        if (jawab) { 
        feed_benar.SetActive(false);
        feed_benar.SetActive(true);
        int skor = PlayerPrefs.GetInt("skor") + 10;
       PlayerPrefs.SetInt("skor", skor);
        gameObject.SetActive(false);
        transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);
        
        } else
        {
            feed_salah.SetActive(false);
            feed_salah.SetActive(true);
        }
    }
    public void Detail()
    {
        detail.SetActive(true);
    }
    public void Close_detail()
    {
        detail.SetActive(false);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
