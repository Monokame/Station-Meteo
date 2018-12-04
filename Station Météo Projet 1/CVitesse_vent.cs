using System;
using Microsoft.SPOT;
using SecretLabs.NETMF.Hardware.Netduino;
using SecretLabs.NETMF.Hardware;

namespace Station_Météo_Projet_1
{
    class CVitesse_vent
    {
        private AnalogInput windspeed;
        public CVitesse_vent()
        {
            windspeed = new AnalogInput(Pins.GPIO_PIN_A0);
        }
        public string ReadWindSpeed()
        {
            return windspeed.Read().ToString();
        }
    }
}
////Capteur vitesse : Code de Debug
//AnalogInput windSpeed = new AnalogInput(Pins.GPIO_PIN_A0);
//while (true)
//{
//    Debug.Print(windSpeed.Read().ToString());
//    Thread.Sleep(1000);
//}