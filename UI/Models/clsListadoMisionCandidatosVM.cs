using BL;
using ENT;

namespace UI.Models
{
    public class clsListadoMisionCandidatosVM : clsMision
    {

        #region Atributos
        private List<clsMision> misiones;
        private List<clsCandidatos> candidatos;
        #endregion

        #region Propiedades
        public List<clsMision> Misiones { get { return misiones; } }
        public List<clsCandidatos> Candidatos { get { return candidatos; } }
        #endregion

        #region Constructores
        public clsListadoMisionCandidatosVM()
        {
            misiones = clsListadoBL.obtenerMisiones();
        }

        public clsListadoMisionCandidatosVM(int id) : this()
        {
            clsMision? mision = clsListadoBL.buscarMisionPorId(id);
            if (mision != null)
            {
                candidatos = clsListadoBL.candidatosValidos(id);
                this.Id = id;
                this.Nombre = mision.Nombre;
                this.Dificultad = mision.Dificultad;
            }
        }
        #endregion
    }
}
