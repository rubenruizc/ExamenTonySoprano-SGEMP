using ENT;

namespace DAL
{
    public class clsListadoDAL
    {
        private static List<clsMision> misiones = new List<clsMision>{

            new clsMision(1,"Recoger impuestos en el restaurante",1),
            new clsMision(2,"Hacer una oferta que no puedan rechazar al sindicato de basura",2),
            new clsMision(3,"Supervisar obras en New Jersey",3),
            new clsMision(4,"Convencer a Concejal de urbanismo para conseguir favores",4),
            new clsMision(5,"Encargarse del concejal de urbanismo que no se dejó convencer",5),
            new clsMision(6,"Llevar la contabilidad del Bada Bing",1),
        };

        private static List<clsCandidatos> candidatos = new List<clsCandidatos> {

            new clsCandidatos(1,"Vito","Gordon","Pizza Street,1232","USA",54567686,63,2500),
            new clsCandidatos(2,"Christopher","Moltisanti","St Monti Av","USA",56876546,24,1500),
            new clsCandidatos(3,"Braulia","Galliani","Brooklyn Av","USA",65679321,26,1500),
            new clsCandidatos(4,"Paulie","Gualtieri","Soprano Street,5","USA",65783287,56,2000),
            new clsCandidatos(5,"Estas","Caputo","Vía Bonna Sera,14","Italia",65434567,51,20000),
            new clsCandidatos(6,"Toco","L'Acordeone","Via Música,20","Italia",6787654,40,14000),
            new clsCandidatos(7,"Luigi","Peperoni","Piaza Roma,3","Italia",56767665,25,16000),
            new clsCandidatos(8,"Silvio","Dante","Town Street,56","USA",87676765,58,2000)

        };

        /// <summary>
        /// Función que obtiene una lista de misiones
        /// Pre: Ninguna
        /// Post: Ninguna
        /// </summary>
        /// <returns>Listado de misiones</returns>
        public static List<clsMision> obtenerMisiones()
        {
            return misiones;
        }

        /// <summary>
        /// Función que obtiene una lista de candidatos
        /// Pre: Ninguna
        /// Post: Ninguna
        /// </summary>
        /// <returns>Listado de candidatos</returns>
        public static List<clsCandidatos> obtenerCandidatos()
        {
            return candidatos;
        }

        /// <summary>
        /// Función que busca una misión por su id
        /// Pre: El id debe ser mayor que 0
        /// Post: Puede devolver null si no encuentra una misión con ese id
        /// </summary>
        /// <param name="id">Id de la misión a buscar</param>
        /// <returns>Mision</returns>
        public static clsMision? buscarMisionPorId(int id)
        {
            clsMision mision = null;

            mision = misiones.Find(mision => mision.Id == id);

            return mision;
        }

        /// <summary>
        /// Función que busca un candidato por su id
        /// Pre: El id debe ser mayor que 0
        /// Post: Puede devolver null si no encuentra un candidato con ese id
        /// </summary>
        /// <param name="id">Id del candidato a buscar</param>
        /// <returns>Candidato</returns>
        public static clsCandidatos? buscarCandidatonPorId(int id)
        {
            clsCandidatos candidato = null;

            candidato = candidatos.Find(candidato => candidato.Id == id);

            return candidato;
        }


    }
}