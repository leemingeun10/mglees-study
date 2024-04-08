using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makewall : MonoBehaviour
{
    // Start is called before the first frame update
    // 임의로 설정된 천장 높이
    public float ceilingHeight;  // 천장 높이 
    public float xpos,ypos,zpos;  // 좌표정보(시작지점)
    public float rm_width, rm_height;  // 방의 넓이 
   

    void Start()
    {
        
        BuildRoom(rm_width, rm_height, new Vector3(xpos, ypos, zpos)); // 방의 너비, 길이 및 시작 위치
    }


    // 방을 만드는 함수
    void BuildRoom(float width, float length, Vector3 startPosition)
    {
        // 방 생성
        CreateWall(new Vector3(startPosition.x+length/2, ceilingHeight / 2, startPosition.z), new Vector3(length, ceilingHeight, 0.1f)); // 앞 벽
        CreateWall(new Vector3(startPosition.x + length / 2, ceilingHeight / 2, startPosition.z + width), new Vector3(length, ceilingHeight, 0.1f)) ; // 뒤 벽
        CreateWall(new Vector3(startPosition.x, ceilingHeight / 2, startPosition.z+width/2), new Vector3(0.1f, ceilingHeight, width)); // 왼쪽 벽
        CreateWall(new Vector3(startPosition.x + length, ceilingHeight / 2, startPosition.z + width / 2), new Vector3(0.1f, ceilingHeight, width)); // 오른쪽 벽
        // 방의 4분면생성완료 

        //바닥생성
        CreateWall(new Vector3((startPosition.x + length)/2, 0, (startPosition.z + width )/ 2), new Vector3(length, 0.1f, width)); // 바닥
    }

    // 큐브형 생성 함수 
    void CreateWall(Vector3 position, Vector3 size)
    {
        // 벽 및 바닥 생성
        GameObject wall = GameObject.CreatePrimitive(PrimitiveType.Cube); // 
        wall.transform.position = position;
        wall.transform.localScale = size;
    }

    

}
