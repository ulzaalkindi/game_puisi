using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
using System.IO;
public class soal_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    public void Next_page()
    {
        int page = transform.GetSiblingIndex();
        Debug.Log(page);
        if (page <=7)
        {
            gameObject.SetActive(false);
            transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);
        }
    }
    public void Previous_page()
    {
        int page = transform.GetSiblingIndex();
        Debug.Log(page);
         if(page>=2) {

            gameObject.SetActive(false);
            transform.parent.GetChild(gameObject.transform.GetSiblingIndex() - 1).gameObject.SetActive(true);
            }
        }
 
    public void Home()
    {
        SceneManager.LoadScene("home");
    }
    public void Close()
    {
        Application.Quit();
    }
	void Update () {
		
	}
}
