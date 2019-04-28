namespace Madlibs.Models
{
    public class MadlibVariable
    {
        private string _adj1;
        private string _adj2;
        private string _adj3;
        private string _adj4;
        private string _adj5;
        private string _adj6;
        private string _adj7;
        private string _noun1;
        private string _noun2;
        private string _verb1;
        private string _bodypart1;
        private string _bodypart2;
        private string _object1;

        public string GetAdj1()
        {
            return _adj1;
        }
        public string GetAdj2()
        {
            return _adj2;
        }
        public string GetAdj3()
        {
            return _adj3;
        }
        public string GetAdj4()
        {
            return _adj4;
        }
        public string GetAdj5()
        {
            return _adj5;
        }
        public string GetAdj6()
        {
            return _adj6;
        }
        public string GetAdj7()
        {
            return _adj7;
        }
        public string GetNoun1()
        {
            return _noun1;
        }
        public string GetNoun2()
        {
            return _noun2;
        } 
        public string GetVerb1()
        {
            return _verb1;
        } 
        public string GetBodyPart1()
        {
            return _bodypart1;
        } 
        public string GetBodyPart2()
        {
            return _bodypart2;
        } 
        public string GetObject1()
        {
            return _object1;
        }
        public void SetAdj1(string adj)
        {
            _adj1 = adj;
        }
        public void SetAdj2(string adj)
        {
            _adj2 = adj;
        }
        public void SetAdj3(string adj)
        {
            _adj3 = adj;
        }
        public void SetAdj4(string adj)
        {
            _adj4 = adj;
        }
        public void SetAdj5(string adj)
        {
            _adj5 = adj;
        }
        public void SetAdj6(string adj)
        {
            _adj6 = adj;
        }
        public void SetAdj7(string adj)
        {
            _adj7 = adj;
        }
        public void SetNoun1(string noun)
        {
            _noun1 = noun;
        }
        public void SetNoun2(string noun)
        {
            _noun1 = noun;
        }
        public void SetVerb1(string verb)
        {
            _verb1 = verb;
        }
        public void SetBodyPart1(string bodypart)
        {
            _bodypart1 = bodypart;
        }
        public void SetBodyPart1(string bodypart)
        {
            _bodypart2 = bodypart;
        }
        public void SetObject1(string obj)
        {
            _object1 = obj;
        }
    }    
}