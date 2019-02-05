using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareController : MonoBehaviour {

    public int countTarget;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.A))
        {
            Count();
        }
	}

    void Count()
    {
        for (int i = 0; i < countTarget; i++)
        {
            Debug.Log(i);
        }
    }
}
