using System;

namespace Dominio
{
    public class Direccion
    {
        private const int PaisLargoMinimo = 3;
        private const int PaisLargoMaximo = 40;
        private const int CiudadLargoMinimo = 3;
        private const int CiudadLargoMaximo = 40;
        private const int CalleLargoMinimo = 3;
        private const int CalleLargoMaximo = 40;

        private string pais;
        private string ciudad;
        private string calle;

        public Direccion()
        {
        }

        public string Pais
        {
            get => pais;
            set
            {
                if (value?.Length < PaisLargoMinimo || value?.Length > PaisLargoMaximo)
                {
                    throw new DireccionException($"El pais tiene que tener entre {PaisLargoMinimo} y {PaisLargoMaximo} caracteres");
                }
                pais = value ?? throw new ArgumentNullException("El pais no puede ser null");
            }
        }

        public string Ciudad
        {
            get => ciudad;
            set
            {
                if (value?.Length < CiudadLargoMinimo || value?.Length > CiudadLargoMaximo)
                {
                    throw new DireccionException($"La ciudad tiene que tener entre {CiudadLargoMinimo} y {CiudadLargoMaximo} caracteres");
                }
                ciudad = value ?? throw new ArgumentNullException("La ciudad no puede ser null"); 
            }
        }

        public string Calle
        {
            get => calle;
            set
            {
                if (value?.Length < CalleLargoMinimo || value?.Length > CalleLargoMaximo)
                {
                    throw new DireccionException($"La calle tiene que tener entre {CalleLargoMinimo} y {CalleLargoMaximo} caracteres");
                }
                calle = value ?? throw new ArgumentNullException("La calle no puede ser null");
            }
        }
    }
}