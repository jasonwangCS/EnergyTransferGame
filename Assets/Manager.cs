using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public int mover = 0;
    [SerializeField] GameObject pole1;
    [SerializeField] GameObject pole2;
    [SerializeField] GameObject pole3;
    public int poleTo = -1;
    public int poleFrom = -1;
    public int move = 0;
    public List<GameObject> stack1;
    public List<GameObject> stack2;
    public List<GameObject> stack3;
    //[SerializeField] GameObject plate5;
    [SerializeField] GameObject plate4;
    [SerializeField] GameObject plate3;
    [SerializeField] GameObject plate2;
    [SerializeField] GameObject plate1;
    [SerializeField] UnityEngine.UI.Text moveText;
    [SerializeField] UnityEngine.UI.Text winText;
    public bool isMove = false;
    public bool isWin = false;
    public bool isLost = false;
    [SerializeField] GameObject LoseLightning;
    // Start is called before the first frame update
    void Start()
    {
        LoseLightning.GetComponent<SpriteRenderer>().enabled = false;
        stack1 = new List<GameObject>();
        stack2 = new List<GameObject>();
        stack3 = new List<GameObject>();
        //stack1.Add(plate5);
        stack1.Add(plate4);
        stack1.Add(plate3);
        stack1.Add(plate2);
        stack1.Add(plate1);
    }

    // Update is called once per frame
    void Update()
    {
        //Boolean win = false;

        if (stack3.Count == 4)
        {
            winText.text = "You won in " + move + " moves!";
            isWin = true;
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadSceneAsync(
                    SceneManager.GetActiveScene().buildIndex);
            }
        }
        if(isLost == true)
        {
            winText.text = "you broke the energy transfer! press R to restart";
            LoseLightning.GetComponent<SpriteRenderer>().enabled = true;
            
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadSceneAsync(
                    SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
    public void Move(int poleFrom, int poleTo)
    {
        if (stack3.Count != 4 && isLost == false)
        {
            if (poleFrom == 1)
            {
                if (poleTo == 2)
                {

                    if (stack1.Count != 0 && stack2.Count == 0 || stack1.Count != 0 && stack1[stack1.Count - 1].GetComponent<SpriteRenderer>().bounds.size.x < stack2[stack2.Count - 1].GetComponent<SpriteRenderer>().bounds.size.x)
                    {
                        move++;
                        IncMove(move);
                        GameObject movingPlate = stack1[stack1.Count - 1];
                        stack1[stack1.Count - 1].transform.position = new Vector3(-1.0263f, stack1[stack1.Count - 1].transform.position.y, transform.position.z);
                        stack1.RemoveAt(stack1.Count - 1);
                        stack2.Add(movingPlate);
                    }
                    else
                    {
                        isLost = true;
                        LoseLightning.transform.position = new Vector3(1.0263f, LoseLightning.transform.position.y, transform.position.z);
                    }
                        
                }
                if (poleTo == 3)
                {
                    if (stack1.Count != 0 && stack3.Count == 0 || stack1.Count != 0 && stack1[stack1.Count - 1].GetComponent<SpriteRenderer>().bounds.size.x < stack3[stack3.Count - 1].GetComponent<SpriteRenderer>().bounds.size.x)
                    {
                        move++;
                        IncMove(move);
                        GameObject movingPlate = stack1[stack1.Count - 1];
                        stack1[stack1.Count - 1].transform.position = new Vector3(138.2646f, stack1[stack1.Count - 1].transform.position.y, transform.position.z);
                        stack1.RemoveAt(stack1.Count - 1);
                        stack3.Add(movingPlate);
                    }
                    else
                    {
                        isLost = true;
                        LoseLightning.transform.position = new Vector3(138.2646f, LoseLightning.transform.position.y, transform.position.z);
                    }
                }
            }
            if (poleFrom == 2)
            {
                if (poleTo == 1)
                {
                    if (stack2.Count != 0 && stack1.Count == 0 || stack2.Count != 0 && stack2[stack2.Count - 1].GetComponent<SpriteRenderer>().bounds.size.x < stack1[stack1.Count - 1].GetComponent<SpriteRenderer>().bounds.size.x)
                    {
                        move++;
                        IncMove(move);
                        GameObject movingPlate = stack2[stack2.Count - 1];
                        stack2[stack2.Count - 1].transform.position = new Vector3(-140.3187f, stack2[stack2.Count - 1].transform.position.y, transform.position.z);
                        stack2.RemoveAt(stack2.Count - 1);
                        stack1.Add(movingPlate);
                    }
                    else
                    {
                        isLost = true;
                        LoseLightning.transform.position = new Vector3(-140.3187f, LoseLightning.transform.position.y, transform.position.z);
                    }
                }
                if (poleTo == 3)
                {
                    if (stack2.Count != 0 && stack3.Count == 0 || stack2.Count != 0 && stack2[stack2.Count - 1].GetComponent<SpriteRenderer>().bounds.size.x < stack3[stack3.Count - 1].GetComponent<SpriteRenderer>().bounds.size.x)
                    {
                        move++;
                        IncMove(move);
                        GameObject movingPlate = stack2[stack2.Count - 1];
                        stack2[stack2.Count - 1].transform.position = new Vector3(138.2646f, stack2[stack2.Count - 1].transform.position.y, transform.position.z);
                        stack2.RemoveAt(stack2.Count - 1);
                        stack3.Add(movingPlate);
                    }
                    else
                    {
                        isLost = true;
                        LoseLightning.transform.position = new Vector3(138.2646f, LoseLightning.transform.position.y, transform.position.z);
                    }
                }
            }
            if (poleFrom == 3)
            {
                if (poleTo == 1)
                {
                    if (stack3.Count != 0 && stack1.Count == 0 || stack3.Count != 0 && stack3[stack3.Count - 1].GetComponent<SpriteRenderer>().bounds.size.x < stack1[stack1.Count - 1].GetComponent<SpriteRenderer>().bounds.size.x)
                    {
                        move++;
                        IncMove(move);
                        GameObject movingPlate = stack3[stack3.Count - 1];
                        stack3[stack3.Count - 1].transform.position = new Vector3(-140.3187f, stack3[stack3.Count - 1].transform.position.y, transform.position.z);
                        stack3.RemoveAt(stack3.Count - 1);
                        stack1.Add(movingPlate);
                    }
                    else
                    {
                        isLost = true;
                        LoseLightning.transform.position = new Vector3(-140.3187f, LoseLightning.transform.position.y, transform.position.z);
                    }
                }
                if (poleTo == 2)
                {
                    if (stack3.Count != 0 && stack2.Count == 0 || stack3.Count != 0 && stack3[stack3.Count - 1].GetComponent<SpriteRenderer>().bounds.size.x < stack2[stack2.Count - 1].GetComponent<SpriteRenderer>().bounds.size.x)
                    {
                        move++;
                        IncMove(move);
                        GameObject movingPlate = stack3[stack3.Count - 1];
                        stack3[stack3.Count - 1].transform.position = new Vector3(-1.0263f, stack3[stack3.Count - 1].transform.position.y, transform.position.z);
                        stack3.RemoveAt(stack3.Count - 1);
                        stack2.Add(movingPlate);
                    }
                    else
                    {
                        isLost = true;
                        LoseLightning.transform.position = new Vector3(1.0263f, LoseLightning.transform.position.y, transform.position.z);
                    }
                }
            }
        }
    }

    public int GetMover()
    {
        return mover;
    }
    public void IncMove(int move)
    {

        moveText.text = "moves: " + move;
    }
    public void IncMover()
    {
        mover++;
    }
    public void ColorReset()
    {
        pole1.GetComponent<SpriteRenderer>().color = Color.gray;
        pole2.GetComponent<SpriteRenderer>().color = Color.gray;
        pole3.GetComponent<SpriteRenderer>().color = Color.gray;
    }
}

