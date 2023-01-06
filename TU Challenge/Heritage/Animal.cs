namespace TU_Challenge.Heritage
{

    public class Animal
    {
        public enum AnimalState { Hungry, Fed, AteBubulle }

        protected int _pattes;
        string _name;
        bool _isAlive;
        AnimalState _fed;

        public virtual int Pattes 
        { 
            get => _pattes; 
            private set => _pattes = value; 
        }
        public virtual string Name { get => _name; private set => _name = value; }

        public bool IsAlive { get => _isAlive; private set => _isAlive = value; }
        public AnimalState Fed { get => _fed; protected set => _fed = value; }

        //public event Action OnDie;

        public Animal(string name)
        {
            _name = name;
            IsAlive = true;
            _fed = AnimalState.Hungry;
        }

        public virtual string Crier()
        {
            return "";
        }

        public void Die()
        {
            IsAlive = false;

            //OnDie?.Invoke();
            // Equivalent
            //if(OnDie != null)
            //{
            //    OnDie.Invoke();
            //}
        }

        public void Feed()
        {
            _fed =  AnimalState.Fed;
        }

        public virtual void ArriveInPetShop(Animalerie master)
        {
            
        }

    }
}
