using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDamage : MonoBehaviour {

    public int damage;

    public float timerCountTo;
    public float timer;

    public bool isContact;
    public unitHealth target;

    public GameObject topBounds;
    public GameObject Light;
    public float distanceTop;

    private void Update()
    {

        if (!target)
        {
            target = null;
        }

        if (!isContact) { 
            topBounds.transform.position = new Vector3(transform.position.x, transform.position.y + 3.5f, transform.position.z);
            Light.SetActive(false);
            return;
         }
        timer += Time.deltaTime;

        topBounds.transform.position = new Vector3(transform.position.x, transform.position.y + 9f, transform.position.z);
        Light.SetActive(true);


        if (timer >= timerCountTo)
        {

            int total = damage - target.armor;
            target.HP -= total;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            isContact = true;
            target = collision.gameObject.GetComponent<unitHealth>();
            
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isContact = false;
            target = null;
        }
    }
}
