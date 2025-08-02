using UnityEngine;
using System.Collections.Generic;
using UnityEditor;
public class DrawLine : MonoBehaviour
{
    private Transform lineParent;
    public Material lineMaterial;
    public float paintSize = 3;
    public bool isMouseDown = false;
    private LineRenderer currentLine;
    private Vector3 currentMousePostion;
    private Vector3 lastMosuePostion;
    private List<Vector3> points = new List<Vector3>();
    private GameObject m_Fx;
    private bool showProj = false;
    private void Awake()
    {
        lineParent = GameObject.Find("DrawL").transform;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ClearLine();
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            Time.timeScale = 2f;
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            Time.timeScale = 1f;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            Time.timeScale = 0.5f;
        }

        if (Input.GetKeyDown(KeyCode.P) && showProj == false)
        {
            List<GameObject> fxls = new List<GameObject>();
            foreach (GameObject g in Resources.LoadAll<GameObject>("Prefabs/SVFX/Range_attack/"))
            {
                fxls.Add(g);
            }

            m_Fx = GameObject.Instantiate(fxls[1], new Vector3(0f, 0f, 0f), Quaternion.Euler(new Vector3(-90f, 0f, 0f))) as GameObject;

            m_Fx.transform.localScale = new Vector3(1f, 1f, 1f);
            showProj = true;
        }

        if (Input.GetKeyDown(KeyCode.L) && showProj)
        {
            Destroy(m_Fx);
            m_Fx = null;
            showProj = false;
        }
        if (m_Fx != null)
        {
            currentMousePostion = Input.mousePosition;
            //Debug.Log(currentMousePostion);
            m_Fx.transform.position = new Vector3((currentMousePostion.x - 960) / (960/4.4f), 1f, (currentMousePostion.y - 540) / (960/4.4f));
        }

        if (isMouseDown)
        {
            currentMousePostion = Input.mousePosition;
            currentMousePostion = new Vector3((currentMousePostion.x - 960) / 50f, (currentMousePostion.y - 540) / 50f, 0f);

            if (Vector3.Distance(currentMousePostion, lastMosuePostion) >= 0.01f)
            {
                AddLinePoint(currentMousePostion);
                lastMosuePostion = currentMousePostion;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            isMouseDown = false;
            currentLine = null;
            lastMosuePostion = Vector3.zero;
            points.Clear();
        }
    }

    private void AddLinePoint(Vector3 pos)
    {
        points.Add(pos);
        currentLine.positionCount = points.Count;
        currentLine.SetPositions(points.ToArray());
    }
    public void ClearLine()
    {
        isMouseDown = false;
        currentLine = null;
        lastMosuePostion = Vector3.zero;
        points.Clear();
        for (int i = 0; i < lineParent.childCount; i++)
        {
            Destroy(lineParent.GetChild(i).gameObject);
        }
    }

}
