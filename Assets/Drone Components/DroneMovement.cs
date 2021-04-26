using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMI2;
using UnityEngine.InputSystem; 

//Basic test of FMU input and output visualized with Unity.
public class DroneMovement : MonoBehaviour
{
    //Set and expose a targeted gain value for movement
    [SerializeField] float gain = (float)5;

    //Manual set the targetFPS to match the polling rate of the FMU. 
    const int targetFPS = 100;

    //Declare the inputActions and set the initial values of each input direction at zero. 
    DroneController inputActions;
    float left_stick_left, left_stick_right, left_stick_up, left_stick_down, right_stick_up, right_stick_down = 0;
    
    //Initialize an empty fmu object. 
    FMU fmu;

    //Create set vs. recieved gps movement from the fmu. 
    float xcoord, ycoord, zcoord = 0; 
    float xdir, ydir, zdir;


    void Awake()
    {
        //Set the target frame rate. 
        Application.targetFrameRate = targetFPS;
        //Allow controller input to be processed. 
        inputActions = new DroneController();
        OnEnable();
        ProcessInput();
        //Instantiate the FMU
        fmu = new FMU("DroneSimulation_Polling", name);
        fmu.Reset();
        fmu.SetupExperiment(Time.time);
        fmu.EnterInitializationMode();
        fmu.ExitInitializationMode();
    }

    //Read the controller input for each stick value and make sure to reset the value when the stick is "zeroed"
    private void ProcessInput()
    {
        inputActions.Gameplay.X_Neg.performed += ctx => left_stick_left = ctx.ReadValue<float>();
        inputActions.Gameplay.X_Neg.canceled += ctx => left_stick_left = 0;
        inputActions.Gameplay.X_Pos.performed += ctx => left_stick_right = ctx.ReadValue<float>();
        inputActions.Gameplay.X_Pos.canceled += ctx => left_stick_right = 0;
        inputActions.Gameplay.Y_Neg.performed += ctx => left_stick_down = ctx.ReadValue<float>();
        inputActions.Gameplay.X_Neg.canceled += ctx => left_stick_down = 0;
        inputActions.Gameplay.Y_Pos.performed += ctx => left_stick_up = ctx.ReadValue<float>();
        inputActions.Gameplay.Y_Pos.canceled += ctx => left_stick_up = 0;
        inputActions.Gameplay.Z_Pos.performed += ctx => right_stick_up = ctx.ReadValue<float>();
        inputActions.Gameplay.Z_Pos.canceled += ctx => right_stick_up = 0;
        inputActions.Gameplay.Z_Neg.performed += ctx => right_stick_down = ctx.ReadValue<float>();
        inputActions.Gameplay.Z_Neg.canceled += ctx => right_stick_down = 0;
    }

    private void FixedUpdate()
    {
        setCoord();
        //Synchronize the model with the current time
        fmu.DoStep(Time.time, Time.deltaTime);
        //Read FMU outputs of position 
        xdir = (float)fmu.GetReal("xgps");
        ydir = (float)fmu.GetReal("ygps");
        zdir = (float)fmu.GetReal("zgps");
        //Assign gps values to the new transform of object
        transform.position = new Vector3(xdir, ydir, zdir);
    }

    //Function to pass through ideal coordinates
    private void setCoord()
    {
        xcoord -= gain * Time.deltaTime * left_stick_left;
        xcoord += gain * Time.deltaTime * left_stick_right;
        ycoord -= gain * Time.deltaTime * left_stick_down;
        ycoord += gain * Time.deltaTime * left_stick_up;
        zcoord -= gain * Time.deltaTime * right_stick_down;
        zcoord += gain * Time.deltaTime * right_stick_up;
        fmu.SetReal("xcoord", xcoord);
        fmu.SetReal("zcoord", ycoord);
        fmu.SetReal("ycoord", zcoord);
        //Print the currrent ideal gps coordinates. 
        print("X: " + xcoord + " Y: " + ycoord + " Z: " + zcoord);
    }


    //Controller enable
    private void OnEnable()
    {
        inputActions.Gameplay.Enable();
    }

    //Controller disable
    private void OnDisable()
    {
        inputActions.Gameplay.Disable();
    }
    //General clean up
    void OnDestroy()
    {
        fmu.FreeInstance();
        fmu.Dispose();
    }

}
