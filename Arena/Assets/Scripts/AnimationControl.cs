using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour {

    public Animator anim;

	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.G))
            anim.SetBool("attack", true);
        else
            anim.SetBool("attack", false);
	}
}
