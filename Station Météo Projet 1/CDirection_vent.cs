using System;
using Microsoft.SPOT;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace Station_Météo_Projet_1
{
    class CDirection_vent
    {
        private AnalogInput wind_direction;
        private int read;
        public CDirection_vent()
        {
            wind_direction = new AnalogInput(Pins.GPIO_PIN_A1);
            wind_direction.SetRange(0, 360);
        }

        public string ReadWindDirection()
        {
            read = wind_direction.Read();
            if(read>=349 && read >=360 || read>=0 && read <=11 )
                return ("NORD " + wind_direction.Read().ToString());

            else if (read >= 12 && read <= 33)
                return ("NORD-NORD-EST " + wind_direction.Read().ToString());

            else if (read >= 34 && read <= 56)
                return ("NORD-EST " + wind_direction.Read().ToString());

            else if (read >= 57 && read <= 78)
                return ("EST-NORD-EST " + wind_direction.Read().ToString());

            else if (read >= 79 && read <= 101)
                return ("EST " + wind_direction.Read().ToString());

            else if (read >= 102 && read <= 123)
                return ("EST-SUD-EST " + wind_direction.Read().ToString());

            else if (read >= 124 && read <= 146)
                return ("SUD-EST " + wind_direction.Read().ToString());

            else if (read >= 147 && read <= 168)
                return ("SUD-SUD-EST " + wind_direction.Read().ToString());

            else if (read >= 169 && read <= 191)
                return ("SUD " + wind_direction.Read().ToString());

            else if (read >= 192 && read <= 213)
                return ("SUD-SUD-OUEST " + wind_direction.Read().ToString());

            else if (read >= 214 && read <= 236)
                return ("OUEST-SUD-OUEST " + wind_direction.Read().ToString());

            else if (read >= 237 && read <= 258)
                return ("SUD-OUEST " + wind_direction.Read().ToString());

            else if (read >= 259 && read <= 281)
                return ("OUEST " + wind_direction.Read().ToString());

            else if (read >= 282 && read <= 303)
                return ("OUEST-NORD-OUEST " + wind_direction.Read().ToString());

            else if (read >= 304 && read <= 326)
                return ("NORD-OUEST " + wind_direction.Read().ToString());

            else if (read >= 327 && read <= 348)
                return ("NORD-NORD-OUEST " + wind_direction.Read().ToString());

            else
                return wind_direction.Read().ToString();
        }
    }
}
////Capteur boussole : Code de Debug

//AnalogInput windSense = new AnalogInput(Pins.GPIO_PIN_A1);
//windSense.SetRange(0,360);
//while (true)
//{
//    Debug.Print(windSense.Read().ToString());
//    Thread.Sleep(1000);
//}