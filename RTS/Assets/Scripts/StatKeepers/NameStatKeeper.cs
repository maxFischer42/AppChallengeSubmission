using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameStatKeeper : MonoBehaviour {
    public string[] nameIDS = { "Recruit", "Rifleman", "Sniper", "Tank", "Drone", "Exosuit Rifleman", "Exosuit Tank", "Basic Mech", "Quadruped Mech", "Railgun Cannon", "Flying Mech Mark I", "Flying Mech Mark II" };
    public float[] damageIDS = {3,5,7,4,2,7,6,15,12,25,13,15};
    public float[] healthIDS = {15,20,18,30,10,25,45,80,120,400,250,450};
    public float[] defIDS = {0,0,0,3,0,2,5,5,6,4,4,6};
    public string[] abilityIDS = {"The basic footsoldier.",
                                  "An upgraded soldier, faster movespeed",
                                  "An upgraded soldier, Higher damage and range",
                                  "An upgraded soldier, Slower speed but more defense",
                                  "A basic robot, nothing too special",
                                  "An upgraded Rifleman, higher damage and move speed.",
                                  "An upgraded Tank, higher defense and damage.",
                                  "A basic Mech, slow but can walk over enemies.",
                                  "An upgraded Mech, faster and can walk over more enemies.",
                                  "A mobile cannon, very slow but with extreme firepower.",
                                  "A basic flying mech. Can easily attack ground units.",
                                  "An upgraded flying mech. Can attack other airborn enemies."};
}
