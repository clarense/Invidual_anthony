using System;

namespace Expert_SRP
{
    public class Kiosco /*No cumple el SRP y no es expert*/
    {

        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Convertir k = new Convertir();
            Double pesos = k.ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioDulce + a.PrecioMasa;
        }

    }
}