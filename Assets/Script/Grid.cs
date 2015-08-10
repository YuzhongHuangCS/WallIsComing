using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class Grid : MonoBehaviour {
	
	public int xSize, ySize;
	
	private Vector3[] vertices;
	private Mesh mesh;
	private Vector3 src;
	
	private void Awake () {
		Generate();
	}
	
	public void Start () {
		GetComponent<MeshCollider>().sharedMesh = mesh;
	}
	
	public void Update () {
		if (Input.GetMouseButtonDown(0)) {
			// begin drag
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			src = ray.origin + ray.direction * (5 / ray.direction.z);
			src.z = 10;
			print("Src");
			print(src);
		} else {
			//render stage
			if (Input.GetMouseButton(0)) {
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				Vector3 dest = ray.origin + ray.direction * (5 / ray.direction.z);
				dest.z = 10;
				//print("Dest");
				//print(dest);

				Vector3 diff = dest - src;

				for (int i = 0; i < vertices.Length; i++) {
					vertices[i] += diff / (1 + (src - vertices[i]).sqrMagnitude); 
				}
				mesh.vertices = vertices;
				src = dest;
				GetComponent<MeshCollider>().sharedMesh = GetComponent<MeshFilter>().mesh;
			}
		}
	}
	
	private void Generate () {
		mesh = GetComponent<MeshFilter>().mesh;
		mesh.name = "Procedural Grid";
		
		vertices = new Vector3[(xSize + 1) * (ySize + 1)];
		for (int i = 0, y = 0; y <= ySize; y++) {
			for (int x = 0; x <= xSize; x++) {
				vertices[i++] = new Vector3(x / 10f + transform.position.x, y / 10f +transform.position.y, 10);
			}
		}
		mesh.vertices = vertices;
		
		int[] triangles = new int[xSize * ySize * 6];
		for (int ti = 0, vi = 0, y = 0; y < ySize; y++, vi++) {
			for (int x = 0; x < xSize; x++, ti += 6, vi++) {
				triangles[ti] = vi;
				triangles[ti + 3] = triangles[ti + 2] = vi + 1;
				triangles[ti + 4] = triangles[ti + 1] = vi + xSize + 1	;
				triangles[ti + 5] = vi + xSize + 2;
			}
		}

		mesh.triangles = triangles;
		mesh.RecalculateNormals();

		Vector3[] normals = mesh.normals;
		for (int i=0;i<normals.Length;i++) {
			normals[i] = -normals[i];
		}
		mesh.normals = normals;

		for (int m = 0; m<mesh.subMeshCount;m++) {
			int[] triangles2 = mesh.GetTriangles(m);
			for (int i=0;i<triangles2.Length;i+=3)
			{
				int temp = triangles[i + 0];
				triangles2[i + 0] = triangles2[i + 1];
				triangles2[i + 1] = temp;
			}
			mesh.SetTriangles(triangles2, m);
		}
	}

}
