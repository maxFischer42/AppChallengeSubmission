using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDamage : MonoBehaviour {

    public int damage;

    public float timerCountTo;
    public float timer;

    public bool isContact;
    public unitHealth target;

    private void Update()
    {
        if (!isContact)
            return;
        timer += Time.deltaTime;
        if (timer >= timerCountTo)
        {
            int total = damage -= target.armor;
            target.HP -= total;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            isContact = true;
            target = collision.gameObject.GetComponent<unitHealth>();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isContact = false;
            target = null;
        }
    }
}
