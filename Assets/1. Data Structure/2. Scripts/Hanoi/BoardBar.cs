using System.Collections.Generic;
using UnityEngine;

public class BoardBar : MonoBehaviour
{
    public enum BarType { Left, Center, Right }
    public BarType barType;
    
    public Stack<GameObject> barStack = new Stack<GameObject>();

    void OnMouseDown()
    {
        if (!HanoiTower.isSelected) // 선택이 안된 상태일 때
        {
            HanoiTower.isSelected = true;
            HanoiTower.selectedDonut = PopDonut();
        }
        else // 선택된 상태일 때
        {
            
            PushDonut(HanoiTower.selectedDonut);
        }
    }


    public bool CheckDonut(GameObject donut)
    {
        if (barStack.Count > 0)
        {
            int pushNumber = donut.GetComponent<Donut>().donutNumber;
            GameObject peekDonut = barStack.Peek();
            int peekNumber = peekDonut.GetComponent<Donut>().donutNumber;
            if (pushNumber < peekNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        
            return true;
        
    }
    
    public void PushDonut(GameObject donut)

    {
        if (!CheckDonut(donut)) return;

            HanoiTower.isSelected = false;
            HanoiTower.selectedDonut = null;

            donut.transform.position = transform.position + Vector3.up * 5f;
            donut.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
            donut.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

            barStack.Push(donut); // Stack에 GameObject를 넣는 기능
        
    }

    public GameObject PopDonut()
    {
        GameObject donut = barStack.Pop(); // Stack에서 GameObject를 꺼내는 기능

        return donut; // 꺼낸 도넛을 반환
    }
}