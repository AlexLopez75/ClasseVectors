using UnityEngine;

[CreateAssetMenu(fileName = "TestSO", menuName = "ScriptableObjects/TestOS")]
public class ScriptableTest : ScriptableObject
{
    public string enemyName;
    public int maxHealth;
    public float speed;
    public int damage;
    public Color color;
}
