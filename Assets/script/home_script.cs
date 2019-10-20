using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class home_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void Soal_scene()
    {
        SceneManager.LoadScene("soal");
    }

    public void Game_scene()
    {
        SceneManager.LoadScene("game");
    }
    

    // Update is called once per frame
    void Update () {
		
	}
    
}
