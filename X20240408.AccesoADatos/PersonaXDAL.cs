
using Microsoft.EntityFrameworkCore;
using X20240408.EntidadesDeNegocio;

namespace X20240408.AccesoADatos
{
    public class PersonaXDAL 
    {
        readonly AppDbContext _appDbContext;
        public PersonaXDAL(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<int> Crear(PersonaX personax)
        {
            _appDbContext.Add(personax);
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<int> Modificar(PersonaX personax)
        {
            var clienteData = await _appDbContext.PersonasX.FirstOrDefaultAsync(s => s.Id == personax.Id);
            if (clienteData != null)
            {
                clienteData.NombreX = personax.NombreX;
                clienteData.ApellidoX = personax.ApellidoX;
                clienteData.FechaNacimientoX = personax.FechaNacimientoX;
                clienteData.SueldoX = personax.SueldoX;
                clienteData.StatusX = personax.StatusX;
                clienteData.ComentarioX = personax.ComentarioX;
                _appDbContext.Update(clienteData);
            }
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<int> Eliminar(PersonaX personax)
        {
            var clienteData = await _appDbContext.PersonasX.FirstOrDefaultAsync(s => s.Id == personax.Id);
            if (clienteData != null)
                _appDbContext.Remove(clienteData);
            return await _appDbContext.SaveChangesAsync();
        }

        public async Task<PersonaX> ObtenerPorId(PersonaX personaX)
        {
            var clienteData = await _appDbContext.PersonasX.FirstOrDefaultAsync(s => s.Id == personaX.Id);
            if (clienteData != null)
                return clienteData;
            else
                return new PersonaX();
        }
        public async Task<List<PersonaX>> ObtenerTodos()
        {
            return await _appDbContext.PersonasX.ToListAsync();
        }
        public async Task<List<PersonaX>> Buscar(PersonaX personaX)
        {

            var query = _appDbContext.PersonasX.AsQueryable();
            if (!string.IsNullOrWhiteSpace(personaX.NombreX))
            {
                query = query.Where(s => s.NombreX.Contains(personaX.NombreX));
            }
            if (!string.IsNullOrWhiteSpace(personaX.ApellidoX))
            {
                query = query.Where(s => s.ApellidoX.Contains(personaX.ApellidoX));
            }
            return await query.ToListAsync();
        }

    }
}
