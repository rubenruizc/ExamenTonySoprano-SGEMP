using DAL;
using ENT;

namespace BL
{
    public class clsListadoBL
    {
        /// <summary>
        /// Función que obtiene una lista de misiones
        /// Pre: Ninguna
        /// Post: Ninguna
        /// </summary>
        /// <returns>Listado de misiones</returns>
        public static List<clsMision> obtenerMisiones()
        {
            return clsListadoDAL.obtenerMisiones();
        }

        /// <summary>
        /// Función que busca una misión por su id
        /// Pre: El id debe ser mayor que 0
        /// Post: Puede devolver null si no encuentra una misión con ese id
        /// </summary>
        /// <param name="id">Id de la misión a buscar</param>
        /// <returns>Mision</returns>
        public static clsMision buscarMisionPorId(int id)
        {
            return clsListadoDAL.buscarMisionPorId(id);
        }

        /// <summary>
        /// Función que obtiene una lista de candidatos
        /// Pre: Ninguna
        /// Post: Ninguna
        /// </summary>
        /// <returns>Listado de candidatos</returns>
        public static List<clsCandidatos> obtenerCandidatos()
        {
            return clsListadoDAL.obtenerCandidatos();
        }

        /// <summary>
        /// Función que busca un candidato por su id
        /// Pre: El id debe ser mayor que 0
        /// Post: Puede devolver null si no encuentra un candidato con ese id
        /// </summary>
        /// <param name="id">Id del candidato a buscar</param>
        /// <returns>Candidato</returns>
        public static clsCandidatos buscarCandidatoPorId(int id)
        {
            return clsListadoDAL.buscarCandidatonPorId(id);
        }


        /// <summary>
        /// Función que busca que candidato es valido dependiendo de la dificultad de la misión
        /// Pre: Ninguna
        /// Post: Puede devolver null si no hay ningún candidato válido para la mision
        /// </summary>
        /// <param name="idMision">Id de la misión</param>
        /// <returns>Lista de candidatos válidos</returns>
        public static List<clsCandidatos> candidatosValidos(int idMision) {

            clsMision mision = buscarMisionPorId(idMision);

            List<clsCandidatos> candidatosValidos = new List<clsCandidatos>();


            if (mision != null)
            {
                if (mision.Dificultad == 1 || mision.Dificultad == 2)
                {
                    candidatosValidos = clsListadoDAL.obtenerCandidatos().Where(can => can.Pais.Contains("USA")).ToList();
                }

                if (mision.Dificultad == 3)
                {
                    candidatosValidos = clsListadoDAL.obtenerCandidatos().Where(can => can.Pais.Contains("USA") && can.Edad >= 40).ToList();
                }

                if (mision.Dificultad == 4)
                {
                    candidatosValidos = clsListadoDAL.obtenerCandidatos().Where(can => can.Pais.Contains("Italia") && can.Edad <= 45).ToList();

                }

                if (mision.Dificultad == 5)
                {

                    candidatosValidos = clsListadoDAL.obtenerCandidatos().Where(can => can.Pais.Contains("Italia") && can.Edad >= 45 && can.Edad <= 55).ToList();
                }
            }
            return candidatosValidos;
        }

    }
}
