using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour {

    public Animator animator;
    public int scenetoload;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
            FadeToLevel(1);
        StartCoroutine("invoke");
	}



    public void FadeToLevel (int index)
    {
        animator.SetTrigger("FadeOut");
    }


    public void OnFadeComplete ()
    {
        SceneManager.LoadScene(scenetoload);
    }

    IEnumerator invoke()
    {
        yield return new WaitForSeconds(3);
        Debug.Log("gg");
        OnFadeComplete();
        
        

    }
    
}
