using UnityEngine;

public class RoomManager : MonoBehaviour
{
    [SerializeField] private TableLayoutData tableLayout; //Ref zu TableLayout ScriptableObject
    [SerializeField] private StudentLayoutData[] students; //
    [SerializeField] private GameObject tablePrefab; //Prefab für Tisch
    [SerializeField] private GameObject chairPrefab;
    [SerializeField] private GameObject Human;
    
    private int currentStudentIndex = 0;

    void Start()
    {
        for (int row = 0; row < tableLayout.rows; row++)
        {
            for (int col = 0; col < tableLayout.columns; col++)
            {
                Vector3 tablePosition = new Vector3(col * tableLayout.tableSpacing, 0, row * tableLayout.tableSpacing);
                GameObject table = Instantiate(tablePrefab, tablePosition, Quaternion.identity, transform);

                Transform pos1 = table.transform.Find("pos1");
                Transform pos2 = table.transform.Find("pos2");
                Transform pos3 = table.transform.Find("pos3");
                Transform pos4 = table.transform.Find("pos4");
                if (pos1)
                {
                    Instantiate(chairPrefab, pos1.position, pos1.rotation, table.transform);
                }

                if (pos2)
                {
                    Instantiate(chairPrefab, pos2.position, pos2.rotation, table.transform);
                }
                
                if (pos3)
                {
                    Quaternion adjustedRotation = pos3.rotation * Quaternion.Euler(0, 90, 0);
                    GameObject human = Instantiate(Human, pos3.position, adjustedRotation, table.transform);
                    human.name = GetNextStudentName(); // Nächster Schülername
                }
 
                if (pos4)
                {
                    Quaternion adjustedRotation = pos4.rotation * Quaternion.Euler(0, 90, 0);
                    GameObject human = Instantiate(Human, pos4.position, adjustedRotation, table.transform);
                    human.name = GetNextStudentName(); // Nächster Schülername
                }
            }
        }
    }
    private string GetNextStudentName()
    {
        // Hole den aktuellen Schülernamen
        string studentName = students[currentStudentIndex].name;
 
        // Erhöhe den Index für den nächsten Aufruf
        currentStudentIndex = (currentStudentIndex + 1) % students.Length; // Zyklisch
 
        if (currentStudentIndex > 18){
            return Human.name = "Human";
        }
 
        return studentName;
    }

}
