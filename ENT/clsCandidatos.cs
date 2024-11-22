namespace ENT
{
    public class clsCandidatos
    {
        #region Atributos

        private int id;

        private string nombre;

        private string apellidos;

        private string direccion;

        private string pais;

        private int telefono;

        private int edad;

        private int precioMedio;

        #endregion

        #region Propiedades

        public int Id
        {
            get => id;
            set
            {
                if (value > 0)
                {
                    id = value;
                }
            }
        }

        public string Nombre
        {
            get => nombre;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    nombre = value;
                }
            }
        }

        public string Apellidos
        {
            get => apellidos;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    apellidos = value;
                }
            }
        }

        public string Direccion
        {
            get => direccion;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    direccion = value;
                }
            }
        }

        public string Pais
        {
            get => pais;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    pais = value;
                }
            }
        }

        public int Telefono
        {
            get => telefono;
            set
            {
                if (value > 9999999 && value < 99999999){
                    telefono = value;
                }
            }
        }

        public int Edad
        {
            get => edad;
            set
            {
                if (edad > 0)
                {
                    edad = value;
                }
            }
        }

        public int PrecioMedio
        {
            get => precioMedio;
            set
            {
                if (value > 0)
                {
                    precioMedio = value;
                }
            }
        }

        #endregion

        #region Constructores

        public clsCandidatos()
        {

        }

        public clsCandidatos(int id, string nombre, string apellidos, string direccion, string pais, int telefono, int edad, int precioMedio)
        {
            if (id > 0)
            {
                this.id = id;
            }

            if (!string.IsNullOrEmpty(nombre))
            {
                this.nombre = nombre;
            }

            if (!string.IsNullOrEmpty(apellidos))
            {
                this.apellidos = apellidos;
            }

            if (!string.IsNullOrEmpty(direccion))
            {
                this.direccion = direccion;
            }

            if (!string.IsNullOrEmpty(pais))
            {
                this.pais = pais;
            }

            if (telefono > 9999999 && telefono < 99999999)
            {
                this.telefono = telefono;
            }

            if (edad > 0)
            {
                this.edad = edad;
            }

            if(precioMedio > 0)
            {
                this.precioMedio = precioMedio;
            }
        }

        #endregion

    }
}
