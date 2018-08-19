﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unitFire : MonoBehaviour {

    public int damage;
    public Transform gunTip;
    public LineRenderer rend;
    public bool loaded;
    public float reloadCooldown;
    public float currentTimer;
    public bool enable;
    private Ray beam;
    public GameObject particle;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(enable)
        {
            
            if (loaded)
            {


                RaycastHit hit;
                beam.origin = transform.position;
                rend.SetPosition(0, beam.origin);

                
                Vector3 fwd = transform.TransformDirection(Vector3.forward);
                if(Physics.Raycast(transform.position,fwd, out hit))
                {
                    rend.enabled = true;
                    particle.SetActive(true);
                    loaded = false;
                    Debug.DrawLine(beam.origin, hit.point, Color.red);
                    rend.SetPosition(1, hit.point);
                    if (hit.collider.tag == "Enemy")
                    {
                        hit.collider.GetComponent<AIHealth>().HP -= damage;
                        if(hit.collider.GetComponent<AIHealth>().HP <= 0 || hit.collider.gameObject == null)
                        {
                            enable = false;
                        }
                        
                        
                        
                    }
                }
                

                


            }
            else
            {
                beam.origin = Vector3.zero;
                currentTimer += Time.deltaTime;
                if (currentTimer > 0.1)
                {
                    rend.enabled = false;
                    particle.SetActive(false);
                }

                if (currentTimer >= reloadCooldown)
                {
                    currentTimer = 0;
                    loaded = true;
                    
                }
            }


        }
		
	}
}
