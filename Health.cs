using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	public float rate = 0.5f;
	// Use this for initialization
	
	float health = 100.0f;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, rate, 0);
		guiText.text = health.ToString();
		
		
            if (Input.GetKey("up"))
              print("up arrow key is held down");
        
            if (Input.GetKey("down"))
              print("down arrow key is held down");
            
            
	}
}
