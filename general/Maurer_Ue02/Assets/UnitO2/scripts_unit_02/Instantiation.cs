//using UnityEngine;

//public class Instantiation : MonoBehaviour
//{
//    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
//    public GameObject myPrefab;

//    // This script will simply instantiate the Prefab when the game starts.
//    void Start()
//    {
//        // Instantiate at position (0, 0, 0) and zero rotation.
//        Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);

//    }
//}



using UnityEngine;

public class Instantiation : MonoBehaviour
{
    public GameObject block;
    public int width = 10;
    public int height = 4;

    void Start()
    {
        for (int y = 0; y < height; ++y)
        {
            for (int x = 0; x < width; ++x)
            {
                Instantiate(block, new Vector3(x, y, 0), Quaternion.identity);
            }
        }
    }
}