namespace ADog
{
    public class Dog
    {
        int age;
        float height;
        float length;
        bool generder;
        string nickName;
        bool hungry;
        float energy;


        public Dog(int _age, float _height, float _length, bool _gender, string _nickName)
        {
            age = _age;
            height = _height;
            length = _length;
            generder = _gender;
            nickName = _nickName;
            hungry = true;
            energy = 100;
        }

        public void DayInLife()
        {
            Ageing();
            Eating();
            Sleeping();
            Walking();
        }

        public string GetNickName()
        {
            return nickName;
        }


        private void Ageing()
        {
            age = age + 1;
            energy = energy - 1;
        }

        public void Eating()
        {
            hungry = false;
            energy = energy - 1;
        }

        private void Sleeping()
        {
            hungry = true;
            energy = energy + 1;
        }

        private void Walking()
        {
            hungry = true;
            energy = energy - 1;
        }

    }
}