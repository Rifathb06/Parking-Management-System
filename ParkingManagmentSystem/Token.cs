using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagmentSystem
{
    public class Token
    {
        public string TokenID;
        public float Price;
        float Duration;
        public int Slot;

        public Token()
        {

        }

        public Token(string tokenID, int slot, float Price, float Duration)
        {
            this.TokenID = tokenID;
            this.Slot = slot;
            this.Price = Price;
            this.Duration = Duration;
        }
        public string TokenID1 { get => TokenID; set => TokenID = value; }
        public float Price1 { get => Price; set => Price = value; }
        public float Duration1 { get => Duration; set => Duration = value; }
        public int Slot1 { get => Slot; set => Slot = value; }

        public void PriceOperation(float duration)
        {
            Price = duration * 150;


        }

        public void Show()
        {
            // Token display can be implemented here if needed
        }

    }
}
