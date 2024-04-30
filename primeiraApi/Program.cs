using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
    Console.WriteLine("/ foi executado");
return "Hello World!";});

app.MapGet("/seunome", () => {
    return "Rafaely";
});

app.MapPost("/criarconta",async (HttpContext context)=>{
    //receber o request.body
   using var reader = new System.IO.StreamReader(context.Request.Body);
   var body = await reader.ReadToEndAsync();

   //deserializar o objeto JSON
    var json = JsonDocument.Parse(body);
    var userName = json.RootElement.GetProperty("nome");
    return "recebido nome: " + userName;
});

app.MapPost("/mostrarIdade",async (HttpContext context)=>{
    using var reader = new System.IO.StreamReader(context.Request.Body);
    var body = await reader.ReadToEndAsync();
    
});

/*criar um endpoit que recebe {"nome", "idade"}
cria o reader
deserealiza
le a propriedade idade
retorna:
"maior de idade" se idade >=18
"menor de idade" se idade < 18
*/
app.Run();
