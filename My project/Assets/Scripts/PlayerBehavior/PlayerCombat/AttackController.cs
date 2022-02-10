using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    
    public Transform attackPoint;

    public Transform meleeWeaponPosition;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    void Update(){

    }

    private void performSwingProcedure(){
        int MouseButtonInput = getBaseInputForMouse();
    
        if(MouseButtonInput == 0){
           //
        }
        if(MouseButtonInput == 1){
            //Do Nothing
        }
    }

    private int getBaseInputForMouse() {
        if(Input.GetKey(KeyCode.Mouse0)){
            return 0;
        }
        if(Input.GetKey(KeyCode.Mouse1)){
            return 1;
        }
        return -1;
    }

    public void attack(){
            Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);
            foreach(Collider enemy in hitEnemies){
                print("We hit" + enemy.name);
                Destroy(enemy.gameObject);
            }
    } 

     
}