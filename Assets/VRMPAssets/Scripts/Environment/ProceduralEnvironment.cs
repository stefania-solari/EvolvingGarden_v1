using UnityEngine;

namespace XRMultiplayer
{
    /// <summary>
    /// Generates a simple procedural environment based on <see cref="EnvironmentParameters"/>.
    /// </summary>
    public class ProceduralEnvironment : MonoBehaviour
    {
        void Start()
        {
            Generate();
        }

        void Generate()
        {
            float size = EnvironmentParameters.Size;
            int count = EnvironmentParameters.ObjectCount;

            // Create a simple floor
            GameObject floor = GameObject.CreatePrimitive(PrimitiveType.Plane);
            floor.transform.localScale = new Vector3(size / 10f, 1f, size / 10f);

            // Spawn random cubes inside the area
            for (int i = 0; i < count; i++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(
                    Random.Range(-size / 2f, size / 2f),
                    0.5f,
                    Random.Range(-size / 2f, size / 2f));
                cube.AddComponent<SimpleMeshEditor>();
            }
        }
    }
}
