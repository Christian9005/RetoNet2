
using RetoNet2.WebApi.Services.Interfaces;
using RetoNet2.WebApi.Model;
using System.Text;

namespace RetoNet2.WebApi.Services;

public class AppServices : IAppServices
{
    public string GetCedula(CedulaDto cedula)
    {
        var dic = new ListaUsuarios();
        var respuesta = dic.DicUsuarios[cedula.Cedula];

        byte[] toEncodeAsBytes = Encoding.ASCII.GetBytes(respuesta);
        return Convert.ToBase64String(toEncodeAsBytes);
    }
}
