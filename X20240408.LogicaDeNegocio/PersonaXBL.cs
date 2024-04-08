

using X20240408.AccesoADatos;
using X20240408.EntidadesDeNegocio;

namespace X20240408.LogicaDeNegocio
{
    public class PersonaXBL
    {
        readonly PersonaXDAL _personaXDAL;
        public PersonaXBL(PersonaXDAL personaXDAL)
        {
            _personaXDAL = personaXDAL;
        }

        public async Task<int> Crear(PersonaX personax)
        {
            return await _personaXDAL.Crear(personax);
        }
        public async Task<int> Modificar(PersonaX personaX)
        {
            return await _personaXDAL.Modificar(personaX);
        }
        public async Task<int> Eliminar(PersonaX personaX)
        {
            return await _personaXDAL.Eliminar(personaX);
        }
        public async Task<PersonaX> ObtenerPorId(PersonaX personaX)
        {
            return await _personaXDAL.ObtenerPorId(personaX);
        }
        public async Task<List<PersonaX>> ObtenerTodos()
        {
            return await _personaXDAL.ObtenerTodos();
        }
        public async Task<List<PersonaX>> Buscar(PersonaX personaX)
        {
            return await _personaXDAL.Buscar(personaX);
        }


    }
}
