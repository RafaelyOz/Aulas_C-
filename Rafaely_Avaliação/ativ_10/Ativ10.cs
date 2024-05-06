public interface iReserva
{
    void ReservarVoo();
    void CancelarReserva();
    string VerificarStatusReserva();
}
public class ReservaVooRegular : iReserva{
    public void ReservarVoo(){
        Console.WriteLine("Reserva de voo regular realizada");
    }

    public void CancelarReserva(){
        Console.WriteLine("Reserva de voo regular cancelada");

    }

    public string VerificarStatusReserva(){
        return "Reserva do voo regular confirmada";
    }
}
public class ReservaVooComUpgrade : iReserva
{
    public void ReservarVoo()
    {
        Console.WriteLine("Reserva de voo com upgrade de classe realizada.");
    }

    public void CancelarReserva()
    {
        Console.WriteLine("Reserva de voo com upgrade de classe cancelada.");
    }

    public string VerificarStatusReserva()
    {
        return "Reserva de voo com upgrade de classe confirmada.";
    }
}
public class ReservaVooGrupoGrande : iReserva
{
    public void ReservarVoo()
    {
        Console.WriteLine("Reserva de voo para grupo grande realizada.");
    }

    public void CancelarReserva()
    {
        Console.WriteLine("Reserva de voo para grupo grande cancelada.");
    }

    public string VerificarStatusReserva()
    {
        return "Reserva de voo para grupo grande confirmada.";
    }
}
