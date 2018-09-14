using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIHealth : MonoBehaviour {

    public int HP = 10;
    public GameObject DeathObject;
    public GameObject cube;
    public bool fallingCubes;
	
	// Update is called once per frame
	void Update () {
		if(HP <= 0)
        {
            GameObject aa = (GameObject)Instantiate(DeathObject, transform.position,Quaternion.identity);
            aa.transform.parent = null;
            Destroy(aa, 5f);
            if(fallingCubes)
            {
                GameObject cube1 = (GameObject)Instantiate(cube,transform.position,Quaternion.identity
                    );
                cube1.transform.parent = null;
                cube1.GetComponentInChildren<MeshCollider>().enabled = true;
                cube1.GetComponentInChildren<Rigidbody>().useGravity = true;
                cube1.GetComponentInChildren<Rigidbody>().AddForce(Vector3.up * 7);
                Destroy(cube1, 10f);

            }
            Destroy(gameObject);
        }
	}

    private void OnParticleCollision(GameObject other)
    {
        string a = "Hit";
        if(other.tag == "HurtEnem")
        {
            HP--;
            a = "Hit Enemy";
        }
        Debug.Log(a);
    }


}
