using System;
using System.Collections.Generic;

namespace ClassyElectronics
{
    class Program
    {
        static void Main(string[] args)
        {   
            Radionator1000 radio1 = new Radionator1000();
            Radionator1000 radio2 = new Radionator1000();

            // Using interfaces, any type that uses the IRadio interface can be added to the list
            List<IRadio> iradioList = new List<IRadio>() {
                radio1, radio2
            };

            TestRadios(iradioList);
            AllInOneTable turnTable1 = new AllInOneTable();
            TurnRadio1000 turnTable2 = new TurnRadio1000();

            List<ITurnTable> turnTables = new List<ITurnTable>()
            {
                turnTable1, turnTable2
            };

            TestTurnTables(turnTables);
        }

        static void TestRadios(List<IRadio> radios)
        {
            foreach(IRadio radio in radios)
            {
                radio.TurnRadioOn();
                radio.TurnRadioOff();
            }
        }

        static void TestTurnTables(List<ITurnTable> turnTables)
        {
            foreach(ITurnTable turnTable in turnTables)
            {
                turnTable.Play();
                turnTable.Stop();
            }
        }
    }
}
