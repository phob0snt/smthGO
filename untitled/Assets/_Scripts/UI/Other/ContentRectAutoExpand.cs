using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class ContentRectAutoExpand : MonoBehaviour
{
    private RectTransform Rect => GetComponent<RectTransform>();
    private const int ROW_HEIGHT = 357;
    public void UpdateRectSize()
    {
        int yCapability = (int)Rect.sizeDelta.y / ROW_HEIGHT;
        Rect.offsetMin = new Vector2(0, -(transform.childCount / 3 - yCapability + 1) * ROW_HEIGHT);
        Debug.Log(Rect.offsetMin);
    }
}
