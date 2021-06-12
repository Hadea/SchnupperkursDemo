using UnityEngine;

public static class Vector3Extensions
{
    public static Vector2 ToVector2(this Vector3 source)
    {
        Vector2 result;
        result.x = source.x;
        result.y = source.y;
        return result;
    }
}
