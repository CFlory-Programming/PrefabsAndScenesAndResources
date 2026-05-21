using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
public class Logic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject cubePrefab = Resources.Load<GameObject>("Cube");
        GameObject spherePrefab = Resources.Load<GameObject>("Sphere");
        GameObject cylinderPrefab = Resources.Load<GameObject>("Cylinder");
        GameObject capsulePrefab = Resources.Load<GameObject>("Capsule");
        Instantiate(cubePrefab, new Vector3(0, 0, 0), Quaternion.Euler(78f, 2f, 239f));
        Instantiate(spherePrefab, new Vector3(-3, 0, 0), Quaternion.Euler(1.5f, 0f, 190f));
        Instantiate(cylinderPrefab, new Vector3(0, 3, 0), Quaternion.Euler(1f, 2f, 56f));
        Instantiate(capsulePrefab, new Vector3(3, 0, 0), Quaternion.Euler(4f, 0f, 100f));
        //Load a scene
        //SceneManager.LoadScene("SampleScene");
        //Load a scene asynchronously
        //SceneManager.LoadSceneAsync("SampleScene");
        //Load a scene additively
        //SceneManager.LoadScene("SampleScene", LoadSceneMode.Additive);
    }
}