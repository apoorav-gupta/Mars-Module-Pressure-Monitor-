using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NASA_Life_Support_System
{
    class NitrogenMonitor : Monitor
    {

        String currentState;    // Current State
        double heightenedTime;	// Time in Heightened State
        double targetLevel;
        Queue sensorValues;
        private double currentSensorValue = 0;
        private double averageValue, min, max;
        Boolean mainSystem, targetSet, overRide;
        Boolean backupSystem;
        String backupSystemName = "Nitrogen Gas Canisters";
        String mainSystemName = "Hydrazine System";

        public NitrogenMonitor()
        {
            init();
          
        }

        public void init()
        {
            setState("regular");
            heightenedTime = 0;
            sensorValues = new Queue(10);
            averageValue = 0;
            min = 11.07;
            max = 11.62;


        }

        public Boolean getBackup()
        {
            return backupSystem;
        }

        public Boolean getMain()
        {
            return mainSystem;
        }

        public String getBackupName()
        {
            return backupSystemName;
        }

        public String getMainName()
        {
            return mainSystemName;
        }

        public void setState(String state)
        {
            currentState = state;
        }

        public String returnName()
        {
            return "Nitrogen";
        }

        public string getState()
        {
            return currentState;
        }

        public void setAverageValue()
        {
            if (sensorValues.Count < 10)
                sensorValues.Enqueue(currentSensorValue);
            else
            {
                sensorValues.Dequeue();
                sensorValues.Enqueue(currentSensorValue);
            }

            averageValue = 0;
            for (int i = 0; i < sensorValues.Count; i++)
            {
                averageValue = averageValue + Convert.ToDouble( sensorValues.ToArray()[i]);
            }
            averageValue = averageValue / sensorValues.Count;
            
        }   // Average value calculated using past 10

        public double getAverageValue()
        {
            return averageValue;
        }   // Returns average value

        public double getCurrentSensorValue()
        {
            return currentSensorValue;
        }   // Gets current values from sensor

        public void setCurrentSensorValue(Sensor sensor)
        {
            currentSensorValue = sensor.getValue();
        }

        public void setTargetLevel(double target)
        {
            if (target >= min && target <= max)
            {
                targetLevel = target;
                targetSet = true;
            }
            else
            {
                throw new System.ApplicationException("Invalid Target Level");


            }
        }   // Sets the target level for PSI
        public double getTargetLevel()
        {
            return targetLevel;
        }       // Gets target level from PSI

        public Boolean isSetTarget()
        {
            return targetSet;
        }

        public void checkAvgLevel()
        {
            if (Math.Abs(currentSensorValue - targetLevel) <= 0.04)
            {
                targetSet = false;
            }
        }

        public String checkState()
        {
            if (heightenedTime == 20 || currentState == "emergency")        // 10 seconds
                currentState = "emergency";


            else if (averageValue >= min && averageValue <= max)
            {
                currentState = "regular";
            }

            else if ((averageValue >= (min - 2.07) && averageValue < min) || (averageValue > max && averageValue <= (max+2.8)))
            {
                currentState = "heightened";
            }
            else
            {
                currentState = "emergency";
            }
           
            return currentState;
        }

        public double getMin()
        {
            return min;
        }

        public double getMax()
        {
            return max;
        }

        public void update(Sensor sensor)
        {

            setCurrentSensorValue(sensor);
            setAverageValue();
            if (overRide == false)
            {
                currentState = checkState();
            }
            else{
                overrideState("heightened");
            }
            if (targetSet == true)
            {
                checkAvgLevel();
            }
            switch (currentState)       // Goes into the proper state
            {
                case "regular":
                    regularState();
                    break;
                case "heightened":
                    heightenedState();
                    break;
                case "emergency":
                    emergencyState();
                    break;
                case "lowPower":
                    lowPowerState();
                    break;
                default:
                    emergencyState();
                    break;
            }

        }

        public void overrideState(string newState)
        {
            currentState = newState;
            overRide = true;
            if (Math.Abs(averageValue - max) < 0.1)
            {
                overRide = false;
            }
            if (Math.Abs(averageValue - min) < 0.1)
            {
                overRide = false;
                currentState = "regular";
            }

        }

        public void lowPowerState()
        {
            heightenedTime = 0;

        }

        public void setLowPower()
        {
            min = 3;
            max = 8;
            overRide = true;
        }

        public void regularState()
        {
            heightenedTime = 0;
            mainSystem = true;
            backupSystem = false;
        }

        public void heightenedState()
        {
            heightenedTime++;
            mainSystem = true;
            backupSystem = true;
        }

        public void emergencyState()
        {
            //heightenedTime = 0;
            mainSystem = true;
            backupSystem = false;
        }
    

    }
}
