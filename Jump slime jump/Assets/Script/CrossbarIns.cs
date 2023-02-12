using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossbarIns : MonoBehaviour
{
    public GameObject Crossbar;

    public float InsTimeOri, InsTimeCur;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InsTimeCur -= Time.deltaTime;

        if (InsTimeCur <= 0)
        {
            InsTimeCur = InsTimeOri;
            CrossIns();
        }
    }

    void CrossIns()
    {
        Vector3 spawn_pos = new Vector3(Random.Range(-6, 6), -5.3f, 0);

        Instantiate(Crossbar, spawn_pos, Quaternion.identity);
    }
}
