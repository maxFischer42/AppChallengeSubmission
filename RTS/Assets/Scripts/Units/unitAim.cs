using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unitAim : MonoBehaviour {

    public GameObject unitMain;
    public GameObject target;
    public float rotateSpeed;
    public unitFire fireScript;
    public Animator anim;
    private Vector3 prevPos;


    public bool isMech;
    public unitFire fireScript2;


	
	
	// Update is called once per frame
	void Update ()
    {
        if(prevPos != unitMain.transform.position)
        {
            anim.SetBool("firing", false);
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("firing", true);
            anim.SetBool("isWalking", false);
        }



        if (target)
        {
            anim.SetBool("firing", true);
            anim.SetBool("isWalking", false);
            float step = rotateSpeed * Time.deltaTime;
            Vector3 targetDir = target.transform.position - unitMain.transform.position;
            Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);
            unitMain.transform.rotation = Quaternion.LookRotation(newDir);
        }
        prevPos = unitMain.transform.position;
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("object in area");
        if(other.gameObject.tag == "Enemy")
        {
            target = other.gameObject;
            fireScript.enabled = true;

            if(isMech)
            {
                fireScript2.enabled = true;
            }

            //par.SetActive(true);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("object in area");
        if (other.gameObject.tag == "Enemy")
        {
            target = other.gameObject;
            fireScript.enabled = true;

            if (isMech)
            {
                fireScript2.enabled = true;
            }
            //par.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("object left area");
        if (other.gameObject.tag == "Enemy")
        {
            target = null;
            fireScript.enabled = false;

            if (isMech)
            {
                fireScript2.enabled = false;
            }

            //par.SetActive(false);
        }
    }
}
