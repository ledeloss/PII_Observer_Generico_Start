namespace Observer
{
    //Se agrega el <T> para "pasarle" el tipo generico, ahora la T se utiliza para 
    //Temperature pero se logra generaizar para utilizar cualquier otro objeto.
    public interface IObserver<T>
    {
        void Update (T value);
    }
}