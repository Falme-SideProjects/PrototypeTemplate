using UnityEngine;

public class Utils
{
    public static Vector3 GetCenteredMapPosition(Vector2 gridPosition, Vector2 mapSize, Vector2 tileSize)
    {
        float tileX = (mapSize.x / 2) - (tileSize.x / 2);
		float tileY = (mapSize.y / 2) - (tileSize.y / 2);

        return new Vector3((gridPosition.x - tileX)*1f, (gridPosition.y - tileY)*1f, 0f);
    }
}
