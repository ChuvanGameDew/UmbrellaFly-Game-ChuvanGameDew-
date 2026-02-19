using UnityEngine;

public class IslandGO : MonoBehaviour
{
    private float SzypkoscIsland = 8;

    // Update is called once per frame
    void Update()
    {
        float posz = transform.position.z;
        transform.Translate(Vector3.forward * SzypkoscIsland * Time.deltaTime, Space.World);
        //Debug.Log(transform.position);

        if (posz > 3.82 )//3.82
        {
            SzypkoscIsland = -8;
        }
         if(posz <  -8 )//-8
        {
            SzypkoscIsland = 8;
        }
    }
}
