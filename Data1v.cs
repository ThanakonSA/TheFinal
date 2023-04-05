using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinal
{
    public class Data1v
    {
        private string _Name;
        private string _Occupation;
        private double _Birthyear;
        private double _Income;
        private double _Days;
        private string _Gender;
        private string _IDCard;
        private string _Nationality;

        public Data1v(String _Name, String _Occupation, double _Birthyear, double _Income, double _Days, String _Gender, String _IDCard,
        String _Nationality)
        {
            this._Name = _Name;
            this._Occupation = _Occupation;
            this._Birthyear = _Birthyear;
            this._Income = _Income;
            this._Days = _Days;
            this._Gender = _Gender;
            this._IDCard = _IDCard;
            this._Nationality = _Nationality;
        }


        public string Name
        {
            get { return _Name; }
        }
        public string Gradeuate
        { 
            get { return _Occupation; }
        }
        public double Birthyear
        { 
            get { return _Birthyear; }
        }
        public double Income
        { 
            get { return _Income; } 
        }
        public double Weigh
        { 
            get { return _Days; }
        }
        public string Gender
        { 
            get { return _Gender; }
        }
        public string IDCard
        { 
            get { return _IDCard; }
        }
        public string Nationality
        { 
            get { return _Nationality; }
        }

    }

}
