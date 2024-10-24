using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pole : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject manager;
    int mover = 0;
    
    SpriteRenderer m_SpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = Color.gray;
    }

    // Update is called once per 
    void Update()
    {

    }
    private void OnMouseDown()
    {
        if (manager.GetComponent<Manager>().stack3.Count != 4 && manager.GetComponent<Manager>().isLost == false)
        {
            mover = manager.GetComponent<Manager>().mover;
            if (mover % 2 == 0) // first select
            {
                if (this.name == "P1")
                {
                    manager.GetComponent<Manager>().poleFrom = 1;
                    GetComponent<SpriteRenderer>().color = Color.blue;
                    Debug.Log("pole 1 selected");
                    Debug.Log(mover);
                }
                if (this.name == "P2")
                {
                    manager.GetComponent<Manager>().poleFrom = 2;
                    GetComponent<SpriteRenderer>().color = Color.blue;
                    Debug.Log("pole 2 selected");
                    Debug.Log(mover);
                }
                if (this.name == "P3")
                {
                    manager.GetComponent<Manager>().poleFrom = 3;
                    GetComponent<SpriteRenderer>().color = Color.blue;
                    Debug.Log("pole 3 selected");
                    Debug.Log(mover);
                }
            }
            else// second select
            {
                if (this.name == "P1")
                {
                    manager.GetComponent<Manager>().poleTo = 1;
                    Debug.Log("pole 1 selected second");
                    Debug.Log(mover);
                }
                if (this.name == "P2")
                {
                    manager.GetComponent<Manager>().poleTo = 2;
                    Debug.Log("pole 2 selected second");
                    Debug.Log(mover);
                }
                if (this.name == "P3")
                {
                    manager.GetComponent<Manager>().poleTo = 3;
                    Debug.Log("pole 3 selected second");
                    Debug.Log(mover);
                }
                manager.GetComponent<Manager>().Move(manager.GetComponent<Manager>().poleFrom, manager.GetComponent<Manager>().poleTo);
                if(manager.GetComponent<Manager>().poleFrom != manager.GetComponent<Manager>().poleTo)
                    manager.GetComponent<Manager>().isMove = true;
                manager.GetComponent<Manager>().ColorReset();
            }
            manager.GetComponent<Manager>().IncMover();
        }


    }

}
