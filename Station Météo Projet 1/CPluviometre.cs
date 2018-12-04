using System;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace Station_Météo_Projet_1
{
    class CPluviometre
    {
        private InputPort capteur;
        private int quantitee = 0;
        public CPluviometre()
        {
            capteur = new InputPort(Pins.GPIO_PIN_D0, false, Port.ResistorMode.PullDown);
        }
        public int ReadPluviometre()
        {
            if (capteur.Read() == true)
            {
                quantitee++;
            }
            return quantitee;
        }
    }
}
////Pluviometre : Code de Debug
//InputPort pluviometre = new InputPort(Pins.GPIO_PIN_D0, false, Port.ResistorMode.PullDown);
//while (true)
//{
//    if (pluviometre.Read() == true)
//    {
//        Debug.Print("test true");
//    }
//    else
//    {
//        Debug.Print("test false");
//    }
//    Thread.Sleep(500);
//}