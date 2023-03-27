using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowWaypoints : MonoBehaviour {


    GameObject[] wps;
    GameObject currentNode;
    NavMeshAgent agent;


    public GameObject wpManager;

    void Start() {
        Time.timeScale = 5.0f;
        wps = wpManager.GetComponent<WPManager>().waypoints;
        currentNode = wps[0];

        agent = GetComponent<NavMeshAgent>();
    }

    public void GoRouteOne() {
        GotoHere(0);
    }

    public void GoRouteTwo() {
        GotoHere(1);
    }


    void GotoHere(int value) {

        agent.SetDestination(wps[value].transform.position);
    }

    void LateUpdate() {

       
    }
}
