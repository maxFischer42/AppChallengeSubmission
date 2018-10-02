using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class unitFire : MonoBehaviour {

    public int damage;
    public Transform gunTip;
    public LineRenderer rend;
    public bool loaded;
    public float reloadCooldown;
    public float currentTimer;
    public bool enable;
    public Transform dir;

    public GameObject hitObject;

    public Transform target;

    public unitAim aim;

    public GameObject muzzleFlashObject;

    public AudioClip shotSound;
    private AudioSource aud;
    Ray beam;




    // Use this for initialization
    void Start () {
        aud = GetComponent<AudioSource>();
        aud.volume = PlayerPrefs.GetFloat("Sound");
	}
	
	// Update is called once per frame
	void Update ()
    {
        RaycastHit hit;
        

        if (enable)
        {
            
            beam.origin = transform.position;

            rend.SetPosition(0, beam.origin);
            

            Vector3 fwd = target.position - transform.position;
            if (Physics.Raycast(transform.position, fwd, out hit))
            {


                //rend.enabled = true;
                Debug.DrawLine(beam.origin, hit.point, Color.red);
                rend.SetPosition(1, hit.point);






                if (hit.collider.tag == "Enemy")
                {
                    aud.PlayOneShot(shotSound);
                    GameObject aa = (GameObject)Instantiate(hitObject, hit.point,Quaternion.identity);
                    Destroy(aa, 4f);
                    GameObject muzzle = (GameObject)Instantiate(muzzleFlashObject, transform);
                    Destroy(muzzle, 0.15f);
                    hit.collider.GetComponent<AIHealth>().HP -= damage;
                    enable = false;
                }
                hit = new RaycastHit();
                beam = new Ray();
            }
        }
        else
        {
            currentTimer += Time.deltaTime;
            if(currentTimer >= reloadCooldown)
            {
                currentTimer = 0;
                enable = true;
            }
        }
        }
        
                

                

            
            
                
            


        
		
	}





