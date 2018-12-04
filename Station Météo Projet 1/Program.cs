using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;
using Station_Météo_Projet_1;

namespace Station_Météo_Projet_1
{
    public class Program
    {
        public static void Main()
        {
            CVitesse_vent windspeed = new CVitesse_vent();          //
            CDirection_vent windDirection = new CDirection_vent();  //Appelle des classes qui gèrent la lecture des capteurs
            CBMP280 bmp280 = new CBMP280();                         // 
            CPluviometre rainmeter = new CPluviometre();            //

            while (true)
            {
                string response = "Vitesse du vent : " + windspeed.ReadWindSpeed() + " m/s\n";
                response += "Orientation du vent : " + windDirection.ReadWindDirection() + "°\n";
                response += "Quantite de pluie : " + rainmeter.ReadPluviometre() + "mm/m²\n";
                response += bmp280.CBMP280Read();
                Debug.Print(response);
                /*Debug.Print("Vitesse du vent : "+windspeed.ReadWindSpeed()+"m/s");
                Debug.Print("Orientation du vent : " + windDirection.ReadWindDirection() + "°");
                Debug.Print("Quantite de pluie : " + rainmeter.ReadPluviometre() + "mm/m²");
                Debug.Print(bmp280.CBMP280Read());
                Thread.Sleep(1000);*/
            }
        }
    }
}