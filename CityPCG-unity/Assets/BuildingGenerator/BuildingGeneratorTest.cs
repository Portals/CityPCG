using System.Collections.Generic;
using UnityEngine;

public class BuildingGeneratorTest : MonoBehaviour {

    public List<Vector2> vertices;
    public BuildingGenerator buildingGenerator;

    public void Start() {
        buildingGenerator.Generate(new Plot(vertices));
    }
}
