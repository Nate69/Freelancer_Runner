using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class textscript : MonoBehaviour {
    private float nextUsage;
    private float textDelay = 2;//two seconds delay.
    Text TextBox;
    string[] FrenchTalk = System.IO.File.ReadAllLines("TestText.txt");
	// Use this for initialization
	void Start () {
        nextUsage = Time.time + textDelay;
        TextBox = gameObject.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextUsage)
        {
            nextUsage = Time.time + textDelay;
            TextBox.text = FrenchTalk[Random.Range(0, 15)];
        }
	}
}
