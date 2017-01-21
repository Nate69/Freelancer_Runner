using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {

    private Rigidbody2D body2d;
    // Use this for initialization
    void Start () {
        body2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
    }
	void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "HP^PickUp")
        {
            GameObject Text = GameObject.Find("Text");
            HealthScript targetScript = Text.GetComponent<HealthScript>();
            targetScript.Health += 10;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "DMGPickUp")
        {
            GameObject Text = GameObject.Find("Text");
            HealthScript targetScript = Text.GetComponent<HealthScript>();
            targetScript.Health -= 20;
            Destroy(other.gameObject);
        }
    }

}

