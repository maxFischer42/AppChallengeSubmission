using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unitAim : MonoBehaviour {

    public GameObject unitMain;
    public GameObject target;
    public float rotateSpeed;
    public unitFire fireScript;


	
	
	// Update is called once per frame
	void Update ()
    {
		if(target)
        {
            float step = rotateSpeed * Time.deltaTime;
            Vector3 targetDir = target.transform.position - unitMain.transform.position;
            Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);
            unitMain.transform.rotation = Quaternion.LookRotation(newDir);
        }

	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("object in area");
        if(other.gameObject.tag == "Enemy")
        {
            target = other.gameObject;
            fireScript.enable = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("object in area");
        if (other.gameObject.tag == "Enemy")
        {
            target = other.gameObject;
            fireScript.enable = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("object left area");
        if (other.gameObject.tag == "Enemy")
        {
            target = null;
            fireScript.enable = false;
        }
    }
}
