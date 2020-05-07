using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningChallenges
{
    //Make a class for a water bottle, have it have at least 3 properties. -> bonus: add another property but have it be an enum.
    public enum WaterBottleBrand { Dasani, Nestle, Aquafina, Evian, Fiji, Voss, IceMountain, DeerPark, }
    public class WaterBottle
    {
        public int Quant { get; set; }
        public decimal Height { get; set; }
        public string Color { get; set; }
        public bool IsGood
        {
            get
            {
                if (Color == "Purple")
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
        public WaterBottleBrand BrandOfBottle { get; set; }

        public WaterBottle() { }
        public WaterBottle(int quant, decimal height, string color, bool isGood, WaterBottleBrand brand)
        {
            Quant = quant;
            Height = height;
            Color = color;
            BrandOfBottle = brand;
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void BottlePropertyTest()
        {
            WaterBottle firstBottle = new WaterBottle();

            firstBottle.Quant = 150;
            firstBottle.Height = 10.55m;
            firstBottle.Color = "blue-green";
            firstBottle.BrandOfBottle = WaterBottleBrand.Dasani;
        }
    }
}
