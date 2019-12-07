using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class SkyDomeMeshInverter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = this.GetComponent<MeshFilter>().mesh;

        for(int i=0;i<mesh.subMeshCount;i++) {
            int[] tris = mesh.GetTriangles(i);
            for(int j=0;j<tris.Length;j+=3) {
                // swap the order of tri-verters
                int temp = tris[j];
                tris[j] = tris[j+1];
                tris[j+1] = temp;
            }

            mesh.SetTriangles(tris, i);
        }

        // mesh.RecalculateNormals();
    }
}
