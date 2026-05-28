using UnityEngine;

public class MatrixTest : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Matrix4x4 worldMatrix = transform.localToWorldMatrix;

        Vector3 localPos = new Vector3(2f, 0, 0);

        Vector3 worldPos = worldMatrix.MultiplyPoint3x4(localPos);

        Gizmos.color = Color.yellow;

        Gizmos.DrawLine(transform.position, worldPos);

        Gizmos.DrawSphere(worldPos, 0.1f);

        //Debug.Log($"로컬 (2, 0, 0) -> 월드 ({worldPos})");
    }

}
