using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Student : Person
    {
        public Student(string Name,string Surname,int Age,int IQRank,int LanguageRank)
        {
            this._name = Name;
             this._surName = Surname;
             this._age = Age;
              this._iqrank = IQRank;
            this._languagerank = LanguageRank;

        }
        private int _iqrank;
        private int _languagerank;
        public int IQRank
        {
            get
            {
                return this._iqrank;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    this._iqrank = value;
                }
            }
        }
        public int LanguageRank
        {
            get
            {
                return this._languagerank;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    this._languagerank = value;
                }
            }
        }
        public void ExamResult()
        {
            int result = IQRank + LanguageRank;
            if (IQRank + LanguageRank > 120)
            {
                Console.WriteLine("You are success");
            }
            else
            {
                Console.WriteLine("You are fail");
            }

        }
    }
}
