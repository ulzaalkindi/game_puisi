using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_script : MonoBehaviour {
    public Button note1;
    public GameObject soal1,feed_note;
    // Use this for initialization
    void Start() {
        Button btnNote1 = note1.GetComponent<Button>();
        btnNote1.onClick.AddListener(Note1_click);
    }

    void Note1_click()
    {
        soal1.SetActive(true);
    }
    public void Close()
    {
        soal1.SetActive(false);
        note1.interactable = false;
        feed_note.SetActive(false);
        feed_note.SetActive(true);
    }
    public void Next()
    {
        gameObject.SetActive(false);
        transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
