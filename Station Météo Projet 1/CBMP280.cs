using System;
using Microsoft.SPOT;
using Netduino.Foundation.Sensors.Atmospheric;


namespace Station_Météo_Projet_1
{
    class CBMP280//Capteur de pression atmospherique et de temperature.
    {
        private BME280 BMP280;//Utilisation de la classe BME280 car pris en charge par NetduinoFondation
        private string message;
        public CBMP280()
        {
            BMP280 = new BME280(address: 0x76, updateInterval: 0);
            //Appel du constructeur en lui passant en parametre :
            //-l'adresse I2C 
            //-La fréquence pour que le capteur soit en position de lecture. 
        }
        public string CBMP280Read()
        {
            BMP280.Update();//On met le capteur a jour
            message = "Temperature: " + BMP280.Temperature.ToString("F1") + " C\n";
            //On lis la valeur du capteur et on la stock dasn une variable
            message += "Pression: " + (BMP280.Pressure / 100).ToString("F0") + " hPa\n\n";
            //
            return message;
        }
    }
}
/*************************Test Unitaire*************************/
////BMP280
//BME280 sensor = new BME280(address:0x76,updateInterval: 0);
//string message;
//while (true)
//{
//    sensor.Update();
//    message = "Temperature: " + sensor.Temperature.ToString("F1") + " C\n";
//    message += "Pressure: " + (sensor.Pressure / 100).ToString("F0") + " hPa\n\n";
//    Debug.Print(message);
//    Thread.Sleep(1000);
//}