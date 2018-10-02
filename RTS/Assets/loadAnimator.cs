using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loadAnimator : MonoBehaviour {

    public Sprite[] frames;
    public float time;
    private float timer;
    public Image m_image;
    public int totalFrames;
    private int currentFrame;


	
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;
        if(timer >= time)
        {
            currentFrame++;
            if(currentFrame > totalFrames)
            {
                currentFrame = 0;
            }
            m_image.sprite = frames[currentFrame];
            timer = 0f;
        }





	}
}
