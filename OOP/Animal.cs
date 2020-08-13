using System;

namespace OOP
{
    partial class Program
    {
        class Animal
        {
            //attributes
            private int _numberOfFeet;
            private bool _isMammal;
            private string _name;

            //setters
            public void SetNumberOfFeet(int nr)
            {
                if (nr >= 0)
                    _numberOfFeet = nr;
                else
                    Console.WriteLine("The number of feet has to be greater or equal to 0.");
            }

            public void SetMammalProperty(bool isMammal)
            {
                _isMammal = isMammal;
            }

            public void SetName(string name)
            {
                _name = name;
            }

            //getters
            public int GetNumberOfFeet()
            {
                return _numberOfFeet;
            }

            public bool GetMammalProperty()
            {
                return _isMammal;
            }
            
            public string GetName()
            {
                return _name;
            }


            //other methods
            public void Name()
            {
                if (_isMammal == true)
                    Console.WriteLine("{0} is a mammal", _name);
                else
                    Console.WriteLine("{0} is an animal", _name);
            }
        }
    }
}
