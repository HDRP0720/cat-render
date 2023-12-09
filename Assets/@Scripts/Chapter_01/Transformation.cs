using UnityEngine;

namespace Chapter_01
{
  public abstract class Transformation : MonoBehaviour
  {
    public abstract Matrix4x4 Matrix { get; }
  }
}


