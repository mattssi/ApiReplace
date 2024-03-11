using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ChisteController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> ObtenerChiste()
    {
        string chiste = GenerarChisteAleatorio();
        return Ok(chiste);
    }

    private string GenerarChisteAleatorio()
    {
        string[] chistes = new string[]
        {
               "¿Qué hace una abeja en el gimnasio? ¡Zum-ba!",
                "¿Por qué los pájaros no usan Facebook? Porque ya tienen Twitter.",
                "¿Cómo se llama un pez con corbata? ¡Un pez-ta!",
                "¿Qué hace una impresora en un gimnasio? ¡Papel de ejercicio!",
                "¿Cuál es el animal más antiguo? ¡La cebra, porque está en blanco y negro!",
                "¿Cómo se despiden los químicos? Ácido un placer.",
                "¿Cómo organiza una fiesta un programador? ¡Hace un byte!",
                "¿Cuál es el colmo de Aladino? Tener mal genio.",
                "¿Qué hace una abeja en el gimnasio? ¡Zum-ba!",
                "¿Por qué los esqueletos no pelean entre ellos? Porque no tienen agallas.",
                "¿Qué hace una abeja en el gimnasio? ¡Zum-ba!",
                "¿Cómo se llama un mago que ha perdido sus poderes? ¡Magordito!",
                "¿Cuál es el colmo de un jardinero? No llegar a nada.",
                "¿Qué hace una abeja en el gimnasio? ¡Zum-ba!",
                "¿Cómo se dice pañuelo en japonés? Saka-moko.",



        };

        // Escoge un chiste aleatorio de la lista
        Random random = new Random();
        int indiceChiste = random.Next(chistes.Length);
        return chistes[indiceChiste];
    }
}


