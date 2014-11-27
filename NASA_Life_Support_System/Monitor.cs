using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASA_Life_Support_System
{
    public interface Monitor
    {

     /*   String currentState;    // Current State
        double heightenedTime;	// Time in Heightened State
        double targetLevel;
     */
        void init();
        double getCurrentSensorValue();		// Getting sensor values
        void setCurrentSensorValue(Sensor sensor);
        void setAverageValue();                   // Gets average of 10
        double getAverageValue();                   // returns the average value
        void setTargetLevel(double target);		// Overriding to specific PSI value
        double getTargetLevel();		// Getting PSI target value
        String checkState();		// Compare and decide state	- Moving Second Average
        void setState(String state);			// Changing current state normally
        void overrideState(String newState);			// User overriding state manually
        String getState();			// Get state value
        void lowPowerState();			// Power is low
        void regularState();			// Normal
        void heightenedState();		// Not a huge issue
        void emergencyState();		// Alert 
        String returnName();
        Boolean isSetTarget();
        void setLowPower();
        double getMin();
        double getMax();
    }
}
