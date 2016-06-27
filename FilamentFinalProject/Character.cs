using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FilamentFinalProject
{
    class Character
    {

        //class variables
        public String Name = "";
        public String Hair = "";
        public String Clothes = "";
        public String Sex = "";


        public Character(string name, string hair, string clothes, string sex)
        {
            name = this.Name;
            hair = this.Hair;
            clothes = this.Clothes;
            sex = this.Sex;
        }


        public void AboutCharacter()
        {
            string theName = Name;
            string theHair = Hair;
            string theClothes = Clothes;
            string theSex = Sex;

            string allInfo = theName + theHair + theClothes + theSex;
            MessageBox.Show(allInfo);
        }


        public string PrintAboutCharacter()
        {
            String PrintName = Name;
            String PrintHair = Hair;
            String PrintClothes = Clothes;
            String PrintSex = Sex;
            string attributes = PrintName + PrintHair + PrintClothes + PrintSex;
            return attributes;
        }
        

    }
}
