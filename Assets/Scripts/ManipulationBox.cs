using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipulationBox : MonoBehaviour {

    public GameObject prefabOfChoice;
    public Material BoundingBoxMaterial;
    public GameObject RotateMenu;
    GameObject cube1;
    GameObject cube2;
    GameObject cube3;
    GameObject cube4;
    GameObject cube5;
    GameObject cube6;
    GameObject cube7;
    GameObject cube8;
    GameObject quad1;
    GameObject quad2;
    GameObject quad3;
    GameObject quad4;
    GameObject quad5;
    GameObject quad6;
    GameObject sphere1;
    GameObject sphere2;
    GameObject sphere3;
    GameObject sphere4;
    GameObject sphere5;
    GameObject sphere6;
    GameObject sphere7;
    GameObject sphere8;
    public bool manipulationInProgress = false;


    // Use this for initialization
    void Start () {
        
        //Create Corner Cubes
        cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube1.transform.SetParent(this.transform);
        cube1.GetComponent<Renderer>().material = BoundingBoxMaterial;
        cube1.GetComponent<Renderer>().enabled = false;
        cube1.GetComponent<Collider>().enabled = false;
        cube1.AddComponent<CubeResponder>();
        cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube2.transform.SetParent(this.transform);
        cube2.GetComponent<Renderer>().material = BoundingBoxMaterial;
        cube2.GetComponent<Renderer>().enabled = false;
        cube2.GetComponent<Collider>().enabled = false;
        cube2.AddComponent<CubeResponder>();
        cube3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube3.transform.SetParent(this.transform);
        cube3.GetComponent<Renderer>().material = BoundingBoxMaterial;
        cube3.GetComponent<Renderer>().enabled = false;
        cube3.GetComponent<Collider>().enabled = false;
        cube3.AddComponent<CubeResponder>();
        cube4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube4.transform.SetParent(this.transform);
        cube4.GetComponent<Renderer>().material = BoundingBoxMaterial;
        cube4.GetComponent<Renderer>().enabled = false;
        cube4.GetComponent<Collider>().enabled = false;
        cube4.AddComponent<CubeResponder>();
        cube5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube5.transform.SetParent(this.transform);
        cube5.GetComponent<Renderer>().material = BoundingBoxMaterial;
        cube5.GetComponent<Renderer>().enabled = false;
        cube5.GetComponent<Collider>().enabled = false;
        cube5.AddComponent<CubeResponder>();
        cube6 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube6.transform.SetParent(this.transform);
        cube6.GetComponent<Renderer>().material = BoundingBoxMaterial;
        cube6.GetComponent<Renderer>().enabled = false;
        cube6.GetComponent<Collider>().enabled = false;
        cube6.AddComponent<CubeResponder>();
        cube7 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube7.transform.SetParent(this.transform);
        cube7.GetComponent<Renderer>().material = BoundingBoxMaterial;
        cube7.GetComponent<Renderer>().enabled = false;
        cube7.GetComponent<Collider>().enabled = false;
        cube7.AddComponent<CubeResponder>();
        cube8 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube8.transform.SetParent(this.transform);
        cube8.GetComponent<Renderer>().material = BoundingBoxMaterial;
        cube8.GetComponent<Renderer>().enabled = false;
        cube8.GetComponent<Collider>().enabled = false;
        cube8.AddComponent<CubeResponder>();

        //Create Face Quads
        quad1 = GameObject.CreatePrimitive(PrimitiveType.Quad);
        quad1.transform.SetParent(this.transform);
        quad1.GetComponent<Renderer>().material = BoundingBoxMaterial;
        quad1.AddComponent<QuadResponder>();
        quad1.GetComponent<Renderer>().enabled = false;
        quad1.GetComponent<Collider>().enabled = false;
        quad2 = GameObject.CreatePrimitive(PrimitiveType.Quad);
        quad2.transform.eulerAngles = new Vector3(0, 180, 0);
        quad2.transform.SetParent(this.transform);
        quad2.GetComponent<Renderer>().material = BoundingBoxMaterial;
        quad2.AddComponent<QuadResponder>();
        quad2.GetComponent<Renderer>().enabled = false;
        quad2.GetComponent<Collider>().enabled = false;
        quad3 = GameObject.CreatePrimitive(PrimitiveType.Quad);
        quad3.transform.eulerAngles = new Vector3(0, 90, 0);
        quad3.transform.SetParent(this.transform);
        quad3.GetComponent<Renderer>().material = BoundingBoxMaterial;
        quad3.AddComponent<QuadResponder>();
        quad3.GetComponent<Renderer>().enabled = false;
        quad3.GetComponent<Collider>().enabled = false;
        quad4 = GameObject.CreatePrimitive(PrimitiveType.Quad);
        quad4.transform.eulerAngles = new Vector3(0, -90, 0);
        quad4.transform.SetParent(this.transform);
        quad4.GetComponent<Renderer>().material = BoundingBoxMaterial;
        quad4.AddComponent<QuadResponder>();
        quad4.GetComponent<Renderer>().enabled = false;
        quad4.GetComponent<Collider>().enabled = false;
        quad5 = GameObject.CreatePrimitive(PrimitiveType.Quad);
        quad5.transform.eulerAngles = new Vector3(-90, 0, 0);
        quad5.transform.SetParent(this.transform);
        quad5.GetComponent<Renderer>().material = BoundingBoxMaterial;
        quad5.AddComponent<QuadResponder>();
        quad5.GetComponent<Renderer>().enabled = false;
        quad5.GetComponent<Collider>().enabled = false;
        quad6 = GameObject.CreatePrimitive(PrimitiveType.Quad);
        quad6.transform.eulerAngles = new Vector3(90, 0, 0);
        quad6.transform.SetParent(this.transform);
        quad6.GetComponent<Renderer>().material = BoundingBoxMaterial;
        quad6.AddComponent<QuadResponder>();
        quad6.GetComponent<Renderer>().enabled = false;
        quad6.GetComponent<Collider>().enabled = false;

        /*//Create Side Spheres
        sphere1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere1.transform.SetParent(this.transform);
        sphere1.GetComponent<Renderer>().material = BoundingBoxMaterial;
        sphere1.GetComponent<Renderer>().enabled = false;
        sphere1.GetComponent<Collider>().enabled = false;
        sphere1.AddComponent<SphereResponder>();
        sphere2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere2.transform.SetParent(this.transform);
        sphere2.GetComponent<Renderer>().material = BoundingBoxMaterial;
        sphere2.GetComponent<Renderer>().enabled = false;
        sphere2.GetComponent<Collider>().enabled = false;
        sphere2.AddComponent<SphereResponder>();
        sphere3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere3.transform.SetParent(this.transform);
        sphere3.GetComponent<Renderer>().material = BoundingBoxMaterial;
        sphere3.GetComponent<Renderer>().enabled = false;
        sphere3.GetComponent<Collider>().enabled = false;
        sphere3.AddComponent<SphereResponder>();
        sphere4 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere4.transform.SetParent(this.transform);
        sphere4.GetComponent<Renderer>().material = BoundingBoxMaterial;
        sphere4.GetComponent<Renderer>().enabled = false;
        sphere4.GetComponent<Collider>().enabled = false;
        sphere4.AddComponent<SphereResponder>();
        sphere5 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere5.transform.SetParent(this.transform);
        sphere5.GetComponent<Renderer>().material = BoundingBoxMaterial;
        sphere5.GetComponent<Renderer>().enabled = false;
        sphere5.GetComponent<Collider>().enabled = false;
        sphere5.AddComponent<SphereResponder>();
        sphere6 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere6.transform.SetParent(this.transform);
        sphere6.GetComponent<Renderer>().material = BoundingBoxMaterial;
        sphere6.GetComponent<Renderer>().enabled = false;
        sphere6.GetComponent<Collider>().enabled = false;
        sphere6.AddComponent<SphereResponder>();
        sphere7 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere7.transform.SetParent(this.transform);
        sphere7.GetComponent<Renderer>().material = BoundingBoxMaterial;
        sphere7.GetComponent<Renderer>().enabled = false;
        sphere7.GetComponent<Collider>().enabled = false;
        sphere7.AddComponent<SphereResponder>();
        sphere8 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere8.transform.SetParent(this.transform);
        sphere8.GetComponent<Renderer>().material = BoundingBoxMaterial;
        sphere8.GetComponent<Renderer>().enabled = false;
        sphere8.GetComponent<Collider>().enabled = false;
        sphere8.AddComponent<SphereResponder>();
        */

        this.transform.position = new Vector3(-5, 0, 0);

    }
	
	// Update is called once per frame
	void Update () {

        if (GameObject.FindGameObjectWithTag("Selected"))
        {
            Vector3 scaleSize = GameObject.FindGameObjectWithTag("Selected").transform.localScale;

            Bounds bounds = new Bounds(prefabOfChoice.transform.position, Vector3.zero);

            foreach (Renderer renderer in prefabOfChoice.GetComponentsInChildren<Renderer>())
            {
                bounds.Encapsulate(renderer.bounds);
            }

            RotateMenu.transform.position = new Vector3(bounds.center.x, bounds.max.y + 0.1f, bounds.center.z);
            RotateMenu.GetComponent<Renderer>().enabled = true;
            RotateMenu.GetComponent<Collider>().enabled = true;


            cube1.transform.position = bounds.min;
            cube1.transform.localScale = scaleSize/10;
            cube2.transform.position = new Vector3(bounds.min.x, bounds.min.y, bounds.max.z);
            cube2.transform.localScale = scaleSize / 10;
            cube3.transform.position = new Vector3(bounds.min.x, bounds.max.y, bounds.max.z);
            cube3.transform.localScale = scaleSize / 10;
            cube4.transform.position = new Vector3(bounds.min.x, bounds.max.y, bounds.min.z);
            cube4.transform.localScale = scaleSize / 10;
            cube5.transform.position = new Vector3(bounds.max.x, bounds.min.y, bounds.min.z);
            cube5.transform.localScale = scaleSize / 10;
            cube6.transform.position = new Vector3(bounds.max.x, bounds.min.y, bounds.max.z);
            cube6.transform.localScale = scaleSize / 10;
            cube7.transform.position = new Vector3(bounds.max.x, bounds.max.y, bounds.min.z);
            cube7.transform.localScale = scaleSize / 10;
            cube8.transform.position = bounds.max;
            cube8.transform.localScale = scaleSize / 10;
            if (RotateMenu.GetComponent<AutoRotateResponder>().selected != true)
            {
                cube1.GetComponent<Renderer>().enabled = true;
                cube1.GetComponent<Collider>().enabled = true;
                cube2.GetComponent<Renderer>().enabled = true;
                cube2.GetComponent<Collider>().enabled = true;
                cube3.GetComponent<Renderer>().enabled = true;
                cube3.GetComponent<Collider>().enabled = true;
                cube4.GetComponent<Renderer>().enabled = true;
                cube4.GetComponent<Collider>().enabled = true;
                cube5.GetComponent<Renderer>().enabled = true;
                cube5.GetComponent<Collider>().enabled = true;
                cube6.GetComponent<Renderer>().enabled = true;
                cube6.GetComponent<Collider>().enabled = true;
                cube7.GetComponent<Renderer>().enabled = true;
                cube7.GetComponent<Collider>().enabled = true;
                cube8.GetComponent<Renderer>().enabled = true;
                cube8.GetComponent<Collider>().enabled = true;
            }
            

            quad1.transform.position = new Vector3(bounds.center.x, bounds.center.y, bounds.min.z);
            quad1.transform.localScale = new Vector3(bounds.max.x - bounds.min.x, bounds.max.y - bounds.min.y, 1);
            quad2.transform.position = new Vector3(bounds.center.x, bounds.center.y, bounds.max.z);
            quad2.transform.localScale = new Vector3(bounds.max.x - bounds.min.x, bounds.max.y - bounds.min.y, 1);
            quad3.transform.position = new Vector3(bounds.min.x, bounds.center.y, bounds.center.z);
            quad3.transform.localScale = new Vector3(bounds.max.z - bounds.min.z, bounds.max.y - bounds.min.y, 1);
            quad4.transform.position = new Vector3(bounds.max.x, bounds.center.y, bounds.center.z);
            quad4.transform.localScale = new Vector3(bounds.max.z - bounds.min.z, bounds.max.y - bounds.min.y, 1);
            quad5.transform.position = new Vector3(bounds.center.x, bounds.min.y, bounds.center.z);
            quad5.transform.localScale = new Vector3(bounds.max.x - bounds.min.x, bounds.max.z - bounds.min.z, 1);
            quad6.transform.position = new Vector3(bounds.center.x, bounds.max.y, bounds.center.z);
            quad6.transform.localScale = new Vector3(bounds.max.x - bounds.min.x, bounds.max.z - bounds.min.z, 1);
            if (RotateMenu.GetComponent<AutoRotateResponder>().selected != true)
            {
                quad1.GetComponent<Renderer>().enabled = true;
                quad1.GetComponent<Collider>().enabled = true;
                quad2.GetComponent<Renderer>().enabled = true;
                quad2.GetComponent<Collider>().enabled = true;
                quad3.GetComponent<Renderer>().enabled = true;
                quad3.GetComponent<Collider>().enabled = true;
                quad4.GetComponent<Renderer>().enabled = true;
                quad4.GetComponent<Collider>().enabled = true;
                quad5.GetComponent<Renderer>().enabled = true;
                quad5.GetComponent<Collider>().enabled = true;
                quad6.GetComponent<Renderer>().enabled = true;
                quad6.GetComponent<Collider>().enabled = true;
            }
            
            
            
            /*
            sphere1.transform.position = new Vector3(bounds.max.x, bounds.center.y, bounds.min.z);
            sphere1.transform.localScale = scaleSize / 10;
            sphere1.GetComponent<Renderer>().enabled = true;
            sphere1.GetComponent<Collider>().enabled = true;
            sphere2.transform.position = new Vector3(bounds.min.x, bounds.center.y, bounds.min.z);
            sphere2.transform.localScale = scaleSize / 10;
            sphere2.GetComponent<Renderer>().enabled = true;
            sphere2.GetComponent<Collider>().enabled = true;
            sphere3.transform.position = new Vector3(bounds.max.x, bounds.center.y, bounds.max.z);
            sphere3.transform.localScale = scaleSize / 10;
            sphere3.GetComponent<Renderer>().enabled = true;
            sphere3.GetComponent<Collider>().enabled = true;
            sphere4.transform.position = new Vector3(bounds.min.x, bounds.center.y, bounds.max.z);
            sphere4.transform.localScale = scaleSize / 10;
            sphere4.GetComponent<Renderer>().enabled = true;
            sphere4.GetComponent<Collider>().enabled = true;
            sphere5.transform.position = new Vector3(bounds.center.x, bounds.min.y, bounds.min.z);
            sphere5.transform.localScale = scaleSize / 10;
            sphere5.GetComponent<Renderer>().enabled = true;
            sphere5.GetComponent<Collider>().enabled = true;
            sphere6.transform.position = new Vector3(bounds.center.x, bounds.min.y, bounds.max.z);
            sphere6.transform.localScale = scaleSize / 10;
            sphere6.GetComponent<Renderer>().enabled = true;
            sphere6.GetComponent<Collider>().enabled = true;
            sphere7.transform.position = new Vector3(bounds.center.x, bounds.max.y, bounds.max.z);
            sphere7.transform.localScale = scaleSize / 10;
            sphere7.GetComponent<Renderer>().enabled = true;
            sphere7.GetComponent<Collider>().enabled = true;
            sphere8.transform.position = new Vector3(bounds.center.x, bounds.max.y, bounds.min.z);
            sphere8.transform.localScale = scaleSize / 10;
            sphere8.GetComponent<Renderer>().enabled = true;
            sphere8.GetComponent<Collider>().enabled = true;
            */

            GameObject.FindGameObjectWithTag("Selected").transform.SetParent(this.transform);
        }

    }
}
