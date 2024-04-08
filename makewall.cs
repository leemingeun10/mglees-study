using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makewall : MonoBehaviour
{
    // Start is called before the first frame update
    // ���Ƿ� ������ õ�� ����
    public float ceilingHeight;  // õ�� ���� 
    public float xpos,ypos,zpos;  // ��ǥ����(��������)
    public float rm_width, rm_height;  // ���� ���� 
   

    void Start()
    {
        
        BuildRoom(rm_width, rm_height, new Vector3(xpos, ypos, zpos)); // ���� �ʺ�, ���� �� ���� ��ġ
    }


    // ���� ����� �Լ�
    void BuildRoom(float width, float length, Vector3 startPosition)
    {
        // �� ����
        CreateWall(new Vector3(startPosition.x+length/2, ceilingHeight / 2, startPosition.z), new Vector3(length, ceilingHeight, 0.1f)); // �� ��
        CreateWall(new Vector3(startPosition.x + length / 2, ceilingHeight / 2, startPosition.z + width), new Vector3(length, ceilingHeight, 0.1f)) ; // �� ��
        CreateWall(new Vector3(startPosition.x, ceilingHeight / 2, startPosition.z+width/2), new Vector3(0.1f, ceilingHeight, width)); // ���� ��
        CreateWall(new Vector3(startPosition.x + length, ceilingHeight / 2, startPosition.z + width / 2), new Vector3(0.1f, ceilingHeight, width)); // ������ ��
        // ���� 4�и�����Ϸ� 

        //�ٴڻ���
        CreateWall(new Vector3((startPosition.x + length)/2, 0, (startPosition.z + width )/ 2), new Vector3(length, 0.1f, width)); // �ٴ�
    }

    // ť���� ���� �Լ� 
    void CreateWall(Vector3 position, Vector3 size)
    {
        // �� �� �ٴ� ����
        GameObject wall = GameObject.CreatePrimitive(PrimitiveType.Cube); // 
        wall.transform.position = position;
        wall.transform.localScale = size;
    }

    

}
