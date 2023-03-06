using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject m_object;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void appear()
    {
        m_object.SetActive(true);
    }
    public void disappear()
    {
        m_object.SetActive(false);
    }
}
