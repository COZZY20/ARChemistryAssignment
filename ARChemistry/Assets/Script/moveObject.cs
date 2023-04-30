using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObject : MonoBehaviour
{
    public Transform[] waypoints;
    public float moveSpeed;
    private int currentPoints;
    float distanceGap;
    float gap = 5.0f;

    public GameObject H;
    public GameObject H_1;
    public GameObject O;
    public GameObject S;
    public GameObject P;
    public GameObject C;

    public bool h_obj = false;
    public bool h1_obj = false;

    public GameObject obj;
    public Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        //obj.SetActive(false);

        //ani.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        distanceGap = Vector3.Distance(H.transform.position, O.transform.position);

        if (distanceGap > gap)
        {
            H.transform.position = Vector3.MoveTowards(H.transform.position, O.transform.position, moveSpeed = Time.deltaTime);
        }

        Debug.Log("Distance: " + distanceGap);
        //if (H.transform.position == waypoints[currentPoints].position || H_1.transform.position == waypoints[currentPoints].position)
        //{
        //    currentPoints++;
        //}
        //if (currentPoints >= waypoints.Length)
        //{
        //    currentPoints = 0;
        //}

        //if (h_obj == true)
        //{
        //    H.transform.position = Vector3.MoveTowards(H.transform.position, waypoints[0].position, moveSpeed = Time.deltaTime);
        //}
        //if (h1_obj == true)
        //{
        //    H_1.transform.position = Vector3.MoveTowards(H.transform.position, waypoints[1].position, moveSpeed = Time.deltaTime);
        //}

        //if (h_obj == true && h1_obj == true)
        //{
        //    StartCoroutine(Dealy());
        //}
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.transform.tag == "H")
    //    {
    //        Debug.Log("Hit");
    //        h_obj = true;
    //    }
    //    if (collision.transform.tag == "H_1")
    //    {
    //        Debug.Log("Hit");
    //        h1_obj = true;
    //    }
    //}


    //IEnumerator Dealy()
    //{
    //    yield return new WaitForSeconds(10f);
    //    obj.SetActive(true);
    //    ani.enabled = true;
    //}
}
