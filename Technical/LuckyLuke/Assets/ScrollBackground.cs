using UnityEngine;
using System.Collections;

public class ScrollBackground : MonoBehaviour {

    public float scrollSpeed = 0.5f;
    public Renderer rend;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        float offset = (Time.time)  * scrollSpeed;
	    float offset2 = offset%1.0f;
        rend.material.SetTextureOffset("_MainTex", new Vector2(offset2, 0));
	}
}
