using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private Transform target;
    private NavMeshAgent nav;
    float time;
    private bool Run;
    private bool Shoot;
    public GameObject bulletPrefab;
    public Transform FireStart;
    public float shellSpeed = 50;
    public GameObject OpenFire;
    public GameObject TurretBase;
    public AudioClip Fire;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<NavMeshAgent>().enabled = true;
        target = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        TurretBase.transform.LookAt(target);

        if (Run == true)
        {
            nav.SetDestination(target.position);
        }
        if (Shoot == true && time >= 3)
        {
            GameObject.Instantiate(OpenFire, FireStart.position, FireStart.rotation);
            GameObject fireInstance = GameObject.Instantiate(bulletPrefab, FireStart.position, FireStart.rotation);
            fireInstance.GetComponent<Rigidbody>().velocity = fireInstance.transform.forward * shellSpeed;
            AudioSource.PlayClipAtPoint(Fire, OpenFire.transform.position, 1f);
            time = 0;
        }
        time += Time.deltaTime;
    }
    public void TKrun()
    {
        Run = true;
        Shoot = false;
        Debug.Log("Run");
    }
    public void Attact()
    {

        Run = false;
        Shoot = true;
        Debug.Log("Attack");
    }
}
