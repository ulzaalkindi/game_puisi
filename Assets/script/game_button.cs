using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class game_button : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public void lihat()
    {
        // transform.GetSiblingIndex();
        Debug.Log(transform.GetSiblingIndex());
        gameObject.SetActive(false);
        transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);
    }
    public void Home()
    {
        SceneManager.LoadScene("home");
    }
    // Update is called once per frame
    void Update () {
		
	}
}
