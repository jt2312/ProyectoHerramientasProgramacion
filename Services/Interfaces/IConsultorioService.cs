using HerramientasProgFinal.Data;
using HerramientasProgFinal.Models;
namespace HerramientasProgFinal.Services;

public interface IConsultorioService {
    void Create(Consultorio obj);
    List<Consultorio> GetAll(string? filter);
    void ConsultorioUpdate(Consultorio obj, int id);
    void Delete(Consultorio obj);
    Task<Consultorio?> GetById(int? id);
    CitacionContext getContext();
}